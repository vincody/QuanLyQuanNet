using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanNet.GUI.FormNgoai.FormKhach
{
    public partial class NapTien : Form
    {
        private string selectedPaymentMethod = "";
        public NapTien()
        {
            InitializeComponent();
            labelTenDN.Text = UserSession.TenDangNhap;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            textBoxSoTienNap.Text = "10.000";
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            textBoxSoTienNap.Text = "20.000";
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            textBoxSoTienNap.Text = "30.000";
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            textBoxSoTienNap.Text = "40.000";
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            textBoxSoTienNap.Text = "50.000";
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            textBoxSoTienNap.Text = "60.000";
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            textBoxSoTienNap.Text = "70.000";
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            textBoxSoTienNap.Text = "80.000";
        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            textBoxSoTienNap.Text = "100.000";
        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            textBoxSoTienNap.Text = "200.000";
        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            textBoxSoTienNap.Text = "300.000";
        }

        private void bunifuButton12_Click(object sender, EventArgs e)
        {
            textBoxSoTienNap.Text = "500.000";
        }

        private void btnTienMat_Click(object sender, EventArgs e)
        {
            // 1. Lưu trạng thái
            selectedPaymentMethod = "Tiền mặt";

            // 2. Hiển thị lên Label
            labelPPTT.Text = "Tiền mặt";
        }

        private void btnMaQR_Click(object sender, EventArgs e)
        {
            // 1. Lưu trạng thái
            selectedPaymentMethod = "Mã QR";

            // 2. Hiển thị lên Label
            labelPPTT.Text = "Mã QR";
        }

        private void btnXacNhanNap_Click(object sender, EventArgs e)
        {
            // 1. KIỂM TRA PHƯƠNG THỨC THANH TOÁN
            if (string.IsNullOrEmpty(selectedPaymentMethod))
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán (Tiền mặt hoặc Mã QR).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. LẤY VÀ KIỂM TRA SỐ TIỀN
            // Loại bỏ dấu chấm phân cách hàng nghìn (ví dụ: "10.000" -> "10000")
            string rawAmount = textBoxSoTienNap.Text.Replace(".", "").Trim();

            if (!decimal.TryParse(rawAmount, out decimal soTienNap) || soTienNap <= 0)
            {
                MessageBox.Show("Số tiền nhập vào không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. XỬ LÝ LOGIC THEO PHƯƠNG THỨC
            if (selectedPaymentMethod == "Tiền mặt")
            {
                // --- TRƯỜNG HỢP TIỀN MẶT ---
                MessageBox.Show("Vui lòng chuẩn bị tiền, sẽ có nhân viên đến máy của bạn để thu tiền.",
                                "Yêu cầu nạp tiền mặt",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Tùy chọn: Gửi thông báo xuống máy chủ quản lý (nếu có tính năng đó)
                // Hoặc đóng form sau khi thông báo
            }
            else if (selectedPaymentMethod == "Mã QR")
            {
                // --- TRƯỜNG HỢP MÃ QR ---
                // Mở form xác nhận và truyền số tiền sang
                XacNhanChuyenKhoan formQR = new XacNhanChuyenKhoan(soTienNap);

                // Ẩn form nạp tiền hiện tại đi (hoặc giữ nguyên tùy bạn)

                formQR.ShowDialog(); // Hiển thị form QR dạng hộp thoại

                // Sau khi form QR đóng lại thì hiện lại form này hoặc đóng luôn
            }
        }
    }
}
