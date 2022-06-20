using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using QuanLyRapChieuPhim_EF.DataObjects;

namespace QuanLyRapChieuPhim_EF.BS_Layer
{
    internal static class BLCinemaRoom
    {
        static BLCinemaRoom()
        {
        }

        public static DataSet GetData()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaPhongChieu", typeof(string));
            dt.Columns.Add("TenPhong", typeof(string));
            dt.Columns.Add("TongSoGhe", typeof(int));
            dt.Columns.Add("TinhTrang", typeof(int));
            dt.Columns.Add("SoHangGhe", typeof(int));
            dt.Columns.Add("SoGheMoiHang", typeof(int));
            dt.Columns.Add("MaDinhDangMH", typeof(string));
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                IList<PhongChieu> cinemaRooms = (from a in ctx.PhongChieux
                               select a).ToList();
                foreach (PhongChieu cinemaRoom in cinemaRooms)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaPhongChieu"] = cinemaRoom.MaPhongChieu;
                    dr["TenPhong"] = cinemaRoom.TenPhong;
                    dr["TongSoGhe"] = cinemaRoom.TongSoGhe;
                    dr["TinhTrang"] = cinemaRoom.TinhTrang;
                    dr["SoHangGhe"] = cinemaRoom.SoHangGhe;
                    dr["SoGheMoiHang"] = cinemaRoom.SoGheMoiHang;
                    dr["MaDinhDangMH"] = cinemaRoom.MaDinhDangMH;
                    dt.Rows.Add(dr);
                }
                ds.Tables.Add(dt);
                int i = ds.Tables[0].Columns.IndexOf("MaDinhDangMH");
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string screenFormatID = row.ItemArray[i].ToString();
                    row[i] = ctx.DinhDangManHinhs.SingleOrDefault(d => d.MaDinhDangMH == screenFormatID)?.TenDinhDang;
                }
                if(i != -1)
                    ds.Tables[0].Columns[i].ColumnName = "LoaiManHinh";
            }
            
            return ds;
        }
        public static List<Tuple<string, string>> GetCinemaRooms()
        {
            List<Tuple<string, string>> cinemaRooms = new List<Tuple<string, string>>();
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                IList<PhongChieu> rooms = (from a in ctx.PhongChieux
                                           select a).ToList();
                foreach (var c in rooms)
                {
                    cinemaRooms.Add(new Tuple<string, string>(c.TenPhong, c.MaPhongChieu));
                }
            }
            return cinemaRooms;
        }
        public static string GetCinemaRoomNameFromCinemaRoomID(string cinemaRoomID)
        {
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                var cinemaRoomName = (from a in ctx.PhongChieux
                                      where a.MaPhongChieu == cinemaRoomID
                                      select a.TenPhong).SingleOrDefault();
                if (string.IsNullOrEmpty(cinemaRoomName))
                    return "";
                return cinemaRoomName;
            }
        }


        public static string GetCinemaRoomIDFromShowTimeID(string showTimeID)
        {
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                var cinemaRoomID = (from a in ctx.SuatChieux
                                    where a.MaSuatChieu == showTimeID
                                    select a.MaPhongChieu).SingleOrDefault();
                if (string.IsNullOrEmpty(cinemaRoomID))
                    return "";
                return cinemaRoomID;
            }
        }
        public static bool Update(string cinemaRoomId, string cinemaRoomName, int totalChair,int cinemaRoomStatus,
            int totalNumberRowChair, int totalChairPerRow, string screenFormatID, ref string err)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    PhongChieu room = ctx.PhongChieux.SingleOrDefault(cinemaRoom => cinemaRoom.MaPhongChieu == cinemaRoomId);
                    if (room != null)
                    {
                        room.TenPhong = cinemaRoomName;
                        room.TongSoGhe = totalChair;
                        room.TinhTrang = cinemaRoomStatus;
                        room.SoHangGhe = totalNumberRowChair;
                        room.SoGheMoiHang = totalChairPerRow;
                        room.MaDinhDangMH = screenFormatID;
                        ctx.SaveChanges();

                        IList<SuatChieu> showTimes = (from a in ctx.SuatChieux
                                        where a.MaPhongChieu == cinemaRoomId
                                        select a).ToList();
                        foreach (SuatChieu showTime in showTimes)
                        {
                            string filmStatus = ctx.BoPhims.SingleOrDefault(x => x.MaBoPhim == showTime.MaBoPhim)?.TrangThai.ToString();
                            if (filmStatus == "0")
                                continue;
                            try
                            {
                                SuatChieu e = ctx.SuatChieux.SingleOrDefault(a => a.MaSuatChieu == showTime.MaSuatChieu);
                                if (e != null)
                                {
                                    e.TrangThai = cinemaRoomStatus;
                                }
                            }
                            catch (Exception e)
                            {
                                success = false;
                                err = e.InnerException.ToString();
                            }
                            if (!success)
                                return success;
                        }
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    success = false;
                    err = e.InnerException.ToString();
                }
                
            }
            return success;
        }
        public static bool Insert(string cinemaRoomId, string cinemaRoomName, int totalChair, int cinemaRoomStatus,
            int totalNumberRowChair, int totalChairPerRow, string screenFormatID, ref string err)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    PhongChieu cinemaRoom = new PhongChieu(cinemaRoomId, cinemaRoomName, totalChair, cinemaRoomStatus, totalNumberRowChair, totalChairPerRow, screenFormatID);
                    ctx.PhongChieux.Add(cinemaRoom);
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    success = false;
                    err = e.InnerException.ToString();
                }
            }
            return success;
        }

        public static bool Remove(string cinemaRoomId, ref string err)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    PhongChieu cinemaRoom = new PhongChieu() { MaPhongChieu = cinemaRoomId };
                    ctx.PhongChieux.Attach(cinemaRoom);
                    ctx.PhongChieux.Remove(cinemaRoom);
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    success = false;
                    err = e.InnerException.ToString();
                }
            }
            return success;
        }
    }
}
