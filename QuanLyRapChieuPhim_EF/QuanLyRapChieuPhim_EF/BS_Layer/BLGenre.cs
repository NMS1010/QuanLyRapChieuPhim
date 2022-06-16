using QuanLyRapChieuPhim_EF.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim_EF.BS_Layer
{
    internal static class BLGenre
    {
        static BLGenre()
        {
            
        }

        public static DataSet GetData()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaTheLoai", typeof(string));
            dt.Columns.Add("TenTheLoai", typeof(string));
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                IList<TheLoai> genres = (from a in ctx.TheLoais
                                select a).ToList();
                foreach (TheLoai genre in genres)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaTheLoai"] = genre.MaTheLoai;
                    dr["TenTheLoai"] = genre.TenTheLoai;
                    dt.Rows.Add(dr);
                }
                ds.Tables.Add(dt);
            }
            return ds;
        }

        public static bool Update(string genreId, string genreName, ref string err)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    TheLoai genre = ctx.TheLoais.SingleOrDefault(c => c.MaTheLoai == genreId);
                    if (genre != null)
                    {
                        genre.TenTheLoai = genreName;
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
        public static bool Insert(string genreId, string genreName, ref string err)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    TheLoai genre = new TheLoai(genreId, genreName);
                    ctx.TheLoais.Add(genre);
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

        public static bool Remove(string genreId, ref string err)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    TheLoai genre = new TheLoai() { MaTheLoai = genreId };
                    ctx.TheLoais.Attach(genre);
                    ctx.TheLoais.Remove(genre);
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
