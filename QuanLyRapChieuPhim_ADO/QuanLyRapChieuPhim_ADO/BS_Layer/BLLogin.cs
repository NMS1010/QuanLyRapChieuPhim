using QuanLyRapChieuPhim_ADO.DB_Layer;
using QuanLyRapChieuPhim_ADO.Enum;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim_ADO.BS_Layer
{
    internal static class BLLogin
    {
        private static string tableName = "TaiKhoan";

        private static ACCOUNT_ROLE accountRole;
        private static string userName;
        static BLLogin()
        {
            
        }

        public static string UserName { get => userName; set => userName = value; }
        public static ACCOUNT_ROLE AccountRole { get => accountRole; set => accountRole = value; }

        public static bool Authentication(string username, string password, ref string error)
        {
            bool success = true;
            string command = $"select * from {tableName} where TenTaiKhoan = N'{username}' and MatKhau = '{password}'";
            DataSet ds = DataProvider.GetData(command);
            if (ds.Tables.Count == 0)
            {
                error = "Cannot get data from database. Please check the connection";
                return false;
            }
            if(ds.Tables[0].Rows.Count <= 0)
            {
                success = false;
                error = "Tài khoản hoặc mật khẩu không chính xác. Vui lòng thử lại";
                return success;
            }
            if (ds.Tables[0].Rows[0]["LoaiTaiKhoan"].ToString() == ((int)ACCOUNT_ROLE.TICKET_CLERK).ToString())
            {
                AccountRole = ACCOUNT_ROLE.TICKET_CLERK;
            }
            else if(ds.Tables[0].Rows[0]["LoaiTaiKhoan"].ToString() == ((int)ACCOUNT_ROLE.ADMIN).ToString())
            {
                AccountRole = ACCOUNT_ROLE.ADMIN;
            }
            UserName = ds.Tables[0].Rows[0]["TenTaiKhoan"].ToString();
            return success;
        }

    }
}
