namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    partial class ChiTietOrderMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietOrderMon));
            flowPanelOrder = new FlowLayoutPanel();
            panel1 = new Panel();
            btnClose = new Button();
            btnHoanThanhDon = new Button();
            labelTongTien = new Label();
            label2 = new Label();
            labelMaDon = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowPanelOrder
            // 
            flowPanelOrder.Dock = DockStyle.Bottom;
            flowPanelOrder.Location = new Point(0, 70);
            flowPanelOrder.Name = "flowPanelOrder";
            flowPanelOrder.Size = new Size(800, 380);
            flowPanelOrder.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnHoanThanhDon);
            panel1.Controls.Add(labelTongTien);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(labelMaDon);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 64);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.AliceBlue;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(761, 24);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 23);
            btnClose.TabIndex = 5;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnHoanThanhDon
            // 
            btnHoanThanhDon.Font = new Font("Segoe UI", 15F);
            btnHoanThanhDon.Location = new Point(477, 18);
            btnHoanThanhDon.Name = "btnHoanThanhDon";
            btnHoanThanhDon.Size = new Size(278, 35);
            btnHoanThanhDon.TabIndex = 4;
            btnHoanThanhDon.Text = "Hoành thành đơn";
            btnHoanThanhDon.UseVisualStyleBackColor = true;
            btnHoanThanhDon.Click += btnHoanThanhDon_Click_1;
            // 
            // labelTongTien
            // 
            labelTongTien.AutoSize = true;
            labelTongTien.Font = new Font("Segoe UI", 15F);
            labelTongTien.Location = new Point(288, 21);
            labelTongTien.Name = "labelTongTien";
            labelTongTien.Size = new Size(35, 28);
            labelTongTien.TabIndex = 3;
            labelTongTien.Text = "So";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(181, 21);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 2;
            label2.Text = "Tổng đơn:";
            // 
            // labelMaDon
            // 
            labelMaDon.AutoSize = true;
            labelMaDon.Font = new Font("Segoe UI", 15F);
            labelMaDon.Location = new Point(12, 21);
            labelMaDon.Name = "labelMaDon";
            labelMaDon.Size = new Size(35, 28);
            labelMaDon.TabIndex = 1;
            labelMaDon.Text = "So";
            // 
            // ChiTietOrderMon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(flowPanelOrder);
            Name = "ChiTietOrderMon";
            Text = "ChiTietOrderMon";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowPanelOrder;
        private Panel panel1;
        private Label labelMaDon;
        private Label label2;
        private Label labelTongTien;
        private Button btnHoanThanhDon;
        private Button btnClose;
    }
}