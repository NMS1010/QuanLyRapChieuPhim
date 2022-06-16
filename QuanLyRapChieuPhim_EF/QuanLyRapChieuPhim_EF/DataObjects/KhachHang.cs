namespace QuanLyRapChieuPhim_EF.DataObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            Ves = new HashSet<Ve>();
        }
        public KhachHang(string customerName, DateTime birthDate, string sex, string address, string phoneNumber,
            int cumulativePoint)
        {
            Ves = new HashSet<Ve>();
            HoTen = customerName;
            NgaySinh = birthDate;
            GioiTinh = sex;
            DiaChi = address;
            SoDienThoai = phoneNumber;
            DiemTichLuy = cumulativePoint;
        }
        [Key]
        public int MaKhachHang { get; set; }

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

        public int DiemTichLuy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ve> Ves { get; set; }
    }
}
