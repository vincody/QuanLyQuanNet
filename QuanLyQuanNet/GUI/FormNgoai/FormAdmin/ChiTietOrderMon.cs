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
using QuanLyQuanNet.GUI.ViewDoAn;

namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    public partial class ChiTietOrderMon : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";
        private int currentDonDatID;
        public ChiTietOrderMon()
        {
            InitializeComponent();
            this.Text = "";
            this.ControlBox = false;
        }
        // drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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

            // Truy vấn 3 bảng (DonDatMon, ChiTietDatMon, ThucDon)
            string query = @"
            SELECT
                DDM.TongTien, CTDM.TenMon, CTDM.SoLuong, CTDM.GiaDonVi, TD.HinhAnhPath
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

                        while (reader.Read())
                        {
                            // Lấy dữ liệu
                            string tenMon = reader["TenMon"].ToString();
                            int soLuong = reader.GetInt32(reader.GetOrdinal("SoLuong"));
                            decimal giaDonVi = reader.GetDecimal(reader.GetOrdinal("GiaDonVi"));
                            string hinhAnhPath = reader["HinhAnhPath"].ToString();

                            // Lấy Tổng tiền từ hàng đầu tiên của reader (tổng tiền là cố định cho đơn hàng)
                            if (isFirstRow)
                            {
                                tongTien = reader.GetDecimal(reader.GetOrdinal("TongTien"));
                                isFirstRow = false;
                            }

                            // 1. Tạo User Control DonDat.cs
                            DonDat itemControl = new DonDat();

                            // 2. Gán dữ liệu vào các Label
                            itemControl.labelTenMA.Text = tenMon;
                            itemControl.labelSoLuong.Text = $"x{soLuong}";
                            itemControl.labelGiaMonAn.Text = giaDonVi.ToString("N0") + " VNĐ";
                            itemControl.labelThanhTien.Text = (soLuong * giaDonVi).ToString("N0") + " VNĐ";

                            // 3. Tải ảnh
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
        // Hàm hỗ trợ tải ảnh
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
            catch (Exception)
            {
                // Bỏ qua lỗi tải ảnh
            }
        }
        // Xử lý nút HOÀN THÀNH ĐƠN
        private void btnHoanThanhDon_Click_1(object sender, EventArgs e)
        {
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
                        MessageBox.Show($"Đơn hàng #{currentDonDatID} đã được chuyển sang trạng thái 'Đã xong'.", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Đóng Form chi tiết
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi cập nhật trạng thái: " + ex.Message, "Lỗi DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
