
SET QUOTED_IDENTIFIER OFF;
GO
CREATE DATABASE QuanLyRapChieuPhim
GO
USE [QuanLyRapChieuPhim];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_BoPhim_SuatChieu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SuatChieu] DROP CONSTRAINT [FK_BoPhim_SuatChieu];
GO
IF OBJECT_ID(N'[dbo].[FK_DinhDangManHinh_PhongChieu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhongChieu] DROP CONSTRAINT [FK_DinhDangManHinh_PhongChieu];
GO
IF OBJECT_ID(N'[dbo].[FK_KhachHang_Ve]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ve] DROP CONSTRAINT [FK_KhachHang_Ve];
GO
IF OBJECT_ID(N'[dbo].[FK_PhongChieu_SuatChieu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SuatChieu] DROP CONSTRAINT [FK_PhongChieu_SuatChieu];
GO
IF OBJECT_ID(N'[dbo].[FK_SuatChieu_Ve]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ve] DROP CONSTRAINT [FK_SuatChieu_Ve];
GO
IF OBJECT_ID(N'[dbo].[FK_BoPhim_TheLoai_BoPhim]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BoPhim_TheLoai] DROP CONSTRAINT [FK_BoPhim_TheLoai_BoPhim];
GO
IF OBJECT_ID(N'[dbo].[FK_BoPhim_TheLoai_TheLoai]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BoPhim_TheLoai] DROP CONSTRAINT [FK_BoPhim_TheLoai_TheLoai];
GO
IF OBJECT_ID(N'[dbo].[FK_NhanVien_TaiKhoan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NhanVien] DROP CONSTRAINT [FK_NhanVien_TaiKhoan];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[BoPhim]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BoPhim];
GO
IF OBJECT_ID(N'[dbo].[DinhDangManHinh]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DinhDangManHinh];
GO
IF OBJECT_ID(N'[dbo].[KhachHang]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KhachHang];
GO
IF OBJECT_ID(N'[dbo].[PhongChieu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PhongChieu];
GO
IF OBJECT_ID(N'[dbo].[SuatChieu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SuatChieu];
GO
IF OBJECT_ID(N'[dbo].[TheLoai]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TheLoai];
GO
IF OBJECT_ID(N'[dbo].[Ve]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ve];
GO
IF OBJECT_ID(N'[dbo].[TaiKhoan]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TaiKhoan];
GO
IF OBJECT_ID(N'[dbo].[NhanVien]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NhanVien];
GO
IF OBJECT_ID(N'[dbo].[BoPhim_TheLoai]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BoPhim_TheLoai];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

CREATE TABLE [dbo].[BoPhim] (
    [MaBoPhim] varchar(50)  NOT NULL,
    [TenPhim] nvarchar(max)  NOT NULL,
    [MoTa] nvarchar(max)  NOT NULL,
    [ThoiLuong] float  NOT NULL,
    [NgayKhoiChieu] date  NOT NULL,
    [NgayKetThuc] date  NOT NULL,
    [NamSX] int  NOT NULL,
    [DaoDien] nvarchar(max)  NOT NULL,
    [TenHangPhim] varchar(50)  NOT NULL,
    [TrangThai] int  NOT NULL
);
GO

CREATE TABLE [dbo].[DinhDangManHinh] (
    [MaDinhDangMH] varchar(50)  NOT NULL,
    [TenDinhDang] nvarchar(max)  NOT NULL,
    [GiaVe] money  NOT NULL
);
GO

CREATE TABLE [dbo].[KhachHang] (
    [MaKhachHang] int IDENTITY(1,1) NOT NULL,
    [HoTen] nvarchar(max)  NOT NULL,
    [NgaySinh] date  NOT NULL,
    [GioiTinh] nvarchar(max)  NOT NULL,
    [DiaChi] nvarchar(max)  NOT NULL,
    [SoDienThoai] varchar(max)  NOT NULL,
    [DiemTichLuy] int  NOT NULL
);
GO

CREATE TABLE [dbo].[PhongChieu] (
    [MaPhongChieu] varchar(50)  NOT NULL,
    [TenPhong] nvarchar(max)  NOT NULL,
    [TongSoGhe] int  NOT NULL,
    [TinhTrang] int  NOT NULL,
    [SoHangGhe] int  NOT NULL,
    [SoGheMoiHang] int  NOT NULL,
    [MaDinhDangMH] varchar(50)
);
GO

CREATE TABLE [dbo].[SuatChieu] (
    [MaSuatChieu] varchar(50)  NOT NULL,
    [ThoiGian] datetime  NOT NULL,
    [TrangThai] int  NOT NULL,
    [MaBoPhim] varchar(50)  NOT NULL,
    [MaPhongChieu] varchar(50)  NOT NULL
);
GO

CREATE TABLE [dbo].[TheLoai] (
    [MaTheLoai] varchar(50)  NOT NULL,
    [TenTheLoai] nvarchar(max)  NOT NULL
);
GO

CREATE TABLE [dbo].[Ve] (
    [MaVe] int IDENTITY(1,1) NOT NULL,
    [TrangThai] int  NOT NULL,
    [MaGhe] varchar(max)  NOT NULL,
    [MaKhachHang] int  NULL,
    [MaSuatChieu] varchar(50)  NOT NULL,
    [LoaiVe] int  NOT NULL,
    [TienVe] money  NOT NULL,
	[NgayMua] date NULL
);
GO

CREATE TABLE [dbo].[TaiKhoan] (
    [TenTaiKhoan] nvarchar(50)  NOT NULL,
    [MatKhau] nvarchar(max)  NOT NULL,
    [MaNhanVien] int  NULL,
	[LoaiTaiKhoan] varchar(50) NOT NULL
);
GO

CREATE TABLE [dbo].[NhanVien] (
    [MaNhanVien] int IDENTITY(1,1) NOT NULL,
    [HoTen] nvarchar(max)  NOT NULL,
    [NgaySinh] date  NOT NULL,
    [GioiTinh] nvarchar(max)  NOT NULL,
    [DiaChi] nvarchar(max)  NOT NULL,
    [SoDienThoai] varchar(max)  NOT NULL,
);
GO

CREATE TABLE [dbo].[BoPhim_TheLoai] (
    [MaBoPhim] varchar(50)  NOT NULL,
    [MaTheLoai] varchar(50)  NOT NULL
);
GO


-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

ALTER TABLE [dbo].[BoPhim]
ADD CONSTRAINT [PK_BoPhim]
    PRIMARY KEY CLUSTERED ([MaBoPhim] ASC);
GO

ALTER TABLE [dbo].[DinhDangManHinh]
ADD CONSTRAINT [PK_DinhDangManHinh]
    PRIMARY KEY CLUSTERED ([MaDinhDangMH] ASC);
GO

ALTER TABLE [dbo].[KhachHang]
ADD CONSTRAINT [PK_KhachHang]
    PRIMARY KEY CLUSTERED ([MaKhachHang] ASC);
GO

ALTER TABLE [dbo].[PhongChieu]
ADD CONSTRAINT [PK_PhongChieu]
    PRIMARY KEY CLUSTERED ([MaPhongChieu] ASC);
GO

ALTER TABLE [dbo].[SuatChieu]
ADD CONSTRAINT [PK_SuatChieu]
    PRIMARY KEY CLUSTERED ([MaSuatChieu] ASC);
GO

ALTER TABLE [dbo].[TheLoai]
ADD CONSTRAINT [PK_TheLoai]
    PRIMARY KEY CLUSTERED ([MaTheLoai] ASC);
GO

ALTER TABLE [dbo].[Ve]
ADD CONSTRAINT [PK_Ve]
    PRIMARY KEY CLUSTERED ([MaVe] ASC);
GO

ALTER TABLE [dbo].[TaiKhoan]
ADD CONSTRAINT [PK_TaiKhoan]
    PRIMARY KEY CLUSTERED ([TenTaiKhoan] ASC);
GO

ALTER TABLE [dbo].[NhanVien]
ADD CONSTRAINT [PK_NhanVien]
    PRIMARY KEY CLUSTERED ([MaNhanVien] ASC);
GO

ALTER TABLE [dbo].[BoPhim_TheLoai]
ADD CONSTRAINT [PK_BoPhim_TheLoai]
    PRIMARY KEY CLUSTERED ([MaBoPhim], [MaTheLoai] ASC);
GO


-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

ALTER TABLE [dbo].[SuatChieu]
ADD CONSTRAINT [FK_BoPhim_SuatChieu]
    FOREIGN KEY ([MaBoPhim])
    REFERENCES [dbo].[BoPhim]
        ([MaBoPhim])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

CREATE INDEX [IX_FK_BoPhim_SuatChieu]
ON [dbo].[SuatChieu]
    ([MaBoPhim]);
GO

ALTER TABLE [dbo].[PhongChieu]
ADD CONSTRAINT [FK_DinhDangManHinh_PhongChieu]
    FOREIGN KEY ([MaDinhDangMH])
    REFERENCES [dbo].[DinhDangManHinh]
        ([MaDinhDangMH])
    ON DELETE SET NULL ON UPDATE NO ACTION;
GO

CREATE INDEX [IX_FK_DinhDangManHinh_PhongChieu]
ON [dbo].[PhongChieu]
    ([MaDinhDangMH]);
GO

ALTER TABLE [dbo].[Ve]
ADD CONSTRAINT [FK_KhachHang_Ve]
    FOREIGN KEY ([MaKhachHang])
    REFERENCES [dbo].[KhachHang]
        ([MaKhachHang])
    ON DELETE SET NULL ON UPDATE NO ACTION;
GO

CREATE INDEX [IX_FK_KhachHang_Ve]
ON [dbo].[Ve]
    ([MaKhachHang]);
GO

ALTER TABLE [dbo].[SuatChieu]
ADD CONSTRAINT [FK_PhongChieu_SuatChieu]
    FOREIGN KEY ([MaPhongChieu])
    REFERENCES [dbo].[PhongChieu]
        ([MaPhongChieu])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

CREATE INDEX [IX_FK_PhongChieu_SuatChieu]
ON [dbo].[SuatChieu]
    ([MaPhongChieu]);
GO

ALTER TABLE [dbo].[Ve]
ADD CONSTRAINT [FK_SuatChieu_Ve]
    FOREIGN KEY ([MaSuatChieu])
    REFERENCES [dbo].[SuatChieu]
        ([MaSuatChieu])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

CREATE INDEX [IX_FK_SuatChieu_Ve]
ON [dbo].[Ve]
    ([MaSuatChieu]);
GO

ALTER TABLE [dbo].[BoPhim_TheLoai]
ADD CONSTRAINT [FK_BoPhim_TheLoai_BoPhim]
    FOREIGN KEY ([MaBoPhim])
    REFERENCES [dbo].[BoPhim]
        ([MaBoPhim])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

ALTER TABLE [dbo].[BoPhim_TheLoai]
ADD CONSTRAINT [FK_BoPhim_TheLoai_TheLoai]
    FOREIGN KEY ([MaTheLoai])
    REFERENCES [dbo].[TheLoai]
        ([MaTheLoai])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

CREATE INDEX [IX_FK_BoPhim_TheLoai_TheLoai]
ON [dbo].[BoPhim_TheLoai]
    ([MaTheLoai]);
GO


ALTER TABLE [dbo].[TaiKhoan]
ADD CONSTRAINT [FK_NhanVien_TaiKhoan]
    FOREIGN KEY ([MaNhanVien])
    REFERENCES [dbo].[NhanVien]
        ([MaNhanVien])
    ON DELETE SET NULL ON UPDATE NO ACTION;
GO

CREATE INDEX [IX_FK_NhanVien_TaiKhoan]
ON [dbo].[TaiKhoan]
    ([MaNhanVien]);
GO


--- Insert some values

insert into TaiKhoan (TenTaiKhoan, MatKhau, LoaiTaiKhoan) values("admin", 'admin', 1)