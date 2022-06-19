using QuanLyRapChieuPhim_EF.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim_EF.BS_Layer
{
    internal static class BLRevenue
    {
        public static DataSet RevenueDataSet;
        public static DataSet GetRevenueData(DateTime start, DateTime end, string isASC = "")
        {
            DataSet revenueDS = new DataSet();
            start = new DateTime(start.Year, start.Month, start.Day, 0,0,0);
            end = new DateTime(end.Year, end.Month, end.Day, 23,59,59);
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                var revenueData = (
                    from film in ctx.BoPhims
                    join showTime in ctx.SuatChieux on film.MaBoPhim equals showTime.MaBoPhim
                    join ticket in ctx.Ves on showTime.MaSuatChieu equals ticket.MaSuatChieu
                    where ticket.TrangThai == 1 && ticket.NgayMua >= start && ticket.NgayMua <= end
                    group film by film.MaBoPhim into revenue
                    select new
                    {
                        MaBoPhim = revenue.Key,
                        TenPhim = revenue.Min(t => t.TenPhim),
                        NgayKhoiChieu = revenue.Min(t => t.NgayKhoiChieu),
                        NgayKetThuc = revenue.Min(t => t.NgayKetThuc),
                        TongSoVe = revenue.Count(t => t.TrangThai == 1),
                        TongTien = (from a in ctx.SuatChieux
                                    where a.MaBoPhim == revenue.Key
                                    select a.MaSuatChieu).Sum(t => ctx.Ves.Where(v => v.MaSuatChieu == t && v.NgayMua >= start && v.NgayMua <= end).Sum(x => x.TienVe))
                    }
                    );
                if(isASC == "ASC")
                {
                    revenueData = revenueData.OrderBy(x => x.TongTien);
                }
                else if(isASC == "DESC")
                {
                    revenueData = revenueData.OrderByDescending(x => x.TongTien);
                }
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("MaBoPhim", typeof(string));
                dataTable.Columns.Add("TenPhim", typeof(string));
                dataTable.Columns.Add("NgayKhoiChieu", typeof(DateTime));
                dataTable.Columns.Add("NgayKetThuc", typeof(DateTime));
                dataTable.Columns.Add("TongSoVe", typeof(int));
                dataTable.Columns.Add("TongTien", typeof(decimal));
                foreach (var dt in revenueData)
                {
                    DataRow dr = dataTable.NewRow();
                    dr["MaBoPhim"] = dt.MaBoPhim;
                    dr["TenPhim"] = dt.TenPhim;
                    dr["NgayKhoiChieu"] = dt.NgayKhoiChieu;
                    dr["NgayKetThuc"] = dt.NgayKetThuc;
                    dr["TongSoVe"] = dt.TongSoVe;
                    dr["TongTien"] = dt.TongTien;
                    dataTable.Rows.Add(dr);
                }
                revenueDS.Tables.Add(dataTable);
                RevenueDataSet = revenueDS.Copy();
            }
            return revenueDS;
        }
        public static DataSet GetDataByFilmName(string filmName)
        {
            filmName = filmName.ToLower();
            DataSet data = GetRevenueData(DateTime.MinValue, DateTime.MaxValue);
            DataSet ds = data.Clone();
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                DataRow r = data.Tables[0].Rows[i];
                string temp = r["TenPhim"].ToString().ToLower();
                if (temp.Contains(filmName))
                {
                    ds.Tables[0].Rows.Add(r.ItemArray);
                }
            }
            RevenueDataSet = new DataSet();
            RevenueDataSet = data.Copy();
            return ds;
        }
    }
}
