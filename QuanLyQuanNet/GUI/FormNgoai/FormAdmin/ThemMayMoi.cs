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
    public partial class ThemMayMoi : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";
        public ThemMayMoi()
        {
            InitializeComponent();
            this.Text = "";
            this.ControlBox = false;
        }
        // drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //
        private void btnThemMay_Click(object sender, EventArgs e)
        {
            string cpu = textBoxTCPU.Text.Trim();
            string gpu = textBoxTGPU.Text.Trim();
            string ram = textBoxTRAM.Text.Trim();
            string manHinh = textBoxTManHinh.Text.Trim();
            string giaText = textBoxTGiaMayTrenH.Text.Trim();
            string tinhTrang = "Available"; // Máy mới luôn đặt trạng thái là Available

            // 1. Kiểm tra và Xác thực dữ liệu nhập vào
            if (string.IsNullOrEmpty(cpu) || string.IsNullOrEmpty(gpu) || string.IsNullOrEmpty(ram) || string.IsNullOrEmpty(manHinh) || string.IsNullOrEmpty(giaText))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cấu hình và giá máy.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(giaText, out decimal giaTheoGio) || giaTheoGio <= 0)
            {
                MessageBox.Show("Giá máy không hợp lệ. Vui lòng nhập số dương.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo chuỗi CauHinh (để tương thích với database nếu cột này vẫn tồn tại)
            string cauHinhString = $"{cpu}, {ram} RAM, {gpu}, {manHinh}";

            // 2. Thực hiện Thêm vào CSDL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Bắt đầu Transaction để đảm bảo cả 2 lệnh (INSERT và UPDATE) thành công hoặc thất bại
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Bước 1: INSERT dữ liệu với TenMay tạm thời
                    string insertQuery = @"
                    INSERT INTO Computers (TenMay, CPU, GPU, RAM, ManHinh, GiaTheoGio, TinhTrang, CauHinh)
                    VALUES (@TenMayTemp, @CPU, @GPU, @RAM, @ManHinh, @GiaTheoGio, @TinhTrang, @CauHinh);
                    SELECT SCOPE_IDENTITY();";

                    SqlCommand command = new SqlCommand(insertQuery, connection, transaction);

                    command.Parameters.AddWithValue("@TenMayTemp", "TEMP"); // Dùng giá trị tạm thời
                    command.Parameters.AddWithValue("@CPU", cpu);
                    command.Parameters.AddWithValue("@GPU", gpu);
                    command.Parameters.AddWithValue("@RAM", ram);
                    command.Parameters.AddWithValue("@ManHinh", manHinh);
                    command.Parameters.AddWithValue("@GiaTheoGio", giaTheoGio);
                    command.Parameters.AddWithValue("@TinhTrang", tinhTrang);
                    command.Parameters.AddWithValue("@CauHinh", cauHinhString);

                    // Lấy ID vừa được tạo (ví dụ: 11)
                    int newId = Convert.ToInt32(command.ExecuteScalar());

                    // Bước 2: Cập nhật TenMay chính xác (MAY + ID, ví dụ: MAY11)
                    string newTenMay = "MAY" + newId.ToString("D2"); // D2 để định dạng số 1 thành 01

                    string updateQuery = "UPDATE Computers SET TenMay = @NewTenMay WHERE Id = @Id";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction);
                    updateCommand.Parameters.AddWithValue("@NewTenMay", newTenMay);
                    updateCommand.Parameters.AddWithValue("@Id", newId);
                    updateCommand.ExecuteNonQuery();

                    transaction.Commit(); // Lưu thay đổi
                    MessageBox.Show($"Thêm máy mới {newTenMay} thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Thiết lập kết quả để Form cha có thể kiểm tra và cập nhật
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // Hoàn tác nếu có lỗi
                    MessageBox.Show("Lỗi CSDL khi thêm máy mới: " + ex.Message, "Lỗi DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
