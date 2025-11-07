namespace QuanLyQuanNet.GUI.Menu
{
    partial class ThongTinKhach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinKhach));
            label1 = new Label();
            panel1 = new Panel();
            MayName = new Label();
            pictureBox1 = new PictureBox();
            panelThongTin = new Panel();
            labelTongThoiGian = new Label();
            labelThoiGianSuDung = new Label();
            labelThoiGianConLai = new Label();
            textBoxTTG = new TextBox();
            textBoxTGSD = new TextBox();
            textBoxTGCL = new TextBox();
            labelGioDangNhap = new Label();
            textBoxGDN = new TextBox();
            btnDoiMK = new Button();
            btnTinNhan = new Button();
            btnGoiMon = new Button();
            btnDangXuat = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(MayName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 53);
            panel1.TabIndex = 1;
            // 
            // MayName
            // 
            MayName.Anchor = AnchorStyles.None;
            MayName.AutoSize = true;
            MayName.Font = new Font("Segoe UI", 15F);
            MayName.Location = new Point(143, 9);
            MayName.Name = "MayName";
            MayName.Size = new Size(62, 28);
            MayName.TabIndex = 0;
            MayName.Text = "MayX";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 270);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 79);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panelThongTin
            // 
            panelThongTin.BackColor = Color.AliceBlue;
            panelThongTin.Controls.Add(textBoxGDN);
            panelThongTin.Controls.Add(labelGioDangNhap);
            panelThongTin.Controls.Add(textBoxTGCL);
            panelThongTin.Controls.Add(textBoxTGSD);
            panelThongTin.Controls.Add(textBoxTTG);
            panelThongTin.Controls.Add(labelThoiGianConLai);
            panelThongTin.Controls.Add(labelThoiGianSuDung);
            panelThongTin.Controls.Add(labelTongThoiGian);
            panelThongTin.Location = new Point(12, 59);
            panelThongTin.Name = "panelThongTin";
            panelThongTin.Size = new Size(329, 132);
            panelThongTin.TabIndex = 3;
            // 
            // labelTongThoiGian
            // 
            labelTongThoiGian.AutoSize = true;
            labelTongThoiGian.Location = new Point(19, 15);
            labelTongThoiGian.Name = "labelTongThoiGian";
            labelTongThoiGian.Size = new Size(88, 15);
            labelTongThoiGian.TabIndex = 0;
            labelTongThoiGian.Text = "Tổng thời gian:";
            // 
            // labelThoiGianSuDung
            // 
            labelThoiGianSuDung.AutoSize = true;
            labelThoiGianSuDung.Location = new Point(19, 44);
            labelThoiGianSuDung.Name = "labelThoiGianSuDung";
            labelThoiGianSuDung.Size = new Size(106, 15);
            labelThoiGianSuDung.TabIndex = 1;
            labelThoiGianSuDung.Text = "Thời gian sử dụng:";
            // 
            // labelThoiGianConLai
            // 
            labelThoiGianConLai.AutoSize = true;
            labelThoiGianConLai.Location = new Point(19, 69);
            labelThoiGianConLai.Name = "labelThoiGianConLai";
            labelThoiGianConLai.Size = new Size(98, 15);
            labelThoiGianConLai.TabIndex = 2;
            labelThoiGianConLai.Text = "Thời gian còn lại:";
            // 
            // textBoxTTG
            // 
            textBoxTTG.Location = new Point(141, 12);
            textBoxTTG.Name = "textBoxTTG";
            textBoxTTG.Size = new Size(185, 23);
            textBoxTTG.TabIndex = 4;
            // 
            // textBoxTGSD
            // 
            textBoxTGSD.Location = new Point(141, 41);
            textBoxTGSD.Name = "textBoxTGSD";
            textBoxTGSD.Size = new Size(185, 23);
            textBoxTGSD.TabIndex = 5;
            // 
            // textBoxTGCL
            // 
            textBoxTGCL.Location = new Point(141, 66);
            textBoxTGCL.Name = "textBoxTGCL";
            textBoxTGCL.Size = new Size(185, 23);
            textBoxTGCL.TabIndex = 6;
            // 
            // labelGioDangNhap
            // 
            labelGioDangNhap.AutoSize = true;
            labelGioDangNhap.Location = new Point(19, 99);
            labelGioDangNhap.Name = "labelGioDangNhap";
            labelGioDangNhap.Size = new Size(88, 15);
            labelGioDangNhap.TabIndex = 7;
            labelGioDangNhap.Text = "Giờ đăng nhập:";
            // 
            // textBoxGDN
            // 
            textBoxGDN.Location = new Point(141, 99);
            textBoxGDN.Name = "textBoxGDN";
            textBoxGDN.Size = new Size(185, 23);
            textBoxGDN.TabIndex = 8;
            // 
            // btnDoiMK
            // 
            btnDoiMK.Image = (Image)resources.GetObject("btnDoiMK.Image");
            btnDoiMK.ImageAlign = ContentAlignment.TopCenter;
            btnDoiMK.Location = new Point(12, 207);
            btnDoiMK.Name = "btnDoiMK";
            btnDoiMK.Size = new Size(75, 57);
            btnDoiMK.TabIndex = 1;
            btnDoiMK.Text = "Mật khẩu";
            btnDoiMK.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDoiMK.UseVisualStyleBackColor = true;
            // 
            // btnTinNhan
            // 
            btnTinNhan.Image = (Image)resources.GetObject("btnTinNhan.Image");
            btnTinNhan.Location = new Point(93, 207);
            btnTinNhan.Name = "btnTinNhan";
            btnTinNhan.Size = new Size(75, 57);
            btnTinNhan.TabIndex = 4;
            btnTinNhan.Text = "Chat";
            btnTinNhan.TextImageRelation = TextImageRelation.ImageAboveText;
            btnTinNhan.UseVisualStyleBackColor = true;
            // 
            // btnGoiMon
            // 
            btnGoiMon.Image = (Image)resources.GetObject("btnGoiMon.Image");
            btnGoiMon.Location = new Point(174, 207);
            btnGoiMon.Name = "btnGoiMon";
            btnGoiMon.Size = new Size(83, 57);
            btnGoiMon.TabIndex = 5;
            btnGoiMon.Text = "Gọi món";
            btnGoiMon.TextImageRelation = TextImageRelation.ImageAboveText;
            btnGoiMon.UseVisualStyleBackColor = true;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Image = (Image)resources.GetObject("btnDangXuat.Image");
            btnDangXuat.Location = new Point(263, 207);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(75, 57);
            btnDangXuat.TabIndex = 6;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // ThongTinKhach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 359);
            Controls.Add(btnDangXuat);
            Controls.Add(btnGoiMon);
            Controls.Add(btnTinNhan);
            Controls.Add(btnDoiMK);
            Controls.Add(panelThongTin);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "ThongTinKhach";
            Text = "ThongTinKhach";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelThongTin.ResumeLayout(false);
            panelThongTin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label MayName;
        private PictureBox pictureBox1;
        private Panel panelThongTin;
        private Label labelTongThoiGian;
        private TextBox textBoxGDN;
        private Label labelGioDangNhap;
        private TextBox textBoxTGCL;
        private TextBox textBoxTGSD;
        private TextBox textBoxTTG;
        private Label labelThoiGianConLai;
        private Label labelThoiGianSuDung;
        private Button btnDoiMK;
        private Button btnTinNhan;
        private Button btnGoiMon;
        private Button btnDangXuat;
    }
}