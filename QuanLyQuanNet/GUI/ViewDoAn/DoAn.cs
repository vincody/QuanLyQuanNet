using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanNet.GUI.ViewDoAn
{
    public partial class DoAn : UserControl
    {
        public DoAn()
        {
            InitializeComponent();
            // Gán sự kiện cho tất cả các controls con trong Constructor (???)
            // Khi control con được click, nó gọi sự kiện Click của control cha (UserControl)
            AttachChildClickEvents(this);
        }

        private void pictureBoxHinhAnh_Click(object sender, EventArgs e)
        {

        }
        // Hàm xử lý Click chung (sẽ chuyển tiếp sự kiện Click của control con)
        private void DoAn_ControlClick(object sender, EventArgs e)
        {
            // Khi bất kỳ control con nào được click, nó sẽ kích hoạt sự kiện Click của UserControl cha.
            // Dùng this.OnClick(e) để kích hoạt sự kiện Click mà MainMenuForm đang lắng nghe.
            this.OnClick(e);
        }
        // Hàm đệ quy để gán sự kiện cho tất cả controls con
        // Hàm đệ quy để gán sự kiện Click cho controls con
        private void AttachChildClickEvents(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                // Gán sự kiện Click của control con để gọi sự kiện Click của control cha
                c.Click += (sender, e) => this.OnClick(e);

                // Tiếp tục đệ quy cho các controls con sâu hơn (nếu có Panel bên trong)
                if (c.HasChildren)
                {
                    AttachChildClickEvents(c);
                }
            }
        }
    }
}
