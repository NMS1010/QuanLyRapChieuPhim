using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyRapChieuPhim_EF.DataObjects
{
    public partial class CinemaManagementModel : DbContext
    {
        public CinemaManagementModel()
            : base("name=CinemaManagementModel")
        {
        }
        public CinemaManagementModel(string connectionStr)
           : base(connectionStr)
        {
        }
        public virtual DbSet<BoPhim> BoPhims { get; set; }
        public virtual DbSet<DinhDangManHinh> DinhDangManHinhs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhongChieu> PhongChieux { get; set; }
        public virtual DbSet<SuatChieu> SuatChieux { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }
        public virtual DbSet<Ve> Ves { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoPhim>()
                .Property(e => e.MaBoPhim)
                .IsUnicode(false);

            modelBuilder.Entity<BoPhim>()
                .Property(e => e.TenHangPhim)
                .IsUnicode(false);

            modelBuilder.Entity<BoPhim>()
                .HasMany(e => e.TheLoais)
                .WithMany(e => e.BoPhims)
                .Map(m => m.ToTable("BoPhim_TheLoai").MapLeftKey("MaBoPhim").MapRightKey("MaTheLoai"));

            modelBuilder.Entity<DinhDangManHinh>()
                .Property(e => e.MaDinhDangMH)
                .IsUnicode(false);

            modelBuilder.Entity<DinhDangManHinh>()
                .Property(e => e.GiaVe)
                .HasPrecision(19, 4);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<PhongChieu>()
                .Property(e => e.MaPhongChieu)
                .IsUnicode(false);

            modelBuilder.Entity<PhongChieu>()
                .Property(e => e.MaDinhDangMH)
                .IsUnicode(false);

            modelBuilder.Entity<SuatChieu>()
                .Property(e => e.MaSuatChieu)
                .IsUnicode(false);

            modelBuilder.Entity<SuatChieu>()
                .Property(e => e.MaBoPhim)
                .IsUnicode(false);

            modelBuilder.Entity<SuatChieu>()
                .Property(e => e.MaPhongChieu)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.LoaiTaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<TheLoai>()
                .Property(e => e.MaTheLoai)
                .IsUnicode(false);

            modelBuilder.Entity<Ve>()
                .Property(e => e.MaGhe)
                .IsUnicode(false);

            modelBuilder.Entity<Ve>()
                .Property(e => e.MaSuatChieu)
                .IsUnicode(false);

            modelBuilder.Entity<Ve>()
                .Property(e => e.TienVe)
                .HasPrecision(19, 4);
        }
    }
}
