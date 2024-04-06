USE [master]
GO
CREATE DATABASE QuanLyThuVien;

go

USE QuanLyThuVien;

go

CREATE TABLE QuanTriVien(
	MaUS char(5) NOT NULL primary key,
	TenUS nvarchar(50)NOT NULL,
	MatKhau varchar(50)NOT NULL,
	Email nvarchar(50)NOT NULL,
	SDT int NOT NULL
)

go

CREATE TABLE TheThanhVien(
	MaTV varchar(5) NOT NULL primary key,
	TenTV nvarchar(50) NOT NULL,
	DiaChi nvarchar(200) NOT NULL,
	Email nvarchar(50) NULL,
	GioiTinh bit NOT NULL,
	SDT int NOT NULL
)

go

CREATE TABLE LoaiSach(
	Maloai varchar(5) NOT NULL primary key,
	TenLoai nvarchar(50) NOT NULL
)

go

CREATE TABLE TacGia(
	MaTG varchar(10) NOT NULL primary key,
	TenTG nvarchar(250) NOT NULL
	
)

go


CREATE TABLE Sach(
	MaSach varchar(20) NOT NULL primary key,
	TenSach nvarchar(50) NOT NULL,
	MaLoai varchar(5) NOT NULL,
	MaTG varchar(10) NOT NULL,
	NhaXB nvarchar(50) NOT NULL,
	SoLuong int NOT NULL,
	FOREIGN KEY (MaLoai) REFERENCES LoaiSach (MaLoai),
	FOREIGN KEY (MaTG) REFERENCES TacGia (MaTG),
)

go

CREATE TABLE PhieuMuon(
	MaPM varchar(5) NOT NULL primary key,
	MaTV varchar(5) NOT NULL,
	NgayMuon date NOT NULL,
	NgayTra date NOT NULL,
	FOREIGN KEY (MaTV) REFERENCES thethanhvien (maTV),
	check (ngaytra >= ngaymuon)
)

go


CREATE TABLE ChiTietPM(
	MAPM VARCHAR(5) NOT NULL,
	MASACH VARCHAR(20)NOT NULL,
	TRANGTHAI BIT DEFAULT 0,
	QUAHAN BIT DEFAULT 0,
	FOREIGN KEY (MAPM) REFERENCES PHIEUMUON(MAPM),
	FOREIGN KEY (MASACH) REFERENCES SACH(MASACH)
)
go


INSERT INTO  [dbo].[QuanTriVien] ([MaUS],[TenUS],[MatKhau],[Email],[SDT]) VALUES('US001','kiet','123','kiet123@gmail.com',0907865399)
INSERT INTO  [dbo].[QuanTriVien] ([MaUS],[TenUS],[MatKhau],[Email],[SDT]) VALUES('US002','phong','123','phong123@gmail.com',0979687453)

go

INSERT INTO  [dbo].[TheThanhVien] ([MaTV],[TenTV],[DiaChi],[Email],[GioiTinh],[SDT]) VALUES('TV001',N'Nguyễn Văn Nam',N'Linh Tây, Thủ Đức, TP.HCM','nguyenvannam@gmail.com','1',0128493736)
INSERT INTO  [dbo].[TheThanhVien] ([MaTV],[TenTV],[DiaChi],[Email],[GioiTinh],[SDT]) VALUES('TV002',N'Trần Thị Mơ',N'Đông Thạnh, Hốc Môn, TP.HCM','tranthimo@gmail.com','0',0958376353)
INSERT INTO  [dbo].[TheThanhVien] ([MaTV],[TenTV],[DiaChi],[Email],[GioiTinh],[SDT]) VALUES('TV003',N'Trần Văn Ngọc',N'Đa Kao, Quận 1, TP.HCM','tranvanngoc@gmail.com','1',0969244797)
INSERT INTO  [dbo].[TheThanhVien] ([MaTV],[TenTV],[DiaChi],[Email],[GioiTinh],[SDT]) VALUES('TV004',N'Nguyễn Thị Vấn',N'Linh Đông, Thủ Đức, TP.HCM','nguyenthivan@gmail.com','0',0968367826)
INSERT INTO  [dbo].[TheThanhVien] ([MaTV],[TenTV],[DiaChi],[Email],[GioiTinh],[SDT]) VALUES('TV005',N'Nguyễn Đăng Nhân',N'An Phú, Quận 2, TP.HCM','nguyendangnhan@gmail.com','1',0967867588)
INSERT INTO  [dbo].[TheThanhVien] ([MaTV],[TenTV],[DiaChi],[Email],[GioiTinh],[SDT]) VALUES('TV006',N'Lê thị Mỹ Dung',N'Lái Thêu, Thuận An, Bình Dương','lethimyxuyen@gmail.com','0',0328794367)
INSERT INTO  [dbo].[TheThanhVien] ([MaTV],[TenTV],[DiaChi],[Email],[GioiTinh],[SDT]) VALUES('TV007',N'Phan Văn Đức',N'Phú Thạnh, Tân Phú, TP.HCM','phanvanduc@gmail.com','1',0336847263)
INSERT INTO  [dbo].[TheThanhVien] ([MaTV],[TenTV],[DiaChi],[Email],[GioiTinh],[SDT]) VALUES('TV008',N'Hoàng Xuân Tuân',N'Cát Lái, Quận 2, TP.HCM','hoanxuantuan@gmail.com','1',0966847867)
INSERT INTO  [dbo].[TheThanhVien] ([MaTV],[TenTV],[DiaChi],[Email],[GioiTinh],[SDT]) VALUES('TV009',N'Trần Thị Hiệp',N'Linh Trung, Thủ Đức, TP.HCM','tranthihiep@gmail.com','0',0577839736)
INSERT INTO  [dbo].[TheThanhVien] ([MaTV],[TenTV],[DiaChi],[Email],[GioiTinh],[SDT]) VALUES('TV010',N'Nguyễn Văn Tài',N'BÌnh Hưng, Bình Chánh, TP.HCM','nguyenvantai@gmail.com','1',0577839736)


go


INSERT INTO [dbo].[LoaiSach] ([Maloai],[TenLoai]) VALUES('LS001',N'Chính trị – Pháp luật')
INSERT INTO [dbo].[LoaiSach] ([Maloai],[TenLoai]) VALUES('LS002',N'Khoa học công nghệ - Kinh tế')
INSERT INTO [dbo].[LoaiSach] ([Maloai],[TenLoai]) VALUES('LS003',N'Lập trình')
INSERT INTO [dbo].[LoaiSach] ([Maloai],[TenLoai]) VALUES('LS004',N'Giáo trình')
INSERT INTO [dbo].[LoaiSach] ([Maloai],[TenLoai]) VALUES('LS005',N'Tiểu thuyết')
INSERT INTO [dbo].[LoaiSach] ([Maloai],[TenLoai]) VALUES('LS006',N'Văn học')
INSERT INTO [dbo].[LoaiSach] ([Maloai],[TenLoai]) VALUES('LS007',N'Lịch Sử')
INSERT INTO [dbo].[LoaiSach] ([Maloai],[TenLoai]) VALUES('LS008',N'Sách thiếu nhi')
INSERT INTO [dbo].[LoaiSach] ([Maloai],[TenLoai]) VALUES('LS009',N'Truyện tranh')
INSERT INTO [dbo].[LoaiSach] ([Maloai],[TenLoai]) VALUES('LS010',N'Ngôn Tình')

go

INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG001',N'Phạm Đoan Trang')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG002',N'Phạm Huy Hoàng')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG003',N'Leong Sheng Ying')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG004',N'Nguyễn Văn Hùng')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG005',N'Nhiêu Tuyết Mạn')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG006',N'Trần Đình Sử')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG007',N'Khuyết Danh')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG008',N'Hải Minh')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG009',N'Minh Long')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG010',N'Phỉ Ngã Tư Đồn')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG011',N'Aristotle')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG012',N'Nguyễn Hữu Hưng')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG013',N'Khánh Hòa')

go

INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS001',N'Chính Trị Bình Dân','LS001','TG001',N'Nhà xuất bản Luật Khoa Tập Chí',50)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS002',N'Học Chính Sách Công Qua Chuyện Đặc Khu','LS001','TG001',N'nhà xuất bản Luật Khoa Tập Chí',50)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS003',N'Chính Trị Luật','LS001','TG011',N'nhà xuất bản thế giới',50)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS004',N'The Nicomachean Ethics','LS001','TG011',N'nhà xuất bản thế giới',50)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS005',N'Lập Trình Đâu Phải Chỉ Biết Code','LS003','TG002',N'Nhà Xuất Bản Dân Chí',100)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS006',N'Cuộc Sống Code và Lập Trình','LS003','TG002',N'Nhà xuất bản dân chí',100)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS007',N'Sách Lập Trình Với Scratch 3.0','LS003','TG012',N'Nhà Xuất Bản đại học quốc gia hà nội',100)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS008',N'Lập Trình Với C#','LS003','TG012',N'Nhà Xuất Bản đại học quốc gia hà nội',100)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS009',N'Nhà Khoa Học Trẻ - Cấp Độ 2','LS002','TG003',N'Nhà xuất bản giáo dục Việt Nam',300)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS010',N'Nhà Khoa Học Trẻ - Cấp Độ 3','LS002','TG003',N'Nhà xuất bản giáo dục Việt Nam',300)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS011',N'Giáo Trình Marketing Căn Bản','LS004','TG004',N'Nhà xuất bản Kinh Tế TPHCM',50)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS012',N'Thương Mại Điện Tử','LS004','TG004',N'Nhà xuất bản Kinh Tế TPHCM',50)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS013',N'Bí Mật Thanh Xuân','LS005','TG005',N'Nhà xuất bản thanh niên',150)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS014',N'Tay Trái','LS005','TG005',N'Nhà xuất bản thanh niên',150)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS015',N'Đọc Văn Học Hay','LS006','TG006',N'Nhà xuất bản tri thức',5)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS016',N'Trên Đường Biên Của Lý Luận Văn','LS006','TG006',N'Nhà xuất bản phụ nữ',50)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS017',N'Sơn Kinh Hải','LS007','TG007',N'Nhà xuất bản văn học',150)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS018',N'Sơn Kinh Hải Đồ','LS007','TG007',N'Nhà xuất bản văn học',150)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS019',N'Đồng Dao Thơ','LS008','TG008',N'Nhà xuất bản phụ nữ',100)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS020',N'Thơ Cho Bé Tập Nói','LS008','TG008',N'Nhà xuất bản phụ nữ',100)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS021',N'Truyện Tranh Tuổi Thần Tiên - Món Quà Của Cô Giáo','LS009','TG009',N'Nhà xuất bản văn học',50)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS022',N'Truyện Tranh Tuổi Thần Tiên - Cây Táo Thần','LS009','TG009',N'Nhà xuất bản văn học',50)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS023',N'Thất Tịch Không Mưa','LS010','TG010',N'Nhà xuất bản văn học',50)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS024',N'Đông Cung','LS010','TG010',N'Nhà xuất bản văn học',50)


go

INSERT INTO [dbo].[PhieuMuon] ([MaPM],[MaTV],[NgayMuon],[NgayTra]) VALUES('PM001','TV001','2019-2-3','2019-3-2')
INSERT INTO [dbo].[PhieuMuon] ([MaPM],[MaTV],[NgayMuon],[NgayTra]) VALUES('PM002','TV002','2019-2-23','2019-2-26')
INSERT INTO [dbo].[PhieuMuon] ([MaPM],[MaTV],[NgayMuon],[NgayTra]) VALUES('PM003','TV003','2019-3-1','2019-3-15')
INSERT INTO [dbo].[PhieuMuon] ([MaPM],[MaTV],[NgayMuon],[NgayTra]) VALUES('PM004','TV004','2019-3-2','2019-3-20')
INSERT INTO [dbo].[PhieuMuon] ([MaPM],[MaTV],[NgayMuon],[NgayTra]) VALUES('PM005','TV005','2019-4-10','2019-4-20')
INSERT INTO [dbo].[PhieuMuon] ([MaPM],[MaTV],[NgayMuon],[NgayTra]) VALUES('PM006','TV006','2019-6-5','2019-6-29')
INSERT INTO [dbo].[PhieuMuon] ([MaPM],[MaTV],[NgayMuon],[NgayTra]) VALUES('PM007','TV007','2019-2-10','2019-2-20')
INSERT INTO [dbo].[PhieuMuon] ([MaPM],[MaTV],[NgayMuon],[NgayTra]) VALUES('PM008','TV008','2019-2-15','2019-2-25')
INSERT INTO [dbo].[PhieuMuon] ([MaPM],[MaTV],[NgayMuon],[NgayTra]) VALUES('PM009','TV009','2019-6-14','2019-6-22')


go


INSERT INTO [dbo].[ChiTietPM] ([MaPM],[MaSach],[TrangThai],QuaHan) VALUES('PM001','MS001',0,0)
INSERT INTO [dbo].[ChiTietPM] ([MaPM],[MaSach],[TrangThai],QuaHan) VALUES('PM001','MS004',1,1)
INSERT INTO [dbo].[ChiTietPM] ([MaPM],[MaSach],[TrangThai],QuaHan) VALUES('PM001','MS002',0,1)
INSERT INTO [dbo].[ChiTietPM] ([MaPM],[MaSach],[TrangThai],QuaHan) VALUES('PM001','MS003',1,0)

go


-- stored đăng nhập
CREATE PROCEDURE CheckLogin
    @Username NVARCHAR(50),
    @Password NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

   

    -- Kiểm tra xem tài khoản đăng nhập có hợp lệ không
    SELECT * FROM QuanTriVien WHERE MaUS = @Username AND MatKhau = @Password
  
END;

EXEC CheckLogin 'US001', '123';

-- tạo views của Sách
alter VIEW SachList AS
SELECT s.MaSach, s.TenSach, ls.TenLoai, s.NhaXB, s.SoLuong, s.MaTG, s.MaLoai, tg.TenTG
FROM Sach s
INNER JOIN LoaiSach ls ON s.MaLoai = ls.Maloai Left join TacGia tg ON tg.MaTG = s.MaTG
ORDER BY s.MaSach DESC; 
select * from SachList ORDER BY MaSach DESC;

-- viết trigger khi insert kiểm tra lỗi  Mã Sách đã tồn tại và Số Lượng nhỏ hơn 0 của bảng sách
CREATE TRIGGER Check_MaSach_SoLuong
ON Sach
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra MaSach đã tồn tại
    IF EXISTS (SELECT 1 FROM inserted i INNER JOIN Sach b ON i.MaSach = b.MaSach)
    BEGIN
        RAISERROR ('Mã sách đã tồn tại trong bảng.', 16, 1);
		ROLLBACK TRANSACTION;
        RETURN; 
    END

	---- Kiểm tra SoLuong
    else if EXISTS (SELECT 1 FROM inserted WHERE SoLuong <= 0)
    BEGIN
        RAISERROR ('Giá trị của số lượng phải lớn hơn 0.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
	else
	BEGIN
        --thực hiện lệnh INSERT
        INSERT INTO Sach(MaSach, TenSach,MaLoai,MaTG,NhaXB,SoLuong)
        SELECT MaSach, TenSach,MaLoai,MaTG,NhaXB,SoLuong
        FROM INSERTED;
    END
END;



-- viết trigger khi update. Số lượng phải lớn hơn 0 của bảng sách
CREATE TRIGGER Check_SoLuong ON Sach
AFTER UPDATE
AS
BEGIN
    -- Kiểm tra SoLuong
   IF EXISTS (SELECT 1 FROM inserted WHERE SoLuong <= 0 OR ISNUMERIC(SoLuong) = 0)
    BEGIN
        RAISERROR ('Giá trị của số lượng phải lớn hơn 0.', 16, 1);
        ROLLBACK TRANSACTION; 
        RETURN;
    END
END;




CREATE PROCEDURE InsertPhieuMuonCT
    @MaPM varchar(5),
    @MaSach varchar(20),
    @TrangThai bit,
    @QuaHan bit
AS
BEGIN
    BEGIN TRY
        DECLARE @GiamSoLuong bit;

        IF @TrangThai = 0
        BEGIN
            SET @GiamSoLuong = 1;
        END
        ELSE
        BEGIN
            SET @GiamSoLuong = 0;
        END

        BEGIN TRANSACTION; -- Bắt đầu giao dịch

        DECLARE @SoLuongSachTruoc int;
        DECLARE @SoLuongSachSau int;

        -- Lấy số lượng sách trước khi giảm (nếu cần)
        IF @GiamSoLuong = 1
        BEGIN
            SELECT @SoLuongSachTruoc = SoLuong
            FROM Sach
            WHERE MaSach = @MaSach;
        END

        -- Giảm số lượng sách (nếu cần)
        IF @GiamSoLuong = 1
        BEGIN
            UPDATE Sach
            SET SoLuong = SoLuong - 1
            WHERE MaSach = @MaSach;
        END

        -- Lấy số lượng sách sau khi giảm (nếu cần)
        IF @GiamSoLuong = 1
        BEGIN
            SELECT @SoLuongSachSau = SoLuong
            FROM Sach
            WHERE MaSach = @MaSach;
        END

        -- Thêm dữ liệu vào bảng ChiTietPM
        INSERT INTO ChiTietPM (MaPM, MaSach, TrangThai, QuaHan)
        VALUES (@MaPM, @MaSach, @TrangThai, @QuaHan);

        -- Commit giao dịch
        COMMIT TRANSACTION;

        PRINT 'Thêm dữ liệu vào bảng và giảm số lượng sách thành công.';
        IF @GiamSoLuong = 1
        BEGIN
            PRINT 'Số lượng sách trước khi giảm: ' + CAST(@SoLuongSachTruoc AS varchar(10)) + ', Số lượng sách sau khi giảm: ' + CAST(@SoLuongSachSau AS varchar(10));
        END
    END TRY
    BEGIN CATCH
        -- Nếu có lỗi, rollback giao dịch
        ROLLBACK TRANSACTION;
        PRINT 'Lỗi khi thực hiện giao dịch: ' + ERROR_MESSAGE();
    END CATCH;
END;

exec PerformTransaction 'PM001','MS001',0,0



alter PROCEDURE update_CTPM
    @MaPM varchar(5),
    @MaSach varchar(20),
    @TrangThai bit

AS
BEGIN
    BEGIN TRY
        DECLARE @GiamSoLuong bit;
        DECLARE @TangSoLuong bit;

        IF @TrangThai = 0
        BEGIN
            SET @GiamSoLuong = 1;
            SET @TangSoLuong = 0;
        END
        ELSE IF @TrangThai = 1
        BEGIN
            SET @GiamSoLuong = 0;
            SET @TangSoLuong = 1;
        END

        BEGIN TRANSACTION; -- Bắt đầu giao dịch

        DECLARE @SoLuongSachTruoc int;
        DECLARE @SoLuongSachSau int;

        -- Lấy số lượng sách trước khi giảm (nếu cần)
        IF @GiamSoLuong = 1
        BEGIN
            SELECT @SoLuongSachTruoc = SoLuong
            FROM Sach
            WHERE MaSach = @MaSach;
        END

        -- Giảm số lượng sách (nếu cần)
        IF @GiamSoLuong = 1
        BEGIN
            UPDATE Sach
            SET SoLuong = SoLuong - 1
            WHERE MaSach = @MaSach;
        END

        -- Tăng số lượng sách (nếu cần)
        IF @TangSoLuong = 1
        BEGIN
            UPDATE Sach
            SET SoLuong = SoLuong + 1
            WHERE MaSach = @MaSach;
        END

        -- Lấy số lượng sách sau khi giảm (nếu cần)
        IF @GiamSoLuong = 1
        BEGIN
            SELECT @SoLuongSachSau = SoLuong
            FROM Sach
            WHERE MaSach = @MaSach;
        END

        -- Kiểm tra trạng thái trước và sau khi cập nhật
        IF EXISTS (
            SELECT 1
            FROM inserted i
            JOIN deleted d ON i.MaSach = d.MaSach
            WHERE i.TrangThai = d.TrangThai
                AND i.TrangThai = @TrangThai
        )
        BEGIN
            -- Nếu trạng thái không thay đổi, rollback giao dịch
            ROLLBACK TRANSACTION;
            PRINT 'Trạng thái không thay đổi, không có thay đổi về số lượng sách.';
        END
        ELSE
        BEGIN
            -- Nếu trạng thái đã thay đổi, thực hiện các thao tác và commit giao dịch
            -- Thêm dữ liệu vào bảng ChiTietPM
           update ChiTietPM set TrangThai = @TrangThai
           where MaPM = @MaPM and MaSach = @MaSach

            -- Commit giao dịch
            COMMIT TRANSACTION;

            PRINT 'Thêm dữ liệu vào bảng ChiTietPM và ' + 
                  CASE WHEN @GiamSoLuong = 1 THEN 'giảm' ELSE 'tăng' END +
                  ' số lượng sách thành công.';
            IF @GiamSoLuong = 1
            BEGIN
                PRINT 'Số lượng sách trước khi giảm: ' + CAST(@SoLuongSachTruoc AS varchar(10)) + ', Số lượng sách sau khi giảm: ' + CAST(@SoLuongSachSau AS varchar(10));
            END
        END
    END TRY
    BEGIN CATCH
        -- Nếu có lỗi, rollback giao dịch
        ROLLBACK TRANSACTION;
        PRINT 'Lỗi khi thực hiện giao dịch: ' + ERROR_MESSAGE();
    END CATCH;
END;


exec update_CTPM 'PM001','MS001',1


