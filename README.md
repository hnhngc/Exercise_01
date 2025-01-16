## Bài Tập: Kết Nối SOAP Web Service Với Cơ Sở Dữ Liệu

### Mục Tiêu
Bài tập bổ sung này yêu cầu bạn tạo một **SOAP Web Service** để truy vấn cơ sở dữ liệu và cung cấp các dịch vụ sau:
- Lấy danh sách tất cả các quốc gia.
- Lấy thông tin quốc gia theo mã quốc gia.
- Lấy thông tin thành phố theo tên.
- Lấy tất cả thành phố của một quốc gia cụ thể.
- Các dịch vụ khác mà bạn có thể nghĩ đến (ví dụ: tìm kiếm thành phố theo mã, hoặc thông tin về các thành phố trong một khu vực cụ thể).

Xây dựng dịch vụ này và kết nối với cơ sở dữ liệu **World Database** để trả về dữ liệu qua SOAP Web Service.

### Các Bước Thực Hiện

#### Bước 1: Chuẩn Bị Cơ Sở Dữ Liệu
1. **Tạo Cơ Sở Dữ Liệu (World Database)**:
    - Sử dụng một cơ sở dữ liệu mẫu như **World Database** (tải về từ các nguồn trực tuyến nếu cần).
    - Cơ sở dữ liệu này bao gồm các bảng như **Countries** và **Cities**, chứa thông tin về các quốc gia và thành phố.

    Ví dụ cấu trúc bảng:
    - **Countries**: chứa các thông tin về quốc gia (id, name, code, continent, population).
    - **Cities**: chứa thông tin về thành phố (id, name, country_id, population).

    Bạn có thể tạo cơ sở dữ liệu và các bảng này trong **SQL Server Management Studio (SSMS)** hoặc **SQL Server Express**.

#### Bước 2: Cấu Hình Kết Nối Cơ Sở Dữ Liệu
1. **Thêm Connection String**:
    - Trong **Web.config** của dự án Web Service, thêm **connection string** để kết nối với cơ sở dữ liệu:
2. **Cài Đặt SQL Server**:
    - Đảm bảo rằng SQL Server đang chạy và có thể truy cập được từ dự án.
    - Kiểm tra lại kết nối để đảm bảo rằng các truy vấn có thể chạy đúng.

#### Bước 3: Tạo Các Phương Thức SOAP
Tạo các phương thức SOAP trong Web Service để truy vấn cơ sở dữ liệu.
1. **GetAllCountries**: Lấy danh sách tất cả các quốc gia.
2. **GetCountryByCode**: Lấy thông tin quốc gia theo mã quốc gia.
3. **GetCityByName**: Lấy thông tin thành phố theo tên.
4. **GetAllCitiesByCountry**: Lấy tất cả thành phố của một quốc gia.

#### Bước 4: Xây Dựng Client-Side để Kết Nối Web Service
1. Tạo một **Windows Forms Application** mới.
2. Thêm **Service Reference** vào ứng dụng client, trỏ đến Web Service đã tạo.
3. Thiết kế giao diện người dùng để hiển thị kết quả khi người dùng nhập thông tin quốc gia hoặc thành phố.
4. Sử dụng mã để gọi các phương thức Web Service từ ứng dụng client

### Kết Quả Đạt Được

Sau khi hoàn thành các bước trên, ta sẽ có một **SOAP Web Service** có khả năng thực hiện các truy vấn cơ sở dữ liệu để lấy thông tin quốc gia và thành phố. Client application sẽ gọi các dịch vụ này để hiển thị thông tin cho người dùng.

Các kết quả đạt được:
- **Web Service** trả về danh sách các quốc gia, thành phố và các thông tin khác từ cơ sở dữ liệu.
- **Client Application** sẽ hiển thị thông tin được lấy từ Web Service dưới dạng dễ hiểu và trực quan.
