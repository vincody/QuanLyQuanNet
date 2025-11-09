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
            textBoxSoDu.Text = UserSession.SoDu.ToString("N0") + " VND";

            // 3. Hiển thị Giá máy hiện tại
            textBoxGiaMay.Text = UserSession.GiaTheoGio.ToString("N0") + " VND/h";

            // 4. Tính Tổng Thời Gian (hh:mm)
            // Công thức: Tổng thời gian = (Số dư / Giá/Giờ)
            if (UserSession.SoDu > 0 && UserSession.GiaTheoGio > 0)
            {
                // Tính số giờ chơi (decimal)
                decimal tongSoGio = UserSession.SoDu / UserSession.GiaTheoGio;

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
            // Sử dụng biến thoiGianDangNhap đã lưu
            TimeSpan thoiGianSuDung = DateTime.Now.Subtract(thoiGianDangNhap);

            // 2. Tính Thời gian còn lại (TGCL)
            TimeSpan thoiGianConLai = tongThoiGianChoi.Subtract(thoiGianSuDung);

            // 3. Định dạng và Hiển thị
            // Hiển thị TGSD (Chỉ lấy giờ và phút)
            textBoxTGSD.Text = ((int)thoiGianSuDung.TotalHours).ToString("D2") + ":" + thoiGianSuDung.Minutes.ToString("D2");

            // Hiển thị TGCL
            if (thoiGianConLai.TotalSeconds > 0)
            {
                // Hiển thị TGCL (Chỉ lấy giờ và phút)
                textBoxTGCL.Text = ((int)thoiGianConLai.TotalHours).ToString("D2") + ":" + thoiGianConLai.Minutes.ToString("D2");
            }
            else // Hết giờ chơi
            {
                textBoxTGCL.Text = "00:00";
                capNhatTimer.Stop(); // Dừng Timer
                MessageBox.Show("Tài khoản của bạn đã hết giờ chơi!", "Hết giờ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Tùy chọn: Gọi logic đăng xuất tự động (nếu có)
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
            string tenMayDangSuDung = UserSession.TenMay;
            string tenDangNhap = UserSession.TenDangNhap;

            if (string.IsNullOrEmpty(tenMayDangSuDung))
            {
                MessageBox.Show("Không tìm thấy thông tin máy đang sử dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Bắt đầu giao dịch để đảm bảo cả 2 UPDATE/INSERT đều thành công
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // === BƯỚC 1: CẬP NHẬT TRẠNG THÁI MÁY VỀ AVAILABLE (Bảng Computers) ===
                        string queryUpdateMay = "UPDATE Computers SET TinhTrang = 'Available' WHERE TenMay = @TenMay AND TinhTrang = 'Busy'";
                        using (SqlCommand cmdUpdateMay = new SqlCommand(queryUpdateMay, connection, transaction))
                        {
                            cmdUpdateMay.Parameters.AddWithValue("@TenMay", tenMayDangSuDung);
                            cmdUpdateMay.ExecuteNonQuery();
                        }

                        // === BƯỚC 2: GHI NHẬN THỜI GIAN KẾT THÚC (Bảng SuDungMay) ===
                        // Cập nhật phiên sử dụng đang hoạt động (ThoiGianKetThuc IS NULL)
                        // Tùy chọn: Bạn có thể tính toán và cập nhật TongTienThanhToan tại đây
                        string queryUpdateSuDung = @"
                        UPDATE SuDungMay 
                        SET ThoiGianKetThuc = GETDATE()
                        -- Tùy chọn: SET TongTienThanhToan = TinhTien(ThoiGianBatDau, GETDATE(), GiaTheoGio)
                        WHERE TenMay = @TenMay AND TenDangNhap = @TenDN AND ThoiGianKetThuc IS NULL";

                        using (SqlCommand cmdUpdateSuDung = new SqlCommand(queryUpdateSuDung, connection, transaction))
                        {
                            cmdUpdateSuDung.Parameters.AddWithValue("@TenMay", tenMayDangSuDung);
                            cmdUpdateSuDung.Parameters.AddWithValue("@TenDN", tenDangNhap);
                            cmdUpdateSuDung.ExecuteNonQuery();
                        }

                        // Hoàn tất Transaction
                        transaction.Commit();

                        // Xóa Session và Đóng Form
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

        private void labelSoDu_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            // Tạo và hiển thị Form đổi mật khẩu
            DoiMK doiMKForm = new DoiMK();
            doiMKForm.ShowDialog(); // Dùng ShowDialog để ngăn người dùng thao tác với Form cha
        }
    }
}
