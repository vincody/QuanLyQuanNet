using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanNet.GUI.FormNgoai.FormKhach
{
    public partial class XacNhanChuyenKhoan : Form
    {
        private decimal soTienCanThanhToan;
        public XacNhanChuyenKhoan(decimal soTien)
        {
            InitializeComponent();
            this.soTienCanThanhToan = soTien;

            // Ví dụ: Hiển thị số tiền lên label (nếu có)
            // labelSoTien.Text = soTien.ToString("N0") + " VNĐ";
        }
        private void XacNhanChuyenKhoan_Load(object sender, EventArgs e)
        {
            // Tại đây bạn sẽ gọi code tạo mã QR PayOS mà chúng ta đã bàn trước đó
            // CreatePayOSQRCode(soTienCanThanhToan);
        }
    }
}
