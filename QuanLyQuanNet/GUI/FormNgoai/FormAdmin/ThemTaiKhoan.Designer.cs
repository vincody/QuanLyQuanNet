namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    partial class ThemTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemTaiKhoan));
            panel1 = new Panel();
            btnClose = new Button();
            labelTenTK = new Label();
            labelSDT = new Label();
            textBoxTenTK = new TextBox();
            textBoxSDT = new TextBox();
            textBoxSoDu = new TextBox();
            labelSoDu = new Label();
            labelHoTen = new Label();
            textBoxHoTen = new TextBox();
            labelCCCD = new Label();
            textBoxCCCD = new TextBox();
            btnTaoTK = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 30);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            // labelTenTK
            // 
            labelTenTK.AutoSize = true;
            labelTenTK.Location = new Point(54, 121);
            labelTenTK.Name = "labelTenTK";
            labelTenTK.Size = new Size(81, 15);
            labelTenTK.TabIndex = 1;
            labelTenTK.Text = "Tên tài khoản:";
            // 
            // labelSDT
            // 
            labelSDT.AutoSize = true;
            labelSDT.Location = new Point(56, 165);
            labelSDT.Name = "labelSDT";
            labelSDT.Size = new Size(79, 15);
            labelSDT.TabIndex = 2;
            labelSDT.Text = "Số điện thoại:";
            // 
            // textBoxTenTK
            // 
            textBoxTenTK.Location = new Point(54, 139);
            textBoxTenTK.Name = "textBoxTenTK";
            textBoxTenTK.Size = new Size(318, 23);
            textBoxTenTK.TabIndex = 3;
            // 
            // textBoxSDT
            // 
            textBoxSDT.Location = new Point(54, 183);
            textBoxSDT.Name = "textBoxSDT";
            textBoxSDT.Size = new Size(318, 23);
            textBoxSDT.TabIndex = 4;
            // 
            // textBoxSoDu
            // 
            textBoxSoDu.Location = new Point(54, 227);
            textBoxSoDu.Name = "textBoxSoDu";
            textBoxSoDu.Size = new Size(318, 23);
            textBoxSoDu.TabIndex = 5;
            // 
            // labelSoDu
            // 
            labelSoDu.AutoSize = true;
            labelSoDu.Location = new Point(57, 209);
            labelSoDu.Name = "labelSoDu";
            labelSoDu.Size = new Size(43, 15);
            labelSoDu.TabIndex = 6;
            labelSoDu.Text = "Số dư: ";
            // 
            // labelHoTen
            // 
            labelHoTen.AutoSize = true;
            labelHoTen.Location = new Point(54, 33);
            labelHoTen.Name = "labelHoTen";
            labelHoTen.Size = new Size(46, 15);
            labelHoTen.TabIndex = 7;
            labelHoTen.Text = "Họ tên:";
            // 
            // textBoxHoTen
            // 
            textBoxHoTen.Location = new Point(54, 51);
            textBoxHoTen.Name = "textBoxHoTen";
            textBoxHoTen.Size = new Size(318, 23);
            textBoxHoTen.TabIndex = 8;
            // 
            // labelCCCD
            // 
            labelCCCD.AutoSize = true;
            labelCCCD.Location = new Point(56, 77);
            labelCCCD.Name = "labelCCCD";
            labelCCCD.Size = new Size(113, 15);
            labelCCCD.TabIndex = 9;
            labelCCCD.Text = "Căn cước công dân:";
            // 
            // textBoxCCCD
            // 
            textBoxCCCD.Location = new Point(54, 95);
            textBoxCCCD.Name = "textBoxCCCD";
            textBoxCCCD.Size = new Size(318, 23);
            textBoxCCCD.TabIndex = 10;
            // 
            // btnTaoTK
            // 
            btnTaoTK.Location = new Point(153, 256);
            btnTaoTK.Name = "btnTaoTK";
            btnTaoTK.Size = new Size(122, 23);
            btnTaoTK.TabIndex = 11;
            btnTaoTK.Text = "Tạo tài khoản";
            btnTaoTK.UseVisualStyleBackColor = true;
            btnTaoTK.Click += btnTaoTK_Click;
            // 
            // ThemTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 288);
            Controls.Add(btnTaoTK);
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
            Name = "ThemTaiKhoan";
            Text = "ThemTaiKhoan";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelTenTK;
        private Label labelSDT;
        private TextBox textBoxTenTK;
        private TextBox textBoxSDT;
        private TextBox textBoxSoDu;
        private Label labelSoDu;
        private Label labelHoTen;
        private TextBox textBoxHoTen;
        private Label labelCCCD;
        private TextBox textBoxCCCD;
        private Button btnTaoTK;
        private Button btnClose;
    }
}