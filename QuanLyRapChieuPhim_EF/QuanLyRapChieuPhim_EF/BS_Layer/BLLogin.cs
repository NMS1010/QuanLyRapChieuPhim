using System;
using System.Collections.Generic;
using System.Data;
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
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    TaiKhoan entity = ctx.TaiKhoans.SingleOrDefault(x => x.TenTaiKhoan == username && x.MatKhau == password);
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
