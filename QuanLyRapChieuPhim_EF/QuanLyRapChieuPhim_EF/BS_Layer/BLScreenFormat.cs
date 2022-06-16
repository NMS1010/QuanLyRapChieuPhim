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
                catch (EntitySqlException e)
                {
                    success = false;
                    err = e.Message;
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
                catch (EntitySqlException e)
                {
                    success = false;
                    err = e.Message;
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
                        ctx.SaveChanges();
                    }
                    DinhDangManHinh screenFormat = new DinhDangManHinh() { MaDinhDangMH = screenFormatID };
                    ctx.DinhDangManHinhs.Attach(screenFormat);
                    ctx.DinhDangManHinhs.Remove(screenFormat);
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
