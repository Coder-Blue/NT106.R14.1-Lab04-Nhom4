# NT106.R14.1 - Lab 04 - Nhóm 4

Bài tập thực hành Lab 04 môn NT106.R14.1: truyền thông với Web Server trong C#.
PR này hoàn thiện **Bài 02** và **Bài 03**; các bài còn lại của Lab 04 sẽ được bổ sung ở PR sau.

## Các bài

- **Bài 02 - Download trang web**: nhập URL, dùng `WebClient.DownloadFile` để lưu trang
  thành file `.html`, sau đó đọc lại file và hiển thị nội dung trong `RichTextBox`.
- **Bài 03 - Web Browser**: dùng `WebView2` để xem website, có nút Back/Forward/Reload/Home,
  tải file HTML, tải toàn bộ hình ảnh của trang (HtmlAgilityPack) và mở form View Source.

## Cài đặt và chạy

1. Cài .NET 10 SDK và Visual Studio 2022/2026 (workload .NET Desktop).
2. Mở `NT106.R14.1-Lab04-Nhom4.slnx`, chọn project `NT106.R14.1-Lab04-Nhom4` làm
   startup rồi bấm F5. Hoặc chạy:

   ```powershell
   dotnet run --project .\NT106.R14.1-Lab04-Nhom4.csproj
   ```

3. Chọn bài ở menu chính. Bài 03 cần Microsoft Edge WebView2 Runtime (Windows 10/11
   thường có sẵn).

## Cấu trúc mã nguồn

| Tệp / thư mục | Vai trò |
|---|---|
| `NT106.R14.1-Lab04-Nhom4.slnx` | Solution gồm 3 project |
| Thư mục gốc | App chính, form menu |
| `Lab04_Bai02/` | Bài 02 - Download trang web |
| `Lab04_Bai03/` | Bài 03 - Web Browser |

## Ghi chú

- Mỗi bài là một project trong cùng solution, có form riêng và có thể chạy độc lập.
- `WebClient` đã bị đánh dấu obsolete từ .NET 6 nhưng đề bài yêu cầu dùng nên vẫn giữ.
- Bài 03 ưu tiên lấy HTML từ DOM của WebView2 để giữ nội dung do JavaScript tạo ra;
  nếu WebView2 chưa sẵn sàng thì fallback sang `HttpClient`.
