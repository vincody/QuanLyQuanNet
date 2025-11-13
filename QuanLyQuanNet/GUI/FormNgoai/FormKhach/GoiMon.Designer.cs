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
            checkBoxSoDu = new CheckBox();
            textBoxNote = new TextBox();
            checkBoxTienMat = new CheckBox();
            btnDatMon = new Button();
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
            panelThanhToan.Controls.Add(checkBoxSoDu);
            panelThanhToan.Controls.Add(textBoxNote);
            panelThanhToan.Controls.Add(checkBoxTienMat);
            panelThanhToan.Controls.Add(btnDatMon);
            panelThanhToan.Location = new Point(-1, 378);
            panelThanhToan.Name = "panelThanhToan";
            panelThanhToan.Size = new Size(372, 124);
            panelThanhToan.TabIndex = 0;
            // 
            // checkBoxSoDu
            // 
            checkBoxSoDu.AutoSize = true;
            checkBoxSoDu.Font = new Font("Segoe UI", 12F);
            checkBoxSoDu.Location = new Point(133, 13);
            checkBoxSoDu.Name = "checkBoxSoDu";
            checkBoxSoDu.Size = new Size(219, 25);
            checkBoxSoDu.TabIndex = 4;
            checkBoxSoDu.Text = "Dùng số dư trong tài khoản";
            checkBoxSoDu.UseVisualStyleBackColor = true;
            // 
            // textBoxNote
            // 
            textBoxNote.Location = new Point(18, 44);
            textBoxNote.Name = "textBoxNote";
            textBoxNote.PlaceholderText = "Note cho quán";
            textBoxNote.Size = new Size(334, 23);
            textBoxNote.TabIndex = 3;
            // 
            // checkBoxTienMat
            // 
            checkBoxTienMat.AutoSize = true;
            checkBoxTienMat.Font = new Font("Segoe UI", 12F);
            checkBoxTienMat.Location = new Point(18, 13);
            checkBoxTienMat.Name = "checkBoxTienMat";
            checkBoxTienMat.Size = new Size(89, 25);
            checkBoxTienMat.TabIndex = 1;
            checkBoxTienMat.Text = "Tiền mặt";
            checkBoxTienMat.UseVisualStyleBackColor = true;
            // 
            // btnDatMon
            // 
            btnDatMon.BackColor = Color.AliceBlue;
            btnDatMon.FlatAppearance.BorderSize = 0;
            btnDatMon.FlatStyle = FlatStyle.Flat;
            btnDatMon.Font = new Font("Segoe UI", 15F);
            btnDatMon.Location = new Point(18, 73);
            btnDatMon.Name = "btnDatMon";
            btnDatMon.Size = new Size(334, 44);
            btnDatMon.TabIndex = 2;
            btnDatMon.Text = "Đặt món";
            btnDatMon.UseVisualStyleBackColor = false;
            btnDatMon.Click += btnDatMon_Click;
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
        private CheckBox checkBoxTienMat;
        private Button btnDatMon;
        private TextBox textBoxNote;
        private CheckBox checkBoxSoDu;
    }
}