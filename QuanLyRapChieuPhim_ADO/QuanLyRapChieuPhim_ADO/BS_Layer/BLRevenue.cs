using QuanLyRapChieuPhim_ADO.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim_ADO.BS_Layer
{
    internal static class BLRevenue
    {
        public static DataSet RevenueDataSet;
        public static DataSet GetRevenueData(DateTime start, DateTime end, string isASC = "")
        {
            string command = "select min(BoPhim.MaBoPhim) as MaBoPhim, min(TenPhim) as TenPhim, min(NgayKhoiChieu) as NgayKhoiChieu, min(NgayKetThuc) as NgayKetThuc, count(Ve.TrangThai) as TongSoVe, sum(TienVe) as TongTien " +
                "from BoPhim " +
                "inner join SuatChieu on BoPhim.MaBoPhim = SuatChieu.MaBoPhim " +
                "inner join Ve on SuatChieu.MaSuatChieu = Ve.MaSuatChieu " +
                $"where Ve.TrangThai = 1 and NgayMua >= '{start}' and NgayMua <= '{end}'" +
                "group by BoPhim.MaBoPhim ";
            if(isASC != "")
            {
                command += $"order by TongTien {isASC}";
            }
            DataSet revenueDataSet = DataProvider.GetData(command);
            RevenueDataSet = new DataSet();
            RevenueDataSet = revenueDataSet.Copy();
            return revenueDataSet;
        }
        public static DataSet GetDataByFilmName(string filmName)
        {
            filmName = filmName.ToLower();
            DataSet data = GetRevenueData(DateTime.MinValue, DateTime.MaxValue);

            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                DataRow r = data.Tables[0].Rows[i];
                string temp = r["TenPhim"].ToString().ToLower();
                if (!temp.Contains(filmName))
                {
                    r.Delete();
                }
            }
            data.Tables[0].AcceptChanges();
            RevenueDataSet = new DataSet();
            RevenueDataSet = data.Copy();
            return data;
        }
    }
}
