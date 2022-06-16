namespace QuanLyRapChieuPhim_EF.DataObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SuatChieu")]
    public partial class SuatChieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SuatChieu()
        {
            Ves = new HashSet<Ve>();
        }
        public SuatChieu(string showTimeID, DateTime startShowTime, string statusShowTime, string filmID, string cinemaRoomID)
        {
            Ves = new HashSet<Ve>();
            MaSuatChieu = showTimeID;
            ThoiGian = startShowTime;
            TrangThai = int.Parse(statusShowTime);
            MaBoPhim = filmID;
            MaPhongChieu = cinemaRoomID;
        }
        [Key]
        [StringLength(50)]
        public string MaSuatChieu { get; set; }

        public DateTime ThoiGian { get; set; }

        public int TrangThai { get; set; }

        [Required]
        [StringLength(50)]
        public string MaBoPhim { get; set; }

        [Required]
        [StringLength(50)]
        public string MaPhongChieu { get; set; }

        public virtual BoPhim BoPhim { get; set; }

        public virtual PhongChieu PhongChieu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ve> Ves { get; set; }
    }
}
