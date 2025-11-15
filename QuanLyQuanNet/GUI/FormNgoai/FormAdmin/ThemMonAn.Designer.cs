namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    partial class ThemMonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemMonAn));
            panel1 = new Panel();
            label1 = new Label();
            pictureBoxAnhMonAn = new PictureBox();
            btnThemAnhMA = new Button();
            panel2 = new Panel();
            btnHoatTatMon = new Button();
            label4 = new Label();
            textBoxTenMA = new TextBox();
            textBoxGiaMonAn = new TextBox();
            label3 = new Label();
            label2 = new Label();
            comboBoxPhanLoai = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnhMonAn).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 58);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 0;
            label1.Text = "Thêm món mới";
            // 
            // pictureBoxAnhMonAn
            // 
            pictureBoxAnhMonAn.Location = new Point(0, 64);
            pictureBoxAnhMonAn.Name = "pictureBoxAnhMonAn";
            pictureBoxAnhMonAn.Size = new Size(405, 195);
            pictureBoxAnhMonAn.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAnhMonAn.TabIndex = 1;
            pictureBoxAnhMonAn.TabStop = false;
            // 
            // btnThemAnhMA
            // 
            btnThemAnhMA.Image = (Image)resources.GetObject("btnThemAnhMA.Image");
            btnThemAnhMA.Location = new Point(0, 265);
            btnThemAnhMA.Name = "btnThemAnhMA";
            btnThemAnhMA.Size = new Size(405, 47);
            btnThemAnhMA.TabIndex = 2;
            btnThemAnhMA.Text = "Thêm ảnh món ăn";
            btnThemAnhMA.TextAlign = ContentAlignment.MiddleRight;
            btnThemAnhMA.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemAnhMA.UseVisualStyleBackColor = true;
            btnThemAnhMA.Click += btnThemAnhMA_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnHoatTatMon);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBoxTenMA);
            panel2.Controls.Add(textBoxGiaMonAn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBoxPhanLoai);
            panel2.Location = new Point(411, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 248);
            panel2.TabIndex = 3;
            // 
            // btnHoatTatMon
            // 
            btnHoatTatMon.Image = (Image)resources.GetObject("btnHoatTatMon.Image");
            btnHoatTatMon.Location = new Point(3, 198);
            btnHoatTatMon.Name = "btnHoatTatMon";
            btnHoatTatMon.Size = new Size(383, 47);
            btnHoatTatMon.TabIndex = 5;
            btnHoatTatMon.Text = "Thêm món ăn";
            btnHoatTatMon.TextAlign = ContentAlignment.MiddleRight;
            btnHoatTatMon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHoatTatMon.UseVisualStyleBackColor = true;
            btnHoatTatMon.Click += btnHoatTatMon_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 112);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 5;
            label4.Text = "Tên món ăn";
            // 
            // textBoxTenMA
            // 
            textBoxTenMA.Location = new Point(3, 136);
            textBoxTenMA.Name = "textBoxTenMA";
            textBoxTenMA.Size = new Size(383, 23);
            textBoxTenMA.TabIndex = 4;
            // 
            // textBoxGiaMonAn
            // 
            textBoxGiaMonAn.Location = new Point(210, 30);
            textBoxGiaMonAn.Name = "textBoxGiaMonAn";
            textBoxGiaMonAn.Size = new Size(167, 23);
            textBoxGiaMonAn.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(210, 6);
            label3.Name = "label3";
            label3.Size = new Size(33, 21);
            label3.TabIndex = 2;
            label3.Text = "Giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 5);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 1;
            label2.Text = "Phân loại";
            // 
            // comboBoxPhanLoai
            // 
            comboBoxPhanLoai.FormattingEnabled = true;
            comboBoxPhanLoai.Location = new Point(3, 29);
            comboBoxPhanLoai.Name = "comboBoxPhanLoai";
            comboBoxPhanLoai.Size = new Size(178, 23);
            comboBoxPhanLoai.TabIndex = 0;
            // 
            // ThemMonAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 318);
            Controls.Add(panel2);
            Controls.Add(btnThemAnhMA);
            Controls.Add(pictureBoxAnhMonAn);
            Controls.Add(panel1);
            Name = "ThemMonAn";
            Text = "ThemMonAn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnhMonAn).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBoxAnhMonAn;
        private Button btnThemAnhMA;
        private Panel panel2;
        private ComboBox comboBoxPhanLoai;
        private Label label2;
        private Button btnHoatTatMon;
        private Label label4;
        private TextBox textBoxTenMA;
        private TextBox textBoxGiaMonAn;
        private Label label3;
    }
}