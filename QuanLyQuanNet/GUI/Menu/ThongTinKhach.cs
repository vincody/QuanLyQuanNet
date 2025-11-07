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

namespace QuanLyQuanNet.GUI.Menu
{
    public partial class ThongTinKhach : Form
    {
        private Form menuKhachFormInstance;
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";
        public ThongTinKhach()
        {
            InitializeComponent();
            // Ẩn nút Minimize (Thu nhỏ)
            this.MinimizeBox = false;

            // Ẩn nút Maximize (Phóng to)
            this.MaximizeBox = false;
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
    }
}
