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
    public partial class NhapKho : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";
        public NhapKho()
        {
            InitializeComponent();
            SetupComboBoxes();
        }
        private void SetupComboBoxes()
        {
            // Thêm items cho ComboBox Nhóm
            comboBoxNhom.Items.AddRange(new string[] { "Đồ ăn", "Đồ uống", "Nguyên liệu" });
            comboBoxNhom.SelectedIndex = 0; // Chọn mặc định

            // Thêm items cho ComboBox Đơn vị
            comboBoxDonVi.Items.AddRange(new string[] { "Chai", "Gói", "Quả", "Cây" });
            comboBoxDonVi.SelectedIndex = 0; // Chọn mặc định
        }

        private void btnNhapVaoKho_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu từ giao diện
            string ten = textBoxTen.Text.Trim();
            string nhom = comboBoxNhom.SelectedItem.ToString();
            string donVi = comboBoxDonVi.SelectedItem.ToString();

            // 2. Kiểm tra nhập liệu
            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập tên nguyên liệu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBoxGia.Text.Trim(), out decimal giaNhap) || giaNhap < 0)
            {
                MessageBox.Show("Giá nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBoxSoLuong.Text.Trim(), out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Thực hiện INSERT vào CSDL
            string query = @"
            INSERT INTO NguyenLieu (TenNguyenLieu, DanhMuc, GiaNhap, DonViTinh, SoLuongTon)
            VALUES (@Ten, @Nhom, @Gia, @DonVi, @SoLuong)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Ten", ten);
                    command.Parameters.AddWithValue("@Nhom", nhom);
                    command.Parameters.AddWithValue("@Gia", giaNhap);
                    command.Parameters.AddWithValue("@DonVi", donVi);
                    command.Parameters.AddWithValue("@SoLuong", soLuong);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Nhập kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Đóng form sau khi thêm xong
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm mới: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // Hàm chỉ cho phép nhập số (gán vào sự kiện KeyPress của textBoxGia và textBoxSoLuong)
        private void InputNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
