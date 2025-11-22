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
using QuanLyQuanNet.GUI.FormNgoai.FormKhach;

namespace QuanLyQuanNet.GUI.Menu
{
    public partial class ThongTinKhach : Form
    {
        private Form menuKhachFormInstance;
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";
        //
        private DateTime thoiGianDangNhap;         // Lưu thời điểm hiện tại khi Form mở
        private System.Windows.Forms.Timer capNhatTimer;
        private TimeSpan tongThoiGianChoi;
        private decimal initialSoDu; // <<< BỔ SUNG: Lưu số dư ban đầu để tính toán trừ tiền
        public ThongTinKhach()
        {
            InitializeComponent();
            // Ẩn nút Minimize (Thu nhỏ)
            this.MinimizeBox = false;

            // Ẩn nút Maximize (Phóng to)
            this.MaximizeBox = false;
        }
        private void SetupThongTinMay()
        {
            // 1. LƯU GIỜ ĐĂNG NHẬP
            thoiGianDangNhap = DateTime.Now;

            // 2. HIỂN THỊ SỐ DƯ & GIÁ MÁY
            initialSoDu = UserSession.SoDu;
            textBoxSoDu.Text = initialSoDu.ToString("N0") + " VND"; // Hiển thị số dư ban đầu
            textBoxGiaMay.Text = UserSession.GiaTheoGio.ToString("N0") + " VND/h"; // Hiển thị Giá máy

            // 3. TÍNH TỔNG THỜI GIAN CÓ THỂ CHƠI (Vẫn cần để tính countdown)
            if (UserSession.SoDu > 0 && UserSession.GiaTheoGio > 0)
            {
                decimal tongSoGio = initialSoDu / UserSession.GiaTheoGio;
                tongThoiGianChoi = TimeSpan.FromHours((double)tongSoGio);
            }
            else
            {
                tongThoiGianChoi = TimeSpan.Zero;
            }
        }
        private void SetupTimer()
        {
            capNhatTimer = new System.Windows.Forms.Timer();
            capNhatTimer.Interval = 1000; // Cập nhật mỗi 1 giây
            capNhatTimer.Tick += CapNhatThoiGian;
            capNhatTimer.Start();
        }
        private void CapNhatThoiGian(object sender, EventArgs e)
        {
            // 1. Tính Thời gian sử dụng (TGSD)
            TimeSpan thoiGianSuDung = DateTime.Now.Subtract(thoiGianDangNhap);

            // === BỔ SUNG LOGIC TÍNH VÀ TRỪ TIỀN (Giữ nguyên) ===
            decimal giaTheoGio = UserSession.GiaTheoGio;
            decimal tongChiPhi = (decimal)thoiGianSuDung.TotalHours * giaTheoGio;
            decimal soDuConLai = initialSoDu - tongChiPhi;

            // Cập nhật hiển thị Số Dư
            UserSession.SoDu = soDuConLai;
            textBoxSoDu.Text = soDuConLai.ToString("N0") + " VND";
            // ========================================

            // 2. Tính Thời gian còn lại (TGCL)
            TimeSpan thoiGianConLai = tongThoiGianChoi.Subtract(thoiGianSuDung);
            // 4. Kiểm tra hết tiền/hết giờ
            if (soDuConLai <= 0) // Hết tiền trước
            {
                // Cập nhật TGCL và SoDu về 0 và dừng
                ThoiGianConLai.Text = "00:00"; // ✅ FIX: Gán vào Label với format hh:mm

                capNhatTimer.Stop();
                textBoxSoDu.Text = 0.ToString("N0") + " VND";

                MessageBox.Show("Tài khoản của bạn đã hết tiền/hết giờ chơi!", "Hết giờ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnDangXuat_Click(sender, e);
            }
            else if (thoiGianConLai.TotalSeconds > 0)
            {
                // ✅ FIX: Gán vào Label với format hh:mm (Loại bỏ giây)
                ThoiGianConLai.Text = thoiGianConLai.ToString(@"hh\:mm");
            }
            else // Trường hợp hết giờ
            {
                ThoiGianConLai.Text = "00:00"; // ✅ FIX: Gán vào Label
                capNhatTimer.Stop();
                MessageBox.Show("Tài khoản của bạn đã hết giờ chơi!", "Hết giờ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Constructor được sử dụng để khởi tạo Form
        public ThongTinKhach(string tenNguoiDung, string tenMaySuDung, Form menuKhachForm)
        {
            InitializeComponent();
            this.menuKhachFormInstance = menuKhachForm;
            labelTenUser.Text = tenNguoiDung;
            this.Text = tenMaySuDung;
            SetupThongTinMay();
            SetupTimer();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            // Đảm bảo timer đã dừng để có số liệu chính xác cuối cùng
            if (capNhatTimer != null)
            {
                capNhatTimer.Stop();
            }

            // 1. TÍNH TOÁN CHI PHÍ CUỐI CÙNG VÀ SỐ DƯ MỚI
            TimeSpan thoiGianSuDung = DateTime.Now.Subtract(thoiGianDangNhap);
            decimal tongChiPhiDaSuDung = (decimal)thoiGianSuDung.TotalHours * UserSession.GiaTheoGio;

            // Số dư cuối cùng (Số dư ban đầu - Chi phí đã dùng)
            decimal soDuMoi = initialSoDu - tongChiPhiDaSuDung;

            // Đảm bảo số dư mới không âm (trường hợp khách hàng đã hết tiền hoặc có sai lệch)
            if (soDuMoi < 0)
            {
                // Nếu số dư âm, chi phí thực tế bằng số dư ban đầu, và số dư mới là 0
                tongChiPhiDaSuDung = initialSoDu;
                soDuMoi = 0;
            }

            // Cập nhật UserSession.SoDu để client-side có giá trị mới
            UserSession.SoDu = soDuMoi;

            string tenMayDangSuDung = UserSession.TenMay;
            string tenDangNhap = UserSession.TenDangNhap;

            if (string.IsNullOrEmpty(tenMayDangSuDung))
            {
                MessageBox.Show("Không tìm thấy thông tin máy đang sử dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Bắt đầu giao dịch để đảm bảo cả 3 UPDATE đều thành công
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // === BƯỚC 1: CẬP NHẬT TRẠNG THÁI MÁY VỀ AVAILABLE (Bảng Computers) ===
                        string queryUpdateMay = "UPDATE Computers SET TinhTrang = N'Available' WHERE TenMay = @TenMay AND TinhTrang = N'Busy'";
                        using (SqlCommand cmdUpdateMay = new SqlCommand(queryUpdateMay, connection, transaction))
                        {
                            cmdUpdateMay.Parameters.AddWithValue("@TenMay", tenMayDangSuDung);
                            cmdUpdateMay.ExecuteNonQuery();
                        }

                        // === BƯỚC 2: CẬP NHẬT SỐ DƯ TÀI KHOẢN (Bảng TaiKhoan) ===
                        string queryUpdateSoDu = "UPDATE TaiKhoan SET SoDu = @SoDuMoi WHERE TenDangNhap = @TenDN";
                        using (SqlCommand cmdUpdateSoDu = new SqlCommand(queryUpdateSoDu, connection, transaction))
                        {
                            cmdUpdateSoDu.Parameters.AddWithValue("@SoDuMoi", soDuMoi);
                            cmdUpdateSoDu.Parameters.AddWithValue("@TenDN", tenDangNhap);
                            cmdUpdateSoDu.ExecuteNonQuery();
                        }

                        // === BƯỚC 3: GHI NHẬN THỜI GIAN KẾT THÚC VÀ TỔNG CHI PHÍ (Bảng SuDungMay) ===
                        string queryUpdateSuDung = @"
                UPDATE SuDungMay 
                SET ThoiGianKetThuc = GETDATE(),
                    TongTienThanhToan = @TongChiPhi
                WHERE TenMay = @TenMay AND TenDangNhap = @TenDN AND ThoiGianKetThuc IS NULL";

                        using (SqlCommand cmdUpdateSuDung = new SqlCommand(queryUpdateSuDung, connection, transaction))
                        {
                            cmdUpdateSuDung.Parameters.AddWithValue("@TenMay", tenMayDangSuDung);
                            cmdUpdateSuDung.Parameters.AddWithValue("@TenDN", tenDangNhap);
                            cmdUpdateSuDung.Parameters.AddWithValue("@TongChiPhi", tongChiPhiDaSuDung); // <<< Ghi nhận chi phí
                            cmdUpdateSuDung.ExecuteNonQuery();
                        }

                        // Hoàn tất Transaction
                        transaction.Commit();

                        // Xóa Session và Đóng Form
                        UserSession.ClearSession(); // <<< Phải có hàm này để dọn dẹp Session
                        if (menuKhachFormInstance != null)
                        {
                            menuKhachFormInstance.Close();
                        }
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi giao dịch khi trả máy: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Hàm RefreshBalanceAfterOrder (Giữ nguyên logic)
        public void RefreshBalanceAfterOrder(decimal newSoDu)
        {
            if (capNhatTimer != null && capNhatTimer.Enabled)
            {
                capNhatTimer.Stop();
            }
            initialSoDu = newSoDu;
            UserSession.SoDu = newSoDu;
            SetupThongTinMay();
            SetupTimer();
        }
        private void labelSoDu_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            // Tạo và hiển thị Form đổi mật khẩu
            DoiMK doiMKForm = new DoiMK();
            doiMKForm.ShowDialog(); // Dùng ShowDialog để ngăn người dùng thao tác với Form cha
        }

        private void btnTinNhan_Click(object sender, EventArgs e)
        {
            // Kiểm tra Admin có sẵn sàng không
            if (!TemporaryChatManager.IsAdminReady)
            {
                MessageBox.Show("Quản lý đang bận, vui lòng thử lại sau vài phút", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mở Form chat, truyền tên máy và tên đăng nhập
            GiaoTiepKH chatForm = new GiaoTiepKH(UserSession.TenMay, UserSession.TenDangNhap);
            chatForm.Show();
        }

        private void btnNapTien_Click(object sender, EventArgs e)
        {
            NapTien napTienForm = new NapTien();
            napTienForm.ShowDialog();
        }
    }
}
