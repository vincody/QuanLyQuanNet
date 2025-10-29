using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if(activateForm != null)
            {
                activateForm.Close();
            }
            ActivateButton(btnSender);
            activateForm = childForm;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelCon.Controls.Add(childForm);
            this.panelCon.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            panelTitle.Text = childForm.Text;
        }

        private void btnMay_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
