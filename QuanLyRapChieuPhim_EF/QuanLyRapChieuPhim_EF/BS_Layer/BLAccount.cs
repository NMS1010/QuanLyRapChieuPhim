using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapChieuPhim_EF.DataObjects;

namespace QuanLyRapChieuPhim_EF.BS_Layer
{
    internal static class BLAccount
    {
        static BLAccount()
        {

        }

        public static DataSet GetData()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("TenTaiKhoan", typeof(string));
            dt.Columns.Add("MatKhau", typeof(string));
            dt.Columns.Add("MaNhanVien", typeof(string));
            dt.Columns.Add("LoaiTaiKhoan", typeof(string));
            using (CinemaManagementModel ctx = new CinemaManagementModel()) {
                IList<TaiKhoan> accounts = (from a in ctx.TaiKhoans
                          select a).ToList();
                foreach(TaiKhoan account in accounts)
                {
                    DataRow dr = dt.NewRow();
                    dr["TenTaiKhoan"] = account.TenTaiKhoan;
                    dr["MatKhau"] = account.MatKhau;
                    dr["MaNhanVien"] = account.MaNhanVien.ToString();
                    dr["LoaiTaiKhoan"] = account.LoaiTaiKhoan;
                    dt.Rows.Add(dr);
                }
                ds.Tables.Add(dt);
            }
            return ds;
        }

        public static bool Update(string userName, string passWord, int employeeID,
            int accountType, ref string err)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    TaiKhoan account = ctx.TaiKhoans.SingleOrDefault(acc => acc.TenTaiKhoan == userName);
                    if(account != null)
                    {
                        account.MatKhau = passWord;
                        if(employeeID > 0)
                            account.MaNhanVien = employeeID;
                        account.LoaiTaiKhoan = accountType.ToString();
                        ctx.SaveChanges();
                    }
                }
                catch(Exception e)
                {
                    success = false;
                    err = e.InnerException.ToString();
                }
            }
            return success;
        }
        public static bool Insert(string userName, string passWord, int employeeID,
            int accountType, ref string err)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    TaiKhoan account = new TaiKhoan(userName, passWord, employeeID, accountType.ToString());
                    ctx.TaiKhoans.Add(account);
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    success = false;
                    err = e.InnerException.ToString();
                }
            }
            return success;
        }

        public static bool Remove(string userName, ref string err)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    TaiKhoan account = new TaiKhoan() { TenTaiKhoan = userName };
                    ctx.TaiKhoans.Attach(account);
                    ctx.TaiKhoans.Remove(account);
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    success = false;
                    err = e.InnerException.ToString();
                }
            }
            return success;
        }
    }
}
