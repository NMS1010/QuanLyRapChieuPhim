using QuanLyRapChieuPhim_EF.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim_EF.BS_Layer
{
    internal class BLEmployee
    {
        static BLEmployee()
        {
            
        }

        public static DataSet GetData()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaNhanVien", typeof(int));
            dt.Columns.Add("HoTen", typeof(string));
            dt.Columns.Add("NgaySinh", typeof(DateTime));
            dt.Columns.Add("GioiTinh", typeof(string));
            dt.Columns.Add("DiaChi", typeof(string));
            dt.Columns.Add("SoDienThoai", typeof(string));
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                IList<NhanVien> employees = (from a in ctx.NhanViens
                                select a).ToList();
                foreach (NhanVien employee in employees)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaNhanVien"] = employee.MaNhanVien;
                    dr["HoTen"] = employee.HoTen;
                    dr["NgaySinh"] = employee.NgaySinh;
                    dr["GioiTinh"] = employee.GioiTinh;
                    dr["DiaChi"] = employee.DiaChi;
                    dr["SoDienThoai"] = employee.SoDienThoai;
                    dt.Rows.Add(dr);
                }
                ds.Tables.Add(dt);
            }
            return ds;
        }

        public static bool Update(string employeeID, string employeeName, DateTime birthDate, string sex, string address, string phoneNumber,
            ref string err)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    int id = int.Parse(employeeID);
                    NhanVien employee = ctx.NhanViens.SingleOrDefault(c => c.MaNhanVien == id);
                    if (employee != null)
                    {
                        employee.HoTen = employeeName;
                        employee.NgaySinh = birthDate;
                        employee.GioiTinh = sex;
                        employee.DiaChi = address;
                        employee.SoDienThoai = phoneNumber;
                        ctx.SaveChanges();
                    }
                }
                catch (EntitySqlException e)
                {
                    success = false;
                    err = e.Message;
                }
            }
            return success;
        }
        public static bool Insert(string employeeName, DateTime birthDate, string sex, string address, string phoneNumber,
            ref string err)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    NhanVien employee = new NhanVien(employeeName, birthDate, sex, address, phoneNumber);
                    ctx.NhanViens.Add(employee);
                    ctx.SaveChanges();
                }
                catch (EntitySqlException e)
                {
                    success = false;
                    err = e.Message;
                }
            }
            return success;
        }

        public static bool Remove(string employeeID, ref string err)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    int id = int.Parse(employeeID);
                    NhanVien employee = new NhanVien() { MaNhanVien = id};
                    ctx.NhanViens.Attach(employee);
                    ctx.NhanViens.Remove(employee);
                    ctx.SaveChanges();
                }
                catch (EntitySqlException e)
                {
                    success = false;
                    err = e.Message;
                }
            }
            return success;
        }
    }
}
