namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    partial class ThemMayMoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemMayMoi));
            panel1 = new Panel();
            btnClose = new Button();
            textBoxTGiaMayTrenH = new TextBox();
            label5 = new Label();
            btnThemMay = new Button();
            textBoxTManHinh = new TextBox();
            label10 = new Label();
            textBoxTRAM = new TextBox();
            textBoxTGPU = new TextBox();
            textBoxTCPU = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
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
            panel1.Size = new Size(379, 38);
            panel1.TabIndex = 45;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(347, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 23);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // textBoxTGiaMayTrenH
            // 
            textBoxTGiaMayTrenH.Location = new Point(134, 278);
            textBoxTGiaMayTrenH.Name = "textBoxTGiaMayTrenH";
            textBoxTGiaMayTrenH.Size = new Size(222, 23);
            textBoxTGiaMayTrenH.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(9, 272);
            label5.Name = "label5";
            label5.Size = new Size(119, 28);
            label5.TabIndex = 43;
            label5.Text = "Giá máy (/h)";
            // 
            // btnThemMay
            // 
            btnThemMay.BackColor = Color.AliceBlue;
            btnThemMay.Font = new Font("Segoe UI", 15F);
            btnThemMay.Location = new Point(87, 323);
            btnThemMay.Name = "btnThemMay";
            btnThemMay.Size = new Size(205, 52);
            btnThemMay.TabIndex = 42;
            btnThemMay.Text = "Thêm máy mới";
            btnThemMay.UseVisualStyleBackColor = false;
            btnThemMay.Click += btnThemMay_Click;
            // 
            // textBoxTManHinh
            // 
            textBoxTManHinh.Location = new Point(134, 241);
            textBoxTManHinh.Name = "textBoxTManHinh";
            textBoxTManHinh.Size = new Size(222, 23);
            textBoxTManHinh.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(19, 236);
            label10.Name = "label10";
            label10.Size = new Size(94, 28);
            label10.TabIndex = 40;
            label10.Text = "Màn hình";
            // 
            // textBoxTRAM
            // 
            textBoxTRAM.Location = new Point(134, 203);
            textBoxTRAM.Name = "textBoxTRAM";
            textBoxTRAM.Size = new Size(222, 23);
            textBoxTRAM.TabIndex = 39;
            // 
            // textBoxTGPU
            // 
            textBoxTGPU.Location = new Point(134, 157);
            textBoxTGPU.Name = "textBoxTGPU";
            textBoxTGPU.Size = new Size(222, 23);
            textBoxTGPU.TabIndex = 38;
            // 
            // textBoxTCPU
            // 
            textBoxTCPU.Location = new Point(134, 111);
            textBoxTCPU.Name = "textBoxTCPU";
            textBoxTCPU.Size = new Size(222, 23);
            textBoxTCPU.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(36, 199);
            label9.Name = "label9";
            label9.Size = new Size(55, 28);
            label9.TabIndex = 36;
            label9.Text = "RAM";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(37, 153);
            label8.Name = "label8";
            label8.Size = new Size(51, 28);
            label8.TabIndex = 35;
            label8.Text = "GPU";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(39, 107);
            label7.Name = "label7";
            label7.Size = new Size(49, 28);
            label7.TabIndex = 34;
            label7.Text = "CPU";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(104, 55);
            label6.Name = "label6";
            label6.Size = new Size(179, 37);
            label6.TabIndex = 33;
            label6.Text = "Cấu hình máy";
            // 
            // ThemMayMoi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 380);
            Controls.Add(panel1);
            Controls.Add(textBoxTGiaMayTrenH);
            Controls.Add(label5);
            Controls.Add(btnThemMay);
            Controls.Add(textBoxTManHinh);
            Controls.Add(label10);
            Controls.Add(textBoxTRAM);
            Controls.Add(textBoxTGPU);
            Controls.Add(textBoxTCPU);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Name = "ThemMayMoi";
            Text = "ThemMayMoi";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnClose;
        private TextBox textBoxTGiaMayTrenH;
        private Label label5;
        private Button btnThemMay;
        private TextBox textBoxTManHinh;
        private Label label10;
        private TextBox textBoxTRAM;
        private TextBox textBoxTGPU;
        private TextBox textBoxTCPU;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}