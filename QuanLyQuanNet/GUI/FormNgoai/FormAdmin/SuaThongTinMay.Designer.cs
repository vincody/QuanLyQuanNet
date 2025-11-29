namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    partial class SuaThongTinMay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaThongTinMay));
            textBoxSGiaMayTrenH = new TextBox();
            label5 = new Label();
            btnSuaThongTin = new Button();
            textBoxSManHinh = new TextBox();
            label10 = new Label();
            textBoxSRAM = new TextBox();
            textBoxSGPU = new TextBox();
            textBoxSCPU = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            btnClose = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxSGiaMayTrenH
            // 
            textBoxSGiaMayTrenH.Location = new Point(134, 273);
            textBoxSGiaMayTrenH.Name = "textBoxSGiaMayTrenH";
            textBoxSGiaMayTrenH.Size = new Size(222, 23);
            textBoxSGiaMayTrenH.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(9, 267);
            label5.Name = "label5";
            label5.Size = new Size(119, 28);
            label5.TabIndex = 30;
            label5.Text = "Giá máy (/h)";
            // 
            // btnSuaThongTin
            // 
            btnSuaThongTin.BackColor = Color.AliceBlue;
            btnSuaThongTin.Font = new Font("Segoe UI", 15F);
            btnSuaThongTin.Location = new Point(87, 318);
            btnSuaThongTin.Name = "btnSuaThongTin";
            btnSuaThongTin.Size = new Size(205, 52);
            btnSuaThongTin.TabIndex = 29;
            btnSuaThongTin.Text = "Sửa thông tin máy";
            btnSuaThongTin.UseVisualStyleBackColor = false;
            btnSuaThongTin.Click += btnSuaThongTin_Click;
            // 
            // textBoxSManHinh
            // 
            textBoxSManHinh.Location = new Point(134, 236);
            textBoxSManHinh.Name = "textBoxSManHinh";
            textBoxSManHinh.Size = new Size(222, 23);
            textBoxSManHinh.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(19, 231);
            label10.Name = "label10";
            label10.Size = new Size(94, 28);
            label10.TabIndex = 27;
            label10.Text = "Màn hình";
            // 
            // textBoxSRAM
            // 
            textBoxSRAM.Location = new Point(134, 198);
            textBoxSRAM.Name = "textBoxSRAM";
            textBoxSRAM.Size = new Size(222, 23);
            textBoxSRAM.TabIndex = 26;
            // 
            // textBoxSGPU
            // 
            textBoxSGPU.Location = new Point(134, 152);
            textBoxSGPU.Name = "textBoxSGPU";
            textBoxSGPU.Size = new Size(222, 23);
            textBoxSGPU.TabIndex = 25;
            // 
            // textBoxSCPU
            // 
            textBoxSCPU.Location = new Point(134, 106);
            textBoxSCPU.Name = "textBoxSCPU";
            textBoxSCPU.Size = new Size(222, 23);
            textBoxSCPU.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(36, 194);
            label9.Name = "label9";
            label9.Size = new Size(55, 28);
            label9.TabIndex = 23;
            label9.Text = "RAM";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(37, 148);
            label8.Name = "label8";
            label8.Size = new Size(51, 28);
            label8.TabIndex = 22;
            label8.Text = "GPU";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(39, 102);
            label7.Name = "label7";
            label7.Size = new Size(49, 28);
            label7.TabIndex = 21;
            label7.Text = "CPU";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(104, 50);
            label6.Name = "label6";
            label6.Size = new Size(179, 37);
            label6.TabIndex = 20;
            label6.Text = "Cấu hình máy";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 38);
            panel1.TabIndex = 32;
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
            // SuaThongTinMay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(379, 380);
            Controls.Add(panel1);
            Controls.Add(textBoxSGiaMayTrenH);
            Controls.Add(label5);
            Controls.Add(btnSuaThongTin);
            Controls.Add(textBoxSManHinh);
            Controls.Add(label10);
            Controls.Add(textBoxSRAM);
            Controls.Add(textBoxSGPU);
            Controls.Add(textBoxSCPU);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Name = "SuaThongTinMay";
            Text = "SuaThongTinMay";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSGiaMayTrenH;
        private Label label5;
        private Button btnSuaThongTin;
        private TextBox textBoxSManHinh;
        private Label label10;
        private TextBox textBoxSRAM;
        private TextBox textBoxSGPU;
        private TextBox textBoxSCPU;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel panel1;
        private Button btnClose;
    }
}