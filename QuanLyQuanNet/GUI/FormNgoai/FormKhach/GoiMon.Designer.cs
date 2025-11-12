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
            panel2 = new Panel();
            labelTongTien = new Label();
            label1 = new Label();
            ListMonAnDat = new FlowLayoutPanel();
            panelThanhToan = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // CagetoryMonAn
            // 
            CagetoryMonAn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CagetoryMonAn.Location = new Point(0, 0);
            CagetoryMonAn.Name = "CagetoryMonAn";
            CagetoryMonAn.Size = new Size(500, 53);
            CagetoryMonAn.TabIndex = 0;
            // 
            // MenuDoAn
            // 
            MenuDoAn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MenuDoAn.AutoScroll = true;
            MenuDoAn.BackColor = SystemColors.ControlDarkDark;
            MenuDoAn.Location = new Point(0, 59);
            MenuDoAn.Name = "MenuDoAn";
            MenuDoAn.Size = new Size(500, 465);
            MenuDoAn.TabIndex = 0;
            MenuDoAn.Paint += MenuDoAn_Paint;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(ListMonAnDat);
            panel1.Controls.Add(panelThanhToan);
            panel1.Location = new Point(506, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 524);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelTongTien);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 347);
            panel2.Name = "panel2";
            panel2.Size = new Size(369, 25);
            panel2.TabIndex = 0;
            // 
            // labelTongTien
            // 
            labelTongTien.AutoSize = true;
            labelTongTien.BackColor = SystemColors.Control;
            labelTongTien.Font = new Font("Segoe UI", 10F);
            labelTongTien.ForeColor = Color.Crimson;
            labelTongTien.Location = new Point(320, 0);
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
            ListMonAnDat.Location = new Point(3, 59);
            ListMonAnDat.Name = "ListMonAnDat";
            ListMonAnDat.Size = new Size(369, 285);
            ListMonAnDat.TabIndex = 0;
            // 
            // panelThanhToan
            // 
            panelThanhToan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelThanhToan.Location = new Point(3, 378);
            panelThanhToan.Name = "panelThanhToan";
            panelThanhToan.Size = new Size(372, 146);
            panelThanhToan.TabIndex = 0;
            // 
            // GoiMon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 524);
            Controls.Add(panel1);
            Controls.Add(CagetoryMonAn);
            Controls.Add(MenuDoAn);
            Name = "GoiMon";
            Text = "GoiMon";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
    }
}