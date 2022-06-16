using QuanLyRapChieuPhim_ADO.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim_ADO.BS_Layer
{
    internal class BLEmployee
    {
        private static string tableName = "NhanVien";
        static BLEmployee()
        {
            
        }

        public static DataSet GetData()
        {
            string command = $"select * from {tableName}";
            DataSet dt = DataProvider.GetData(command);
            return dt;
        }

        public static bool Update(string employeeID, string employeeName, DateTime birthDate, string sex, string address, string phoneNumber,
            ref string err)
        {
            string command = $"update {tableName} set Hoten = N'{employeeName}', NgaySinh = '{birthDate}', GioiTinh = N'{sex}', DiaChi = N'{address}', " +
                $"SoDienThoai = '{phoneNumber}' where MaNhanVien = '{employeeID}'; ";
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }
        public static bool Insert(string employeeName, DateTime birthDate, string sex, string address, string phoneNumber,
            ref string err)
        {
            string command = $"insert into {tableName} (Hoten, NgaySinh, GioiTinh, DiaChi, SoDienThoai) values( N'{employeeName}','{birthDate}', N'{sex}', N'{address}'," +
                $"'{phoneNumber}');";
            return DataProvider.ExecuteNonQuery(command, ref err);
        }

        public static bool Remove(string employeeID, ref string err)
        {
            string command = $"delete from NhanVien where MaNhanVien = '{employeeID}'";
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }
    }
}
