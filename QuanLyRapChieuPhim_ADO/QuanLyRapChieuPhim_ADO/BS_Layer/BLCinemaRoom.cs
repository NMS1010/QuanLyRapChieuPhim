using QuanLyRapChieuPhim_ADO.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace QuanLyRapChieuPhim_ADO.BS_Layer
{
    internal static class BLCinemaRoom
    {
        private static string tableName = "PhongChieu";
        static BLCinemaRoom()
        {
        }

        public static DataSet GetData()
        {
            string command = $"select * from {tableName}";
            DataSet ds = DataProvider.GetData(command);
            int i = ds.Tables[0].Columns.IndexOf("MaDinhDangMH");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                row[i] = GetScreenFormatNameFromID(row.ItemArray[i].ToString());
            }
            if(i != -1)
                ds.Tables[0].Columns[i].ColumnName = "LoaiManHinh";
            return ds;
        }
        public static string GetScreenFormatNameFromID(string screenFormatID)
        {
            string command = $"select TenDinhDang " +
                $"from DinhDangManHinh where MaDinhDangMH = '{screenFormatID}'";
            return DataProvider.GetSingleStringValueFromQuery(command);
        }

        public static string GetCinemaRoomIDFromShowTimeID(string showTimeID)
        {
            string command = $"select MaPhongChieu from SuatChieu where MaSuatChieu = N'{showTimeID}'";
            return DataProvider.GetSingleStringValueFromQuery(command);
        }
        public static List<Tuple<string, string>> GetCinemaRooms()
        {
            string command = "select TenPhong, MaPhongChieu from PhongChieu";
            DataSet ds = DataProvider.GetData(command);
            List<Tuple<string, string>> cinemaRooms = new List<Tuple<string, string>>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                cinemaRooms.Add(new Tuple<string, string>(dr["TenPhong"].ToString(), dr["MaPhongChieu"].ToString()));
            }
            return cinemaRooms;
        }
        public static string GetCinemaRoomNameFromCinemaRoomID(string cinemaRoomID)
        {
            string command = $"select TenPhong from PhongChieu where MaPhongChieu = N'{cinemaRoomID}'";
            return DataProvider.GetSingleStringValueFromQuery(command);
        }
        public static bool Update(string cinemaRoomId, string cinemaRoomName, int totalChair,int cinemaRoomStatus,
            int totalNumberRowChair, int totalChairPerRow, string screenFormatID, ref string err)
        {
            string command = $"update {tableName} set MaPhongChieu = '{cinemaRoomId}', TenPhong = N'{cinemaRoomName}', TongSoGhe = {totalChair}, " +
                $"TinhTrang = {cinemaRoomStatus}, SoHangGhe = {totalNumberRowChair}, SoGheMoiHang = {totalChairPerRow}, MaDinhDangMH = '{screenFormatID}' " +
                $"where MaPhongChieu = '{cinemaRoomId}'; ";
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            List<string> showTimeIDs = DataProvider.GetStringValuesFromSpecificColumnWithCondition("SuatChieu", "MaSuatChieu", $"MaPhongChieu = '{cinemaRoomId}'");
            foreach (string showTimeID in showTimeIDs)
            {
                string filmID = DataProvider.GetSingleStringValueFromQuery($"select MaBoPhim from SuatChieu where MaSuatChieu = '{showTimeID}'");
                string filmStatus = DataProvider.GetSingleStringValueFromQuery($"select TrangThai from BoPhim where MaBoPhim = '{filmID}'");
                if (filmStatus == "0")
                    continue;
                success = BLCommon.UpdateState("TrangThai", "SuatChieu", cinemaRoomStatus, $"MaSuatChieu = '{showTimeID}'", ref err);
                if (!success)
                    return success;
            }
            return success;
        }
        public static bool Insert(string cinemaRoomId, string cinemaRoomName, int totalChair, int cinemaRoomStatus,
            int totalNumberRowChair, int totalChairPerRow, string screenFormatID, ref string err)
        {
            string command = $"insert into {tableName} values('{cinemaRoomId}', N'{cinemaRoomName}',{totalChair}, {cinemaRoomStatus}, " +
                $"{totalNumberRowChair},{totalChairPerRow}, '{screenFormatID}' );";
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }

        public static bool Remove(string cinemaRoomId, ref string err)
        {
            string command = $"delete from {tableName} where MaPhongChieu = '{cinemaRoomId}';";
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }
    }
}
