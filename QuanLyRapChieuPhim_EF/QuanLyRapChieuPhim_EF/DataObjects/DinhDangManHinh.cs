namespace QuanLyRapChieuPhim_EF.DataObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DinhDangManHinh")]
    public partial class DinhDangManHinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DinhDangManHinh()
        {
            PhongChieux = new HashSet<PhongChieu>();
        }
        public DinhDangManHinh(string screenFormatID, string nameScreenFormat, decimal ticketPrice)
        {
            PhongChieux = new HashSet<PhongChieu>();
            MaDinhDangMH = screenFormatID;
            TenDinhDang = nameScreenFormat;
            GiaVe = ticketPrice;
        }
        [Key]
        [StringLength(50)]
        public string MaDinhDangMH { get; set; }

        [Required]
        public string TenDinhDang { get; set; }

        [Column(TypeName = "money")]
        public decimal GiaVe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhongChieu> PhongChieux { get; set; }
    }
}
