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

namespace QuanLyQuanNet.GUI.Menu
{
    public partial class MenuKhach : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activateForm;
        public MenuKhach()
        {
            InitializeComponent();
            this.Text = "";
            this.ControlBox = false;
        }
        // drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //
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
            foreach (Control previousBtn in panelMenu.Controls)
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
            this.panelChild.Controls.Add(childForm);
            this.panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelList.Text = childForm.Text;
        }

        private void btnFoods_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNgoai.FormKhach.MenuGames(), sender);
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnNapTien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNgoai.FormKhach.NapTien(), sender);
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizeK_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizeK_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnCloseK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNgoai.FormKhach.GoiMon(), sender);
        }

        private void btnXemPhim_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNgoai.FormKhach.ListPhim(), sender);
        }
    }
}
