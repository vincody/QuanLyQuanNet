namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    partial class SuaMonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaMonAn));
            panel1 = new Panel();
            btnClose = new Button();
            label1 = new Label();
            panel2 = new Panel();
            btnSuaMonAn = new Button();
            label4 = new Label();
            textBoxTenMA = new TextBox();
            textBoxGiaMonAn = new TextBox();
            label3 = new Label();
            label2 = new Label();
            comboBoxPhanLoai = new ComboBox();
            btnSuaAnhMA = new Button();
            pictureBoxAnhMonAn = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnhMonAn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 58);
            panel1.TabIndex = 4;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 15F);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(761, 16);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 23);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 0;
            label1.Text = "Sửa món ăn";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSuaMonAn);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBoxTenMA);
            panel2.Controls.Add(textBoxGiaMonAn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBoxPhanLoai);
            panel2.Location = new Point(411, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 248);
            panel2.TabIndex = 7;
            // 
            // btnSuaMonAn
            // 
            btnSuaMonAn.Image = (Image)resources.GetObject("btnSuaMonAn.Image");
            btnSuaMonAn.Location = new Point(3, 198);
            btnSuaMonAn.Name = "btnSuaMonAn";
            btnSuaMonAn.Size = new Size(383, 47);
            btnSuaMonAn.TabIndex = 5;
            btnSuaMonAn.Text = "Sửa món ăn";
            btnSuaMonAn.TextAlign = ContentAlignment.MiddleRight;
            btnSuaMonAn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSuaMonAn.UseVisualStyleBackColor = true;
            btnSuaMonAn.Click += btnSuaMonAn_Click;
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
            // btnSuaAnhMA
            // 
            btnSuaAnhMA.Image = (Image)resources.GetObject("btnSuaAnhMA.Image");
            btnSuaAnhMA.Location = new Point(0, 268);
            btnSuaAnhMA.Name = "btnSuaAnhMA";
            btnSuaAnhMA.Size = new Size(405, 47);
            btnSuaAnhMA.TabIndex = 6;
            btnSuaAnhMA.Text = "Sửa ảnh món ăn";
            btnSuaAnhMA.TextAlign = ContentAlignment.MiddleRight;
            btnSuaAnhMA.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSuaAnhMA.UseVisualStyleBackColor = true;
            btnSuaAnhMA.Click += btnSuaAnhMA_Click;
            // 
            // pictureBoxAnhMonAn
            // 
            pictureBoxAnhMonAn.Location = new Point(0, 67);
            pictureBoxAnhMonAn.Name = "pictureBoxAnhMonAn";
            pictureBoxAnhMonAn.Size = new Size(405, 195);
            pictureBoxAnhMonAn.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAnhMonAn.TabIndex = 5;
            pictureBoxAnhMonAn.TabStop = false;
            // 
            // SuaMonAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 318);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btnSuaAnhMA);
            Controls.Add(pictureBoxAnhMonAn);
            Name = "SuaMonAn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnhMonAn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnClose;
        private Label label1;
        private Panel panel2;
        private Button btnSuaMonAn;
        private Label label4;
        private TextBox textBoxTenMA;
        private TextBox textBoxGiaMonAn;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxPhanLoai;
        private Button btnSuaAnhMA;
        private PictureBox pictureBoxAnhMonAn;
    }
}