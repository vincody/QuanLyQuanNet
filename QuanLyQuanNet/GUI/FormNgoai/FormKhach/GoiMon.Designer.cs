namespace QuanLyQuanNet.GUI.FormNgoai.FormKhach
{
    partial class GoiMon
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
            CagetoryMonAn = new FlowLayoutPanel();
            MenuDoAn = new FlowLayoutPanel();
            panel1 = new Panel();
            textBoxTimMonAn = new TextBox();
            panel2 = new Panel();
            labelTongTien = new Label();
            label1 = new Label();
            ListMonAnDat = new FlowLayoutPanel();
            panelThanhToan = new Panel();
            checkBox2 = new CheckBox();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelThanhToan.SuspendLayout();
            SuspendLayout();
            // 
            // CagetoryMonAn
            // 
            CagetoryMonAn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CagetoryMonAn.BorderStyle = BorderStyle.Fixed3D;
            CagetoryMonAn.Location = new Point(0, 0);
            CagetoryMonAn.Name = "CagetoryMonAn";
            CagetoryMonAn.Size = new Size(500, 42);
            CagetoryMonAn.TabIndex = 0;
            // 
            // MenuDoAn
            // 
            MenuDoAn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MenuDoAn.AutoScroll = true;
            MenuDoAn.BackColor = SystemColors.ControlDarkDark;
            MenuDoAn.BorderStyle = BorderStyle.Fixed3D;
            MenuDoAn.Location = new Point(0, 40);
            MenuDoAn.Name = "MenuDoAn";
            MenuDoAn.Size = new Size(500, 462);
            MenuDoAn.TabIndex = 0;
            MenuDoAn.Paint += MenuDoAn_Paint;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(textBoxTimMonAn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(ListMonAnDat);
            panel1.Controls.Add(panelThanhToan);
            panel1.Location = new Point(506, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 524);
            panel1.TabIndex = 0;
            // 
            // textBoxTimMonAn
            // 
            textBoxTimMonAn.BackColor = Color.LightGray;
            textBoxTimMonAn.BorderStyle = BorderStyle.None;
            textBoxTimMonAn.Font = new Font("Segoe UI", 15F);
            textBoxTimMonAn.Location = new Point(6, 7);
            textBoxTimMonAn.Name = "textBoxTimMonAn";
            textBoxTimMonAn.PlaceholderText = "Tìm tên món ăn";
            textBoxTimMonAn.Size = new Size(210, 27);
            textBoxTimMonAn.TabIndex = 0;
            textBoxTimMonAn.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(labelTongTien);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 347);
            panel2.Name = "panel2";
            panel2.Size = new Size(362, 25);
            panel2.TabIndex = 0;
            // 
            // labelTongTien
            // 
            labelTongTien.AutoSize = true;
            labelTongTien.BackColor = SystemColors.Control;
            labelTongTien.Font = new Font("Segoe UI", 10F);
            labelTongTien.ForeColor = Color.Crimson;
            labelTongTien.Location = new Point(260, 0);
            labelTongTien.Name = "labelTongTien";
            labelTongTien.Size = new Size(49, 19);
            labelTongTien.TabIndex = 1;
            labelTongTien.Text = "SoTien";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 19);
            label1.TabIndex = 0;
            label1.Text = "Tổng tiền:";
            // 
            // ListMonAnDat
            // 
            ListMonAnDat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ListMonAnDat.AutoScroll = true;
            ListMonAnDat.BackColor = SystemColors.ControlDarkDark;
            ListMonAnDat.BorderStyle = BorderStyle.Fixed3D;
            ListMonAnDat.Location = new Point(-1, 40);
            ListMonAnDat.Name = "ListMonAnDat";
            ListMonAnDat.Size = new Size(369, 304);
            ListMonAnDat.TabIndex = 0;
            // 
            // panelThanhToan
            // 
            panelThanhToan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelThanhToan.BorderStyle = BorderStyle.Fixed3D;
            panelThanhToan.Controls.Add(checkBox2);
            panelThanhToan.Controls.Add(textBox1);
            panelThanhToan.Controls.Add(checkBox1);
            panelThanhToan.Controls.Add(button1);
            panelThanhToan.Location = new Point(-1, 378);
            panelThanhToan.Name = "panelThanhToan";
            panelThanhToan.Size = new Size(372, 124);
            panelThanhToan.TabIndex = 0;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 12F);
            checkBox2.Location = new Point(133, 13);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(219, 25);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Dùng số dư trong tài khoản";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 44);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Note cho quán";
            textBox1.Size = new Size(334, 23);
            textBox1.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F);
            checkBox1.Location = new Point(18, 13);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 25);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Tiền mặt";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.AliceBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(18, 73);
            button1.Name = "button1";
            button1.Size = new Size(334, 44);
            button1.TabIndex = 2;
            button1.Text = "Đặt món";
            button1.UseVisualStyleBackColor = false;
            // 
            // GoiMon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 502);
            Controls.Add(panel1);
            Controls.Add(CagetoryMonAn);
            Controls.Add(MenuDoAn);
            Name = "GoiMon";
            Text = "Gọi món";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelThanhToan.ResumeLayout(false);
            panelThanhToan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel CagetoryMonAn;
        private FlowLayoutPanel MenuDoAn;
        private Panel panel1;
        private FlowLayoutPanel ListMonAnDat;
        private Panel panelThanhToan;
        private Panel panel2;
        private Label labelTongTien;
        private Label label1;
        private TextBox textBoxTimMonAn;
        private CheckBox checkBox1;
        private Button button1;
        private TextBox textBox1;
        private CheckBox checkBox2;
    }
}