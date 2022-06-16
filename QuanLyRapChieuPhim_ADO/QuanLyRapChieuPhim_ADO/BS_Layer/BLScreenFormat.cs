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
            string command = $"delete from DinhDangManHinh where MaDinhDangMH = '{screenFormatID}'";
            success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }

    }
}
