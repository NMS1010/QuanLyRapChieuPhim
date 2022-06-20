using QuanLyRapChieuPhim_ADO.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim_ADO.BS_Layer
{
    public static class BLOrderTicket
    {
        private static DataSet dataShowTime;
        private static List<string> showTimeIDs;
        private static string selectedShowTimeID;
        private static string customerID = "";
        static BLOrderTicket()
        {
            
        }
        public static void GetValidShowTime()
        {
            DataSet temp = BLShowTime.GetData();
            DataShowTime = temp.Clone();
            for(int i = 0; i < temp.Tables[0].Rows.Count; i++)
            {
                DataRow r = temp.Tables[0].Rows[i];
                string command = $"select MaSuatChieu from Ve where MaSuatChieu = '{r["MaSuatChieu"]}'";
                string res = DataProvider.GetSingleStringValueFromQuery(command);
                if (r["TrangThai"].ToString() != "0" && res != "")
                {
                    DataShowTime.Tables[0].Rows.Add(r.ItemArray);
                }
            }
            DataShowTime.Tables[0].AcceptChanges();
            showTimeIDs = DataShowTime.Tables[0].Rows
                             .OfType<DataRow>()
                             .Select(r => r["MaSuatChieu"].ToString())
                             .ToList();
            DataShowTime.Tables[0].Columns.Remove("MaSuatChieu");
            DataShowTime.Tables[0].Columns.Remove("TrangThai");
        }
        public static DataSet DataShowTime { get => dataShowTime; set => dataShowTime = value; }
        public static List<string> ShowTimeIDs { get => showTimeIDs; set => showTimeIDs = value; }
        public static string SelectedShowTimeID { get => selectedShowTimeID; set => selectedShowTimeID = value; }
        public static string CustomerID { get => customerID; set => customerID = value; }

        public static DataSet GetDataByDate(DateTime d)
        {
            DataSet ds = DataShowTime.Clone();
            for (int i = 0; i < DataShowTime.Tables[0].Rows.Count; i++)
            {
                DataRow r = DataShowTime.Tables[0].Rows[i];
                DateTime temp = (DateTime)r["NgayChieu"];
                if (temp.ToShortDateString() == d.ToShortDateString())
                {
                    ds.Tables[0].Rows.Add(r.ItemArray);
                }
            }
            return ds;
        }
        public static DataSet GetDataByFilmName(string filmName)
        {
            filmName = filmName.ToLower();
            DataSet ds = DataShowTime.Clone();
            for (int i = 0; i < DataShowTime.Tables[0].Rows.Count; i++)
            {
                DataRow r = DataShowTime.Tables[0].Rows[i];
                string temp = r["TenPhim"].ToString();
                temp = temp.ToLower();
                if (temp.Contains(filmName))
                {
                    ds.Tables[0].Rows.Add(r.ItemArray);
                }
            }
            return ds;
        }

        public static DataSet GetDataByDateAndFilmName(DateTime d, string filmName)
        {
            DataSet ds1 = GetDataByDate(d);
            DataSet ds2 = GetDataByFilmName(filmName);
            DataSet res = new DataSet();
            res.Merge(DataShowTime);
            res.Tables[0].Rows.Clear();
            var rows = ds1.Tables[0].AsEnumerable().Intersect(ds2.Tables[0].AsEnumerable(), DataRowComparer.Default);
            if (rows.Any())
            {
                foreach(DataRow r in rows)
                    res.Tables[0].Rows.Add(r.ItemArray);
            }
            return res;
        }

        public static Dictionary<string, string> GetShowTimeInfo()
        {
            string command = $"select SoHangGhe, SoGheMoiHang, TenPhong, ThoiGian, TenPhim, ThoiLuong, GiaVe" +
                $" from PhongChieu inner join SuatChieu on PhongChieu.MaPhongChieu = SuatChieu.MaPhongChieu " +
                $"inner join BoPhim on SuatChieu.MaBoPhim = BoPhim.MaBoPhim " +
                $"inner join DinhDangManHinh on PhongChieu.MaDinhDangMH = DinhDangManHinh.MaDinhDangMH" +
                $" where MaSuatChieu = '{selectedShowTimeID}'";
            DataSet ds = DataProvider.GetData(command);
            Dictionary<string, string> dict = new Dictionary<string, string>();
            if (ds.Tables[0].Rows.Count == 0)
            {
                return dict;
            }
            List<string> colNames = new List<string>() { "SoHangGhe", "SoGheMoiHang", "TenPhong", "ThoiGian", "TenPhim", "ThoiLuong", "GiaVe" };
            for(int i = 0; i < colNames.Count; i++)
            {
                dict.Add(colNames[i], ds.Tables[0].Rows[0].ItemArray[i].ToString());
            }
            return dict;

        }
        public static List<string> GetOrderedTicket()
        {
            return DataProvider.GetStringValuesFromSpecificColumnWithCondition("Ve", "MaGhe", $"TrangThai = '1' and MaSuatChieu = '{selectedShowTimeID}'");
        }

        public  static bool UpdateBoughtTicket(List<string> orderedTicket, int ticketType, double ticketPrice, DateTime buyDate, ref string error)
        {
            bool success = true;
            foreach (string seatID in orderedTicket)
            {
                success = BLTicket.UpdateOrderedTicket(BLOrderTicket.CustomerID, ticketPrice, seatID, ticketType, 1, selectedShowTimeID, buyDate, ref error);
                if (!success)
                    return success;
            }
            return success;
        }
    }
}
