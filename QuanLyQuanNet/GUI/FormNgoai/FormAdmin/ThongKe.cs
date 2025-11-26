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
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    public partial class ThongKe : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            LoadDoanhThuData();
        }
        private void LoadDoanhThuData()
        {
            decimal doanhThuMay = 0;
            decimal doanhThuDichVu = 0;

            // 1. Truy vấn Tổng hợp Doanh thu
            // Sử dụng ISNULL để tránh lỗi nếu bảng trống
            string query = @"
                SELECT 
                    (SELECT ISNULL(SUM(TongTienThanhToan), 0) FROM SuDungMay WHERE ThoiGianKetThuc IS NOT NULL) AS TienMay,
                    (SELECT ISNULL(SUM(TongTien), 0) FROM DonDatMon WHERE TrangThai = N'Đã xong') AS TienDichVu";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            doanhThuMay = reader.GetDecimal(reader.GetOrdinal("TienMay"));
                            doanhThuDichVu = reader.GetDecimal(reader.GetOrdinal("TienDichVu"));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi tải dữ liệu thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            // 2. HIỂN THỊ LÊN LABEL RIÊNG (THAY VÌ TRÊN CHART)
            labelTienMay.Text = doanhThuMay.ToString("N0") + " đ"; // Ví dụ: 1,500,000 đ
            labelDichVu.Text = doanhThuDichVu.ToString("N0") + " đ";

            // 2. Vẽ biểu đồ với dữ liệu vừa lấy
            DrawPieChart(doanhThuMay, doanhThuDichVu);
        }
        // Hàm vẽ biểu đồ (Gọi hàm này sau khi đã lấy dữ liệu thống kê)
        private void DrawPieChart(decimal tienGioChoi, decimal tienDichVu, decimal tienKhac = 0)
        {
            // 1. Xóa dữ liệu cũ
            chartDoanhThu.Series.Clear();
            chartDoanhThu.Legends.Clear();
            chartDoanhThu.Titles.Clear();

            // 2. Tạo Series mới
            Series series = new Series("DoanhThu");
            series.ChartType = SeriesChartType.Doughnut;

            // --- CẤU HÌNH HIỂN THỊ ---

            // Hiển thị % trên biểu đồ
            series.IsValueShownAsLabel = true;
            series.Label = "#PERCENT{P1}";
            series.LabelForeColor = Color.White;
            series.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            series.ToolTip = "#AXISLABEL: #VAL{N0} đ";

            // ✅ QUAN TRỌNG: Cấu hình để Legend hiển thị Tên thay vì Số liệu
            // #AXISLABEL đại diện cho giá trị trục X ("Thuê máy", "Dịch vụ"...)
            series.LegendText = "#AXISLABEL";

            // 3. Thêm dữ liệu vào Series
            // Điểm 1: Thuê máy
            int index1 = series.Points.AddXY("Thuê máy", tienGioChoi);
            series.Points[index1].Color = Color.Orange;
            // Bạn cũng có thể gán cứng LegendText tại đây nếu muốn chắc chắn hơn:
            // series.Points[index1].LegendText = "Thuê máy"; 

            // Điểm 2: Dịch vụ
            int index2 = series.Points.AddXY("Dịch vụ", tienDichVu);
            series.Points[index2].Color = Color.CornflowerBlue;

            // Điểm 3: Khác (nếu có)
            if (tienKhac > 0)
            {
                int index3 = series.Points.AddXY("Khác", tienKhac);
                series.Points[index3].Color = Color.LightGreen;
            }

            // 4. Thêm Series vào Chart
            chartDoanhThu.Series.Add(series);

            // 5. Thêm Legend (Chú giải)
            Legend legend = new Legend("Legend1");
            legend.Docking = Docking.Bottom;
            legend.Alignment = StringAlignment.Center;
            // Tùy chỉnh font cho Legend nếu cần
            legend.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            chartDoanhThu.Legends.Add(legend);

            // 6. Hiển thị Tổng doanh thu ở giữa
            decimal tongDoanhThu = tienGioChoi + tienDichVu + tienKhac;
            if (labelTongDoanhThuGiua != null)
            {
                labelTongDoanhThuGiua.Text = $"Tổng doanh thu\n{tongDoanhThu:N0} đ";
            }
            // ✅ BỔ SUNG: Cập nhật Label Doanh Thu riêng ở chỗ khác
            if (labelDoanhThu != null)
            {
                // Hiển thị số tiền với định dạng phân cách hàng nghìn
                labelDoanhThu.Text = $"{tongDoanhThu:N0} đ";
            }
        }
    }
}
