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
using static QuanLyQuanNet.Models; // Chứa FilmApiResponse và FilmItem
using QuanLyQuanNet.GUI.VocVachPhim; // Chứa ThongTinPhim User Control

namespace QuanLyQuanNet.GUI.FormNgoai.FormKhach
{
    public partial class ListPhim : Form
    {
        private readonly HttpClient client = new HttpClient();
        private const string ApiBaseUrl = "https://phim.nguonc.com/api/films/phim-moi-cap-nhat?page=";
        private const string SearchApiBaseUrl = "https://phim.nguonc.com/api/films/search?keyword=";

        // Biến quản lý trạng thái trang
        private int currentPage = 1;
        private int totalPages = 1; // Số trang tối đa (sẽ được cập nhật từ API)

        public ListPhim()
        {
            InitializeComponent();
            UpdatePageControls();

            // Gán sự kiện cho TextBox tìm kiếm (Enter key)
            this.textBoxTimTen.KeyDown += new KeyEventHandler(this.textBoxTimTen_KeyDown);
            this.textBoxSoTrang.KeyDown += new KeyEventHandler(this.textBoxSoTrang_KeyDown);
        }

        // ====================================================================
        // PHƯƠNG THỨC TẢI PHIM MỚI (PHÂN TRANG)
        // ====================================================================

        public async void LoadFilms(int page)
        {
            if (page < 1 || (totalPages > 1 && page > totalPages)) return;

            currentPage = page;
            panelListPhim.Controls.Clear();

            string url = $"{ApiBaseUrl}{page}";

            try
            {
                textBoxSoTrang.Text = currentPage.ToString();

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                FilmApiResponse apiResponse = JsonConvert.DeserializeObject<FilmApiResponse>(responseBody);

                if (apiResponse?.items == null || apiResponse.items.Count == 0)
                {
                    if (currentPage > 1) { totalPages = currentPage; }

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
                    ThongTinPhim filmControl = new ThongTinPhim();

                    filmControl.labelTenPhim.Text = film.name;

                    if (!string.IsNullOrEmpty(film.poster_url))
                    {
                        filmControl.HinhPhim.ImageLocation = film.poster_url;
                        filmControl.HinhPhim.SizeMode = PictureBoxSizeMode.Zoom;
                    }

                    // === LOGIC XỬ LÝ VÀ GÁN TẬP PHIM (labelTap) ===
                    string currentEpStatus = film.current_episode?.Trim() ?? "";
                    int totalEpCount = film.total_episodes;
                    string tapPhimToDisplay = "Đang cập nhật";

                    if (currentEpStatus.StartsWith("Hoàn tất", StringComparison.OrdinalIgnoreCase))
                    {
                        tapPhimToDisplay = currentEpStatus;
                    }
                    else if (currentEpStatus.StartsWith("Tập ", StringComparison.OrdinalIgnoreCase))
                    {
                        if (totalEpCount > 0)
                        {
                            tapPhimToDisplay = $"{currentEpStatus}/{totalEpCount}";
                        }
                        else
                        {
                            tapPhimToDisplay = currentEpStatus;
                        }
                    }
                    filmControl.labelTap.Text = tapPhimToDisplay;
                    // ===============================================

                    panelListPhim.Controls.Add(filmControl);

                    // ✅ KHẮC PHỤC LỖI HIỂN THỊ: GỌI HÀM CĂN CHỈNH SAU KHI CONTROL ĐƯỢC LOAD
                    // Điều này đảm bảo kích thước Control đã hợp lệ trước khi tính toán vị trí
                    filmControl.Load += (sender, e) => filmControl.CenterLabels();
                }

                // 3. Cập nhật trạng thái nút sau khi tải xong
                UpdatePageControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải phim: {ex.Message}", "Lỗi API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdatePageControls();
            }
        }

        // ====================================================================
        // PHƯƠNG THỨC TÌM KIẾM
        // ====================================================================

        public async void SearchFilms(string keyword)
        {
            panelListPhim.Controls.Clear();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                panelListPhim.Controls.Add(new Label() { Text = "Vui lòng nhập từ khóa tìm kiếm.", AutoSize = true, ForeColor = Color.White });
                return;
            }

            string encodedKeyword = System.Web.HttpUtility.UrlEncode(keyword.Trim());
            string url = $"{SearchApiBaseUrl}{encodedKeyword}";

            try
            {
                panelListPhim.Controls.Add(new Label() { Text = "Đang tìm kiếm...", AutoSize = true, ForeColor = Color.White });

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                FilmApiResponse apiResponse = JsonConvert.DeserializeObject<FilmApiResponse>(responseBody);

                panelListPhim.Controls.Clear(); // Xóa thông báo 'Đang tìm kiếm...'

                if (apiResponse?.items == null || apiResponse.items.Count == 0)
                {
                    panelListPhim.Controls.Add(new Label() { Text = $"Không tìm thấy phim nào cho từ khóa '{keyword}'.", AutoSize = true, ForeColor = Color.White });
                    totalPages = 1;
                    currentPage = 1;
                    UpdatePageControls();
                    return;
                }

                // Hiển thị Kết quả
                foreach (var film in apiResponse.items)
                {
                    ThongTinPhim filmControl = new ThongTinPhim();
                    filmControl.labelTenPhim.Text = film.name;

                    if (!string.IsNullOrEmpty(film.poster_url))
                    {
                        filmControl.HinhPhim.ImageLocation = film.poster_url;
                        filmControl.HinhPhim.SizeMode = PictureBoxSizeMode.Zoom;
                    }

                    // === LOGIC XỬ LÝ VÀ GÁN TẬP PHIM (labelTap) ===
                    string currentEpStatus = film.current_episode?.Trim() ?? "";
                    string tapPhimToDisplay = currentEpStatus;
                    filmControl.labelTap.Text = tapPhimToDisplay;
                    // ===============================================

                    panelListPhim.Controls.Add(filmControl);

                    // ✅ KHẮC PHỤC LỖI HIỂN THỊ: GỌI HÀM CĂN CHỈNH SAU KHI CONTROL ĐƯỢC LOAD
                    filmControl.Load += (sender, e) => filmControl.CenterLabels();
                }

                // Đặt lại trạng thái phân trang (vì đây là kết quả tìm kiếm)
                totalPages = 1; // Kết quả tìm kiếm không có phân trang
                currentPage = 1;
                UpdatePageControls();
            }
            catch (Exception ex)
            {
                panelListPhim.Controls.Clear();
                MessageBox.Show($"Lỗi tìm kiếm: {ex.Message}", "Lỗi API", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ====================================================================
        // LOGIC QUẢN LÝ UI VÀ PHÂN TRANG
        // ====================================================================

        private void UpdatePageControls()
        {
            // Vô hiệu hóa nút TRỪ nếu đang ở trang 1
            btnTru.Enabled = (currentPage > 1);

            // Bật nút CỘNG nếu chưa phải trang cuối HOẶC totalPages vẫn còn là 1
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
            // Cho phép tăng nếu chưa phải trang cuối HOẶC totalPages là 1.
            if (currentPage < totalPages || totalPages == 1)
            {
                LoadFilms(currentPage + 1);
            }
        }

        // HÀM XỬ LÝ NHẬP TÊN TÌM KIẾM
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

                SearchFilms(keyword);
                e.SuppressKeyPress = true;
            }
        }

        // Xử lý nhập trang trực tiếp
        private void textBoxSoTrang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(textBoxSoTrang.Text, out int requestedPage) && requestedPage >= 1)
                {
                    e.SuppressKeyPress = true;

                    if (totalPages > 1 && requestedPage > totalPages)
                    {
                        MessageBox.Show($"Vui lòng nhập số trang hợp lệ (1 đến {totalPages}).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    LoadFilms(requestedPage);
                }
                else
                {
                    MessageBox.Show($"Vui lòng nhập số trang hợp lệ (phải là số nguyên dương).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}