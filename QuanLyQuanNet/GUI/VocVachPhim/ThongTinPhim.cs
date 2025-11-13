using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanNet.GUI.VocVachPhim
{
    public partial class ThongTinPhim : UserControl
    {
        public ThongTinPhim()
        {
            InitializeComponent();
        }
        private const int LABEL_SPACING = 5;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void CenterLabels()
        {
            // 1. Tính toán chiều cao cần thiết cho labelTenPhim
            int requiredHeight = CalculateTextHeight(
                labelTenPhim.Text,
                labelTenPhim.Font,
                labelTenPhim.Width // Sử dụng chiều rộng hiện tại của Label
            );

            // Cập nhật chiều cao của Label
            labelTenPhim.Height = requiredHeight;

            // 2. Tính toán tổng chiều cao và căn chỉnh (logic cũ)
            int parentWidth = this.Width;
            int parentHeight = this.Height;
            const int LABEL_SPACING = 5;

            int totalHeight = labelTenPhim.Height + LABEL_SPACING + labelTap.Height;

            // Tính toán vị trí bắt đầu theo chiều dọc (Y)
            int startY = (parentHeight - totalHeight) / 2;

            // 3. Căn chỉnh labelTenPhim
            // Chỉ đặt lại Y (vì X và Width đã dùng Anchor)
            labelTenPhim.Location = new Point(labelTenPhim.Location.X, startY);

            // 4. Căn chỉnh labelTap (dưới)
            int tapX = (parentWidth - labelTap.Width) / 2;
            int tapY = startY + labelTenPhim.Height + LABEL_SPACING;
            labelTap.Location = new Point(tapX, tapY);
        }
        private int CalculateTextHeight(string text, Font font, int width)
        {
            // Tạo đối tượng Graphics tạm thời để đo kích thước văn bản
            using (Graphics g = this.CreateGraphics())
            {
                SizeF size = g.MeasureString(text, font, width);
                // Trả về chiều cao làm tròn lên
                return (int)Math.Ceiling(size.Height);
            }
        }
    }
}
