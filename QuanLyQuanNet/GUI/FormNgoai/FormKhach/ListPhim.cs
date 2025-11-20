using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Web;
using static QuanLyQuanNet.Models;
using QuanLyQuanNet.GUI.VocVachPhim;

namespace QuanLyQuanNet.GUI.FormNgoai.FormKhach
{
    public partial class ListPhim : Form
    {
        private readonly HttpClient client = new HttpClient();
        private const string ApiBaseUrl = "https://phim.nguonc.com/api/films/phim-moi-cap-nhat?page=";
        private const string SearchApiBaseUrl = "https://phim.nguonc.com/api/films/search?keyword=";

        private int currentPage = 1;
        private int totalPages = 1;
        private string activeKeyword = ""; // Lưu từ khóa tìm kiếm đang hoạt động

        public ListPhim()
        {
            InitializeComponent();
            UpdatePageControls();

            this.textBoxTimTen.KeyDown += new KeyEventHandler(this.textBoxTimTen_KeyDown);
            this.textBoxSoTrang.KeyDown += new KeyEventHandler(this.textBoxSoTrang_KeyDown);

            // ✅ BỔ SUNG: Gán sự kiện click cho các thẻ phim để mở Form XemPhim
            this.panelListPhim.ControlAdded += (s, e) => {
                if (e.Control is ThongTinPhim filmControl)
                {
                    // Gán sự kiện cho chính UserControl
                    filmControl.Click += FilmCard_Click;
                    // Gán sự kiện cho các controls con bên trong (để bắt click bất kể ở đâu)
                    foreach (Control c in filmControl.Controls)
                    {
                        c.Click += FilmCard_Click;
                    }
                }
            };
        }

        // ====================================================================
        // PHƯƠNG THỨC TẢI NỘI DUNG (THỐNG NHẤT: PHÂN TRANG & TÌM KIẾM)
        // ====================================================================

        public async void LoadContent(int page, string keyword = "")
        {
            if (page < 1 || (totalPages > 1 && page > totalPages)) return;

            currentPage = page;
            activeKeyword = keyword.Trim(); // Cập nhật từ khóa đang hoạt động
            panelListPhim.Controls.Clear();

            string url = "";

            // 1. XÂY DỰNG URL DỰA TRÊN TRẠNG THÁI (PHÂN TRANG HAY TÌM KIẾM)
            if (!string.IsNullOrEmpty(activeKeyword))
            {
                string encodedKeyword = System.Web.HttpUtility.UrlEncode(activeKeyword);
                url = $"{SearchApiBaseUrl}{encodedKeyword}&page={page}";
            }
            else
            {
                url = $"{ApiBaseUrl}{page}";
            }

            try
            {
                textBoxSoTrang.Text = currentPage.ToString();
                panelListPhim.Controls.Add(new Label() { Text = "Đang tải...", AutoSize = true, ForeColor = Color.White });

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                FilmApiResponse apiResponse = JsonConvert.DeserializeObject<FilmApiResponse>(responseBody);

                panelListPhim.Controls.Clear(); // Xóa thông báo tải

                if (apiResponse?.items == null || apiResponse.items.Count == 0)
                {
                    if (currentPage > 1) { totalPages = currentPage; }

                    string message = string.IsNullOrEmpty(activeKeyword) ? "Không tìm thấy phim nào." : $"Không tìm thấy phim nào cho từ khóa '{activeKeyword}'.";
                    panelListPhim.Controls.Add(new Label() { Text = message, AutoSize = true, ForeColor = Color.White });
                    UpdatePageControls();
                    return;
                }

                // 2. Cập nhật tổng số trang từ API
                if (apiResponse.totalPages > 0)
                {
                    totalPages = apiResponse.totalPages;
                }

                // 3. Tạo và thêm User Controls vào FlowLayoutPanel
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
                    string tapPhimToDisplay = ""; // Mặc định là chuỗi rỗng

                    // 1. Kiểm tra trường hợp Movie đã FULL: total=1 và current="FULL"
                    if (totalEpCount == 1 && currentEpStatus.Equals("FULL", StringComparison.OrdinalIgnoreCase))
                    {
                        tapPhimToDisplay = "Hoàn tất";
                    }
                    // 2. Trường hợp Hoàn tất (dạng chuỗi)
                    else if (currentEpStatus.StartsWith("Hoàn tất", StringComparison.OrdinalIgnoreCase))
                    {
                        tapPhimToDisplay = currentEpStatus;
                    }
                    // 3. Trường hợp Đang chiếu: "Tập X"
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
                    // 4. Trường hợp khác (Phim lẻ, Trailer, Full HD)
                    else if (!string.IsNullOrEmpty(currentEpStatus))
                    {
                        tapPhimToDisplay = currentEpStatus;
                    }

                    filmControl.labelTap.Text = tapPhimToDisplay;
                    // ===============================================

                    // Lưu Slug vào Tag để Form XemPhim có thể truy vấn
                    filmControl.Tag = film.slug;

                    panelListPhim.Controls.Add(filmControl);

                    // Khắc phục lỗi hiển thị: GỌI HÀM CĂN CHỈNH SAU KHI CONTROL ĐƯỢC LOAD
                    filmControl.Load += (sender, e) => filmControl.CenterLabels();
                }

                UpdatePageControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải nội dung: {ex.Message}", "Lỗi API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdatePageControls();
            }
        }

        // ====================================================================
        // HÀM XỬ LÝ CLICK CARD PHIM (MỞ FORM XEM PHIM)
        // ====================================================================

        private void FilmCard_Click(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;
            if (clickedControl == null) return;

            // Tìm control cha có kiểu ThongTinPhim (vì click có thể đến từ Label/PictureBox con)
            ThongTinPhim filmControl = clickedControl as ThongTinPhim ?? clickedControl.Parent as ThongTinPhim;

            // 2. Lấy Slug từ Tag và kiểm tra
            if (filmControl?.Tag == null || string.IsNullOrEmpty(filmControl.Tag.ToString())) return;

            string filmSlug = filmControl.Tag.ToString();

            // 3. Mở Form XemPhim và truyền slug đi
            // Giả định bạn đã tạo Form XemPhim và có Constructor nhận slug
            // LƯU Ý: Nếu Form XemPhim của bạn không có namespace rõ ràng, bạn cần đảm bảo nó được tham chiếu đúng.
            XemPhim filmPlayer = new XemPhim(filmSlug);
            filmPlayer.ShowDialog();
        }

        // ====================================================================
        // LOGIC QUẢN LÝ UI VÀ PHÂN TRANG (Giữ nguyên)
        // ====================================================================

        private void UpdatePageControls()
        {
            btnTru.Enabled = (currentPage > 1);
            btnCong.Enabled = (currentPage < totalPages || totalPages == 1);

            textBoxSoTrang.Text = currentPage.ToString();
            textBoxSoTrang.PlaceholderText = string.IsNullOrEmpty(activeKeyword) ?
                                              $"Trang {currentPage}/{totalPages}" :
                                              "Tìm kiếm";
        }

        private void ListPhim_Load(object sender, EventArgs e)
        {
            LoadContent(1);
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                LoadContent(currentPage - 1, activeKeyword);
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages || totalPages == 1)
            {
                LoadContent(currentPage + 1, activeKeyword);
            }
        }

        private void textBoxTimTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string keyword = textBoxTimTen.Text.Trim();

                if (string.IsNullOrEmpty(keyword))
                {
                    LoadContent(1, "");
                    return;
                }
                // ✅ FIX: GỌI TRỰC TIẾP HÀM LOADCONTENT VỚI TỪ KHÓA
                LoadContent(1, keyword);
                e.SuppressKeyPress = true;
            }
        }

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

                    LoadContent(requestedPage, activeKeyword);
                }
                else
                {
                    MessageBox.Show($"Vui lòng nhập số trang hợp lệ (phải là số nguyên dương).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}