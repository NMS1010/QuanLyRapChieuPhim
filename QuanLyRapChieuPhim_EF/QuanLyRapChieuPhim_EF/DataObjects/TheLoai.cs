namespace QuanLyRapChieuPhim_EF.DataObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TheLoai")]
    public partial class TheLoai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TheLoai()
        {
            BoPhims = new HashSet<BoPhim>();
        }
        public TheLoai(string genreId, string genreName)
        {
            BoPhims = new HashSet<BoPhim>();
            MaTheLoai = genreId;
            TenTheLoai = genreName;
        }
        [Key]
        [StringLength(50)]
        public string MaTheLoai { get; set; }

        [Required]
        public string TenTheLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoPhim> BoPhims { get; set; }
    }
}
