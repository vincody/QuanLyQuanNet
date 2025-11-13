using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Web; // Cần add reference System.Web cho UrlEncode
using static QuanLyQuanNet.Models;
using QuanLyQuanNet.GUI.VocVachPhim;

namespace QuanLyQuanNet.GUI.FormNgoai.FormKhach
{
    public partial class ListPhim : Form
    {
        private readonly HttpClient client = new HttpClient();
        private const string ApiBaseUrl = "https://phim.nguonc.com/api/films/phim-moi-cap-nhat?page=";
        // Đặt hằng số API tìm kiếm mới
        private const string SearchApiBaseUrl = "https://phim.nguonc.com/api/films/search?keyword=";

        // Biến quản lý trạng thái trang
        private int currentPage = 1;
        private int totalPages = 1; // Số trang tối đa (sẽ được cập nhật từ API)

        public ListPhim()
        {
            InitializeComponent();
            // Thiết lập trạng thái ban đầu của TextBox/Button
            UpdatePageControls();
        }

        // Phương thức chính tải phim
        public async void LoadFilms(int page)
        {
            // Kiểm tra giới hạn trang hợp lệ trước khi tải
            // Kiểm tra tổng số trang chỉ khi nó đã được xác định (totalPages > 1)
            if (page < 1 || (totalPages > 1 && page > totalPages)) return;

            // Cập nhật trạng thái trang hiện tại
            currentPage = page;
            panelListPhim.Controls.Clear();

            // ✅ TẠO URL API CHÍNH XÁC VỚI SỐ TRANG MỚI
            // ApiBaseUrl: "https://phim.nguonc.com/api/films/phim-moi-cap-nhat?page="
            string url = $"{ApiBaseUrl}{page}"; // <-- Đảm bảo URL là chính xác

            try
            {
                // Cập nhật hiển thị trang đang tải
                textBoxSoTrang.Text = currentPage.ToString();

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                // Phân tích cú pháp JSON
                FilmApiResponse apiResponse = JsonConvert.DeserializeObject<FilmApiResponse>(responseBody);

                if (apiResponse?.items == null || apiResponse.items.Count == 0)
                {
                    // Nếu hết phim ở trang này và nó không phải trang 1, giả định đây là trang cuối
                    if (currentPage > 1)
                    {
                        totalPages = currentPage;
                    }
                    panelListPhim.Controls.Add(new Label() { Text = "Không tìm thấy phim nào.", AutoSize = true, ForeColor = Color.White });
                    UpdatePageControls();
                    return;
                }

                // 1. Cập nhật tổng số trang từ API
                if (apiResponse.totalPages > 0)
                {
                    totalPages = apiResponse.totalPages;
                }

                // 2. Tạo và thêm User Controls vào FlowLayoutPanel
                foreach (var film in apiResponse.items)
                {
                    // TẠO USER CONTROL ThongTinPhim
                    ThongTinPhim filmControl = new ThongTinPhim();

                    // Gán Tên Phim
                    filmControl.labelTenPhim.Text = film.name;

                    // Tải và gán Poster
                    if (!string.IsNullOrEmpty(film.poster_url))
                    {
                        filmControl.HinhPhim.ImageLocation = film.poster_url;
                    }

                    panelListPhim.Controls.Add(filmControl);
                }

                // 3. Cập nhật trạng thái nút sau khi tải xong
                UpdatePageControls();
            }
            catch (Exception ex)
            {
                // Nếu có lỗi, giữ nguyên totalPages (hoặc lùi về trang trước)
                MessageBox.Show($"Lỗi tải phim: {ex.Message}", "Lỗi API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdatePageControls();
            }
        }
        public async void SearchFilms(string keyword)
        {
            panelListPhim.Controls.Clear();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                panelListPhim.Controls.Add(new Label() { Text = "Vui lòng nhập từ khóa tìm kiếm.", AutoSize = true, ForeColor = Color.White });
                return;
            }

            // 1. URL Encoding (Mã hóa từ khóa để đảm bảo an toàn trong URL)
            string encodedKeyword = System.Web.HttpUtility.UrlEncode(keyword.Trim());
            string url = $"{SearchApiBaseUrl}{encodedKeyword}";

            try
            {
                panelListPhim.Controls.Add(new Label() { Text = "Đang tìm kiếm...", AutoSize = true, ForeColor = Color.White });

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                // 2. Deserialize JSON (Sử dụng lại FilmApiResponse và FilmItem)
                FilmApiResponse apiResponse = JsonConvert.DeserializeObject<FilmApiResponse>(responseBody);

                panelListPhim.Controls.Clear(); // Xóa thông báo 'Đang tìm kiếm...'

                if (apiResponse?.items == null || apiResponse.items.Count == 0)
                {
                    panelListPhim.Controls.Add(new Label() { Text = $"Không tìm thấy phim nào cho từ khóa '{keyword}'.", AutoSize = true, ForeColor = Color.White });

                    // ✅ Đặt lại trạng thái phân trang (vì đây là kết quả tìm kiếm)
                    totalPages = 1;
                    currentPage = 1;
                    UpdatePageControls();
                    return;
                }

                // 3. Hiển thị Kết quả
                foreach (var film in apiResponse.items)
                {
                    // TẠO USER CONTROL ThongTinPhim (Tái sử dụng logic hiển thị đã có)
                    ThongTinPhim filmControl = new ThongTinPhim();
                    filmControl.labelTenPhim.Text = film.name;

                    if (!string.IsNullOrEmpty(film.poster_url))
                    {
                        filmControl.HinhPhim.ImageLocation = film.poster_url;
                        filmControl.HinhPhim.SizeMode = PictureBoxSizeMode.Zoom;
                    }

                    panelListPhim.Controls.Add(filmControl);
                }

                // ✅ Đặt lại trạng thái phân trang (vì đây là kết quả tìm kiếm)
                totalPages = 1;
                currentPage = 1;
                UpdatePageControls();
            }
            catch (Exception ex)
            {
                panelListPhim.Controls.Clear();
                MessageBox.Show($"Lỗi tìm kiếm: {ex.Message}", "Lỗi API", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePageControls()
        {
            // Vô hiệu hóa nút TRỪ nếu đang ở trang 1
            btnTru.Enabled = (currentPage > 1);

            // ✅ SỬA LỖI UI: Bật nút CỘNG nếu chưa phải trang cuối HOẶC totalPages vẫn còn là 1
            // (tức là ta chưa xác định được giới hạn, nên ta cho phép người dùng thử tải trang 2)
            btnCong.Enabled = (currentPage < totalPages || totalPages == 1);

            // Cập nhật hiển thị số trang hiện tại
            textBoxSoTrang.Text = currentPage.ToString();
            textBoxSoTrang.PlaceholderText = $"Trang {currentPage}/{totalPages}";
        }

        private void ListPhim_Load(object sender, EventArgs e)
        {
            LoadFilms(1);
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                LoadFilms(currentPage - 1);
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            // ✅ SỬA LỖI LOGIC: Cho phép tăng nếu chưa phải trang cuối HOẶC totalPages là 1.
            if (currentPage < totalPages || totalPages == 1)
            {
                // Khi tải trang 2 (hoặc cao hơn), LoadFilms sẽ nhận giá trị totalPages thực tế 
                // và tự khắc phục lỗi.
                LoadFilms(currentPage + 1);
            }
        }

        // Tùy chọn: Xử lý nhập trang trực tiếp
        private void textBoxSoTrang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 1. Kiểm tra đầu vào hợp lệ
                if (int.TryParse(textBoxSoTrang.Text, out int requestedPage) && requestedPage >= 1)
                {
                    // Tắt tiếng beep khi nhấn Enter
                    e.SuppressKeyPress = true;

                    // 2. LOGIC KIỂM TRA GIỚI HẠN:
                    // Chỉ kiểm tra trang tối đa (totalPages) nếu chúng ta đã xác định được nó (> 1).
                    // Hoặc kiểm tra nếu trang yêu cầu lớn hơn totalPages, CHÚNG TA LẶP LẠI TRANG ĐẦU
                    if (totalPages > 1 && requestedPage > totalPages)
                    {
                        MessageBox.Show($"Vui lòng nhập số trang hợp lệ (1 đến {totalPages}).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 3. Tải phim với trang mới
                    LoadFilms(requestedPage);
                }
                else
                {
                    MessageBox.Show($"Vui lòng nhập số trang hợp lệ (phải là số nguyên dương).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        // Event handler cho TextBox tìm kiếm (khi nhấn Enter)
        private void textBoxTimTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string keyword = textBoxTimTen.Text.Trim();

                if (string.IsNullOrEmpty(keyword))
                {
                    MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi hàm tìm kiếm
                SearchFilms(keyword);

                // Ngăn Enter key kích hoạt các controls khác
                e.SuppressKeyPress = true;
            }
        }
    }
}