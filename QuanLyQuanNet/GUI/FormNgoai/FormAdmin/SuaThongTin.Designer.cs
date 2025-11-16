namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    partial class SuaThongTin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaThongTin));
            btnSuaThongTin = new Button();
            textBoxCCCD = new TextBox();
            labelCCCD = new Label();
            textBoxHoTen = new TextBox();
            labelHoTen = new Label();
            labelSoDu = new Label();
            textBoxSoDu = new TextBox();
            textBoxSDT = new TextBox();
            textBoxTenTK = new TextBox();
            labelSDT = new Label();
            labelTenTK = new Label();
            panel1 = new Panel();
            btnClose = new Button();
            checkBoxMK = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSuaThongTin
            // 
            btnSuaThongTin.Location = new Point(137, 261);
            btnSuaThongTin.Name = "btnSuaThongTin";
            btnSuaThongTin.Size = new Size(161, 38);
            btnSuaThongTin.TabIndex = 23;
            btnSuaThongTin.Text = "Sửa thông tin";
            btnSuaThongTin.UseVisualStyleBackColor = true;
            btnSuaThongTin.Click += btnSuaThongTin_Click;
            // 
            // textBoxCCCD
            // 
            textBoxCCCD.Location = new Point(54, 100);
            textBoxCCCD.Name = "textBoxCCCD";
            textBoxCCCD.Size = new Size(318, 23);
            textBoxCCCD.TabIndex = 22;
            // 
            // labelCCCD
            // 
            labelCCCD.AutoSize = true;
            labelCCCD.Location = new Point(56, 82);
            labelCCCD.Name = "labelCCCD";
            labelCCCD.Size = new Size(113, 15);
            labelCCCD.TabIndex = 21;
            labelCCCD.Text = "Căn cước công dân:";
            // 
            // textBoxHoTen
            // 
            textBoxHoTen.Location = new Point(54, 56);
            textBoxHoTen.Name = "textBoxHoTen";
            textBoxHoTen.Size = new Size(318, 23);
            textBoxHoTen.TabIndex = 20;
            // 
            // labelHoTen
            // 
            labelHoTen.AutoSize = true;
            labelHoTen.Location = new Point(54, 38);
            labelHoTen.Name = "labelHoTen";
            labelHoTen.Size = new Size(46, 15);
            labelHoTen.TabIndex = 19;
            labelHoTen.Text = "Họ tên:";
            // 
            // labelSoDu
            // 
            labelSoDu.AutoSize = true;
            labelSoDu.Location = new Point(57, 214);
            labelSoDu.Name = "labelSoDu";
            labelSoDu.Size = new Size(43, 15);
            labelSoDu.TabIndex = 18;
            labelSoDu.Text = "Số dư: ";
            // 
            // textBoxSoDu
            // 
            textBoxSoDu.Location = new Point(54, 232);
            textBoxSoDu.Name = "textBoxSoDu";
            textBoxSoDu.Size = new Size(318, 23);
            textBoxSoDu.TabIndex = 17;
            // 
            // textBoxSDT
            // 
            textBoxSDT.Location = new Point(54, 188);
            textBoxSDT.Name = "textBoxSDT";
            textBoxSDT.Size = new Size(318, 23);
            textBoxSDT.TabIndex = 16;
            // 
            // textBoxTenTK
            // 
            textBoxTenTK.Location = new Point(54, 144);
            textBoxTenTK.Name = "textBoxTenTK";
            textBoxTenTK.Size = new Size(318, 23);
            textBoxTenTK.TabIndex = 15;
            // 
            // labelSDT
            // 
            labelSDT.AutoSize = true;
            labelSDT.Location = new Point(56, 170);
            labelSDT.Name = "labelSDT";
            labelSDT.Size = new Size(79, 15);
            labelSDT.TabIndex = 14;
            labelSDT.Text = "Số điện thoại:";
            // 
            // labelTenTK
            // 
            labelTenTK.AutoSize = true;
            labelTenTK.Location = new Point(54, 126);
            labelTenTK.Name = "labelTenTK";
            labelTenTK.Size = new Size(81, 15);
            labelTenTK.TabIndex = 13;
            labelTenTK.Text = "Tên tài khoản:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 30);
            panel1.TabIndex = 12;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(397, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 23);
            btnClose.TabIndex = 1;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // checkBoxMK
            // 
            checkBoxMK.AutoSize = true;
            checkBoxMK.Location = new Point(161, 31);
            checkBoxMK.Name = "checkBoxMK";
            checkBoxMK.Size = new Size(112, 19);
            checkBoxMK.TabIndex = 24;
            checkBoxMK.Text = "Đặt lại mật khẩu";
            checkBoxMK.UseVisualStyleBackColor = true;
            // 
            // SuaThongTin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 308);
            Controls.Add(checkBoxMK);
            Controls.Add(btnSuaThongTin);
            Controls.Add(textBoxCCCD);
            Controls.Add(labelCCCD);
            Controls.Add(textBoxHoTen);
            Controls.Add(labelHoTen);
            Controls.Add(labelSoDu);
            Controls.Add(textBoxSoDu);
            Controls.Add(textBoxSDT);
            Controls.Add(textBoxTenTK);
            Controls.Add(labelSDT);
            Controls.Add(labelTenTK);
            Controls.Add(panel1);
            Name = "SuaThongTin";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSuaThongTin;
        private TextBox textBoxCCCD;
        private Label labelCCCD;
        private TextBox textBoxHoTen;
        private Label labelHoTen;
        private Label labelSoDu;
        private TextBox textBoxSoDu;
        private TextBox textBoxSDT;
        private TextBox textBoxTenTK;
        private Label labelSDT;
        private Label labelTenTK;
        private Panel panel1;
        private Button btnClose;
        private CheckBox checkBoxMK;
    }
}