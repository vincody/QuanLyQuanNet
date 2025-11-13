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
            labelTenPhim = new Label();
            HinhPhim = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HinhPhim).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelTenPhim);
            panel1.Controls.Add(HinhPhim);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 197);
            panel1.TabIndex = 0;
            // 
            // labelTenPhim
            // 
            labelTenPhim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTenPhim.AutoSize = true;
            labelTenPhim.Font = new Font("Segoe UI", 12F);
            labelTenPhim.Location = new Point(25, 152);
            labelTenPhim.Name = "labelTenPhim";
            labelTenPhim.Size = new Size(69, 21);
            labelTenPhim.TabIndex = 1;
            labelTenPhim.Text = "TenPhim";
            labelTenPhim.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HinhPhim
            // 
            HinhPhim.Location = new Point(30, 3);
            HinhPhim.Name = "HinhPhim";
            HinhPhim.Size = new Size(146, 146);
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
            Size = new Size(210, 197);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HinhPhim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        public Label labelTenPhim;
        public PictureBox HinhPhim;
    }
}
