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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    public partial class SuaThongTinMay : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";
        private ComputerData originalData;
        public SuaThongTinMay(ComputerData data)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.originalData = data;
            LoadFormData();
            this.Text = "";
        }
        // drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //
        private void LoadFormData()
        {
            this.Text = $"Sửa thông tin máy: {originalData.TenMay}";

            // Gán dữ liệu vào các TextBox để chỉnh sửa
            textBoxSCPU.Text = originalData.CPU;
            textBoxSGPU.Text = originalData.GPU;
            textBoxSRAM.Text = originalData.RAM;
            textBoxSManHinh.Text = originalData.ManHinh;
            textBoxSGiaMayTrenH.Text = originalData.GiaTheoGio.ToString();
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra đầu vào và chuyển đổi
            if (!decimal.TryParse(textBoxSGiaMayTrenH.Text, out decimal giaMoi))
            {
                MessageBox.Show("Giá máy không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Thực hiện UPDATE CSDL
            string updateQuery = @"
            UPDATE Computers SET 
            CPU = @CPU, GPU = @GPU, RAM = @RAM, ManHinh = @ManHinh, GiaTheoGio = @GiaMoi 
            WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", originalData.Id);
                    command.Parameters.AddWithValue("@CPU", textBoxSCPU.Text.Trim());
                    command.Parameters.AddWithValue("@GPU", textBoxSGPU.Text.Trim());
                    command.Parameters.AddWithValue("@RAM", textBoxSRAM.Text.Trim());
                    command.Parameters.AddWithValue("@ManHinh", textBoxSManHinh.Text.Trim());
                    command.Parameters.AddWithValue("@GiaMoi", giaMoi);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show($"Cập nhật thông tin máy {originalData.TenMay} thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
