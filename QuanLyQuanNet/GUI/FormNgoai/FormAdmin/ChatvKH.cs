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

namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    public partial class ChatvKH : Form
    {
        private string tenMayKhach;
        private System.Windows.Forms.Timer chatTimer;
        private int lastMessageCount = 0;
        public ChatvKH(string tenMay)
        {
            InitializeComponent();
            this.tenMayKhach = tenMay;
            this.labelTenMay.Text = $"Đang chat với: {tenMay}"; // Gán tên máy
            richTextBoxNhanAD.ReadOnly = true;
            this.ControlBox = false;

            SetupTimer();
            LoadHistory();
        }

        private void SetupTimer()
        {
            chatTimer = new System.Windows.Forms.Timer();
            chatTimer.Interval = 1000;
            chatTimer.Tick += ChatTimer_Tick;
            chatTimer.Start();
        }

        private void ChatTimer_Tick(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void LoadHistory()
        {
            List<ChatMessage> history = TemporaryChatManager.GetHistory(tenMayKhach);

            // ✅ Sửa lỗi logic: Chỉ cập nhật nếu số lượng tin nhắn trong bộ nhớ TĂNG
            if (history.Count <= lastMessageCount) return;

            // 1. Nếu đây là lần đầu tiên tải lịch sử (Form mới mở), xóa nội dung cũ
            if (lastMessageCount == 0)
            {
                richTextBoxNhanAD.Clear();
            }

            // 2. Tải các tin nhắn mới (chỉ từ vị trí lastMessageCount)
            for (int i = lastMessageCount; i < history.Count; i++)
            {
                var msg = history[i];

                // Định dạng tin nhắn (Giữ nguyên)
                string senderDisplay = (msg.Sender == "Quản lý") ? "[Quản lý]" : $"[{msg.Sender}]";
                string line = $"{msg.Time:HH:mm:ss} {senderDisplay}: {msg.Content}";

                // Chọn màu: Xanh dương cho Quản lý, Đen cho Khách
                Color color = (msg.Sender == "Quản lý") ? Color.Blue : Color.Black;

                // Thêm dòng mới vào RichTextBox với màu sắc
                AppendText(richTextBoxNhanAD, line + Environment.NewLine, color);
            }

            // 3. Cập nhật biến đếm: Đánh dấu số tin nhắn đã hiển thị
            lastMessageCount = history.Count;
        }

        // Hàm AppendText (Giữ nguyên như đã thảo luận)
        private void AppendText(RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
            box.ScrollToCaret(); // Cuộn xuống cuối
        }

        // drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //

        private void btnCloseAd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnChatAd_Click(object sender, EventArgs e)
        {
            string noiDung = textBoxGuiAD.Text.Trim();
            if (string.IsNullOrEmpty(noiDung)) return;

            // Gửi tin nhắn từ Admin
            TemporaryChatManager.AddMessage(tenMayKhach, "Quản lý", noiDung);

            textBoxGuiAD.Clear();
            LoadHistory(); // Tải lại ngay lập tức
        }

        // *****************************************************************
        // <<< CODE BỔ SUNG: XỬ LÝ KHI FORM CHAT ĐÓNG >>>
        // *****************************************************************

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            // 1. Dừng Timer để giải phóng tài nguyên
            if (chatTimer != null)
            {
                chatTimer.Stop();
                chatTimer.Dispose();
            }

            // 2. Xóa tên máy khỏi danh sách các cửa sổ chat đang mở của Admin
            // Điều này cho phép tin nhắn mới kích hoạt cửa sổ chat lần nữa.
            if (TemporaryChatManager.OpenAdminChatWindows.Contains(tenMayKhach))
            {
                TemporaryChatManager.OpenAdminChatWindows.Remove(tenMayKhach);
            }
        }

        // *****************************************************************
    }
}