# Đồ án Quản lý Nhà trọ (WinForms)

Đây là mã nguồn nền tảng cho ứng dụng Quản lý Nhà trọ, được xây dựng bằng C# WinForms và mô hình MVP.

## Hướng dẫn Cài đặt và Chạy dự án

Trước khi mở và chạy dự án trong Visual Studio 2022, bạn cần hoàn thành các bước thiết lập quan trọng sau:

### 1. Cấu hình Chuỗi kết nối Cơ sở dữ liệu

Tệp `database_schema.sql` chứa toàn bộ script để tạo cơ sở dữ liệu. Sau khi bạn đã chạy script này trên SQL Server của mình, bạn cần phải cập nhật chuỗi kết nối.

- **Mở tệp**: `QuanLyNhaTro/QuanLyNhaTro.Views/App.config`
- **Tìm đến dòng**: `<add name="DefaultConnection" connectionString="..." />`
- **Thay thế các giá trị `YOUR_SERVER_NAME`, `YOUR_USERNAME`, `YOUR_PASSWORD`** bằng thông tin đăng nhập SQL Server thực tế của bạn.

### 2. Thêm Tham chiếu Assembly `System.Configuration`

Dự án cần tham chiếu đến `System.Configuration.dll` để đọc chuỗi kết nối từ tệp `App.config`.

- Trong Visual Studio, chuột phải vào project `QuanLyNhaTro.Data` trong Solution Explorer.
- Chọn `Add` > `Reference...`.
- Trong tab `Assemblies`, tìm và tích chọn vào `System.Configuration`.
- Nhấn OK.

### 3. Cài đặt Gói NuGet `BCrypt.Net-Next`

Dự án sử dụng thư viện BCrypt.Net-Next để băm và xác minh mật khẩu một cách an toàn.

- Trong Visual Studio, mở `Tools` > `NuGet Package Manager` > `Package Manager Console`.
- Chạy lần lượt các lệnh sau để cài đặt gói vào các project cần thiết:
  ```powershell
  Install-Package BCrypt.Net-Next -ProjectName QuanLyNhaTro.Data
  Install-Package BCrypt.Net-Next -ProjectName QuanLyNhaTro.Presenters
  ```

Sau khi hoàn thành các bước trên, bạn có thể build và phát triển tiếp các tính năng của dự án.
