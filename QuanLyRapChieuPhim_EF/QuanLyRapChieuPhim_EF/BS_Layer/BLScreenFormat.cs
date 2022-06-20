using QuanLyRapChieuPhim_EF.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim_EF.BS_Layer
{
    internal static class BLScreenFormat
    {
        static BLScreenFormat()
        {
        }

        public static DataSet GetData()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaDinhDangMH", typeof(string));
            dt.Columns.Add("TenDinhDang", typeof(string));
            dt.Columns.Add("GiaVe", typeof(decimal));
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                IList<DinhDangManHinh> screenFormats = (from a in ctx.DinhDangManHinhs
                             select a).ToList();
                foreach (DinhDangManHinh screenFormat in screenFormats)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaDinhDangMH"] = screenFormat.MaDinhDangMH;
                    dr["TenDinhDang"] = screenFormat.TenDinhDang;
                    dr["GiaVe"] = screenFormat.GiaVe;
                    dt.Rows.Add(dr);
                }
                ds.Tables.Add(dt);
            }
            return ds;
        }
        public static List<Tuple<string, string>> GetScreenFormats()
        {
            List<Tuple<string, string>> screenFormats = new List<Tuple<string, string>>();
            using (CinemaManagementModel ctx = new CinemaManagementModel())
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
        public static string GetScreenFormatNameFromScreenFormatID(string screenFormatID)
        {
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                var screenFormatName = (from a in ctx.DinhDangManHinhs
                                        where a.MaDinhDangMH == screenFormatID
                                        select a.TenDinhDang).SingleOrDefault();
                if (string.IsNullOrEmpty(screenFormatName))
                    return "";
                return screenFormatName;
            }
        }
        public static string GetScreenFormatNameFromCinemaRoomID(string cinemaRoomID)
        {
            string screenFormatID = GetScreenFormatIDFromCinemaRoomID(cinemaRoomID);
            return GetScreenFormatNameFromScreenFormatID(screenFormatID);
        }
        public static string GetScreenFormatIDFromCinemaRoomID(string cinemaRoomID)
        {
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                var formatID = (from a in ctx.PhongChieux
                                where a.MaPhongChieu == cinemaRoomID
                                select a.MaDinhDangMH).SingleOrDefault();
                if (string.IsNullOrEmpty(formatID))
                    return "";
                return formatID;
            }
        }
        public static bool Update(string screenFormatID, string nameScreenFormat, decimal ticketPrice, ref string err)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    DinhDangManHinh entity = ctx.DinhDangManHinhs.SingleOrDefault(c => c.MaDinhDangMH == screenFormatID);
                    if (entity != null)
                    {
                        entity.TenDinhDang = nameScreenFormat;
                        entity.GiaVe = ticketPrice;
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
        public static bool Insert(string screenFormatID, string nameScreenFormat, decimal ticketPrice, ref string err)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    DinhDangManHinh screenFormat = new DinhDangManHinh(screenFormatID, nameScreenFormat, ticketPrice);
                    ctx.DinhDangManHinhs.Add(screenFormat);
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

        public static bool Remove(string screenFormatID, ref string err)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    IList<PhongChieu> cinemaRoom = (from a in ctx.PhongChieux
                                      where a.MaDinhDangMH == screenFormatID
                                      select a).ToList();
                    foreach(PhongChieu room in cinemaRoom)
                    {
                        room.TinhTrang = 0; 
                    }
                    DinhDangManHinh screenFormat = new DinhDangManHinh() { MaDinhDangMH = screenFormatID };
                    ctx.DinhDangManHinhs.Attach(screenFormat);
                    ctx.DinhDangManHinhs.Remove(screenFormat);
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
