using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapChieuPhim_EF.DataObjects;
using QuanLyRapChieuPhim_EF.Enum;

namespace QuanLyRapChieuPhim_EF.BS_Layer
{
    internal static class BLLogin
    {

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
            DBConnect.DBConnection.Connect();
            using (CinemaManagementModel ctx = new CinemaManagementModel(DBConnect.DBConnection.ConnectionString))
            {
                try
                {
                    TaiKhoan entity = (from a in ctx.TaiKhoans
                                       where a.TenTaiKhoan == username && a.MatKhau == password
                                       select a).SingleOrDefault();
                    if (entity == null)
                    {
                        success = false;
                        error = "Tài khoản hoặc mật khẩu không chính xác. Vui lòng thử lại";
                        return success;
                    }
                    if (entity.LoaiTaiKhoan == ((int)ACCOUNT_ROLE.TICKET_CLERK).ToString())
                    {
                        AccountRole = ACCOUNT_ROLE.TICKET_CLERK;
                    }
                    else if (entity.LoaiTaiKhoan == ((int)ACCOUNT_ROLE.ADMIN).ToString())
                    {
                        AccountRole = ACCOUNT_ROLE.ADMIN;
                    }
                    UserName = entity.TenTaiKhoan.ToString();
                }
                catch (SqlException e)
                {

                    success = false;
                    error = e.Message;
                }
                catch (Exception e)
                {
                    success = false;
                    error = e.Message;
                }
                
            }
            return success;
        }

    }
}
