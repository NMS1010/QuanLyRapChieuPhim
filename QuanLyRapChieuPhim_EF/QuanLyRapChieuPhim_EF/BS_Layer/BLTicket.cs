using QuanLyRapChieuPhim_EF.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim_EF.BS_Layer
{
    internal static class BLTicket
    {
        static BLTicket()
        {
            
        }

        public static DataSet GetTicketDataByShowTime(string showTimeID)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaVe", typeof(int));
            dt.Columns.Add("TrangThai", typeof(int));
            dt.Columns.Add("MaGhe", typeof(string));
            dt.Columns.Add("MaKhachHang", typeof(string));
            dt.Columns.Add("MaSuatChieu", typeof(string));
            dt.Columns.Add("LoaiVe", typeof(int));
            dt.Columns.Add("TienVe", typeof(decimal));
            dt.Columns.Add("NgayMua", typeof(string));
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                IList<Ve> tickets = (from a in ctx.Ves
                              where a.MaSuatChieu == showTimeID
                              select a).ToList();
                foreach (Ve ticket in tickets)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaVe"] = ticket.MaVe;
                    dr["TrangThai"] = ticket.TrangThai;
                    dr["MaGhe"] = ticket.MaGhe;
                    dr["MaKhachHang"] = ticket.MaKhachHang.ToString();
                    dr["MaSuatChieu"] = ticket.MaSuatChieu.ToString();
                    dr["LoaiVe"] = ticket.LoaiVe;
                    dr["TienVe"] = ticket.TienVe;
                    dr["NgayMua"] = ticket.NgayMua;
                    if (ticket.NgayMua.HasValue)
                        dr["NgayMua"] = ticket.NgayMua.Value.ToString("dd/MM/yyyy");
                    dt.Rows.Add(dr);
                }
                ds.Tables.Add(dt);
            }
            return ds;
        }
        public static bool IsTicketsCreateByShowTime(string showTimeID)
        {
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                IList<Ve> entity = (from a in ctx.Ves
                             where a.MaSuatChieu == showTimeID
                             select a).ToList();
                if (entity.Count == 0)
                    return false;
                return true;
            }
        }
        public static DataSet GetShowTimeData()
        {
            DataSet ds = BLShowTime.GetData();
            ds.Tables[0].Columns.Remove("GiaVe");
            ds.Tables[0].Columns.Add(new DataColumn("TinhTrangVe", typeof(string)));
            DataSet res = ds.Clone();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow dr = ds.Tables[0].Rows[i];
                if ((int)dr["TrangThai"] != 0)
                {
                    if (!IsTicketsCreateByShowTime(dr["MaSuatChieu"].ToString()))
                    {
                        dr["TinhTrangVe"] = "Chưa tạo vé";
                    }
                    else
                    {
                        dr["TinhTrangVe"] = "Đã tạo vé";
                    }
                    res.Tables[0].Rows.Add(dr.ItemArray);
                }
            }
            return res;
        }
        public static bool Insert(int ticketStatus, string seatID, string customerID, string showTimeID, int ticketType, decimal ticketPrice, ref string error)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    Ve ticket = new Ve(ticketStatus, seatID, customerID, showTimeID, ticketType, ticketPrice);
                    ctx.Ves.Add(ticket);
                    ctx.SaveChanges();
                }
                catch(Exception e)
                {
                    success = false;
                    error = e.InnerException.ToString();
                }
            }
            return success;
        }

        public static bool UpdateOrderedTicket(string customerID, double ticketPrice, string seatID, int ticketType, int ticketStatus, string showID, DateTime buyDate, ref string error)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    var entity = ctx.Ves.SingleOrDefault(c => c.MaGhe == seatID && c.MaSuatChieu == showID);
                    if (entity != null)
                    {
                        entity.TrangThai = ticketStatus;
                        entity.LoaiVe = ticketType;
                        entity.TienVe = (decimal)ticketPrice;
                        entity.NgayMua = buyDate;
                        if (customerID != "")
                            entity.MaKhachHang = int.Parse(customerID);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    success = false;
                    error = e.InnerException.ToString();
                }
            }
            return success;
        }
        public static bool RemoveAllTicketByShowTime(string showTimeID, ref string error)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    IList<Ve> tickets = (from a in ctx.Ves
                                         where a.MaSuatChieu == showTimeID
                                         select a).ToList();
                    foreach (Ve ticket in tickets)
                    {
                        ctx.Ves.Attach(ticket);
                        ctx.Ves.Remove(ticket);
                    }
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    success = false;
                    error = e.InnerException.ToString();
                }
            }
            return success;
        }
        public static string GetTicketPriceFromCinemaRoomID(string cinemaRoomID)
        {
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                decimal ticketPrice = (from a in ctx.PhongChieux
                                       join b in ctx.DinhDangManHinhs on a.MaDinhDangMH equals b.MaDinhDangMH
                                       where a.MaPhongChieu == cinemaRoomID
                                       select b.GiaVe).SingleOrDefault();
                return ticketPrice.ToString();
            }
        }
        public static bool GenerateTicket(string showTimeID, ref string error)
        {
            if (IsTicketsCreateByShowTime(showTimeID))
            {
                error = "Đã tạo vé cho suất chiếu này";
                return false;
            }
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                string cinemaRoomID = BLCinemaRoom.GetCinemaRoomIDFromShowTimeID(showTimeID);
                PhongChieu seatInfo = (from a in ctx.PhongChieux
                             where a.MaPhongChieu == cinemaRoomID
                             select a).SingleOrDefault();
                if (seatInfo == null)
                {
                    error = "Phòng chiếu không hợp lệ!!!";
                    return false;
                }
                int numberRows = seatInfo.SoHangGhe;
                int numberChairPerRow = seatInfo.SoGheMoiHang;
                string strSequence = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                bool success = true;
                for (int i = 0; i < numberRows; i++)
                {
                    for (int j = 0; j < numberChairPerRow; j++)
                    {
                        success = Insert(0, strSequence[i] + j.ToString(), String.Empty, showTimeID, 0, (decimal)0, ref error);
                        if (!success)
                            return success;
                    }
                }
                return success;
            }
        }

    }
}
