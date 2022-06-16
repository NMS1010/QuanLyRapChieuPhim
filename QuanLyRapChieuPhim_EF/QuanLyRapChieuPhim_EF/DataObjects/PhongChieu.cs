namespace QuanLyRapChieuPhim_EF.DataObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhongChieu")]
    public partial class PhongChieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhongChieu()
        {
            SuatChieux = new HashSet<SuatChieu>();
        }
        public PhongChieu(string cinemaRoomId, string cinemaRoomName, int totalChair, int cinemaRoomStatus,
            int totalNumberRowChair, int totalChairPerRow, string screenFormatID)
        {
            SuatChieux = new HashSet<SuatChieu>();
            MaPhongChieu = cinemaRoomId;
            TenPhong = cinemaRoomName;
            TongSoGhe = totalChair;
            TinhTrang = cinemaRoomStatus;
            SoHangGhe = totalNumberRowChair;
            SoGheMoiHang = totalChairPerRow;
            MaDinhDangMH = screenFormatID;
        }
        [Key]
        [StringLength(50)]
        public string MaPhongChieu { get; set; }

        [Required]
        public string TenPhong { get; set; }

        public int TongSoGhe { get; set; }

        public int TinhTrang { get; set; }

        public int SoHangGhe { get; set; }

        public int SoGheMoiHang { get; set; }

        [StringLength(50)]
        public string MaDinhDangMH { get; set; }

        public virtual DinhDangManHinh DinhDangManHinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SuatChieu> SuatChieux { get; set; }
    }
}
