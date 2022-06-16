using QuanLyRapChieuPhim_ADO.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim_ADO.BS_Layer
{
    internal static class BLAccount
    {
        private static string tableName = "TaiKhoan";
        static BLAccount()
        {

        }

        public static DataSet GetData()
        {
            string command = $"select * from {tableName}";
            DataSet dt = DataProvider.GetData(command);
            return dt;
        }

        public static bool Update(string userName, string passWord, int employeeID,
            int accountType, ref string err)
        {
            string command;
            if (employeeID <= 0)
            {
                command = $"update {tableName} set MatKhau = N'{passWord}', LoaiTaiKhoan = N'{accountType}' " +
                    $" where TenTaiKhoan = N'{userName}'; ";
            }
            else
                command = $"update {tableName} set MatKhau = N'{passWord}', MaNhanVien = {employeeID}, LoaiTaiKhoan = N'{accountType}' " +
                    $" where TenTaiKhoan = N'{userName}'; ";
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }
        public static bool Insert(string userName, string passWord, int employeeID,
            int accountType, ref string err)
        {
            string command;
            if (employeeID <= 0)
            {
                command = $"insert into {tableName} (TenTaiKhoan, MatKhau, LoaiTaiKhoan) values( N'{userName}',N'{passWord}',N'{accountType}');";
            }
            else
            {
                command = $"insert into {tableName} (TenTaiKhoan, MatKhau, MaNhanVien, LoaiTaiKhoan) values( N'{userName}',N'{passWord}',{employeeID},N'{accountType}');";
            }
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }

        public static bool Remove(string userName, ref string err)
        {
            string command = $"delete from TaiKhoan where TenTaiKhoan = '{userName}'";
            return DataProvider.ExecuteNonQuery(command, ref err);
        }
    }
}
