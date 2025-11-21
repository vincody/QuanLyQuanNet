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
        private void LoadGameMenu(string filterCategory = "Tất cả")
        {
            // Xóa controls cũ trước khi tải lại
            flowPanelGame.Controls.Clear();

            string query = "SELECT MaGameID, TenGame, DanhMuc, HinhAnhGamePath FROM Game";

            // 1. Xây dựng mệnh đề WHERE (Nếu không phải là "Tất cả")
            if (filterCategory != "Tất cả")
            {
                query += " WHERE DanhMuc = @Category";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // 2. Thêm tham số SQL
                    if (filterCategory != "Tất cả")
                    {
                        command.Parameters.AddWithValue("@Category", filterCategory);
                    }

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string tenGame = reader["TenGame"].ToString();
                            string hinhAnhPath = reader["HinhAnhGamePath"].ToString();

                            // Tạo một instance của User Control (GameInfo.cs)
                            GameInfo gameControl = new GameInfo();

                            // Gán Tên Game
                            gameControl.bunifuLabelTenGame.Text = tenGame;

                            // Tải hình ảnh
                            if (!string.IsNullOrEmpty(hinhAnhPath))
                            {
                                try
                                {
                                    string fullPath = Path.Combine(Application.StartupPath, hinhAnhPath);
                                    if (File.Exists(fullPath))
                                    {
                                        // Tải ảnh (Lưu ý: Bạn đang dùng Bunifu PictureBox, thường hỗ trợ ImageLocation)
                                        gameControl.bunifuPictureBoxHinhAnhGame.ImageLocation = fullPath;
                                    }
                                }
                                catch (Exception imgEx)
                                {
                                    Console.WriteLine("Lỗi tải ảnh game: " + imgEx.Message);
                                }
                            }

                            // Thêm User Control vào FlowLayoutPanel
                            flowPanelGame.Controls.Add(gameControl);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi tải thực đơn game: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


                // Gán chung sự kiện Click
                btn.Click += CategoryButton_Click;

                // Thêm nút vào FlowLayoutPanel
                CagetoryGames.Controls.Add(btn);
            }
        }
        // Xử lý sự kiện khi một nút phân loại được nhấn
        private void CategoryButton_Click(object sender, EventArgs e)
        {
            // ✅ FIX LỖI: Kiểm tra đối tượng gửi sự kiện dưới dạng Control chung hoặc BunifuButton
            Control clickedControl = sender as Control;

            if (clickedControl != null)
            {
                // Lấy giá trị Tag trực tiếp từ Control (vì Tag là thuộc tính chung)
                string selectedCategory = clickedControl.Tag.ToString();

                // Lưu trạng thái lọc hiện tại
                currentCategory = selectedCategory;

                // Gọi hàm tải menu với tham số phân loại
                LoadGameMenu(selectedCategory);
            }
        }
    }
}
