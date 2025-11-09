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

        public ChatvKH(string tenMay)
        {
            InitializeComponent();
            this.tenMayKhach = tenMay;
            this.labelTenMay.Text = $"Đang chat với: {tenMay}"; // Gán tên máy
            textBoxNhanAD.ReadOnly = true;
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
            List<string> history = TemporaryChatManager.GetHistory(tenMayKhach);
            string newContent = string.Join(Environment.NewLine, history);

            if (textBoxNhanAD.Text != newContent)
            {
                textBoxNhanAD.Text = newContent;
                textBoxNhanAD.SelectionStart = textBoxNhanAD.Text.Length;
                textBoxNhanAD.ScrollToCaret();
            }
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