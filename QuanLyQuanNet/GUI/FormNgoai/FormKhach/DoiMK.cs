using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace QuanLyQuanNet.GUI.FormNgoai.FormKhach
{
    public partial class DoiMK : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";
        public DoiMK()
        {
            InitializeComponent();
            // Thiết lập ẩn ký tự mật khẩu cho các TextBox
            textBoxMKHT.UseSystemPasswordChar = true;
            textBoxMKM.UseSystemPasswordChar = true;
            textBoxConfirm.UseSystemPasswordChar = true;
            this.ControlBox = false;
        }
        // drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string mkHienTai = textBoxMKHT.Text;
            string mkMoi = textBoxMKM.Text;
            string mkXacNhan = textBoxConfirm.Text;
            string tenDangNhap = UserSession.TenDangNhap; // Lấy tên đăng nhập hiện tại

            // 1. Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrWhiteSpace(mkHienTai) || string.IsNullOrWhiteSpace(mkMoi) || string.IsNullOrWhiteSpace(mkXacNhan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra Mật khẩu mới và Xác nhận mật khẩu
            if (mkMoi != mkXacNhan)
            {
                MessageBox.Show("Mật khẩu mới và Xác nhận mật khẩu không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxConfirm.Clear();
                return;
            }
            // 4. BƯỚC XÁC THỰC MẬT KHẨU HIỆN TẠI VÀ CẬP NHẬT
            string queryCheck = "SELECT MatKhau FROM TaiKhoan WHERE TenDangNhap = @TenDN";
            string queryUpdate = "UPDATE TaiKhoan SET MatKhau = @MatKhauMoi WHERE TenDangNhap = @TenDN AND MatKhau = @MatKhauCu";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null; // Declare transaction outside try block
                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();
                    string matKhauDB = string.Empty;

                    // A. XÁC THỰC MẬT KHẨU HIỆN TẠI
                    using (SqlCommand cmdCheck = new SqlCommand(queryCheck, connection, transaction))
                    {
                        cmdCheck.Parameters.AddWithValue("@TenDN", tenDangNhap);

                        using (SqlDataReader reader = cmdCheck.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                matKhauDB = reader["MatKhau"].ToString();
                            }
                        } // reader đóng
                    }

                    // So sánh mật khẩu hiện tại nhập vào với mật khẩu trong DB
                    if (matKhauDB != mkHienTai)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Mật khẩu hiện tại không đúng!", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxMKHT.Clear();
                        return;
                    }

                    // B. CẬP NHẬT MẬT KHẨU MỚI
                    using (SqlCommand cmdUpdate = new SqlCommand(queryUpdate, connection, transaction))
                    {
                        cmdUpdate.Parameters.AddWithValue("@MatKhauMoi", mkMoi); // Mật khẩu mới
                        cmdUpdate.Parameters.AddWithValue("@TenDN", tenDangNhap);
                        cmdUpdate.Parameters.AddWithValue("@MatKhauCu", mkHienTai); // Dùng cho WHERE clause (tăng tính an toàn)

                        int rowsAffected = cmdUpdate.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            transaction.Commit();
                            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Đóng Form sau khi đổi thành công
                        }
                        else
                        {
                            // Lỗi không xác định hoặc không tìm thấy hàng (không nên xảy ra)
                            transaction.Rollback();
                            MessageBox.Show("Không thể đổi mật khẩu. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi CSDL
                    try { if (transaction != null) transaction.Rollback(); } catch { }
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxMKHT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
