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
using System.IO;
using QuanLyQuanNet.GUI.ViewDoAn;

namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    public partial class ChiTietOrderMon : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";
        private int currentDonDatID;

        // Constructor mặc định
        //
        //
        public ChiTietOrderMon()
        {
            InitializeComponent();
            this.Text = "";
            this.ControlBox = false;
        }

        // Drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Constructor chính nhận ID đơn hàng
        public ChiTietOrderMon(int donDatID)
        {
            InitializeComponent();
            this.currentDonDatID = donDatID;
            this.Text = "";
            this.ControlBox = false;

            // Gán Mã đơn
            labelMaDon.Text = $"Mã đơn: #{donDatID}";

            LoadOrderDetails();
        }

        private void LoadOrderDetails()
        {
            flowPanelOrder.Controls.Clear();

            string query = @"
            SELECT 
                DDM.TongTien, 
                DDM.PhuongThucTT, 
                DDM.TrangThai, 
                DDM.TaiKhoanID,
                CTDM.TenMon, 
                CTDM.SoLuong, 
                CTDM.GiaDonVi, 
                TD.HinhAnhPath
            FROM 
                DonDatMon DDM
            JOIN ChiTietDatMon CTDM ON DDM.DonDatID = CTDM.DonDatID
            JOIN ThucDon TD ON CTDM.MonAnID = TD.MonAnID
            WHERE DDM.DonDatID = @DonDatID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DonDatID", currentDonDatID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        decimal tongTien = 0;
                        bool isFirstRow = true;
                        string trangThai = "";

                        while (reader.Read())
                        {
                            // Lấy dữ liệu chi tiết món
                            string tenMon = reader["TenMon"].ToString();
                            int soLuong = reader.GetInt32(reader.GetOrdinal("SoLuong"));
                            decimal giaDonVi = reader.GetDecimal(reader.GetOrdinal("GiaDonVi"));
                            string hinhAnhPath = reader["HinhAnhPath"].ToString();

                            // Lấy thông tin chung từ hàng đầu tiên
                            if (isFirstRow)
                            {
                                tongTien = reader.GetDecimal(reader.GetOrdinal("TongTien"));
                                trangThai = reader["TrangThai"].ToString();

                                // Xử lý hiển thị nút dựa trên trạng thái
                                if (trangThai == "Đã hủy" || trangThai == "Đã xong")
                                {
                                    btnHuyDon.Enabled = false;
                                    btnHoanThanhDon.Enabled = false; // Vô hiệu hóa cả nút hoàn thành
                                }
                                else
                                {
                                    btnHuyDon.Enabled = true;
                                    btnHoanThanhDon.Enabled = true;
                                }

                                isFirstRow = false;
                            }

                            // Tạo User Control DonDat.cs
                            DonDat itemControl = new DonDat();
                            itemControl.labelTenMA.Text = tenMon;
                            itemControl.labelSoLuong.Text = $"x{soLuong}";
                            itemControl.labelGiaMonAn.Text = giaDonVi.ToString("N0") + " VNĐ";
                            itemControl.labelThanhTien.Text = (soLuong * giaDonVi).ToString("N0") + " VNĐ";
                            LoadImageToControl(itemControl.pictureBoxAnhMonAn, hinhAnhPath);

                            flowPanelOrder.Controls.Add(itemControl);
                        }

                        // Gán tổng tiền
                        labelTongTien.Text = tongTien.ToString("N0") + " VNĐ";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi tải chi tiết đơn hàng: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadImageToControl(PictureBox pb, string hinhAnhPath)
        {
            if (string.IsNullOrEmpty(hinhAnhPath)) return;
            try
            {
                string fullPath = Path.Combine(Application.StartupPath, hinhAnhPath);
                if (File.Exists(fullPath))
                {
                    using (var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                    {
                        pb.Image = Image.FromStream(stream);
                    }
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception) { }
        }

        // Xử lý nút HỦY ĐƠN
        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy đơn hàng này không?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HuyDonHang();
            }
        }

        // ✅ Xử lý nút HOÀN THÀNH ĐƠN (Đã bổ sung lại)
        private void btnHoanThanhDon_Click_1(object sender, EventArgs e)
        {
            // 1. Lấy thông tin đơn hàng (Cần TenMay để gửi tin nhắn)
            OrderInfo info = GetOrderInfo(currentDonDatID);
            if (info == null) return;

            string updateQuery = "UPDATE DonDatMon SET TrangThai = N'Đã xong' WHERE DonDatID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID", currentDonDatID);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        // ✅ GỬI THÔNG BÁO CHO KHÁCH
                        string message = "Đơn của bạn đang được chuẩn bị, vui lòng đợi.";
                        TemporaryChatManager.AddMessage(info.TenMay, "Quản lý", message);

                        MessageBox.Show($"Đơn hàng #{currentDonDatID} đã hoàn thành. Đã gửi thông báo tới {info.TenMay}.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi cập nhật: " + ex.Message, "Lỗi DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void HuyDonHang()
        {
            // 1. Lấy thông tin đơn hàng
            OrderInfo info = GetOrderInfo(currentDonDatID);
            if (info == null) return;

            if (info.TrangThai == "Đã hủy")
            {
                MessageBox.Show("Đơn hàng này đã được hủy trước đó.", "Thông báo");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // 2. Cập nhật trạng thái đơn hàng thành "Đã hủy"
                    string updateStatusQuery = "UPDATE DonDatMon SET TrangThai = N'Đã hủy' WHERE DonDatID = @DonDatID";
                    SqlCommand cmdUpdateStatus = new SqlCommand(updateStatusQuery, connection, transaction);
                    cmdUpdateStatus.Parameters.AddWithValue("@DonDatID", currentDonDatID);
                    cmdUpdateStatus.ExecuteNonQuery();

                    string notificationMsg = "";

                    // 3. Hoàn tiền và tạo thông báo
                    if (info.PhuongThucTT == "Số dư")
                    {
                        string updateBalanceQuery = "UPDATE TaiKhoan SET SoDu = SoDu + @TongTien WHERE TaiKhoanID = @TaiKhoanID";
                        SqlCommand cmdUpdateBalance = new SqlCommand(updateBalanceQuery, connection, transaction);
                        cmdUpdateBalance.Parameters.AddWithValue("@TongTien", info.TongTien);
                        cmdUpdateBalance.Parameters.AddWithValue("@TaiKhoanID", info.TaiKhoanID);
                        cmdUpdateBalance.ExecuteNonQuery();

                        notificationMsg = "Đơn của bạn đã được hủy do quán đã hết món bạn đặt. Tiền của bạn đã được hoàn về.";
                        MessageBox.Show($"Đã hủy đơn và hoàn {info.TongTien:N0} VNĐ vào tài khoản khách hàng.", "Hoàn tiền thành công");
                    }
                    else
                    {
                        notificationMsg = "Đơn của bạn đã được hủy do quán đã hết món bạn đặt.";
                        MessageBox.Show("Đã hủy đơn hàng (Thanh toán tiền mặt).", "Hủy đơn thành công");
                    }

                    // ✅ GỬI THÔNG BÁO CHO KHÁCH
                    TemporaryChatManager.AddMessage(info.TenMay, "Quản lý", notificationMsg);

                    transaction.Commit();
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi hủy đơn hàng: " + ex.Message, "Lỗi DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // =================================================================================
        // HÀM HỖ TRỢ LẤY THÔNG TIN ĐƠN HÀNG
        // =================================================================================

        // Class chứa thông tin cần thiết để xử lý
        private class OrderInfo
        {
            public string TenMay { get; set; }
            public int TaiKhoanID { get; set; }
            public string PhuongThucTT { get; set; }
            public decimal TongTien { get; set; }
            public string TrangThai { get; set; }
        }
        private OrderInfo GetOrderInfo(int donDatID)
        {
            // Truy vấn thêm TenMay để biết gửi tin nhắn cho máy nào
            string query = "SELECT TenMay, TaiKhoanID, PhuongThucTT, TongTien, TrangThai FROM DonDatMon WHERE DonDatID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", donDatID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new OrderInfo
                        {
                            TenMay = reader["TenMay"].ToString(),
                            TaiKhoanID = reader.GetInt32(reader.GetOrdinal("TaiKhoanID")),
                            PhuongThucTT = reader["PhuongThucTT"].ToString(),
                            TongTien = reader.GetDecimal(reader.GetOrdinal("TongTien")),
                            TrangThai = reader["TrangThai"].ToString()
                        };
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lấy thông tin đơn: " + ex.Message);
                }
            }
            return null;
        }
    }
}