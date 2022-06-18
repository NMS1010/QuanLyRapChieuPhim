using QuanLyRapChieuPhim_ADO.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim_ADO.BS_Layer
{
    internal static class BLShowTime
    {
        private static string tableName = "SuatChieu";
        static BLShowTime()
        {
            
        }

        public static DataSet GetData()
        {
            string command = $"select * from {tableName}";
            DataSet ds = DataProvider.GetData(command);

            ds.Tables[0].Columns.Add(new DataColumn("TenPhim", typeof(string)));
            ds.Tables[0].Columns.Add(new DataColumn("TenDinhDang", typeof(string)));
            ds.Tables[0].Columns.Add(new DataColumn("TenPhongChieu", typeof(string)));
            ds.Tables[0].Columns.Add(new DataColumn("GiaVe", typeof(decimal)));
            ds.Tables[0].Columns.Add(new DataColumn("NgayChieu", typeof(DateTime)));
            ds.Tables[0].Columns.Add(new DataColumn("GioChieu", typeof(DateTime)));

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                row["TenPhim"] = BLMovie.GetFilmNameFromFilmID(row["MaBoPhim"].ToString());
                row["TenDinhDang"] = BLScreenFormat.GetScreenFormatNameFromCinemaRoomID(row["MaPhongChieu"].ToString());
                row["TenPhongChieu"] = BLCinemaRoom.GetCinemaRoomNameFromCinemaRoomID(row["MaPhongChieu"].ToString());
                string price = BLTicket.GetTicketPriceFromCinemaRoomID(row["MaPhongChieu"].ToString());
                if(price == "")
                {
                    price = "0";
                    string error = "";
                    bool b = BLCommon.UpdateState("TrangThai", tableName, 0, $"MaSuatChieu = '{row["MaSuatChieu"]}'", ref error);
                    row["TrangThai"] = DataProvider.GetSingleStringValueFromQuery($"select TrangThai from {tableName} where MaSuatChieu = '{row["MaSuatChieu"]}'");
                    if (!b)
                        continue;
                }
                row["GiaVe"] = price;
                DateTime t = (DateTime)row["ThoiGian"];
                row["NgayChieu"] = t;
                row["GioChieu"] = t;
            }
            ds.Tables[0].Columns.Remove("MaBoPhim");
            ds.Tables[0].Columns.Remove("MaPhongChieu");
            ds.Tables[0].Columns.Remove("ThoiGian");
            return ds;
        }
        
        
        
        

        public static bool CheckCinemaRoomAndMovie(string filmID, string cinemaRoomID, ref string error)
        {
            string command = $"select BoPhim.TrangThai as TrangThai " +
                $"from SuatChieu inner join BoPhim on SuatChieu.MaBoPhim = BoPhim.MaBoPhim " +
                $"inner join PhongChieu on SuatChieu.MaPhongChieu = PhongChieu.MaPhongChieu " +
                $"where BoPhim.MaBoPhim = '{filmID}'";
            DataSet ds = DataProvider.GetData(command);
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                if (row["TrangThai"].ToString() == "0")
                {
                    error = "Bộ phim đang ở trạng thái chưa sẵn sàng!!!";
                    return false;
                }
            }
            command = $"select PhongChieu.TinhTrang as TinhTrang " +
                $"from SuatChieu inner join BoPhim on SuatChieu.MaBoPhim = BoPhim.MaBoPhim " +
                $"inner join PhongChieu on SuatChieu.MaPhongChieu = PhongChieu.MaPhongChieu " +
                $"where PhongChieu.MaPhongChieu = '{cinemaRoomID}'";
            ds = DataProvider.GetData(command);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row["TinhTrang"].ToString() == "0")
                {
                    error = "Phòng chiếu đang ở trạng thái chưa sẵn sàng!!!";
                    return false;
                }
            }
            return true;
        }
        public static bool CheckShowTime(string showTimeID, DateTime startShowTime, string filmID, string cinemaRoomID, ref string error)
        {
            if (!CheckCinemaRoomAndMovie(filmID, cinemaRoomID, ref error))
                return false;
            double totalFilmTime = double.Parse(DataProvider.GetSingleStringValueFromQuery($"select ThoiLuong from BoPhim where MaBoPhim = '{filmID}'"));
            DateTime endShowTime = startShowTime.AddMinutes(totalFilmTime);
            string command = $"select MaPhongChieu, ThoiGian, ThoiLuong, NgayKhoiChieu, NgayKetThuc from SuatChieu " +
                $"inner join BoPhim on SuatChieu.MaBoPhim = BoPhim.MaBoPhim where SuatChieu.MaSuatChieu != '{showTimeID}'";
            DataSet ds = DataProvider.GetData(command);
            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow dr = ds.Tables[0].Rows[i];
                DateTime startShow = (DateTime)dr["ThoiGian"];
                double time = (double)dr["ThoiLuong"];
                DateTime endShow = startShow.AddMinutes(time);
                if (dr["MaPhongChieu"].ToString() == cinemaRoomID)
                {
                    if ((startShowTime >= startShow && startShowTime <= endShow) ||
                        (endShowTime >= startShow && endShowTime <= endShow))
                    {
                        error = "Trùng lịch chiếu phim khác. Vui lòng chọn lại!!!";
                        return false;
                    }
                }
            }
            command = $"select MaBoPhim, ThoiLuong, NgayKhoiChieu, NgayKetThuc from BoPhim ";
            ds = DataProvider.GetData(command);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow dr = ds.Tables[0].Rows[i];
                DateTime startDate = (DateTime)dr["NgayKhoiChieu"];
                DateTime endDate = (DateTime)dr["NgayKetThuc"];
                if (dr["MaBoPhim"].ToString() == filmID)
                {
                    if (startShowTime < startDate)
                    {
                        error = "Phim chưa khởi chiếu!!!";
                        return false;
                    }
                    if (startShowTime > endDate)
                    {
                        error = "Phim đã kết thúc chiếu!!!";
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool Update(string showTimeID, DateTime startShowTime, string statusShowTime, string filmID,
            string cinemaRoomID, ref string err)
        {
            if (!CheckShowTime(showTimeID,startShowTime, filmID, cinemaRoomID, ref err))
                return false;
            string command = $"update {tableName} set ThoiGian = '{startShowTime}'," +
                $" TrangThai = {statusShowTime}, MaBoPhim = '{filmID}', MaPhongChieu = '{cinemaRoomID}' where MaSuatChieu = '{showTimeID}'; ";
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }
        public static bool Insert(string showTimeID, DateTime startShowTime, string statusShowTime, string filmID,
            string cinemaRoomID, ref string err)
        {
            if (!CheckShowTime(showTimeID,startShowTime, filmID, cinemaRoomID, ref err))
                return false;
            string command = $"insert into {tableName} values('{showTimeID}','{startShowTime}', {int.Parse(statusShowTime)},'{filmID}','{cinemaRoomID}');";
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }
        
        public static bool Remove(string showTimeId, ref string err)
        {
            string command = $"delete from {tableName} where MaSuatChieu = '{showTimeId}'";
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }
    }
}
