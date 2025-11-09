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
        public NapTien()
        {
            InitializeComponent();
            textBoxTKN.Text = UserSession.TenDangNhap;
            textBoxTKN.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNap_Click(object sender, EventArgs e)
        {
            // Đảm bảo Label luôn ẩn trước khi xử lý (để tránh hiển thị sau khi nạp tiền mặt)
            labelYCNap.Visible = false;
            pictureBoxQR.Image = null; // Xóa hình ảnh cũ nếu có

            // Kiểm tra nếu người dùng chọn nạp bằng TIỀN MẶT
            if (checkBoxTienMat.Checked)
            {
                // === HÌNH THỨC NẠP TIỀN MẶT ===

                if (string.IsNullOrWhiteSpace(textBoxSTN.Text))
                {
                    MessageBox.Show("Vui lòng nhập số tiền muốn nạp.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xuất thông báo cho nhân viên
                MessageBox.Show(
                    "Yêu cầu nạp tiền mặt đã được ghi nhận. Sẽ có nhân viên đến máy của bạn (" + UserSession.TenMay + ") để thu tiền. Vui lòng đợi.",
                    "Yêu cầu nạp tiền mặt",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            // === HÌNH THỨC NẠP CHUYỂN KHOẢN (QR Code) ===

            // 1. Kiểm tra và lấy Số tiền nạp
            if (!decimal.TryParse(textBoxSTN.Text.Trim(), out decimal soTienNap) || soTienNap <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền nạp hợp lệ (số dương).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Lấy Tên tài khoản và định dạng thông tin chuyển khoản (addInfo)
            string tenDangNhap = UserSession.TenDangNhap;
            string thongTinCK = $"{tenDangNhap}-{soTienNap.ToString("N0").Replace(",", "")}";
            string thongTinCKEncoded = WebUtility.UrlEncode(thongTinCK);

            // 3. Xây dựng URL QR Code hoàn chỉnh (Sử dụng logic đã cung cấp)
            string bankId = "970436";
            string accountNo = "1060653629";
            string accountName = "QUAN NET UIT";
            string amountString = soTienNap.ToString("F0");

            string qrUrl = $"https://img.vietqr.io/image/{bankId}-{accountNo}-print.png?amount={amountString}&addInfo={thongTinCKEncoded}&accountName={WebUtility.UrlEncode(accountName)}";

            // 4. Tải và hiển thị hình ảnh QR Code
            try
            {
                using (WebClient client = new WebClient())
                {
                    byte[] imageBytes = client.DownloadData(qrUrl);

                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        pictureBoxQR.Image = Image.FromStream(ms);
                    }
                }

                // <<< BỔ SUNG QUAN TRỌNG: HIỂN THỊ LABEL VÀ NỘI DUNG >>>
                labelYCNap.Visible = true;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tạo mã QR. Lỗi: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
