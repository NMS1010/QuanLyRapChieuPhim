namespace QuanLyRapChieuPhim_EF.DataObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            TaiKhoans = new HashSet<TaiKhoan>();
        }
        public NhanVien(string employeeName, DateTime birthDate, string sex, string address, string phoneNumber)
        {
            TaiKhoans = new HashSet<TaiKhoan>();
            HoTen = employeeName;
            NgaySinh = birthDate;
            GioiTinh = sex;
            DiaChi = address;
            SoDienThoai = phoneNumber;
        }
        [Key]
        public int MaNhanVien { get; set; }

        [Required]
        public string HoTen { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [Required]
        public string GioiTinh { get; set; }

        [Required]
        public string DiaChi { get; set; }

        [Required]
        public string SoDienThoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
