using System;
using System.Collections.Generic;
using System.Data.SqlClient;

// ... các using khác ...
using QuanLyQuanNet.GUI.Menu;
// Thêm using cho class UserSession nếu nó ở namespace khác
// Ví dụ: using QuanLyQuanNet.Utils; 

namespace QuanLyQuanNet
{
    public partial class DangNhap : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";
        public DangNhap()
        {
            InitializeComponent();
            // Thiết lập thuộc tính UseSystemPasswordChar cho TextBox mật khẩu
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            // ⚠️ Lưu ý bảo mật: Hãy nhớ triển khai hàm BĂM MẬT KHẨU thực tế!
            // Ví dụ: string matKhauDaBam = HashFunction(matKhau); 

            // Hàm KiemTraDangNhap đã được sửa để vừa kiểm tra và vừa lưu thông tin session.
            if (KiemTraVaTaoSession(tenDangNhap, matKhau))
            {
                // Đăng nhập thành công

                // 2. Chuyển sang Form MenuQN (Admin/Nhân viên) hoặc MenuKhach (Khách)
                if (UserSession.IsAdmin || UserSession.IsNhanVien)
                {
                    // Chuyển đến Menu chính cho Quản lý / Nhân viên
                    MenuQN menuForm = new MenuQN();
                    menuForm.Show();
                }
                else if (UserSession.IsKhach)
                {
                    // Chuyển đến Menu cho Khách
                    // Giả sử bạn có Form tên là MenuKhach
                    MenuKhach menuKhachForm = new MenuKhach();
                    menuKhachForm.Show();
                }
                else
                {
                    // Trường hợp không có quyền nào (Không nên xảy ra nếu DB đúng)
                    MessageBox.Show("Đăng nhập thành công nhưng không có quyền hạn nào được gán.", "Lỗi Quyền hạn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Ẩn Form Đăng nhập hiện tại
                this.Hide();
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không đúng!", "Lỗi Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtTenDangNhap.Focus();
            }
        }

        // Đổi tên hàm để phản ánh chức năng: kiểm tra và tạo phiên người dùng
        private bool KiemTraVaTaoSession(string tenDangNhap, string matKhau)
        {
            // Lấy tất cả thông tin cần thiết, bao gồm mật khẩu băm và quyền hạn
            string query = "SELECT MatKhau, isAdmin, isNhanVien, isKhach FROM TaiKhoan WHERE TenDangNhap = @TenDN";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenDN", tenDangNhap);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            string matKhauDB = reader["MatKhau"].ToString();

                            // ⚠️ BƯỚC QUAN TRỌNG: So sánh mật khẩu BĂM thực tế.
                            // **Hiện tại vẫn là so sánh mật khẩu thô - CẦN ĐƯỢC THAY THẾ**
                            bool isPasswordValid = (matKhau == matKhauDB);

                            if (isPasswordValid)
                            {
                                // Đăng nhập thành công -> LƯU THÔNG TIN SESSION
                                UserSession.TenDangNhap = tenDangNhap;
                                UserSession.IsAdmin = reader.GetBoolean(reader.GetOrdinal("isAdmin"));
                                UserSession.IsNhanVien = reader.GetBoolean(reader.GetOrdinal("isNhanVien"));
                                UserSession.IsKhach = reader.GetBoolean(reader.GetOrdinal("isKhach"));

                                return true; // Trả về thành công
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