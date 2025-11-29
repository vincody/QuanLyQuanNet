namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    partial class TTMay
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
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            textBoxGiaMayTrenH = new TextBox();
            label5 = new Label();
            btnSuaThongTinMay = new Button();
            textBoxManHinh = new TextBox();
            label10 = new Label();
            textBoxRAM = new TextBox();
            textBoxGPU = new TextBox();
            textBoxCPU = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            labelMayHT = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAddMay = new Button();
            flowPanelMayTinh = new FlowLayoutPanel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaGreen;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(137, 14);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(210, 14);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 2;
            label2.Text = "Trống";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(textBoxGiaMayTrenH);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnSuaThongTinMay);
            panel1.Controls.Add(textBoxManHinh);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(textBoxRAM);
            panel1.Controls.Add(textBoxGPU);
            panel1.Controls.Add(textBoxCPU);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(labelMayHT);
            panel1.Location = new Point(433, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 435);
            panel1.TabIndex = 3;
            // 
            // textBoxGiaMayTrenH
            // 
            textBoxGiaMayTrenH.Location = new Point(128, 271);
            textBoxGiaMayTrenH.Name = "textBoxGiaMayTrenH";
            textBoxGiaMayTrenH.ReadOnly = true;
            textBoxGiaMayTrenH.Size = new Size(222, 23);
            textBoxGiaMayTrenH.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(3, 265);
            label5.Name = "label5";
            label5.Size = new Size(119, 28);
            label5.TabIndex = 18;
            label5.Text = "Giá máy (/h)";
            // 
            // btnSuaThongTinMay
            // 
            btnSuaThongTinMay.BackColor = Color.AliceBlue;
            btnSuaThongTinMay.Font = new Font("Segoe UI", 15F);
            btnSuaThongTinMay.Location = new Point(82, 340);
            btnSuaThongTinMay.Name = "btnSuaThongTinMay";
            btnSuaThongTinMay.Size = new Size(205, 52);
            btnSuaThongTinMay.TabIndex = 17;
            btnSuaThongTinMay.Text = "Sửa thông tin máy";
            btnSuaThongTinMay.UseVisualStyleBackColor = false;
            btnSuaThongTinMay.Click += btnSuaThongTinMay_Click;
            // 
            // textBoxManHinh
            // 
            textBoxManHinh.Location = new Point(128, 234);
            textBoxManHinh.Name = "textBoxManHinh";
            textBoxManHinh.ReadOnly = true;
            textBoxManHinh.Size = new Size(222, 23);
            textBoxManHinh.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(13, 229);
            label10.Name = "label10";
            label10.Size = new Size(94, 28);
            label10.TabIndex = 15;
            label10.Text = "Màn hình";
            // 
            // textBoxRAM
            // 
            textBoxRAM.Location = new Point(128, 196);
            textBoxRAM.Name = "textBoxRAM";
            textBoxRAM.ReadOnly = true;
            textBoxRAM.Size = new Size(222, 23);
            textBoxRAM.TabIndex = 14;
            // 
            // textBoxGPU
            // 
            textBoxGPU.Location = new Point(128, 150);
            textBoxGPU.Name = "textBoxGPU";
            textBoxGPU.ReadOnly = true;
            textBoxGPU.Size = new Size(222, 23);
            textBoxGPU.TabIndex = 13;
            // 
            // textBoxCPU
            // 
            textBoxCPU.Location = new Point(128, 104);
            textBoxCPU.Name = "textBoxCPU";
            textBoxCPU.ReadOnly = true;
            textBoxCPU.Size = new Size(222, 23);
            textBoxCPU.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(30, 192);
            label9.Name = "label9";
            label9.Size = new Size(55, 28);
            label9.TabIndex = 11;
            label9.Text = "RAM";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(31, 146);
            label8.Name = "label8";
            label8.Size = new Size(51, 28);
            label8.TabIndex = 10;
            label8.Text = "GPU";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(33, 100);
            label7.Name = "label7";
            label7.Size = new Size(49, 28);
            label7.TabIndex = 9;
            label7.Text = "CPU";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(98, 48);
            label6.Name = "label6";
            label6.Size = new Size(179, 37);
            label6.TabIndex = 8;
            label6.Text = "Cấu hình máy";
            // 
            // labelMayHT
            // 
            labelMayHT.AutoSize = true;
            labelMayHT.Font = new Font("Segoe UI", 15F);
            labelMayHT.Location = new Point(13, 9);
            labelMayHT.Name = "labelMayHT";
            labelMayHT.Size = new Size(73, 28);
            labelMayHT.TabIndex = 0;
            labelMayHT.Text = "MaySo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(349, 14);
            label3.Name = "label3";
            label3.Size = new Size(135, 28);
            label3.TabIndex = 5;
            label3.Text = "Đang sử dụng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Maroon;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(278, 14);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // btnAddMay
            // 
            btnAddMay.BackColor = Color.AliceBlue;
            btnAddMay.Font = new Font("Segoe UI", 12F);
            btnAddMay.Location = new Point(12, 9);
            btnAddMay.Name = "btnAddMay";
            btnAddMay.Size = new Size(119, 33);
            btnAddMay.TabIndex = 6;
            btnAddMay.Text = "Thêm máy";
            btnAddMay.UseVisualStyleBackColor = false;
            btnAddMay.Click += btnAddMay_Click;
            // 
            // flowPanelMayTinh
            // 
            flowPanelMayTinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowPanelMayTinh.Location = new Point(1, 48);
            flowPanelMayTinh.Name = "flowPanelMayTinh";
            flowPanelMayTinh.Size = new Size(416, 435);
            flowPanelMayTinh.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.AliceBlue;
            panel2.Location = new Point(420, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 435);
            panel2.TabIndex = 8;
            // 
            // TTMay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 482);
            Controls.Add(panel2);
            Controls.Add(flowPanelMayTinh);
            Controls.Add(btnAddMay);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TTMay";
            Text = "Tình trạng máy";
            Load += TTMay_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Button btnAddMay;
        private Label labelMayHT;
        private FlowLayoutPanel flowPanelMayTinh;
        private TextBox textBoxRAM;
        private TextBox textBoxGPU;
        private TextBox textBoxCPU;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textBoxManHinh;
        private Label label10;
        private Panel panel2;
        private Button btnSuaThongTinMay;
        private TextBox textBoxGiaMayTrenH;
        private Label label5;
    }
}