namespace QuanLyQuanNet.GUI.VocVachPhim
{
    partial class ThongTinPhim
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            labelTenPhim = new Label();
            labelTap = new Label();
            HinhPhim = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HinhPhim).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(HinhPhim);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 240);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelTenPhim);
            panel2.Controls.Add(labelTap);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 193);
            panel2.Name = "panel2";
            panel2.Size = new Size(216, 43);
            panel2.TabIndex = 3;
            // 
            // labelTenPhim
            // 
            labelTenPhim.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelTenPhim.AutoSize = true;
            labelTenPhim.Font = new Font("Segoe UI", 9F);
            labelTenPhim.Location = new Point(51, 5);
            labelTenPhim.Name = "labelTenPhim";
            labelTenPhim.Size = new Size(54, 15);
            labelTenPhim.TabIndex = 1;
            labelTenPhim.Text = "TenPhim";
            labelTenPhim.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTap
            // 
            labelTap.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelTap.AutoSize = true;
            labelTap.Location = new Point(79, 28);
            labelTap.Name = "labelTap";
            labelTap.Size = new Size(26, 15);
            labelTap.TabIndex = 2;
            labelTap.Text = "Tap";
            labelTap.TextAlign = ContentAlignment.MiddleCenter;
            labelTap.Click += label1_Click;
            // 
            // HinhPhim
            // 
            HinhPhim.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            HinhPhim.Location = new Point(27, 3);
            HinhPhim.Name = "HinhPhim";
            HinhPhim.Size = new Size(162, 192);
            HinhPhim.SizeMode = PictureBoxSizeMode.StretchImage;
            HinhPhim.TabIndex = 0;
            HinhPhim.TabStop = false;
            // 
            // ThongTinPhim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ThongTinPhim";
            Size = new Size(220, 240);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HinhPhim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        public Label labelTenPhim;
        public PictureBox HinhPhim;
        public Label labelTap;
        public Panel panel2;
    }
}
