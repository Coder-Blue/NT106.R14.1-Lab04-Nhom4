# Review PR #2 - `feat(bai02, bai03): download trang web và web browser cơ bản`

- Repo: `Coder-Blue/NT106.R14.1-Lab04-Nhom4`
- PR: https://github.com/Coder-Blue/NT106.R14.1-Lab04-Nhom4/pull/2
- Commit reviewed: `c48ca82` (`bai02-bai03`)
- Người review: nhóm 4
- Tài liệu đối chiếu: `Lab-4-Working-with-Web-Server-in-C.pdf`

## 1. Tóm tắt

PR thêm 2 form `FormBai02`, `FormBai03` và 2 package (`HtmlAgilityPack`, `Microsoft.Web.WebView2`).
Code build được, phần lớn chức năng của Bài 02/03 có mặt. Tuy nhiên PR **chưa dùng được từ app
chính** và **chưa đúng cấu trúc project mà PDF yêu cầu**, nên chưa thể merge nguyên trạng.

Kết luận: **Request changes** ở thời điểm review. Bản local `review/pr2` đã sửa các lỗi dưới đây.

## 2. Lỗi blocking

### 2.1. Không có form điều hướng, không mở được Bài 02/03

`Program.cs` vẫn chạy `Form1`:

```csharp
Application.Run(new Form1());
```

`Form1` chỉ là form trống, không có button nào. PR thêm `FormBai02`/`FormBai03` nhưng không có
chỗ nào tạo 2 form này. Người dùng mở app chỉ thấy form trắng.

PDF yêu cầu: "Mỗi project đều có form điều hướng để mở các form liên quan."

**Đã sửa:** thêm `FormChinh` (menu 2 bài), đổi `Program.cs` chạy `FormChinh`.

### 2.2. Sai cấu trúc project so với PDF

PDF yêu cầu: "Mỗi bài tập là 1 project và đặt trong cùng 1 solution."

PR để `Bai02/`, `Bai03/` bên trong project chính; `slnx` vẫn chỉ có 1 project. Như vậy không
tách được bài, không chạy độc lập được từng bài, và không giống cấu trúc Lab 03 của nhóm.

**Đã sửa:** tách thành `Lab04_Bai02`, `Lab04_Bai03` (mỗi project có `Program.cs` riêng), project
chính reference 2 project này; cập nhật `slnx`.

## 3. Lỗi logic / chất lượng

### 3.1. Bài 02 tải trang 2 lần

`DownloadPage` gọi `DownloadFile` rồi `OpenRead` cùng URL:

```csharp
myClient.DownloadFile(url, savePath);
using Stream response = myClient.OpenRead(url);
```

Mỗi lần là một request HTTP. Trang bị tải 2 lần, tốn gấp đôi băng thông; nếu server thay đổi
giữa 2 request thì file đã lưu và nội dung hiển thị có thể khác nhau.

**Đã sửa:** `DownloadFile` một lần rồi đọc lại file local để hiển thị.

### 3.2. Bài 02 hard-code UTF-8

`new StreamReader(response, Encoding.UTF8)` không đọc charset trong `Content-Type`/`meta`.
Trang dùng encoding khác (windows-1258, iso-8859-1...) sẽ bị lỗi font.

**Ghi nhận:** bản sửa vẫn dùng UTF-8 + BOM detection cho đơn giản; nếu cần hỗ trợ đa encoding
thì đọc `ResponseHeaders["Content-Type"]` và `Encoding.GetEncoding(...)`.

### 3.3. Bài 03 lấy HTML bằng `HttpClient`, không phải trang đang xem

`btnDownloadHtml_Click` và `btnViewSource_Click` gọi `Http.GetStringAsync(pageUri)`. Với trang
SPA (React/Next.js), trang sau khi render bằng JavaScript khác hẳn HTML gốc. Với trang cần
cookie/login, `HttpClient` cũng không có session của WebView2.

**Đã sửa:** ưu tiên `CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML")`
(giữ DOM đã render), fallback `HttpClient` nếu WebView2 chưa sẵn sàng. Có thêm `<!DOCTYPE html>`
vì `outerHTML` không trả về doctype.

### 3.4. Bài 03 bỏ sót ảnh

`ExtractImageUris` chỉ đọc `data-src` hoặc `src`. Các trường hợp bị bỏ:
- `data-original`, `data-lazy-src` (lazy-load)
- `srcset` của `<img>` và `<source>`
- `<base href>` (đường dẫn tương đối tính sai)
- ảnh trùng URL (dùng `List.Contains`, chậm và vẫn có thể trùng nếu khác fragment)

**Đã sửa:** tách `HtmlHelper.LayDanhSachAnh`, xử lý các trường hợp trên, dedupe bằng
`HashSet<string>`.

### 3.5. WebView2 lỗi khởi tạo nhưng nút vẫn gọi được

Nếu `EnsureCoreWebView2Async` throw, `CoreWebView2` là `null`. Các nút Reload/Back/Forward vẫn
gọi `webView.Reload()`, `CanGoBack`... có thể ném `NullReferenceException`/`InvalidOperationException`.

**Đã sửa:** kiểm tra `CoreWebView2 != null` trước khi gọi; disable các nút điều hướng khi
khởi tạo lỗi; các nút tải vẫn dùng `HttpClient` fallback.

### 3.6. `async void` + đóng form giữa lúc tải

Các handler `btnDownload_Click`, `btnDownloadResource_Click`, `FormBai03_Load` là `async void`.
Nếu người dùng đóng form khi đang await, code tiếp tục chạy và truy cập control đã dispose
(`lblStatus`, `progressBar`, `webView`...).

**Đã sửa:** thêm `if (IsDisposed) return;` sau các `await` và trong `finally`.

### 3.7. Link `target="_blank"` không mở được

WebView2 mặc định bắn `NewWindowRequested`; PR không đăng ký event này nên link mở tab mới
không có phản ứng.

**Đã sửa:** đăng ký `NewWindowRequested`, điều hướng luôn trong webView hiện tại.

### 3.8. Progress bar không được reset

`progressBar.Maximum`/`Value` chỉ set khi có ảnh; nếu lần trước tải 20 ảnh, lần sau trang
không có ảnh thì progress bar vẫn ở trạng thái cũ.

**Đã sửa:** ẩn progress bar mặc định, chỉ hiện khi bắt đầu tải ảnh và reset `Value = 0`.

## 4. UI / coding style

- UI PR dùng màu xanh `(0, 84, 166)`, font 16F, anchor tự do; không giống theme Lab 03 của nhóm
  (title 18F màu `(35, 78, 120)`, nền trắng, button xanh `(51, 122, 183)`, form fixed).
- Code PR có nhiều XML doc comment, tên tiếng Anh (`DownloadPage`, `ExtractImageUris`,
  `GetUniqueFileName`), trông quá "AI" so với code Lab 03 (tên tiếng Việt, ít comment, helper
  đơn giản).
- Thiếu `FormBai02.resx`, `FormBai03.resx`, `FormViewSource.resx` (không bắt buộc để build,
  nhưng Visual Studio designer sẽ tạo lại).
- `.csproj` thiếu newline cuối file; `.csproj.user` vẫn trỏ `Form1.cs`.

**Đã sửa:** thiết kế lại 2 form theo theme Lab 03, đổi tên control/hàm sang tiếng Việt, giảm
comment, thêm resx, sửa `.csproj.user`, cập nhật README.

## 5. Đối chiếu yêu cầu PDF

### Bài 02

| Yêu cầu | Trạng thái |
|---|---|
| Nhập URL bất kỳ | Có |
| Dùng `WebClient` tải file HTML | Có (`DownloadFile`) |
| Lưu file theo đường dẫn người dùng chọn | Có (`SaveFileDialog`) |
| Hiển thị nội dung trang lên form | Có (`RichTextBox`) |
| Báo lỗi URL/file/mạng | Có |

### Bài 03

| Yêu cầu | Trạng thái |
|---|---|
| Xem nội dung website | Có (`WebView2`) |
| Download file HTML | Có |
| Download resource (hình ảnh) bằng HtmlAgilityPack | Có |
| View Source bằng form mới | Có (`FormViewSource`) |
| ProgressBar khi tải resource | Có |
| Điều hướng Back/Forward/Reload | Có |

### Yêu cầu chung

| Yêu cầu | Trạng thái |
|---|---|
| Mỗi bài 1 project trong cùng solution | Đã sửa |
| Mỗi project có form điều hướng | Đã sửa (`FormChinh`) |
| Giao diện dễ nhìn, đẹp | Đã sửa theo Lab 03 |
| Code sạch, tên rõ ràng | Đã cải thiện |

## 6. Kiểm thử đã chạy

```text
dotnet build --no-incremental
Build succeeded.
    0 Warning(s)
    0 Error(s)
```

- Menu chính: bấm "Bài 02" mở `Bài 02 - Download trang web`; bấm "Bài 03" mở
  `Bài 03 - Web Browser` (đã kiểm tra bằng UI Automation).
- Bài 02: bấm "Tải về" với `https://uit.edu.vn`, file `uit.html` được tạo **688.614 byte**,
  status hiện "Đã lưu 688,614 byte...".
- Bài 03: WebView2 mở `https://uit.edu.vn`, title cập nhật theo trang, status "Đã tải xong.";
  mở từ menu chính vẫn tải được trang.
- Bài 03 - View Source: mở form mới, lấy được hơn **715.000 ký tự** từ DOM.
- Bài 03 - Tải HTML: lưu file **728.206 byte**, bắt đầu bằng `<!DOCTYPE html>`.
- `HtmlHelper.LayDanhSachAnh` với HTML mẫu: lấy đúng 6 ảnh (src, data-src, data-original,
  srcset, source, base href; bỏ data URI; dedupe).
- `HtmlHelper.LayTenFile`: `hinh.png`, `hinh_1.png`, `hinh.jpg` cho URL không có tên.
- Tải thử 5 ảnh đầu của `https://uit.edu.vn`: **5/5 thành công**, tên file không trùng
  (`image.jpg`, `image_1.jpg`, `image_e897f2fe48.png`...).

## 7. Ngoài phạm vi PR

PR chỉ làm Bài 02 và Bài 03; PDF còn Bài 01, Bài 04, Bài 05, Bài 06, Bài 07. Các bài này
không nằm trong PR này, cần PR/bổ sung riêng trước khi nộp Lab đầy đủ.
