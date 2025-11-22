using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;
using PayOS.Models.V2.PaymentRequests; // Namespace V2
using Microsoft.Web.WebView2.Core;     // Cần thiết cho WebView2

namespace QuanLyQuanNet.GUI.FormNgoai.FormKhach
{
    public partial class XacNhanChuyenKhoan : Form
    {
        private decimal soTienCanNap;
        private long currentOrderCode = 0;
        private System.Windows.Forms.Timer paymentCheckTimer;
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";

        public XacNhanChuyenKhoan(decimal soTien)
        {
            InitializeComponent();
            this.soTienCanNap = soTien;

            paymentCheckTimer = new System.Windows.Forms.Timer();
            paymentCheckTimer.Interval = 2000; // Kiểm tra mỗi 2 giây
            paymentCheckTimer.Tick += PaymentCheckTimer_Tick;
        }

        private async void XacNhanChuyenKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo WebView2 trước
                await webViewPayOS.EnsureCoreWebView2Async();

                string description = $"NAP {UserSession.TenDangNhap}";
                int amountInt = (int)soTienCanNap;

                // 1. Gọi PayOS tạo link
                CreatePaymentLinkResponse result = await PayOsService.CreatePaymentLink(amountInt, description, UserSession.TenDangNhap);

                currentOrderCode = result.OrderCode;
                this.Text = $"Thanh toán đơn: {currentOrderCode}";

                // 2. HIỂN THỊ TRANG THANH TOÁN TRÊN WEBVIEW
                // result.checkoutUrl chính là đường link trang web như trong ảnh bạn gửi
                if (!string.IsNullOrEmpty(result.CheckoutUrl))
                {
                    webViewPayOS.CoreWebView2.Navigate(result.CheckoutUrl);
                }
                else
                {
                    MessageBox.Show("Không lấy được link thanh toán.");
                }

                // 3. Bắt đầu Timer kiểm tra ngầm (Vẫn cần thiết để cộng tiền vào DB)
                paymentCheckTimer.Start();
            }
            catch (Exception ex)
            {
                paymentCheckTimer.Stop();
                MessageBox.Show("Lỗi khởi tạo: " + ex.Message, "Lỗi PayOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // Sự kiện Timer: Hỏi PayOS xem khách đã thanh toán trên trang web chưa
        private async void PaymentCheckTimer_Tick(object sender, EventArgs e)
        {
            if (currentOrderCode == 0) return;

            try
            {
                PaymentLink info = await PayOsService.GetPaymentInfo(currentOrderCode);

                if (info.Status == PaymentLinkStatus.Paid)
                {
                    paymentCheckTimer.Stop();

                    // Cộng tiền vào Database
                    CongTienVaoDatabase(UserSession.TenDangNhap, soTienCanNap);

                    // Cập nhật Session và UI chính
                    UserSession.SoDu += soTienCanNap;
                    RefreshMainFormBalance(UserSession.SoDu);

                    // Thông báo và đóng
                    MessageBox.Show($"Nạp thành công {soTienCanNap:N0} VNĐ!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (info.Status == PaymentLinkStatus.Cancelled || info.Status == PaymentLinkStatus.Expired)
                {
                    paymentCheckTimer.Stop();
                    MessageBox.Show("Giao dịch đã bị hủy hoặc hết hạn.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            catch
            {
                // Bỏ qua lỗi mạng
            }
        }

        // ... (Các hàm CongTienVaoDatabase, RefreshMainFormBalance giữ nguyên như cũ) ...

        // Hàm cập nhật CSDL (Copy lại để đảm bảo đủ code)
        private void CongTienVaoDatabase(string tenDangNhap, decimal soTien)
        {
            string query = "UPDATE TaiKhoan SET SoDu = SoDu + @SoTien WHERE TenDangNhap = @TenDN";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SoTien", soTien);
                        cmd.Parameters.AddWithValue("@TenDN", tenDangNhap);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi cập nhật CSDL: " + ex.Message); }
            }
        }

        private void RefreshMainFormBalance(decimal newBalance)
        {
            // Lặp qua tất cả các Form đang mở của ứng dụng
            foreach (Form f in Application.OpenForms)
            {
                // Kiểm tra xem Form đó có phải là ThongTinKhach không
                // Lưu ý: Đảm bảo namespace 'QuanLyQuanNet.GUI.Menu' là chính xác
                if (f is QuanLyQuanNet.GUI.Menu.ThongTinKhach thongTinForm)
                {
                    // Gọi hàm cập nhật công khai bên ThongTinKhach
                    // Hàm này sẽ gán lại initialSoDu, UserSession và cập nhật labelHienThiSoDu
                    thongTinForm.RefreshBalanceAfterOrder(newBalance);

                    // Thoát vòng lặp vì chỉ có 1 Form thông tin khách
                    break;
                }
            }
        }

        private void XacNhanChuyenKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (paymentCheckTimer != null) paymentCheckTimer.Stop();
            // Giải phóng WebView2 nếu cần
            webViewPayOS.Dispose();
        }
    }
}