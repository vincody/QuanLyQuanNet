using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        // Constructor

        public MenuQN()
        {
            InitializeComponent();
        }
        private void MenuQN_Load(object sender, EventArgs e)
        {
            // 1. Cập nhật label
            // Giả sử tên label của bạn là lblTenDN
            lblTenDN.Text = "Xin chào, " + UserSession.TenDangNhap;
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
                currentButton.BackColor = themeColor;
                currentButton.ForeColor = Color.White;
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.AliceBlue;
                    previousBtn.ForeColor = Color.MidnightBlue;
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
            lblTitle.Text = childForm.Text;
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
            OpenChildForm(new FormNgoai.FormAdmin.ChatvKH(), sender);
        }
    }
}
