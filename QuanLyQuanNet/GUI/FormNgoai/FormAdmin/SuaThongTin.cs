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
using System.Windows.Forms;

namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    public partial class SuaThongTin : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";
        private TaiKhoanData currentData; // Lưu trữ dữ liệu gốc và ID
        public SuaThongTin(TaiKhoanData data)
        {
            InitializeComponent();
            this.currentData = data;
            LoadInitialData();
        }
        // drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //
        private void LoadInitialData()
        {
            // Ẩn tên tài khoản (TenDangNhap) khỏi chỉnh sửa
            textBoxTenTK.Text = currentData.TenDangNhap;
            textBoxTenTK.ReadOnly = true;

            // Gán các giá trị hiện tại
            textBoxHoTen.Text = currentData.HoTen;
            textBoxCCCD.Text = currentData.CCCD;
            textBoxSDT.Text = currentData.SDT;
            textBoxSoDu.Text = currentData.SoDu.ToString();
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu mới
            string hoTenMoi = textBoxHoTen.Text.Trim();
            string cccdMoi = textBoxCCCD.Text.Trim();
            string sdtMoi = textBoxSDT.Text.Trim();

            if (!decimal.TryParse(textBoxSoDu.Text.Trim(), out decimal soDuMoi))
            {
                MessageBox.Show("Số dư không hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra ràng buộc độ dài (Tương tự như form Tạo tài khoản)
            if (cccdMoi.Length != 12 || sdtMoi.Length != 10)
            {
                MessageBox.Show("CCCD phải là 12 chữ số, SĐT phải là 10 chữ số.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Xây dựng truy vấn UPDATE
            string updateQuery = "UPDATE TaiKhoan SET HoTen = @HoTen, CCCD = @CCCD, SDT = @SDT, SoDu = @SoDu, NgayTao = GETDATE()";

            // Bổ sung UPDATE Mật khẩu nếu checkbox được chọn
            if (checkBoxMK.Checked)
            {
                // Mật khẩu mới bằng Số điện thoại đã đăng ký (SDT MỚI)
                updateQuery += ", MatKhau = @MatKhauMoi";
            }

            updateQuery += " WHERE TaiKhoanID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID", currentData.TaiKhoanID);
                    command.Parameters.AddWithValue("@HoTen", hoTenMoi);
                    command.Parameters.AddWithValue("@CCCD", cccdMoi);
                    command.Parameters.AddWithValue("@SDT", sdtMoi);
                    command.Parameters.AddWithValue("@SoDu", soDuMoi);

                    if (checkBoxMK.Checked)
                    {
                        // Đặt mật khẩu là số điện thoại mới nhập vào
                        command.Parameters.AddWithValue("@MatKhauMoi", sdtMoi);
                    }

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Cập nhật thông tin thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi CSDL khi cập nhật: " + ex.Message, "Lỗi DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
    }
}
