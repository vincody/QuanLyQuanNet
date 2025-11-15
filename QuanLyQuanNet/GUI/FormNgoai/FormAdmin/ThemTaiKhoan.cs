using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    public partial class ThemTaiKhoan : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";
        public ThemTaiKhoan()
        {
            InitializeComponent();
            this.ControlBox = false;
            textBoxSoDu.KeyPress += TextBox_AllowOnlyNumbers_KeyPress;
        }
        // drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //
        // Hàm kiểm tra chỉ cho phép nhập số và một dấu chấm thập phân (cho SoDu)
        private void TextBox_AllowOnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép số, phím Backspace, và dấu chấm (dấu thập phân)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Chỉ cho phép một dấu chấm thập phân
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            // 1. Lấy và Chuẩn hóa Dữ liệu
            string hoTen = textBoxHoTen.Text.Trim();
            string cccd = textBoxCCCD.Text.Trim();
            string tenDangNhap = textBoxTenTK.Text.Trim();
            string sdt = textBoxSDT.Text.Trim();

            // Cố gắng chuyển đổi SoDu
            if (!decimal.TryParse(textBoxSoDu.Text.Trim(), out decimal soDu))
            {
                MessageBox.Show("Số dư không hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Kiểm tra Ràng buộc (Client-side Validation)
            if (string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("Vui lòng điền đủ Họ tên, Tên tài khoản và SĐT.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra độ dài CCCD (12 số) và SDT (10 số)
            if (cccd.Length != 12 || !Regex.IsMatch(cccd, @"^\d{12}$"))
            {
                MessageBox.Show("Căn cước công dân phải là 12 chữ số.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sdt.Length != 10 || !Regex.IsMatch(sdt, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải là 10 chữ số.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Thực hiện Giao dịch (INSERT và Kiểm tra Trùng lặp)
            if (CreateNewAccountTransaction(hoTen, cccd, tenDangNhap, sdt, soDu))
            {
                MessageBox.Show("Tạo tài khoản thành công! Mật khẩu mặc định là sdt.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        //
        /// <summary>
        /// Thực hiện kiểm tra trùng lặp và chèn tài khoản mới vào CSDL trong một Transaction.
        /// </summary>
        private bool CreateNewAccountTransaction(string hoTen, string cccd, string tenDangNhap, string sdt, decimal soDu)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // BƯỚC 1: KIỂM TRA TRÙNG LẶP CCCD, SDT, Tên Đăng Nhập
                    string checkQuery = @"
                    SELECT 
                        CASE WHEN EXISTS (SELECT 1 FROM TaiKhoan WHERE TenDangNhap = @TenDN) THEN 'TenDN' ELSE '' END + 
                        CASE WHEN EXISTS (SELECT 1 FROM TaiKhoan WHERE CCCD = @CCCD) THEN 'CCCD' ELSE '' END +
                        CASE WHEN EXISTS (SELECT 1 FROM TaiKhoan WHERE SDT = @SDT) THEN 'SDT' ELSE '' END AS Conflicts";

                    using (SqlCommand cmdCheck = new SqlCommand(checkQuery, connection, transaction))
                    {
                        cmdCheck.Parameters.AddWithValue("@TenDN", tenDangNhap);
                        cmdCheck.Parameters.AddWithValue("@CCCD", cccd);
                        cmdCheck.Parameters.AddWithValue("@SDT", sdt);

                        string conflicts = cmdCheck.ExecuteScalar()?.ToString() ?? "";

                        if (conflicts.Contains("TenDN"))
                        {
                            MessageBox.Show("Tên tài khoản đã tồn tại.", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                            return false;
                        }
                        if (conflicts.Contains("CCCD"))
                        {
                            MessageBox.Show("CCCD đã được đăng ký.", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                            return false;
                        }
                        if (conflicts.Contains("SDT"))
                        {
                            MessageBox.Show("Số điện thoại đã được đăng ký.", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                            return false;
                        }
                    }

                    // BƯỚC 2: CHÈN (INSERT) TÀI KHOẢN MỚI
                    string insertQuery = $@"
                    INSERT INTO TaiKhoan (TenDangNhap, MatKhau, isAdmin, isNhanVien, isKhach, HoTen, SDT, CCCD, SoDu, NgayTao)
                    VALUES (@TenDN, @MK, 0, 0, 1, @HoTen, @SDT, @CCCD, @SoDu, GETDATE())";

                    using (SqlCommand cmdInsert = new SqlCommand(insertQuery, connection, transaction))
                    {
                        cmdInsert.Parameters.AddWithValue("@TenDN", tenDangNhap);
                        cmdInsert.Parameters.AddWithValue("@MK", sdt); // Mật khẩu mặc định là sdt đăng ký cùng
                        cmdInsert.Parameters.AddWithValue("@HoTen", hoTen);
                        cmdInsert.Parameters.AddWithValue("@SDT", sdt);
                        // Dùng N'value' cho NVARCHAR trong trường hợp này không cần thiết vì ta dùng Parameters, 
                        // nhưng đảm bảo CCCD, HoTen là NVARCHAR trong DB (đã kiểm tra là đúng)
                        cmdInsert.Parameters.AddWithValue("@CCCD", cccd);
                        cmdInsert.Parameters.AddWithValue("@SoDu", soDu);

                        cmdInsert.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi CSDL khi tạo tài khoản: " + ex.Message, "Lỗi DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
