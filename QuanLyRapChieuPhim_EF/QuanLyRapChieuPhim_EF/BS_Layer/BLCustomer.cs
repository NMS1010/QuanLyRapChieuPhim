using QuanLyRapChieuPhim_EF.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim_EF.BS_Layer
{
    internal static class BLCustomer
    {
        static BLCustomer()
        {
        }

        public static DataSet GetData()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaKhachHang", typeof(int));
            dt.Columns.Add("HoTen", typeof(string));
            dt.Columns.Add("NgaySinh", typeof(DateTime));
            dt.Columns.Add("GioiTinh", typeof(string));
            dt.Columns.Add("DiaChi", typeof(string));
            dt.Columns.Add("SoDienThoai", typeof(string));
            dt.Columns.Add("DiemTichLuy", typeof(int));
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                IList<KhachHang> customers = (from a in ctx.KhachHangs
                               select a).ToList();
                foreach (KhachHang customer in customers)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaKhachHang"] = customer.MaKhachHang;
                    dr["HoTen"] = customer.HoTen;
                    dr["NgaySinh"] = customer.NgaySinh;
                    dr["GioiTinh"] = customer.GioiTinh;
                    dr["DiaChi"] = customer.DiaChi;
                    dr["SoDienThoai"] = customer.SoDienThoai;
                    dr["DiemTichLuy"] = customer.DiemTichLuy;
                    dt.Rows.Add(dr);
                }
                ds.Tables.Add(dt);
            }
            return ds;
        }

        public static bool Update(string customerID, string customerName, DateTime birthDate, string sex, string address, string phoneNumber,
            int cumulativePoint, ref string err)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    int id = int.Parse(customerID);
                    KhachHang customer = ctx.KhachHangs.SingleOrDefault(c => c.MaKhachHang == id);
                    if (customer != null)
                    {
                        customer.HoTen = customerName;
                        customer.NgaySinh = birthDate;
                        customer.GioiTinh = sex;
                        customer.DiaChi = address;
                        customer.SoDienThoai = phoneNumber;
                        customer.DiemTichLuy = cumulativePoint;
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    success = false;
                    err = e.InnerException.ToString();
                }
            }
            return success;
        }
        public static bool Insert(string customerName, DateTime birthDate, string sex, string address, string phoneNumber,
            int cumulativePoint, ref string err)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    KhachHang customer = new KhachHang(customerName, birthDate, sex, address, phoneNumber, cumulativePoint);
                    ctx.KhachHangs.Add(customer);
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
        public static bool UpdatePoint(string customerID, int cumulativePoint, ref string err)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    int id = int.Parse(customerID);
                    KhachHang customer = ctx.KhachHangs.SingleOrDefault(c => c.MaKhachHang == id);
                    if (customer != null)
                    {
                        customer.DiemTichLuy = cumulativePoint;
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    success = false;
                    err = e.InnerException.ToString();
                }
            }
            return success;
        }
        public static bool ContainCustomer(string customerID)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    int id = int.Parse(customerID);
                    KhachHang customer = ctx.KhachHangs.SingleOrDefault(c => c.MaKhachHang == id);
                    if (customer != null)
                        success = true;
                    else
                        success = false;
                }
                catch
                {
                    success = false;
                }
            }
            return success;
        }
        public static bool Remove(string customerID, ref string err)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    int id = int.Parse(customerID);
                    KhachHang customer = new KhachHang() { MaKhachHang = id };
                    ctx.KhachHangs.Attach(customer);
                    ctx.KhachHangs.Remove(customer);
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
