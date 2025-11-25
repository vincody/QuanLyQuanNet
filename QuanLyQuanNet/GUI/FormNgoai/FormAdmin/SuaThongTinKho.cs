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
    public partial class SuaThongTinKho : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";
        // Biến lưu trữ thông tin nguyên liệu cần sửa
        private int currentID;
        private string currentTen;
        private string currentNhom;
        private string currentDonVi;
        private decimal currentGia;
        private int currentSoLuong;
        // Constructor nhận dữ liệu từ Form cha
        public SuaThongTinKho(int id, string ten, string nhom, decimal gia, string donVi, int soLuong)
        {
            InitializeComponent();

            // Lưu dữ liệu vào biến
            this.currentID = id;
            this.currentTen = ten;
            this.currentNhom = nhom;
            this.currentGia = gia;
            this.currentDonVi = donVi;
            this.currentSoLuong = soLuong;

            SetupComboBoxes();
            LoadDataToUI();
        }
        private void SetupComboBoxes()
        {
            comboBoxNhom.Items.AddRange(new string[] { "Đồ ăn", "Đồ uống", "Nguyên liệu" });
            comboBoxDonVi.Items.AddRange(new string[] { "Chai", "Gói", "Quả", "Cây" });
        }

        private void LoadDataToUI()
        {
            // Gán dữ liệu cũ lên giao diện
            textBoxTen.Text = currentTen;
            textBoxGia.Text = currentGia.ToString("F0"); // Định dạng số nguyên
            textBoxSoLuong.Text = currentSoLuong.ToString();

            // Chọn đúng item trong ComboBox
            if (comboBoxNhom.Items.Contains(currentNhom))
                comboBoxNhom.SelectedItem = currentNhom;

            if (comboBoxDonVi.Items.Contains(currentDonVi))
                comboBoxDonVi.SelectedItem = currentDonVi;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu mới (Logic tương tự NhapKho)
            string tenMoi = textBoxTen.Text.Trim();
            string nhomMoi = comboBoxNhom.SelectedItem?.ToString() ?? currentNhom;
            string donViMoi = comboBoxDonVi.SelectedItem?.ToString() ?? currentDonVi;

            if (!decimal.TryParse(textBoxGia.Text.Trim(), out decimal giaMoi) || giaMoi < 0)
            {
                MessageBox.Show("Giá không hợp lệ."); return;
            }
            if (!int.TryParse(textBoxSoLuong.Text.Trim(), out int soLuongMoi) || soLuongMoi < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ."); return;
            }

            // 2. Thực hiện UPDATE
            string query = @"
            UPDATE NguyenLieu 
            SET TenNguyenLieu = @Ten, 
                DanhMuc = @Nhom, 
                GiaNhap = @Gia, 
                DonViTinh = @DonVi, 
                SoLuongTon = @SoLuong
            WHERE NguyenLieuID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Ten", tenMoi);
                    command.Parameters.AddWithValue("@Nhom", nhomMoi);
                    command.Parameters.AddWithValue("@Gia", giaMoi);
                    command.Parameters.AddWithValue("@DonVi", donViMoi);
                    command.Parameters.AddWithValue("@SoLuong", soLuongMoi);
                    command.Parameters.AddWithValue("@ID", currentID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thông tin thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi cập nhật: " + ex.Message, "Lỗi DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
