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
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            btnHomNay.PerformClick();
        }
        private void LoadDoanhThuData(DateTime fromDate, DateTime toDate)
        {
            decimal doanhThuMay = 0;
            decimal doanhThuDichVu = 0;

            // Cập nhật Query để lọc theo ngày
            string query = @"
        SELECT 
            (SELECT ISNULL(SUM(TongTienThanhToan), 0) FROM SuDungMay 
             WHERE ThoiGianKetThuc BETWEEN @FromDate AND @ToDate) AS TienMay,
             
            (SELECT ISNULL(SUM(TongTien), 0) FROM DonDatMon 
             WHERE TrangThai = N'Đã xong' 
             AND NgayDat BETWEEN @FromDate AND @ToDate) AS TienDichVu";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số ngày giờ
                    command.Parameters.AddWithValue("@FromDate", fromDate);
                    command.Parameters.AddWithValue("@ToDate", toDate);

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

            // Cập nhật Label hiển thị khoảng thời gian (Tùy chọn, để biết đang xem ngày nào)
            // labelTimeRange.Text = $"Từ: {fromDate:dd/MM/yyyy} - Đến: {toDate:dd/MM/yyyy}";

            // Hiển thị lên Label riêng
            labelTienMay.Text = doanhThuMay.ToString("N0") + " đ";
            labelDichVu.Text = doanhThuDichVu.ToString("N0") + " đ";

            // Vẽ lại biểu đồ
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

        private void btnHomNay_Click(object sender, EventArgs e)
        {
            // Từ 00:00:00 hôm nay đến hiện tại
            DateTime today = DateTime.Now.Date; // Lấy 00:00:00
            DateTime endOfDay = DateTime.Now;   // Lấy giờ hiện tại (hoặc today.AddDays(1).AddTicks(-1) cho hết ngày)

            LoadDoanhThuData(today, endOfDay);
        }

        private void btnHomQua_Click(object sender, EventArgs e)
        {
            // Từ 00:00:00 hôm qua đến 23:59:59 hôm qua
            DateTime yesterdayStart = DateTime.Now.Date.AddDays(-1);
            DateTime yesterdayEnd = DateTime.Now.Date.AddTicks(-1); // 23:59:59 hôm qua

            LoadDoanhThuData(yesterdayStart, yesterdayEnd);
        }

        private void btnBayNgay_Click(object sender, EventArgs e)
        {
            DateTime sevenDaysAgo = DateTime.Now.Date.AddDays(-6); // 6 ngày trước + hôm nay = 7 ngày
            DateTime now = DateTime.Now;

            LoadDoanhThuData(sevenDaysAgo, now);
        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            // Cách 1: Lấy từ đầu tháng này
            DateTime startOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime now = DateTime.Now;

            // Cách 2: Lấy 30 ngày gần nhất (dùng cách này nếu muốn xem xu hướng)
            // DateTime startOf30Days = DateTime.Now.Date.AddDays(-29);

            LoadDoanhThuData(startOfMonth, now);
        }
    }
}
