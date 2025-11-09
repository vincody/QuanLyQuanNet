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
        private int lastMessageCount = 0;

        public GiaoTiepKH(string tenMay, string tenDangNhap)
        {
            InitializeComponent();
            this.tenMayHienTai = tenMay;
            this.tenNguoiGui = tenDangNhap; // Người gửi là TenDangNhap
            richTextBoxNhanKH.ReadOnly = true;
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
            List<ChatMessage> history = TemporaryChatManager.GetHistory(tenMayHienTai);

            // 1. Kiểm tra nếu không có tin nhắn mới, thoát khỏi hàm
            if (history.Count <= lastMessageCount) return;

            // 2. Tải các tin nhắn mới (chỉ từ vị trí lastMessageCount)
            for (int i = lastMessageCount; i < history.Count; i++)
            {
                var msg = history[i];

                string senderDisplay = (msg.Sender == "Quản lý") ? "[Quản lý]" : $"[{msg.Sender}]";
                string line = $"{msg.Time:HH:mm:ss} {senderDisplay}: {msg.Content}";

                // Chọn màu: Xanh dương cho Quản lý, Đen cho Khách
                Color color = (msg.Sender == "Quản lý") ? Color.Blue : Color.Black;

                // Thêm dòng mới vào RichTextBox với màu sắc
                AppendText(richTextBoxNhanKH, line + Environment.NewLine, color);
            }

            // 3. Cập nhật biến đếm: Đánh dấu số tin nhắn đã hiển thị
            lastMessageCount = history.Count;
        }
        // Hàm hỗ trợ (cần phải được thêm vào GiaoTiepKH.cs)
        // Hàm AppendText (Giữ nguyên như đã thảo luận)
        private void AppendText(RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
            box.ScrollToCaret();
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
