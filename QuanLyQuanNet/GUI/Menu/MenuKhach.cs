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
    public partial class MenuKhach : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activateForm;
        public MenuKhach()
        {
            InitializeComponent();
        }
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
    }
}
