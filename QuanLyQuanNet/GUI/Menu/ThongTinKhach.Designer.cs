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
            labelDaKetNoi = new Label();
            labelTenUser = new Label();
            pictureBox1 = new PictureBox();
            panelThongTin = new Panel();
            textBoxGiaMay = new TextBox();
            textBoxSoDu = new TextBox();
            labelGiaMay = new Label();
            labelSoDu = new Label();
            textBoxGDN = new TextBox();
            labelGioDangNhap = new Label();
            textBoxTGCL = new TextBox();
            textBoxTGSD = new TextBox();
            textBoxTTG = new TextBox();
            labelThoiGianConLai = new Label();
            labelThoiGianSuDung = new Label();
            labelTongThoiGian = new Label();
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
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(labelDaKetNoi);
            panel1.Controls.Add(labelTenUser);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 47);
            panel1.TabIndex = 1;
            // 
            // labelDaKetNoi
            // 
            labelDaKetNoi.AutoSize = true;
            labelDaKetNoi.Font = new Font("Segoe UI", 15F);
            labelDaKetNoi.ForeColor = Color.LawnGreen;
            labelDaKetNoi.Location = new Point(237, 9);
            labelDaKetNoi.Name = "labelDaKetNoi";
            labelDaKetNoi.Size = new Size(101, 28);
            labelDaKetNoi.TabIndex = 1;
            labelDaKetNoi.Text = "Đã kết nối";
            // 
            // labelTenUser
            // 
            labelTenUser.AutoSize = true;
            labelTenUser.Font = new Font("Segoe UI", 15F);
            labelTenUser.ForeColor = SystemColors.ButtonFace;
            labelTenUser.Location = new Point(31, 9);
            labelTenUser.Name = "labelTenUser";
            labelTenUser.Size = new Size(80, 28);
            labelTenUser.TabIndex = 0;
            labelTenUser.Text = "TenUser";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 299);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 79);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panelThongTin
            // 
            panelThongTin.BackColor = Color.AliceBlue;
            panelThongTin.Controls.Add(textBoxGiaMay);
            panelThongTin.Controls.Add(textBoxSoDu);
            panelThongTin.Controls.Add(labelGiaMay);
            panelThongTin.Controls.Add(labelSoDu);
            panelThongTin.Controls.Add(textBoxGDN);
            panelThongTin.Controls.Add(labelGioDangNhap);
            panelThongTin.Controls.Add(textBoxTGCL);
            panelThongTin.Controls.Add(textBoxTGSD);
            panelThongTin.Controls.Add(textBoxTTG);
            panelThongTin.Controls.Add(labelThoiGianConLai);
            panelThongTin.Controls.Add(labelThoiGianSuDung);
            panelThongTin.Controls.Add(labelTongThoiGian);
            panelThongTin.Location = new Point(12, 53);
            panelThongTin.Name = "panelThongTin";
            panelThongTin.Size = new Size(329, 177);
            panelThongTin.TabIndex = 3;
            // 
            // textBoxGiaMay
            // 
            textBoxGiaMay.Location = new Point(141, 146);
            textBoxGiaMay.Name = "textBoxGiaMay";
            textBoxGiaMay.ReadOnly = true;
            textBoxGiaMay.Size = new Size(185, 23);
            textBoxGiaMay.TabIndex = 12;
            // 
            // textBoxSoDu
            // 
            textBoxSoDu.Location = new Point(141, 117);
            textBoxSoDu.Name = "textBoxSoDu";
            textBoxSoDu.ReadOnly = true;
            textBoxSoDu.Size = new Size(185, 23);
            textBoxSoDu.TabIndex = 11;
            // 
            // labelGiaMay
            // 
            labelGiaMay.AutoSize = true;
            labelGiaMay.Location = new Point(19, 149);
            labelGiaMay.Name = "labelGiaMay";
            labelGiaMay.Size = new Size(114, 15);
            labelGiaMay.TabIndex = 10;
            labelGiaMay.Text = "Giá máy đang dùng:";
            // 
            // labelSoDu
            // 
            labelSoDu.AutoSize = true;
            labelSoDu.Location = new Point(19, 120);
            labelSoDu.Name = "labelSoDu";
            labelSoDu.Size = new Size(92, 15);
            labelSoDu.TabIndex = 9;
            labelSoDu.Text = "Số dư tài khoản:";
            labelSoDu.Click += labelSoDu_Click;
            // 
            // textBoxGDN
            // 
            textBoxGDN.Location = new Point(141, 91);
            textBoxGDN.Name = "textBoxGDN";
            textBoxGDN.ReadOnly = true;
            textBoxGDN.Size = new Size(185, 23);
            textBoxGDN.TabIndex = 8;
            // 
            // labelGioDangNhap
            // 
            labelGioDangNhap.AutoSize = true;
            labelGioDangNhap.Location = new Point(19, 94);
            labelGioDangNhap.Name = "labelGioDangNhap";
            labelGioDangNhap.Size = new Size(88, 15);
            labelGioDangNhap.TabIndex = 7;
            labelGioDangNhap.Text = "Giờ đăng nhập:";
            // 
            // textBoxTGCL
            // 
            textBoxTGCL.Location = new Point(141, 66);
            textBoxTGCL.Name = "textBoxTGCL";
            textBoxTGCL.ReadOnly = true;
            textBoxTGCL.Size = new Size(185, 23);
            textBoxTGCL.TabIndex = 6;
            // 
            // textBoxTGSD
            // 
            textBoxTGSD.Location = new Point(141, 41);
            textBoxTGSD.Name = "textBoxTGSD";
            textBoxTGSD.ReadOnly = true;
            textBoxTGSD.Size = new Size(185, 23);
            textBoxTGSD.TabIndex = 5;
            // 
            // textBoxTTG
            // 
            textBoxTTG.Location = new Point(141, 12);
            textBoxTTG.Name = "textBoxTTG";
            textBoxTTG.ReadOnly = true;
            textBoxTTG.Size = new Size(185, 23);
            textBoxTTG.TabIndex = 4;
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
            // labelThoiGianSuDung
            // 
            labelThoiGianSuDung.AutoSize = true;
            labelThoiGianSuDung.Location = new Point(19, 44);
            labelThoiGianSuDung.Name = "labelThoiGianSuDung";
            labelThoiGianSuDung.Size = new Size(106, 15);
            labelThoiGianSuDung.TabIndex = 1;
            labelThoiGianSuDung.Text = "Thời gian sử dụng:";
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
            // btnDoiMK
            // 
            btnDoiMK.Image = (Image)resources.GetObject("btnDoiMK.Image");
            btnDoiMK.ImageAlign = ContentAlignment.TopCenter;
            btnDoiMK.Location = new Point(9, 236);
            btnDoiMK.Name = "btnDoiMK";
            btnDoiMK.Size = new Size(78, 57);
            btnDoiMK.TabIndex = 1;
            btnDoiMK.Text = "Mật khẩu";
            btnDoiMK.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDoiMK.UseVisualStyleBackColor = true;
            // 
            // btnTinNhan
            // 
            btnTinNhan.Image = (Image)resources.GetObject("btnTinNhan.Image");
            btnTinNhan.Location = new Point(93, 236);
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
            btnGoiMon.Location = new Point(174, 236);
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
            btnDangXuat.Location = new Point(263, 236);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(78, 57);
            btnDangXuat.TabIndex = 6;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // ThongTinKhach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 384);
            ControlBox = false;
            Controls.Add(btnDangXuat);
            Controls.Add(btnGoiMon);
            Controls.Add(btnTinNhan);
            Controls.Add(btnDoiMK);
            Controls.Add(panelThongTin);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ThongTinKhach";
            Text = "Máy trạm";
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
        private Label labelDaKetNoi;
        private Label labelTenUser;
        private TextBox textBoxGiaMay;
        private TextBox textBoxSoDu;
        private Label labelGiaMay;
        private Label labelSoDu;
    }
}