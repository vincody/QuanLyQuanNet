using System;
using System.Windows.Forms;

namespace QuanLyQuanNet.GUI.ViewDoAn
{
    public partial class DoAn : UserControl
    {
        // 1. Tạo sự kiện tùy chỉnh để Form cha lắng nghe
        public event EventHandler ThemMonClicked;

        public DoAn()
        {
            InitializeComponent();
            // Không cần AttachChildClickEvents nữa vì ta chỉ bắt sự kiện nút Button
        }

        // Xử lý khi bấm nút "Thêm Món"
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            // Kích hoạt sự kiện và gửi chính UserControl này (this) làm sender
            ThemMonClicked?.Invoke(this, EventArgs.Empty);
        }

        // Các hàm click khác có thể bỏ trống hoặc xóa nếu không dùng
        private void pictureBoxHinhAnh_Click(object sender, EventArgs e) { }
        private void labelGiaDoAn_Click(object sender, EventArgs e) { }
    }
}