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

namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    public partial class NapTienKhach : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";

        private string tenDangNhapCanNap;
        private decimal soDuHienTai;
        public NapTienKhach(string tenDangNhap, decimal soDuHienTai)
        {
            InitializeComponent();
            this.tenDangNhapCanNap = tenDangNhap;
            this.soDuHienTai = soDuHienTai;
            SetupForm();
        }
        private void SetupForm()
        {
            // Hiển thị thông tin và khóa chỉnh sửa những ô không cần thiết
            textBoxTenDangNhap.Text = tenDangNhapCanNap;
            textBoxTenDangNhap.ReadOnly = true; // Chỉ đọc

            textBoxSoTienSauNap.ReadOnly = true; // Chỉ đọc, tự động tính
            textBoxSoTienSauNap.Text = soDuHienTai.ToString("N0"); // Ban đầu bằng số dư cũ

            // Gán sự kiện để tính toán real-time
            textBoxTienNap.TextChanged += TextBoxTienNap_TextChanged;
        }
        // Sự kiện: Tự động tính tổng tiền khi nhập số tiền nạp
        private void TextBoxTienNap_TextChanged(object sender, EventArgs e)
        {
            // 1. Lấy chuỗi và loại bỏ dấu chấm phân cách hàng nghìn
            // Ví dụ: "60.000" -> "60000"
            string rawAmount = textBoxTienNap.Text.Replace(".", "").Replace(",", "").Trim();

            if (decimal.TryParse(rawAmount, out decimal tienNap))
            {
                decimal tongTien = soDuHienTai + tienNap;

                // Hiển thị lại với định dạng N0 (có dấu chấm phân cách: 160.000)
                textBoxSoTienSauNap.Text = tongTien.ToString("N0");
            }
            else
            {
                // Nếu xóa hết hoặc nhập sai, hiển thị lại số dư cũ
                textBoxSoTienSauNap.Text = soDuHienTai.ToString("N0");
            }
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            textBoxTienNap.Text = "10.000";
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            textBoxTienNap.Text = "20.000";
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            textBoxTienNap.Text = "30.000";
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            textBoxTienNap.Text = "40.000";
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            textBoxTienNap.Text = "50.000";
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            textBoxTienNap.Text = "60.000";
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            textBoxTienNap.Text = "70.000";
        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            textBoxTienNap.Text = "80.000";
        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            textBoxTienNap.Text = "100.000";
        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            textBoxTienNap.Text = "200.000";
        }

        private void bunifuButton12_Click(object sender, EventArgs e)
        {
            textBoxTienNap.Text = "500.000";
        }

        private void bunifuButton14_Click(object sender, EventArgs e)
        {
            textBoxTienNap.Clear();
        }
        // Sự kiện: Nút Xác Nhận Nạp
        private void btnXacNhanNap_Click_1(object sender, EventArgs e)
        {
            // 1. Sanitize và Kiểm tra đầu vào

            // ✅ FIX LỖI: Lấy chuỗi từ TextBox và loại bỏ dấu chấm, dấu phẩy phân cách hàng nghìn
            string rawAmount = textBoxTienNap.Text.Replace(".", "").Replace(",", "").Trim();

            if (!decimal.TryParse(rawAmount, out decimal tienNap) || tienNap <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền nạp hợp lệ (> 0).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Thực hiện UPDATE vào CSDL
            string query = "UPDATE TaiKhoan SET SoDu = SoDu + @TienNap WHERE TenDangNhap = @TenDN";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Truyền giá trị tienNap đã xử lý (ví dụ: 60000) vào SQL
                    command.Parameters.AddWithValue("@TienNap", tienNap);
                    command.Parameters.AddWithValue("@TenDN", tenDangNhapCanNap);

                    try
                    {
                        connection.Open();
                        int rows = command.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            // Sử dụng định dạng tiền tệ N0 để hiển thị số tiền nạp chính xác
                            MessageBox.Show($"Nạp thành công {tienNap:N0} VNĐ cho tài khoản {tenDangNhapCanNap}.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Đóng form sau khi nạp xong
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy tài khoản để nạp tiền.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
