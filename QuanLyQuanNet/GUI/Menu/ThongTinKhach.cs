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
            // 1. Gán Giờ Đăng Nhập (theo yêu cầu)
            thoiGianDangNhap = DateTime.Now; // <<< LƯU THỜI ĐIỂM HIỆN TẠI
            textBoxGDN.Text = thoiGianDangNhap.ToString("HH:mm:ss dd/MM/yyyy");

            // 2. Hiển thị Số dư tài khoản
            // Sử dụng định dạng tiền tệ (C0) hoặc tùy chỉnh (N0)
            initialSoDu = UserSession.SoDu; // <<< LƯU SỐ DƯ BAN ĐẦU
            textBoxSoDu.Text = UserSession.SoDu.ToString("N0") + " VND";

            // 3. Hiển thị Giá máy hiện tại
            textBoxGiaMay.Text = UserSession.GiaTheoGio.ToString("N0") + " VND/h";

            // 4. Tính Tổng Thời Gian (hh:mm)
            // Công thức: Tổng thời gian = (Số dư / Giá/Giờ)
            if (UserSession.SoDu > 0 && UserSession.GiaTheoGio > 0)
            {
                // Tính số giờ chơi (decimal)
                decimal tongSoGio = initialSoDu / UserSession.GiaTheoGio;

                // Chuyển thành TimeSpan
                tongThoiGianChoi = TimeSpan.FromHours((double)tongSoGio);

                // Hiển thị Tổng Thời Gian có thể chơi (hh:mm)
                textBoxTTG.Text = ((int)tongThoiGianChoi.TotalHours).ToString("D2") + ":" + tongThoiGianChoi.Minutes.ToString("D2");
            }
            else
            {
                textBoxTTG.Text = "00:00";
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

            // === BỔ SUNG LOGIC TÍNH VÀ TRỪ TIỀN ===
            decimal giaTheoGio = UserSession.GiaTheoGio;

            // Tính tổng chi phí dựa trên tổng số giờ (TotalHours là decimal) đã sử dụng
            decimal tongChiPhi = (decimal)thoiGianSuDung.TotalHours * giaTheoGio;

            // Số dư còn lại: Số dư ban đầu - Tổng chi phí
            decimal soDuConLai = initialSoDu - tongChiPhi;

            // Cập nhật UserSession.SoDu (client-side) và hiển thị
            UserSession.SoDu = soDuConLai;
            textBoxSoDu.Text = soDuConLai.ToString("N0") + " VND";
            // ========================================

            // 2. Tính Thời gian còn lại (TGCL)
            TimeSpan thoiGianConLai = tongThoiGianChoi.Subtract(thoiGianSuDung);

            // 3. Định dạng và Hiển thị
            // Thêm hiển thị giây để chính xác hơn
            textBoxTGSD.Text = thoiGianSuDung.ToString(@"hh\:mm\:ss");

            // Kiểm tra hết tiền/hết giờ
            if (soDuConLai <= 0) // Hết tiền trước
            {
                thoiGianConLai = TimeSpan.Zero;
                textBoxTGCL.Text = "00:00:00";
                capNhatTimer.Stop();

                textBoxSoDu.Text = 0.ToString("N0") + " VND"; // Hiển thị 0 VND

                // Tự động xử lý đăng xuất khi hết tiền
                MessageBox.Show("Tài khoản của bạn đã hết tiền/hết giờ chơi!", "Hết giờ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnDangXuat_Click(sender, e); // Tự động gọi đăng xuất để cập nhật CSDL
            }
            else if (thoiGianConLai.TotalSeconds > 0)
            {
                // Hiển thị TGCL
                textBoxTGCL.Text = thoiGianConLai.ToString(@"hh\:mm\:ss");
            }
            else // Trường hợp hết giờ (Nếu có lỗi tính toán)
            {
                textBoxTGCL.Text = "00:00:00";
                capNhatTimer.Stop();
                MessageBox.Show("Tài khoản của bạn đã hết giờ chơi!", "Hết giờ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public ThongTinKhach(string tenNguoiDung, string tenMaySuDung, Form menuKhachForm)
        {
            InitializeComponent();
            // Gán tham chiếu của MenuKhach
            this.menuKhachFormInstance = menuKhachForm;
            // 1. Cập nhật Label (labelTenUser)
            labelTenUser.Text = tenNguoiDung;

            // 2. Cập nhật Tiêu đề Form (Text)
            this.Text = tenMaySuDung; // Sửa Text của Form thành tên máy
            SetupThongTinMay(); // <<< PHẢI CÓ DÒNG NÀY
            SetupTimer();
            // 3. Tùy chọn: Ẩn nút nếu cần (như yêu cầu trước)
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
        public void RefreshBalanceAfterOrder(decimal newSoDu)
        {
            // 1. Dừng timer cũ
            if (capNhatTimer != null && capNhatTimer.Enabled)
            {
                capNhatTimer.Stop();
            }

            // 2. Cập nhật initialSoDu và UserSession
            initialSoDu = newSoDu;
            UserSession.SoDu = newSoDu;

            // 3. Chạy lại logic thiết lập thông tin (tính Tổng Thời Gian Chơi mới)
            SetupThongTinMay();

            // 4. Khởi động lại Timer
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
    }
}
