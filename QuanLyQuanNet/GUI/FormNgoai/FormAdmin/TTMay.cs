using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanNet.GUI.ThongTinMay;

namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    public partial class TTMay : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";
        public TTMay()
        {
            InitializeComponent();
            labelMayHT.Visible = false;
        }
        // Hàm này nên được gọi khi Form TTMay Load
        private void LoadComputerStatus()
        {
            // Xóa controls cũ trước khi tải lại
            flowPanelMayTinh.Controls.Clear();

            string query = "SELECT Id, TenMay, GiaTheoGio, TinhTrang, CPU, GPU, RAM, ManHinh FROM Computers ORDER BY Id ASC";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string tenMay = reader["TenMay"].ToString();
                            string tinhTrang = reader["TinhTrang"].ToString();

                            // 1. Tạo instance của User Control TTMayTinh
                            // Đảm bảo bạn đã thêm 'using' cho namespace của TTMayTinh
                            TTMayTinh ucControl = new TTMayTinh(); // <<< ĐÃ ĐỔI TÊN

                            // 2. Chuyển đổi tên máy ("MAY01" -> "Máy số 1")
                            string maySo = ExtractMachineNumber(tenMay);

                            // 3. Gán giá trị và đổi màu
                            // labelMaySo phải được sửa Modifiers thành Public trong TTMayTinh.cs
                            ucControl.labelMaySo.Text = $"Máy số {maySo}";
                            ucControl.BackColor = GetBackColor(tinhTrang);
                            ucControl.ForeColor = Color.White;

                            // Tùy chọn: Lưu TenMay vào Tag
                            ucControl.Tag = tenMay;
                            ucControl.Click += TTMayTinh_Click;
                            // Cần gán sự kiện cho các controls con để click vào bất cứ đâu đều hoạt động
                            foreach (Control c in ucControl.Controls)
                            {
                                c.Click += TTMayTinh_Click;
                            }

                            flowPanelMayTinh.Controls.Add(ucControl);

                            // 4. Thêm control vào FlowLayoutPanel
                            flowPanelMayTinh.Controls.Add(ucControl);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi tải trạng thái máy: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // ====================================================================
        // II. HÀM HỖ TRỢ LOGIC
        // ====================================================================

        /// <summary>
        /// Trích xuất số từ chuỗi "MAYXX".
        /// </summary>
        private string ExtractMachineNumber(string tenMay)
        {
            // Sử dụng Regex để tìm bất kỳ chữ số nào và trả về
            Match match = Regex.Match(tenMay, @"\d+");
            return match.Success ? int.Parse(match.Value).ToString() : "?"; // Loại bỏ số 0 ở đầu (nếu có)
        }

        /// <summary>
        /// Trả về màu nền dựa trên trạng thái.
        /// </summary>
        private Color GetBackColor(string tinhTrang)
        {
            if (tinhTrang.Equals("Available", StringComparison.OrdinalIgnoreCase))
            {
                return Color.SeaGreen; // Màu xanh lá cho Available
            }
            else if (tinhTrang.Equals("Busy", StringComparison.OrdinalIgnoreCase))
            {
                return Color.Maroon; // Màu đỏ sẫm cho Busy
            }
            else
            {
                return Color.Gray; // Màu mặc định cho trạng thái khác (Maintenance, v.v.)
            }
        }

        // Bạn cần gọi hàm LoadComputerStatus() trong sự kiện Form_Load của TTMay
        private void TTMay_Load(object sender, EventArgs e)
        {
            LoadComputerStatus();
        }
        private void TTMayTinh_Click(object sender, EventArgs e)
        {
            // 1. Lấy Control cha (TTMayTinh) từ control được click
            Control clickedControl = sender as Control;
            if (clickedControl == null) return;

            TTMayTinh mayControl = clickedControl as TTMayTinh;
            if (mayControl == null)
            {
                // Nếu click vào control con (Label), tìm UserControl cha
                mayControl = clickedControl.Parent as TTMayTinh;
            }

            if (mayControl?.Tag == null) return;

            string tenMayChon = mayControl.Tag.ToString();
            // ✅ HIỆN LABEL
            labelMayHT.Visible = true;

            // 2. Tải thông tin chi tiết vào các TextBox
            LoadDetailInfo(tenMayChon);
        }
        private void LoadDetailInfo(string tenMay)
        {
            // Cập nhật Label máy hiện tại
            labelMayHT.Text = tenMay;

            string query = "SELECT GiaTheoGio, CPU, GPU, RAM, ManHinh FROM Computers WHERE TenMay = @TenMay";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenMay", tenMay);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            // ✅ SỬA LỖI: Đọc dữ liệu dưới dạng DECIMAL (hoặc string)
                            decimal giaTheoGio = reader.GetDecimal(reader.GetOrdinal("GiaTheoGio"));

                            // ✅ HIỂN THỊ GIÁ VÀO TEXTBOX MỚI
                            // Định dạng giá trị để hiển thị (ví dụ: 15.000)
                            textBoxGiaMayTrenH.Text = giaTheoGio.ToString("N0", new System.Globalization.CultureInfo("vi-VN"));

                            // Gán thông tin cấu hình cũ (giữ nguyên logic cũ)
                            textBoxCPU.Text = reader["CPU"].ToString();
                            textBoxGPU.Text = reader["GPU"].ToString();
                            textBoxRAM.Text = reader["RAM"].ToString();
                            textBoxManHinh.Text = reader["ManHinh"].ToString();
                        }
                        else
                        {
                            // Trường hợp không tìm thấy máy (Xóa nội dung cũ)
                            textBoxCPU.Text = "";
                            textBoxGPU.Text = "";
                            textBoxRAM.Text = "";
                            textBoxManHinh.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi truy vấn chi tiết máy: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
