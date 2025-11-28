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
using QuanLyQuanNet.GUI.FormNgoai.FormAdmin;

namespace QuanLyQuanNet.GUI.Menu
{
    public partial class MenuQN : Form
    {
        // Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activateForm;
        private System.Windows.Forms.Timer notificationTimer;
        private Dictionary<string, ChatvKH> openChatForms = new Dictionary<string, ChatvKH>();
        // Constructor

        public MenuQN()
        {
            InitializeComponent();
            SetupNotificationTimer();
            // Đảm bảo IsAdminReady = true khi Form này mở
            // TemporaryChatManager.IsAdminReady = true;
            TemporaryChatManager.IsAdminReady = true;
            this.Text = "";
            this.ControlBox = false;
        }
        private void MenuQN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (notificationTimer != null)
            {
                notificationTimer.Stop();
            }
            // Đánh dấu Admin BẬN (Không sẵn sàng) khi Form Quản lý đóng
            TemporaryChatManager.IsAdminReady = false;
        }
        private void SetupNotificationTimer()
        {
            notificationTimer = new System.Windows.Forms.Timer();
            notificationTimer.Interval = 1000; // Kiểm tra mỗi 1 giây
            notificationTimer.Tick += NotificationTimer_Tick;
            notificationTimer.Start();
        }
        private void NotificationTimer_Tick(object sender, EventArgs e)
        {
            if (TemporaryChatManager.MachinesWithNewMessages.Count > 0)
            {
                // Lấy danh sách các máy cần mở chat để tránh lỗi Collection modified
                string[] machinesToProcess = TemporaryChatManager.MachinesWithNewMessages.ToArray();

                foreach (string tenMayCanChat in machinesToProcess)
                {
                    // Xóa máy khỏi danh sách chờ ngay lập tức
                    TemporaryChatManager.MachinesWithNewMessages.Remove(tenMayCanChat);

                    // Kiểm tra xem Form chat cho máy này đã mở chưa
                    if (!openChatForms.ContainsKey(tenMayCanChat) || openChatForms[tenMayCanChat].IsDisposed)
                    {
                        // Mở Form ChatvKH mới
                        OpenChatForMachine(tenMayCanChat);
                    }
                    else
                    {
                        // Nếu đã mở, chỉ cần đưa Form đó lên phía trước (Focus)
                        openChatForms[tenMayCanChat].BringToFront();
                    }
                }
            }
        }
        private void OpenChatForMachine(string tenMay)
        {
            ChatvKH adminChatForm = new ChatvKH(tenMay);

            // Lưu Form vào Dictionary
            openChatForms.Add(tenMay, adminChatForm);

            // Xử lý sự kiện khi Form đóng để dọn dẹp Dictionary
            adminChatForm.FormClosed += (s, args) =>
            {
                if (openChatForms.ContainsKey(tenMay))
                {
                    openChatForms.Remove(tenMay);
                }
                // Logic xóa khỏi OpenAdminChatWindows của TemporaryChatManager vẫn cần giữ
                if (TemporaryChatManager.OpenAdminChatWindows.Contains(tenMay))
                {
                    TemporaryChatManager.OpenAdminChatWindows.Remove(tenMay);
                }
            };

            // Đánh dấu máy này đang được Admin mở chat
            TemporaryChatManager.OpenAdminChatWindows.Add(tenMay);

            adminChatForm.Show();
        }
        // Đừng quên dừng Timer khi Form MenuQN đóng
        // drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void MenuQN_Load(object sender, EventArgs e)
        {
            // 1. Cập nhật label
            // Giả sử tên label của bạn là lblTenDN
            lblTenDN.Text = UserSession.TenDangNhap;
        }
        // Methods
        private Color SelectThemeColor()
        {
            ThemeColor theme = new ThemeColor();
            string hexColor = theme.ColorList[0];
            return System.Drawing.ColorTranslator.FromHtml(hexColor);
        }
        private void ActivateButton(object btnSender)
        {
            Button currentButton = btnSender as Button;

            if (currentButton != null)
            {
                DisableButton();
                Color themeColor = SelectThemeColor();
                currentButton.BackColor = Color.AliceBlue;
                currentButton.ForeColor = Color.Navy;
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 67, 190);
                    previousBtn.ForeColor = Color.FromArgb(224, 224, 224);
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            ActivateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelCon.Controls.Add(childForm);
            this.panelCon.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelGanTen.Text = childForm.Text;
        }

        private void btnMay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNgoai.FormAdmin.TTMay(), sender);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNgoai.FormAdmin.MenuDA(), sender);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNgoai.FormAdmin.LSMay(), sender);
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNgoai.FormAdmin.KHang(), sender);
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNgoai.FormAdmin.Voucher(), sender);
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNgoai.FormAdmin.KhoQL(), sender);
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNgoai.FormAdmin.NVien(), sender);
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNgoai.FormAdmin.ThongKe(), sender);
        }

        private void btnChatAdmin_Click(object sender, EventArgs e)
        {

        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
