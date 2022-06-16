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
                row["TenPhim"] = GetFilmNameFromFilmID(row["MaBoPhim"].ToString());
                row["TenDinhDang"] = GetScreenFormatNameFromCinemaRoomID(row["MaPhongChieu"].ToString());
                row["TenPhongChieu"] = GetCinemaRoomNameFromCinemaRoomID(row["MaPhongChieu"].ToString());
                string price = GetTicketPriceFromCinemaRoomID(row["MaPhongChieu"].ToString());
                if(price == "")
                {
                    price = "0";
                    string error = "";
                    bool b = BLCommon.UpdateState("TrangThai", "SuatChieu", 0, $"MaSuatChieu = '{row["MaSuatChieu"]}'", ref error);
                    row["TrangThai"] = DataProvider.GetSingleStringValueFromQuery($"select TrangThai from SuatChieu where MaSuatChieu = '{row["MaSuatChieu"]}'");
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
        
        public static List<Tuple<string, string>> GetFilms()
        {
            string command = "select TenPhim, MaBoPhim from BoPhim where TrangThai = 1";
            DataSet ds = DataProvider.GetData(command);
            List<Tuple<string, string>> films = new List<Tuple<string, string>>();
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                films.Add(new Tuple<string, string>(dr["TenPhim"].ToString(), dr["MaBoPhim"].ToString()));
            }
            return films;
        }
        public static List<Tuple<string, string>> GetCinemaRooms()
        {
            string command = "select TenPhong, MaPhongChieu from PhongChieu where TinhTrang = 1";
            DataSet ds = DataProvider.GetData(command);
            List<Tuple<string, string>> cinemaRooms = new List<Tuple<string, string>>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                cinemaRooms.Add(new Tuple<string, string>(dr["TenPhong"].ToString(), dr["MaPhongChieu"].ToString()));
            }
            return cinemaRooms;
        }
        
        public static string GetScreenFormatNameFromCinemaRoomID(string cinemaRoomID)
        {
            string screenFormatID = GetScreenFormatIDFromCinemaRoomID(cinemaRoomID);
            return GetScreenFormatNameFromScreenFormatID(screenFormatID);
        }
        public static string GetScreenFormatIDFromCinemaRoomID(string cinemaRoomID)
        {
            string command = $"select MaDinhDangMH from PhongChieu where MaPhongChieu = N'{cinemaRoomID}'";
            return  DataProvider.GetSingleStringValueFromQuery(command);
        }
        public static string GetTicketPriceFromCinemaRoomID(string cinemaRoomID)
        {
            string command = $"select MaDinhDangMH from PhongChieu where MaPhongChieu = N'{cinemaRoomID}'";
            string screenFormatID = DataProvider.GetSingleStringValueFromQuery(command);
            return GetTicketPriceFromScreenFormatID(screenFormatID);
        }

        public static string GetTicketPriceFromScreenFormatID(string screenFormatID)
        {
            string command = $"select GiaVe from DinhDangManHinh where MaDinhDangMH = N'{screenFormatID}'";
            return DataProvider.GetSingleStringValueFromQuery(command);
        }
        public static string GetFilmNameFromFilmID(string filmID)
        {
            string command = $"select TenPhim from BoPhim where MaBoPhim = N'{filmID}'";
            return DataProvider.GetSingleStringValueFromQuery(command);
        }
        public static string GetCinemaRoomNameFromCinemaRoomID(string cinemaRoomID)
        {
            string command = $"select TenPhong from PhongChieu where MaPhongChieu = N'{cinemaRoomID}'";
            return DataProvider.GetSingleStringValueFromQuery(command);
        }
        public static string GetScreenFormatNameFromScreenFormatID(string screenFormatID)
        {
            string command = $"select TenDinhDang from DinhDangManHinh where MaDinhDangMH = N'{screenFormatID}'";
            return DataProvider.GetSingleStringValueFromQuery(command);
        }

        public static string GetCinemaRoomIDFromShowTimeID(string showTimeID)
        {
            string command = $"select MaPhongChieu from {tableName} where MaSuatChieu = N'{showTimeID}'";
            return DataProvider.GetSingleStringValueFromQuery(command);
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
            string command = $"delete from SuatChieu where MaSuatChieu = '{showTimeId}'";
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }
    }
}
