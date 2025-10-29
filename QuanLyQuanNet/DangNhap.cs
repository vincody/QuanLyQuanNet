using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanNet.GUI.Menu;


namespace QuanLyQuanNet
{
    public partial class DangNhap : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Lấy tên đăng nhập và mật khẩu từ các TextBox (Giả sử tên là txtTenDangNhap và txtMatKhau)
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            // ⚠️ LƯU Ý BẢO MẬT QUAN TRỌNG: Mật khẩu PHẢI được BĂM (Hash) trước khi so sánh.
            // Dưới đây là ví dụ CHƯA BĂM, bạn phải tự triển khai hàm băm (ví dụ: SHA256)
            // string matKhauDaBam = HashFunction(matKhau); 

            // Ở đây, tôi dùng mật khẩu thô để làm ví dụ, nhưng trong thực tế, bạn phải dùng mật khẩu đã băm.
            if (KiemTraDangNhap(tenDangNhap, matKhau))
            {
                // 1. Đăng nhập thành công

                // 2. Chuyển sang Form MenuQN
                MenuQN menuForm = new MenuQN();
                menuForm.Show();

                // 3. Ẩn hoặc đóng Form Đăng nhập hiện tại
                this.Hide(); // Ẩn Form hiện tại
                             // Hoặc: this.Close(); // Đóng Form hiện tại (Cẩn thận nếu đây là Form chính)
            }
            else
            {
                // 1. Đăng nhập thất bại
                MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không đúng!", "Lỗi Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtTenDangNhap.Focus();
            }
        }
        private bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            // Dùng tham số hóa (@TenDN, @MK) để tránh lỗi SQL Injection 
            string query = "SELECT MatKhau, isAdmin, isNhanVien, isKhach FROM TaiKhoan WHERE TenDangNhap = @TenDN";

            // Nếu bạn đã băm mật khẩu trong C#, thì query sẽ là:
            // string query = "SELECT isAdmin, isNhanVien, isKhach FROM TaiKhoan WHERE TenDangNhap = @TenDN AND MatKhau = @MK";

            using (SqlConnection connection = new   SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số tên đăng nhập
                    command.Parameters.AddWithValue("@TenDN", tenDangNhap);

                    // ⚠️ Nếu bạn BĂM mật khẩu trên code và so sánh trong query, thêm tham số mật khẩu
                    // command.Parameters.AddWithValue("@MK", matKhauDaBam); // Mật khẩu đã BĂM

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            // Lấy mật khẩu đã băm từ DB (Giả sử cột MatKhau)
                            string matKhauDB = reader["MatKhau"].ToString();

                            // ⚠️ BƯỚC QUAN TRỌNG: So sánh mật khẩu
                            // Thực hiện so sánh mật khẩu BĂM TỪ INPUT với mật khẩu BĂM TỪ DB.
                            // Nếu bạn dùng thư viện băm (ví dụ: BCrypt.Net), nó sẽ là:
                            // bool isPasswordValid = BCrypt.Net.BCrypt.Verify(matKhau, matKhauDB);

                            // **VÍ DỤ TẠM THỜI (Dễ bị tấn công): So sánh mật khẩu thô**
                            // **Trong thực tế, BẠN KHÔNG NÊN làm như thế này!**
                            bool isPasswordValid = (matKhau == matKhauDB);

                            if (isPasswordValid)
                            {
                                // Đăng nhập thành công, có thể lưu thông tin quyền hạn vào một biến toàn cục
                                // hoặc đối tượng UserSession
                                bool isAdmin = reader.GetBoolean(reader.GetOrdinal("isAdmin"));
                                bool isNhanVien = reader.GetBoolean(reader.GetOrdinal("isNhanVien"));
                                // ... và các logic phân quyền khác ...

                                return true;
                            }
                        }
                        return false; // Không tìm thấy tài khoản hoặc mật khẩu không khớp
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
    }
}

