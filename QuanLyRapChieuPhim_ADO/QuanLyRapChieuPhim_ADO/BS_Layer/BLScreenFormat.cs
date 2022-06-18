using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapChieuPhim_ADO.DB_Layer;

namespace QuanLyRapChieuPhim_ADO.BS_Layer
{
    internal static class BLScreenFormat
    {
        private static string tableName = "DinhDangManHinh";
        static BLScreenFormat()
        {
        }

        public static DataSet GetData()
        {
            string command = $"select * from {tableName}";
            DataSet dt = DataProvider.GetData(command);
            return dt;
        }
        public static string GetScreenFormatNameFromScreenFormatID(string screenFormatID)
        {
            string command = $"select TenDinhDang from {tableName} where MaDinhDangMH = N'{screenFormatID}'";
            return DataProvider.GetSingleStringValueFromQuery(command);
        }
        public static string GetScreenFormatNameFromCinemaRoomID(string cinemaRoomID)
        {
            string screenFormatID = GetScreenFormatIDFromCinemaRoomID(cinemaRoomID);
            return GetScreenFormatNameFromScreenFormatID(screenFormatID);
        }
        public static string GetScreenFormatIDFromCinemaRoomID(string cinemaRoomID)
        {
            string command = $"select MaDinhDangMH from PhongChieu where MaPhongChieu = N'{cinemaRoomID}'";
            return DataProvider.GetSingleStringValueFromQuery(command);
        }
        public static List<Tuple<string, string>> GetScreenFormats()
        {
            string command = $"select TenDinhDang, MaDinhDangMH from {tableName}";
            DataSet ds = DataProvider.GetData(command);
            List<Tuple<string, string>> screenFormats = new List<Tuple<string, string>>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                screenFormats.Add(new Tuple<string, string>(dr["TenDinhDang"].ToString(), dr["MaDinhDangMH"].ToString()));
            }
            return screenFormats;
        }
        public static bool Update(string screenFormatID, string nameScreenFormat, decimal ticketPrice, ref string err)
        {
            string command = $"update {tableName} set TenDinhDang = N'{nameScreenFormat}', GiaVe = {ticketPrice} where MaDinhDangMH = '{screenFormatID}'; ";
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }
        public static bool Insert(string screenFormatID, string nameScreenFormat, decimal ticketPrice, ref string err)
        {
            string command = $"insert into {tableName} values('{screenFormatID}', N'{nameScreenFormat}',{ticketPrice});";
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }

        public static bool Remove(string screenFormatID, ref string err)
        {
            bool success = BLCommon.UpdateState("TinhTrang", "PhongChieu", 0, $"MaDinhDangMH = '{screenFormatID}'", ref err);
            if (!success)
                return success;
            string command = $"delete from {tableName} where MaDinhDangMH = '{screenFormatID}'";
            success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }

    }
}
