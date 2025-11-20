using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core; // Cần thiết cho WebView2
using System.Net.Http; // Giữ lại cho cấu trúc class

namespace QuanLyQuanNet.GUI.FormNgoai.FormKhach
{
    public partial class XemPhim : Form
    {
        // ✅ SỬA LỖI: Đây là URL trang web, không phải API
        private const string DetailUrlBase = "https://phim.nguonc.com/phim/";

        // HttpClient không cần thiết cho hàm này, nhưng giữ lại nếu có hàm khác sử dụng
        private readonly HttpClient client = new HttpClient();

        public XemPhim(string filmSlug)
        {
            InitializeComponent();

            // ✅ ĐẢM BẢO CHỈ GỌI HÀM TẢI TRANG WEB
            LoadFilmPage(filmSlug);
        }

        /// <summary>
        /// Xây dựng URL trang web hoàn chỉnh và tải nó vào WebView2.
        /// </summary>
        private async void LoadFilmPage(string slug)
        {
            // 1. Xây dựng URL trang web trực tiếp (Ví dụ: https://phim.nguonc.com/phim/hoa-thien-cot)
            string finalUrl = $"{DetailUrlBase}{slug}";

            try
            {
                // 2. CHỜ COREWEBVIEW2 SẴN SÀNG
                await webViewPhim.EnsureCoreWebView2Async();

                // 3. TẢI TRANG WEB
                // Sử dụng CoreWebView2.Navigate() là phương thức đúng để tải trang
                webViewPhim.CoreWebView2.Navigate(finalUrl);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu việc khởi tạo WebView2 hoặc mạng có vấn đề
                MessageBox.Show($"Lỗi khi tải trang phim: {ex.Message}", "Lỗi Phát phim");
            }
        }

        // Phương thức cũ đã bị xóa vì không cần gọi API JSON chi tiết nữa
        /*
        private async void LoadFilmDetailsAndStream(string slug)
        {
            // ... (Logic cũ bị xóa) ...
        }
        */
    }
}