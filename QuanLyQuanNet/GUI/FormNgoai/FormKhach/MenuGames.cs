using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using Bunifu.UI.WinForms;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanNet.GUI.ThongTinGame;

namespace QuanLyQuanNet.GUI.FormNgoai.FormKhach
{
    public partial class MenuGames : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";
        private string currentCategory = "Tất cả"; // Biến lưu trạng thái lọc hiện tại
        public MenuGames()
        {
            InitializeComponent();
            SetupCategoryFilters();
            LoadGameMenu(); // Tải menu lần đầu
        }
        private void LoadGameMenu(string filterCategory = "Tất cả", string searchKeyword = "") // <<< Thêm tham số searchKeyword
        {
            // Xóa controls cũ
            flowPanelGame.Controls.Clear();

            string query = "SELECT MaGameID, TenGame, DanhMuc, HinhAnhGamePath FROM Game";

            // --- XÂY DỰNG CÂU TRUY VẤN ĐỘNG ---
            System.Collections.Generic.List<string> whereClauses = new System.Collections.Generic.List<string>();

            // 1. Lọc theo Danh mục
            if (filterCategory != "Tất cả")
            {
                whereClauses.Add("DanhMuc = @Category");
            }

            // 2. Lọc theo Tên Game (Tìm kiếm)
            if (!string.IsNullOrEmpty(searchKeyword))
            {
                whereClauses.Add("TenGame LIKE @SearchKeyword");
            }

            // Ghép các điều kiện lại với nhau bằng AND
            if (whereClauses.Count > 0)
            {
                query += " WHERE " + string.Join(" AND ", whereClauses);
            }
            // -----------------------------------

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số SQL
                    if (filterCategory != "Tất cả")
                    {
                        command.Parameters.AddWithValue("@Category", filterCategory);
                    }

                    if (!string.IsNullOrEmpty(searchKeyword))
                    {
                        // Tìm kiếm tương đối (%)
                        command.Parameters.AddWithValue("@SearchKeyword", "%" + searchKeyword + "%");
                    }

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string tenGame = reader["TenGame"].ToString();
                            string hinhAnhPath = reader["HinhAnhGamePath"].ToString();

                            // Tạo User Control GameInfo
                            GameInfo gameControl = new GameInfo();
                            gameControl.bunifuLabelTenGame.Text = tenGame;

                            // Tải hình ảnh (Code xử lý ảnh như đã làm trước đó)
                            if (!string.IsNullOrEmpty(hinhAnhPath))
                            {
                                try
                                {
                                    string fullPath = Path.Combine(Application.StartupPath, hinhAnhPath);
                                    if (File.Exists(fullPath))
                                    {
                                        gameControl.bunifuPictureBoxHinhAnhGame.ImageLocation = fullPath;
                                    }
                                }
                                catch (Exception) { }
                            }

                            // Xử lý Label xuống dòng (như đã làm trước đó)
                            // AutoResizeLabelHeight(gameControl.bunifuLabelTenGame);

                            flowPanelGame.Controls.Add(gameControl);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi tải game: " + ex.Message);
                    }
                }
            }
        }
        // Hàm này nên được gọi trong Constructor
        private void SetupCategoryFilters()
        {
            string[] categories = { "Tất cả", "Online", "Offline", "Tools" };

            foreach (string category in categories)
            {
                // 1. Thay đổi kiểu dữ liệu từ Button sang BunifuButton
                // Giả sử class BunifuButton nằm trong namespace Bunifu.UI.WinForms.BunifuButton
                Bunifu.UI.WinForms.BunifuButton.BunifuButton btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
                btn.Text = category;
                btn.Tag = category;

                // 2. Thiết lập hiển thị nút (Điều chỉnh thuộc tính cho khớp với BunifuButton)
                // Nhiều thuộc tính của BunifuButton khác với Button chuẩn.

                // Ví dụ: Sử dụng thuộc tính Bunifu Button 
                btn.AllowAnimations = true; // Bật hoạt ảnh
                btn.AllowToggling = false;
                btn.AutoRoundBorders = true;

                btn.Height = 35; // Chiều cao cố định
                btn.Width = 80; // Chiều rộng cố định (Nếu không dùng AutoSize)
                btn.OnIdleState.BorderColor = Color.White;
                btn.OnIdleState.FillColor = Color.Transparent;
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Padding = new Padding(20, 0, 0, 0);

                // Gán chung sự kiện Click
                btn.Click += CategoryButton_Click;

                // Thêm nút vào FlowLayoutPanel
                CagetoryGames.Controls.Add(btn);
            }
        }
        // Xử lý sự kiện khi một nút phân loại được nhấn
        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;
            if (clickedControl != null)
            {
                string selectedCategory = clickedControl.Tag.ToString();
                currentCategory = selectedCategory; // Lưu trạng thái

                // Lấy từ khóa đang có trong ô tìm kiếm
                string currentKeyword = textBoxTimKiemGame.Text.Trim();

                // Tải lại với Category MỚI và Keyword CŨ
                LoadGameMenu(currentCategory, currentKeyword);
            }
        }
        private void textBoxTimKiemGame_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxTimKiemGame.Text.Trim();

            // Gọi hàm tải lại với Category đang chọn và Keyword mới
            // 'currentCategory' là biến bạn đã khai báo ở phần trước để lưu trạng thái nút bấm
            LoadGameMenu(currentCategory, keyword);
        }
    }
}
