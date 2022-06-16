namespace QuanLyRapChieuPhim_EF.DataObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BoPhim")]
    public partial class BoPhim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BoPhim()
        {
            SuatChieux = new HashSet<SuatChieu>();
            TheLoais = new HashSet<TheLoai>();
        }
        public BoPhim(string filmId, string filmName, string filmDes, double totalFilmTime,
            DateTime startShow, DateTime endShow, int year, string director, string studioFilm, int movieStatus)
        {
            SuatChieux = new HashSet<SuatChieu>();
            TheLoais = new HashSet<TheLoai>();
            MaBoPhim = filmId;
            TenPhim = filmName;
            MoTa = filmDes;
            ThoiLuong = totalFilmTime;
            NgayKhoiChieu = startShow;
            NgayKetThuc = endShow;
            NamSX = year;
            DaoDien = director;
            TenHangPhim = studioFilm;
            TrangThai = movieStatus;
        }
        [Key]
        [StringLength(50)]
        public string MaBoPhim { get; set; }

        [Required]
        public string TenPhim { get; set; }

        [Required]
        public string MoTa { get; set; }

        public double ThoiLuong { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayKhoiChieu { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayKetThuc { get; set; }

        public int NamSX { get; set; }

        [Required]
        public string DaoDien { get; set; }

        [Required]
        [StringLength(50)]
        public string TenHangPhim { get; set; }

        public int TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SuatChieu> SuatChieux { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TheLoai> TheLoais { get; set; }
    }
}
