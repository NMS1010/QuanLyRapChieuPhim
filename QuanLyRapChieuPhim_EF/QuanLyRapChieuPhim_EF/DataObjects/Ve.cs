namespace QuanLyRapChieuPhim_EF.DataObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ve")]
    public partial class Ve
    {
        [Key]
        public int MaVe { get; set; }

        public int TrangThai { get; set; }

        [Required]
        public string MaGhe { get; set; }

        public int? MaKhachHang { get; set; }

        [Required]
        [StringLength(50)]
        public string MaSuatChieu { get; set; }

        public int LoaiVe { get; set; }

        [Column(TypeName = "money")]
        public decimal TienVe { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayMua { get; set; }
        public Ve(int ticketStatus, string seatID, string customerID, string showTimeID, int ticketType, decimal ticketPrice, DateTime buyDate)
        {
            TrangThai = ticketStatus;
            MaGhe = seatID;
            if (customerID != "")
                MaKhachHang = int.Parse(customerID);
            MaSuatChieu = showTimeID;
            LoaiVe = ticketType;
            TienVe = ticketPrice;
            NgayMua = buyDate;
        }
        public Ve()
        {

        }
        public virtual KhachHang KhachHang { get; set; }

        public virtual SuatChieu SuatChieu { get; set; }
    }
}
