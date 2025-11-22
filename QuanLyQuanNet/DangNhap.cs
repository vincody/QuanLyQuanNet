using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Transactions;
using System.Drawing; // Thêm using System.Drawing cho Point
using System.Windows.Forms; // Thêm using System.Windows.Forms
using System.Linq; // Thêm using System.Linq

// ... các using khác ...
using QuanLyQuanNet.GUI.Menu;
// Thêm using cho class UserSession nếu nó ở namespace khác
// Ví dụ: using QuanLyQuanNet.Utils; 

namespace QuanLyQuanNet
{
    public partial class DangNhap : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";
        public DangNhap()
        {
            InitializeComponent();
            // Thiết lập thuộc tính UseSystemPasswordChar cho TextBox mật khẩu
            txtMatKhau.UseSystemPasswordChar = true;
            this.Text = "";
            this.ControlBox = false;
        }
        // drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            // ⚠️ Lưu ý bảo mật: Hãy nhớ triển khai hàm BĂM MẬT KHẨU thực tế!
            // Ví dụ: string matKhauDaBam = HashFunction(matKhau); 

            // Hàm KiemTraDangNhap đã được sửa để vừa kiểm tra và vừa lưu thông tin session.
            if (KiemTraVaTaoSession(tenDangNhap, matKhau))
            {
                // Đăng nhập thành công

                // 2. Chuyển sang Form MenuQN (Admin/Nhân viên) hoặc MenuKhach (Khách)
                if (UserSession.IsAdmin || UserSession.IsNhanVien)
                {
                    // Chuyển đến Menu chính cho Quản lý / Nhân viên
                    MenuQN menuForm = new MenuQN();
                    menuForm.Show();
                }
                else if (UserSession.IsKhach)
                {
                    // Chuyển đến Menu cho Khách
                    // Giả sử bạn có Form tên là MenuKhach

                    ThongTinKhach formThongTin = new ThongTinKhach(
                        UserSession.TenDangNhap, // Giá trị cho labelTenUser
                        UserSession.TenMay,      // Giá trị cho tiêu đề Form
                        null                     // Truyền null hoặc một instance của Form menuKhachForm nếu có
                    );
                    // =============================================================
                    // *** ĐIỀU CHỈNH VỊ TRÍ FORM MỚI (ThongTinKhach) ***

                    // 1. Đảm bảo Form không tự động canh giữa
                    formThongTin.StartPosition = FormStartPosition.Manual;

                    // 2. Lấy kích thước màn hình
                    int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
                    // int screenHeight = Screen.PrimaryScreen.WorkingArea.Height; // Không cần thiết

                    // 3. Tính toán vị trí X và Y (góc trên bên phải)
                    // X = Chiều rộng màn hình - Chiều rộng của Form ThongTinKhach
                    int x = screenWidth - formThongTin.Width;
                    // Y = 0 (cho góc trên cùng)
                    int y = 0;

                    // Nếu bạn muốn có một khoảng lề nhỏ (ví dụ 10 pixels):
                    // int x = screenWidth - formThongTin.Width - 10;
                    // int y = 10;

                    // 4. Thiết lập vị trí
                    formThongTin.Location = new Point(x, y);

                    // 5. Hiển thị Form
                    formThongTin.Show();
                }
                else
                {
                    // Trường hợp không có quyền nào (Không nên xảy ra nếu DB đúng)
                    MessageBox.Show("Đăng nhập thành công nhưng không có quyền hạn nào được gán.", "Lỗi Quyền hạn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Ẩn Form Đăng nhập hiện tại
                
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không đúng!", "Lỗi Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtTenDangNhap.Focus();
            }
        }

        // Đổi tên hàm để phản ánh chức năng: kiểm tra và tạo phiên người dùng
        private bool KiemTraVaTaoSession(string tenDangNhap, string matKhau)
        {
            // Cập nhật Query: Thêm cột SoDu vào danh sách SELECT
            string queryTaiKhoan = "SELECT TaiKhoanID, MatKhau, isAdmin, isNhanVien, isKhach, HoTen, SoDu FROM TaiKhoan WHERE TenDangNhap = @TenDN";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null;
                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction(); // Bắt đầu Transaction

                    // Biến để lưu thông tin từ CSDL
                    string matKhauDB = string.Empty;
                    bool isKhach = false;
                    int taiKhoanID = 0;
                    string hoTen = string.Empty;
                    decimal soDu = 0; // Khai báo biến để chứa SoDu

                    // 1. THỰC THI QUERY TAI KHOAN
                    using (SqlCommand commandTK = new SqlCommand(queryTaiKhoan, connection, transaction))
                    {
                        commandTK.Parameters.AddWithValue("@TenDN", tenDangNhap);

                        using (SqlDataReader reader = commandTK.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                matKhauDB = reader["MatKhau"].ToString();
                                isKhach = reader.GetBoolean(reader.GetOrdinal("isKhach"));

                                // Lấy các giá trị đúng tên cột
                                taiKhoanID = reader.GetInt32(reader.GetOrdinal("TaiKhoanID"));
                                hoTen = reader["HoTen"].ToString();

                                // <<< BỔ SUNG LẤY SỐ DƯ >>>
                                soDu = reader.GetDecimal(reader.GetOrdinal("SoDu"));

                                // Lưu các quyền hạn vào Session ngay lúc này
                                UserSession.IsAdmin = reader.GetBoolean(reader.GetOrdinal("isAdmin"));
                                UserSession.IsNhanVien = reader.GetBoolean(reader.GetOrdinal("isNhanVien"));
                                UserSession.IsKhach = isKhach;
                                UserSession.TaiKhoanID = taiKhoanID;
                                UserSession.HoTen = hoTen;
                                UserSession.TenDangNhap = tenDangNhap;
                                UserSession.SoDu = soDu; // LƯU SỐ DƯ VÀO SESSION
                            }
                        } // reader tự động đóng tại đây
                    }

                    // ⚠️ 2. BƯỚC XÁC THỰC MẬT KHẨU (KHÔNG CHỈNH SỬA)
                    bool isPasswordValid = (matKhau == matKhauDB);

                    if (!isPasswordValid)
                    {
                        transaction.Rollback();
                        return false;
                    }

                    // 3. XỬ LÝ CHO TÀI KHOẢN KHÁCH
                    if (isKhach)
                    {
                        // Hàm này sẽ chọn máy ngẫu nhiên, kiểm tra trạng thái và cập nhật CSDL (trong Transaction)
                        string tenMayDaChon = TimVaGiaHanMay(connection, transaction);

                        if (string.IsNullOrEmpty(tenMayDaChon))
                        {
                            // Không tìm thấy máy trống
                            MessageBox.Show("Rất tiếc, tất cả các máy đang bận hoặc đang bảo trì.", "Máy bận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            transaction.Rollback();
                            return false;
                        }

                        // Ghi nhận máy vào Session (TenMay đã được gán GiaTheoGio trong TimVaGiaHanMay)
                        UserSession.TenMay = tenMayDaChon;
                    }

                    // Nếu đến đây, mọi thứ thành công
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    // Xảy ra lỗi CSDL, hoàn tác Transaction
                    try { if (transaction != null) transaction.Rollback(); } catch { }
                    MessageBox.Show("Lỗi kết nối CSDL hoặc giao dịch: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // Đặt hàm này trong class DangNhap
        private string TimVaGiaHanMay(SqlConnection connection, SqlTransaction transaction)
        {
            string[] danhSachMay = {
                "MAY01", "MAY02", "MAY03", "MAY04", "MAY05",
                "MAY06", "MAY07", "MAY08", "MAY09", "MAY10"
            };
            Random random = new Random();

            // Tối đa 20 lần thử để tìm máy ngẫu nhiên
            for (int i = 0; i < 20; i++)
            {
                string tenMayChon = danhSachMay[random.Next(0, danhSachMay.Length)];

                // ✅ SỬA LỖI: Dùng LOWER() để loại bỏ lỗi phân biệt chữ hoa/thường 
                // và dùng NOT EXISTS để kiểm tra phiên đang hoạt động.
                string queryKiemTra = @"
            SELECT C.GiaTheoGio 
            FROM Computers C
            WHERE C.TenMay = @TenMay 
              AND LOWER(C.TinhTrang) = 'available' -- BẮT BUỘC: So sánh ở dạng chữ thường
              AND NOT EXISTS (
                  SELECT 1 FROM SuDungMay S 
                  WHERE S.TenMay = C.TenMay AND S.ThoiGianKetThuc IS NULL
              );";

                using (SqlCommand commandKiemTra = new SqlCommand(queryKiemTra, connection, transaction))
                {
                    commandKiemTra.Parameters.AddWithValue("@TenMay", tenMayChon);

                    // SỬ DỤNG ExecuteReader để đọc cột GiaTheoGio
                    using (SqlDataReader reader = commandKiemTra.ExecuteReader())
                    {
                        if (reader.Read()) // Nếu tìm thấy hàng, tức là máy RẢNH và không bị kẹt
                        {
                            // Lấy Giá Theo Giờ
                            decimal giaTheoGio = reader.GetDecimal(reader.GetOrdinal("GiaTheoGio"));
                            reader.Close(); // ĐÓNG READER ĐỂ THỰC THI CÁC LỆNH SQL TIẾP THEO

                            // 1. CẬP NHẬT TRẠNG THÁI MÁY THÀNH 'Busy'
                            string queryUpdate = "UPDATE Computers SET TinhTrang = 'Busy' WHERE TenMay = @TenMay";
                            using (SqlCommand commandUpdate = new SqlCommand(queryUpdate, connection, transaction))
                            {
                                commandUpdate.Parameters.AddWithValue("@TenMay", tenMayChon);
                                commandUpdate.ExecuteNonQuery();
                            }

                            // 2. GHI NHẬN PHIÊN SỬ DỤNG MỚI (INSERT)
                            string queryInsert = @"
                            INSERT INTO SuDungMay (TenMay, TenDangNhap, ThoiGianBatDau, GiaTheoGio) 
                            VALUES (@May, @User, GETDATE(), @GiaTheoGio)";

                            using (SqlCommand commandInsert = new SqlCommand(queryInsert, connection, transaction))
                            {
                                commandInsert.Parameters.AddWithValue("@May", tenMayChon);
                                commandInsert.Parameters.AddWithValue("@User", UserSession.TenDangNhap);
                                commandInsert.Parameters.AddWithValue("@GiaTheoGio", giaTheoGio);
                                commandInsert.ExecuteNonQuery();
                            }

                            // LƯU VÀO SESSION
                            UserSession.GiaTheoGio = giaTheoGio;
                            UserSession.TenMay = tenMayChon;

                            return tenMayChon; // Trả về tên máy thành công
                        }
                    }
                }
            }
            return null; // Không tìm thấy máy rảnh
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}