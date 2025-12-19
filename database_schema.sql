
-- =================================================================
-- Script to create the database schema for QuanLyNhaTro project
-- =================================================================

-- Drop existing tables in reverse order of dependency to avoid foreign key constraints issues
IF OBJECT_ID('dbo.ChiTietHoaDon', 'U') IS NOT NULL DROP TABLE dbo.ChiTietHoaDon;
IF OBJECT_ID('dbo.HoaDon', 'U') IS NOT NULL DROP TABLE dbo.HoaDon;
IF OBJECT_ID('dbo.ChiSoDienNuoc', 'U') IS NOT NULL DROP TABLE dbo.ChiSoDienNuoc;
IF OBJECT_ID('dbo.PhuongTien', 'U') IS NOT NULL DROP TABLE dbo.PhuongTien;
IF OBJECT_ID('dbo.ViTriGiuXe', 'U') IS NOT NULL DROP TABLE dbo.ViTriGiuXe;
IF OBJECT_ID('dbo.LoaiXe', 'U') IS NOT NULL DROP TABLE dbo.LoaiXe;
IF OBJECT_ID('dbo.HopDong', 'U') IS NOT NULL DROP TABLE dbo.HopDong;
IF OBJECT_ID('dbo.KhachThue', 'U') IS NOT NULL DROP TABLE dbo.KhachThue;
IF OBJECT_ID('dbo.Phong', 'U') IS NOT NULL DROP TABLE dbo.Phong;
IF OBJECT_ID('dbo.LoaiPhong', 'U') IS NOT NULL DROP TABLE dbo.LoaiPhong;
IF OBJECT_ID('dbo.KhuNha', 'U') IS NOT NULL DROP TABLE dbo.KhuNha;
IF OBJECT_ID('dbo.DichVu', 'U') IS NOT NULL DROP TABLE dbo.DichVu;
IF OBJECT_ID('dbo.NguoiDung', 'U') IS NOT NULL DROP TABLE dbo.NguoiDung;

-- =================================================================
-- Table Creation
-- =================================================================

-- 1. NguoiDung (Users)
CREATE TABLE NguoiDung (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TenDangNhap NVARCHAR(50) NOT NULL UNIQUE,
    MatKhau NVARCHAR(255) NOT NULL, -- Hashed password
    HoTen NVARCHAR(100) NOT NULL,
    Quyen NVARCHAR(50) NOT NULL, -- e.g., 'Admin', 'QuanLy'
    TrangThai BIT NOT NULL DEFAULT 1 -- 1: Active, 0: Inactive
);

-- 2. KhuNha (Building Areas)
CREATE TABLE KhuNha (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TenKhuNha NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(255)
);

-- 3. LoaiPhong (Room Types)
CREATE TABLE LoaiPhong (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TenLoaiPhong NVARCHAR(100) NOT NULL
);

-- 4. Phong (Rooms)
CREATE TABLE Phong (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TenPhong NVARCHAR(100) NOT NULL,
    IDKhuNha INT NOT NULL,
    IDLoaiPhong INT NOT NULL,
    DienTich FLOAT NOT NULL,
    GiaThue DECIMAL(18, 2) NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL, -- e.g., 'Trống', 'Đang thuê', 'Bảo trì'
    MoTa NVARCHAR(MAX),
    FOREIGN KEY (IDKhuNha) REFERENCES KhuNha(ID),
    FOREIGN KEY (IDLoaiPhong) REFERENCES LoaiPhong(ID)
);

-- 5. KhachThue (Tenants)
CREATE TABLE KhachThue (
    ID INT PRIMARY KEY IDENTITY(1,1),
    HoTen NVARCHAR(100) NOT NULL,
    CMND_CCCD NVARCHAR(20) NOT NULL UNIQUE,
    SoDienThoai NVARCHAR(15),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    QueQuan NVARCHAR(255),
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Đang thuê' -- e.g., 'Đang thuê', 'Đã trả phòng'
);

-- 6. HopDong (Contracts)
CREATE TABLE HopDong (
    ID INT PRIMARY KEY IDENTITY(1,1),
    MaHopDong AS ('HD' + RIGHT('00000' + CAST(ID AS VARCHAR(5)), 5)) PERSISTED,
    IDPhong INT NOT NULL,
    IDKhachThue INT NOT NULL,
    GiaThue DECIMAL(18, 2) NOT NULL,
    TienCoc DECIMAL(18, 2) NOT NULL,
    NgayBatDau DATE NOT NULL,
    NgayKetThuc DATE NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL, -- e.g., 'Hiệu lực', 'Sắp hết hạn', 'Đã thanh lý'
    FOREIGN KEY (IDPhong) REFERENCES Phong(ID),
    FOREIGN KEY (IDKhachThue) REFERENCES KhachThue(ID)
);

-- 7. DichVu (Services)
CREATE TABLE DichVu (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TenDichVu NVARCHAR(100) NOT NULL,
    DonGia DECIMAL(18, 2) NOT NULL,
    DonViTinh NVARCHAR(50) NOT NULL, -- e.g., 'kWh', 'm3', 'Tháng', 'Người'
    LoaiTinhPhi NVARCHAR(50) NOT NULL, -- e.g., 'Theo chỉ số', 'Theo phòng', 'Theo người'
    TrangThai BIT NOT NULL DEFAULT 1 -- 1: Active, 0: Inactive
);

-- 8. ChiSoDienNuoc (Utility Readings)
CREATE TABLE ChiSoDienNuoc (
    ID INT PRIMARY KEY IDENTITY(1,1),
    IDPhong INT NOT NULL,
    ThangGhi INT NOT NULL,
    NamGhi INT NOT NULL,
    ChiSoDienCu INT NOT NULL,
    ChiSoDienMoi INT NOT NULL,
    ChiSoNuocCu INT NOT NULL,
    ChiSoNuocMoi INT NOT NULL,
    FOREIGN KEY (IDPhong) REFERENCES Phong(ID),
    UNIQUE (IDPhong, ThangGhi, NamGhi)
);

-- 9. HoaDon (Invoices)
CREATE TABLE HoaDon (
    ID INT PRIMARY KEY IDENTITY(1,1),
    MaHoaDon AS ('INV' + RIGHT('00000' + CAST(ID AS VARCHAR(5)), 5)) PERSISTED,
    IDHopDong INT NOT NULL,
    NgayLap DATE NOT NULL,
    HanThanhToan DATE NOT NULL,
    TongTien DECIMAL(18, 2) NOT NULL,
    DaThanhToan DECIMAL(18, 2) DEFAULT 0,
    ConNo AS (TongTien - DaThanhToan),
    TrangThai NVARCHAR(50) NOT NULL, -- e.g., 'Chưa thanh toán', 'Đã thanh toán', 'Quá hạn'
    GhiChu NVARCHAR(MAX),
    FOREIGN KEY (IDHopDong) REFERENCES HopDong(ID)
);

-- 10. ChiTietHoaDon (Invoice Details)
CREATE TABLE ChiTietHoaDon (
    ID INT PRIMARY KEY IDENTITY(1,1),
    IDHoaDon INT NOT NULL,
    IDDichVu INT NOT NULL,
    SoLuong INT,
    DonGia DECIMAL(18, 2) NOT NULL,
    ThanhTien AS (SoLuong * DonGia),
    FOREIGN KEY (IDHoaDon) REFERENCES HoaDon(ID),
    FOREIGN KEY (IDDichVu) REFERENCES DichVu(ID)
);

-- 11. LoaiXe (Vehicle Types)
CREATE TABLE LoaiXe (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TenLoaiXe NVARCHAR(100) NOT NULL, -- e.g., 'Xe máy', 'Ô tô'
    PhiGiuXe DECIMAL(18, 2) NOT NULL
);

-- 12. ViTriGiuXe (Parking Spots)
CREATE TABLE ViTriGiuXe (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TenViTri NVARCHAR(50) NOT NULL UNIQUE, -- e.g., 'A-01', 'B-02'
    KhuVuc NVARCHAR(50),
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Còn trống' -- e.g., 'Còn trống', 'Đang sử dụng'
);

-- 13. PhuongTien (Vehicles)
CREATE TABLE PhuongTien (
    ID INT PRIMARY KEY IDENTITY(1,1),
    BienSo NVARCHAR(50) NOT NULL UNIQUE,
    IDLoaiXe INT NOT NULL,
    IDKhachThue INT NOT NULL,
    IDViTriGiuXe INT,
    HieuXe NVARCHAR(100),
    MauXe NVARCHAR(50),
    NgayGui DATE,
    FOREIGN KEY (IDLoaiXe) REFERENCES LoaiXe(ID),
    FOREIGN KEY (IDKhachThue) REFERENCES KhachThue(ID),
    FOREIGN KEY (IDViTriGiuXe) REFERENCES ViTriGiuXe(ID)
);

-- =================================================================
-- Sample Data Insertion
-- =================================================================
-- Default password is 'admin123'
INSERT INTO NguoiDung (TenDangNhap, MatKhau, HoTen, Quyen) VALUES
('admin', '$2a$10$g.M.e2630e2g61fV5tAU3O1Bd8gU5t2a61fV5tAU3O1Bd8gU5t2aG', N'Admin User', 'Admin');

INSERT INTO KhuNha (TenKhuNha, DiaChi) VALUES
(N'WinHome Quận 1', N'123 Nguyễn Huệ, Quận 1, TPHCM'),
(N'WinHome Bình Thạnh', N'456 Xô Viết Nghệ Tĩnh, Bình Thạnh, TPHCM');

INSERT INTO LoaiPhong (TenLoaiPhong) VALUES
(N'Phòng Standard'), (N'Phòng Deluxe'), (N'Căn hộ mini');

INSERT INTO DichVu (TenDichVu, DonGia, DonViTinh, LoaiTinhPhi) VALUES
(N'Điện sinh hoạt', 3500, 'kWh', N'Theo chỉ số'),
(N'Nước sạch', 15000, 'm3', N'Theo chỉ số'),
(N'Internet', 100000, N'Tháng', N'Theo phòng'),
(N'Phí vệ sinh', 30000, N'Tháng', N'Theo người');

INSERT INTO LoaiXe (TenLoaiXe, PhiGiuXe) VALUES
(N'Xe máy', 100000), (N'Ô tô', 1200000);

PRINT 'Database schema and sample data created successfully.';
