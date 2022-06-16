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
                ds.Tables[0].Columns[i].ColumnName = "LoaiManHinh";
            }
            
            return ds;
        }
        //public static string GetScreenFormatNameFromID(string screenFormatID)
        //{
        //    string command = $"select TenDinhDang " +
        //        $"from DinhDangManHinh where MaDinhDangMH = '{screenFormatID}'";
        //    return DataProvider.GetSingleStringValueFromQuery(command);
        //}
        public static List<Tuple<string, string>> GetScreenFormats()
        {
            List<Tuple<string, string>> screenFormats = new List<Tuple<string, string>>();
            using(CinemaManagementModel ctx = new CinemaManagementModel())
            {
                IList<DinhDangManHinh> formats = (from a in ctx.DinhDangManHinhs
                        select a).ToList();
                foreach (DinhDangManHinh format in formats)
                {
                    screenFormats.Add(new Tuple<string, string>(format.TenDinhDang, format.MaDinhDangMH));
                }
            }
            return screenFormats;
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
                                    ctx.SaveChanges();
                                }
                            }
                            catch (EntitySqlException e)
                            {
                                success = false;
                                err = e.Message;
                            }
                            if (!success)
                                return success;
                        }
                    }
                }
                catch (EntitySqlException e)
                {
                    success = false;
                    err = e.Message;
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
                catch (EntitySqlException e)
                {
                    success = false;
                    err = e.Message;
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
                catch (EntitySqlException e)
                {
                    success = false;
                    err = e.Message;
                }
            }
            return success;
        }
    }
}
