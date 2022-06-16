namespace QuanLyRapChieuPhim_EF.DataObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(50)]
        public string TenTaiKhoan { get; set; }

        [Required]
        public string MatKhau { get; set; }

        public int? MaNhanVien { get; set; }

        [Required]
        [StringLength(50)]
        public string LoaiTaiKhoan { get; set; }
        public TaiKhoan(string accountName, string password, int employeeID, string accountType)
        {
            TenTaiKhoan = accountName;
            MatKhau = password;
            if (employeeID > 0)
                MaNhanVien = employeeID;
            LoaiTaiKhoan = accountType;
        }
        public TaiKhoan()
        {

        }
        public virtual NhanVien NhanVien { get; set; }
    }
}
