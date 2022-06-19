using QuanLyRapChieuPhim_ADO.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim_ADO.BS_Layer
{
    internal static class BLCustomer
    {
        private static string tableName = "KhachHang";
        static BLCustomer()
        {
        }

        public static DataSet GetData()
        {
            string command = $"select * from {tableName}";
            DataSet dt = DataProvider.GetData(command);
            return dt;
        }

        public static bool Update(string customerID, string customerName, DateTime birthDate, string sex, string address, string phoneNumber,
            int cumulativePoint, ref string err)
        {
            string command = $"update {tableName} set Hoten = N'{customerName}', NgaySinh = '{birthDate}', GioiTinh = N'{sex}', DiaChi = N'{address}', " +
                $"SoDienThoai = '{phoneNumber}', DiemTichLuy = {cumulativePoint} where MaKhachHang = '{customerID}'; ";
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }
        public static bool Insert(string customerName, DateTime birthDate, string sex, string address, string phoneNumber,
            int cumulativePoint, ref string err)
        {
            string command = $"insert into {tableName} (Hoten, NgaySinh, GioiTinh, DiaChi, SoDienThoai, DiemTichLuy) values( N'{customerName}','{birthDate}', N'{sex}', N'{address}'," +
                $"'{phoneNumber}', {cumulativePoint});";
            return DataProvider.ExecuteNonQuery(command, ref err);
        }
        public static int GetPoint(string customerID)
        {
            string command = $"select DiemTichLuy from KhachHang where MaKhachHang = '{customerID}'; ";
            string res = DataProvider.GetSingleStringValueFromQuery(command);
            return int.Parse(res);
        }
        public static bool UpdatePoint(string customerID, int cumulativePoint, ref string err)
        {
            string command = $"update {tableName} set DiemTichLuy = {cumulativePoint + GetPoint(customerID)} where MaKhachHang = '{customerID}'; ";
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }
        public static bool ContainCustomer(string customerID)
        {
            string command = $"select MaKhachHang from {tableName} where MaKhachHang = '{customerID}'";
            string res = DataProvider.GetSingleStringValueFromQuery(command);
            if (res == "")
                return false;
            return true;
        }
        public static bool Remove(string customerID, ref string err)
        {
            string command = $"delete from {tableName} where MaKhachHang = '{customerID}'";
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }
    }
}
