namespace QuanLyQuanNet.GUI.ViewDoAn
{
    partial class ThongTinDatMon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinDatMon));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            btnThem = new Button();
            SoLuong = new Label();
            btnBot = new Button();
            pictureBoxHienThiAnh = new Guna.UI2.WinForms.Guna2PictureBox();
            btnXoaMon = new Button();
            labelGiaTien = new Label();
            labelTenMon = new Label();
            bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHienThiAnh).BeginInit();
            bunifuPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // bunifuPanel1
            // 
            bunifuPanel1.BackgroundColor = Color.FromArgb(139, 149, 163);
            bunifuPanel1.BackgroundImage = (Image)resources.GetObject("bunifuPanel1.BackgroundImage");
            bunifuPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuPanel1.BorderColor = Color.White;
            bunifuPanel1.BorderRadius = 15;
            bunifuPanel1.BorderThickness = 1;
            bunifuPanel1.Controls.Add(btnThem);
            bunifuPanel1.Controls.Add(SoLuong);
            bunifuPanel1.Controls.Add(btnBot);
            bunifuPanel1.Location = new Point(90, 48);
            bunifuPanel1.Name = "bunifuPanel1";
            bunifuPanel1.ShowBorders = true;
            bunifuPanel1.Size = new Size(120, 30);
            bunifuPanel1.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(139, 149, 163);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 12F);
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.Location = new Point(73, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(31, 23);
            btnThem.TabIndex = 3;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // SoLuong
            // 
            SoLuong.AutoSize = true;
            SoLuong.BackColor = Color.FromArgb(139, 149, 163);
            SoLuong.ForeColor = Color.White;
            SoLuong.Location = new Point(47, 7);
            SoLuong.Name = "SoLuong";
            SoLuong.Size = new Size(20, 15);
            SoLuong.TabIndex = 1;
            SoLuong.Text = "So";
            // 
            // btnBot
            // 
            btnBot.BackColor = Color.FromArgb(139, 149, 163);
            btnBot.FlatAppearance.BorderSize = 0;
            btnBot.FlatStyle = FlatStyle.Flat;
            btnBot.Image = (Image)resources.GetObject("btnBot.Image");
            btnBot.Location = new Point(11, 3);
            btnBot.Name = "btnBot";
            btnBot.Size = new Size(30, 23);
            btnBot.TabIndex = 2;
            btnBot.UseVisualStyleBackColor = false;
            btnBot.Click += btnBot_Click;
            // 
            // pictureBoxHienThiAnh
            // 
            pictureBoxHienThiAnh.BackColor = Color.Transparent;
            pictureBoxHienThiAnh.BorderRadius = 20;
            pictureBoxHienThiAnh.CustomizableEdges = customizableEdges1;
            pictureBoxHienThiAnh.ImageRotate = 0F;
            pictureBoxHienThiAnh.Location = new Point(5, 5);
            pictureBoxHienThiAnh.Name = "pictureBoxHienThiAnh";
            pictureBoxHienThiAnh.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pictureBoxHienThiAnh.Size = new Size(81, 83);
            pictureBoxHienThiAnh.TabIndex = 6;
            pictureBoxHienThiAnh.TabStop = false;
            // 
            // btnXoaMon
            // 
            btnXoaMon.BackColor = Color.FromArgb(139, 149, 163);
            btnXoaMon.FlatAppearance.BorderSize = 0;
            btnXoaMon.FlatStyle = FlatStyle.Flat;
            btnXoaMon.Image = (Image)resources.GetObject("btnXoaMon.Image");
            btnXoaMon.Location = new Point(299, 9);
            btnXoaMon.Name = "btnXoaMon";
            btnXoaMon.Size = new Size(30, 30);
            btnXoaMon.TabIndex = 5;
            btnXoaMon.UseVisualStyleBackColor = false;
            btnXoaMon.Click += btnXoaMon_Click;
            // 
            // labelGiaTien
            // 
            labelGiaTien.AutoSize = true;
            labelGiaTien.BackColor = Color.FromArgb(139, 149, 163);
            labelGiaTien.Font = new Font("Segoe UI", 12F);
            labelGiaTien.ForeColor = Color.White;
            labelGiaTien.Location = new Point(90, 27);
            labelGiaTien.Name = "labelGiaTien";
            labelGiaTien.Size = new Size(62, 21);
            labelGiaTien.TabIndex = 4;
            labelGiaTien.Text = "GiaTien";
            labelGiaTien.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTenMon
            // 
            labelTenMon.AutoSize = true;
            labelTenMon.BackColor = Color.FromArgb(139, 149, 163);
            labelTenMon.Font = new Font("Segoe UI", 12F);
            labelTenMon.ForeColor = Color.White;
            labelTenMon.Location = new Point(89, 3);
            labelTenMon.Name = "labelTenMon";
            labelTenMon.Size = new Size(65, 21);
            labelTenMon.TabIndex = 0;
            labelTenMon.Text = "TenMon";
            // 
            // bunifuPanel2
            // 
            bunifuPanel2.BackgroundColor = Color.FromArgb(139, 149, 163);
            bunifuPanel2.BackgroundImage = (Image)resources.GetObject("bunifuPanel2.BackgroundImage");
            bunifuPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuPanel2.BorderColor = Color.FromArgb(139, 149, 163);
            bunifuPanel2.BorderRadius = 15;
            bunifuPanel2.BorderThickness = 1;
            bunifuPanel2.Controls.Add(pictureBoxHienThiAnh);
            bunifuPanel2.Controls.Add(bunifuPanel1);
            bunifuPanel2.Controls.Add(labelGiaTien);
            bunifuPanel2.Controls.Add(labelTenMon);
            bunifuPanel2.Controls.Add(btnXoaMon);
            bunifuPanel2.Location = new Point(0, 0);
            bunifuPanel2.Name = "bunifuPanel2";
            bunifuPanel2.ShowBorders = true;
            bunifuPanel2.Size = new Size(341, 95);
            bunifuPanel2.TabIndex = 8;
            // 
            // ThongTinDatMon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(bunifuPanel2);
            Name = "ThongTinDatMon";
            Size = new Size(342, 95);
            bunifuPanel1.ResumeLayout(false);
            bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHienThiAnh).EndInit();
            bunifuPanel2.ResumeLayout(false);
            bunifuPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Button btnBot;
        public Label SoLuong;
        public Label labelTenMon;
        public Button btnXoaMon;
        public Label labelGiaTien;
        public Button btnThem;
        private Button button3;
        public Guna.UI2.WinForms.Guna2PictureBox pictureBoxHienThiAnh;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
    }
}
