namespace QuanLyQuanNet.GUI.ViewDoAn
{
    partial class DoAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoAn));
            panel1 = new Panel();
            panel2 = new Panel();
            labelTenDoAn = new Label();
            labelGiaDoAn = new Label();
            pictureBoxHinhAnh = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHinhAnh).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(labelGiaDoAn);
            panel1.Controls.Add(pictureBoxHinhAnh);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 194);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelTenDoAn);
            panel2.Location = new Point(0, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 28);
            panel2.TabIndex = 3;
            // 
            // labelTenDoAn
            // 
            labelTenDoAn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelTenDoAn.Location = new Point(61, 3);
            labelTenDoAn.Name = "labelTenDoAn";
            labelTenDoAn.Size = new Size(66, 15);
            labelTenDoAn.TabIndex = 1;
            labelTenDoAn.Text = "TenMonAn";
            labelTenDoAn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelGiaDoAn
            // 
            labelGiaDoAn.AutoSize = true;
            labelGiaDoAn.ForeColor = Color.Firebrick;
            labelGiaDoAn.Location = new Point(3, 177);
            labelGiaDoAn.Name = "labelGiaDoAn";
            labelGiaDoAn.Size = new Size(54, 15);
            labelGiaDoAn.TabIndex = 2;
            labelGiaDoAn.Text = "GiaDoAn";
            // 
            // pictureBoxHinhAnh
            // 
            pictureBoxHinhAnh.Image = (Image)resources.GetObject("pictureBoxHinhAnh.Image");
            pictureBoxHinhAnh.Location = new Point(29, 15);
            pictureBoxHinhAnh.Name = "pictureBoxHinhAnh";
            pictureBoxHinhAnh.Size = new Size(133, 131);
            pictureBoxHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHinhAnh.TabIndex = 0;
            pictureBoxHinhAnh.TabStop = false;
            pictureBoxHinhAnh.Click += pictureBoxHinhAnh_Click;
            // 
            // DoAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "DoAn";
            Size = new Size(190, 194);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxHinhAnh).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public PictureBox pictureBoxHinhAnh;
        public Label labelGiaDoAn;
        public Label labelTenDoAn;
        public Panel panel1;
        private Panel panel2;
    }
}
