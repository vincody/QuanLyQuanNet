using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanNet.GUI.FormNgoai.FormKhach
{
    public partial class GiaoTiepKH : Form
    {
        public GiaoTiepKH()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        // drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //
        private void btnCloseKH_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string tenMayHienTai;
        private string tenNguoiGui;
        private System.Windows.Forms.Timer chatTimer;

        public GiaoTiepKH(string tenMay, string tenDangNhap)
        {
            InitializeComponent();
            this.tenMayHienTai = tenMay;
            this.tenNguoiGui = tenDangNhap; // Người gửi là TenDangNhap
            textBoxNhanKH.ReadOnly = true;
            this.ControlBox = false;
            SetupTimer();
            LoadHistory();
        }

        private void SetupTimer()
        {
            chatTimer = new System.Windows.Forms.Timer();
            chatTimer.Interval = 1000; // Cập nhật mỗi 1 giây
            chatTimer.Tick += ChatTimer_Tick;
            chatTimer.Start();
        }

        private void ChatTimer_Tick(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void LoadHistory()
        {
            List<string> history = TemporaryChatManager.GetHistory(tenMayHienTai);

            // Cập nhật TextBox chỉ khi có sự thay đổi
            string newContent = string.Join(Environment.NewLine, history);
            if (textBoxNhanKH.Text != newContent)
            {
                textBoxNhanKH.Text = newContent;
                // Cuộn xuống cuối
                textBoxNhanKH.SelectionStart = textBoxNhanKH.Text.Length;
                textBoxNhanKH.ScrollToCaret();
            }
        }



        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnChatKH_Click(object sender, EventArgs e)
        {
            string noiDung = textBoxGuiKH.Text.Trim();
            if (string.IsNullOrEmpty(noiDung)) return;

            // Gửi tin nhắn vào bộ nhớ tạm thời
            TemporaryChatManager.AddMessage(tenMayHienTai, tenNguoiGui, noiDung);

            textBoxGuiKH.Clear();
            LoadHistory(); // Tải lại ngay lập tức để hiển thị tin nhắn của mình
        }
    }
}
