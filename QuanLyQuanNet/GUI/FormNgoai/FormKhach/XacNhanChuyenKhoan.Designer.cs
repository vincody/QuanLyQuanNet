namespace QuanLyQuanNet.GUI.FormNgoai.FormKhach
{
    partial class XacNhanChuyenKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XacNhanChuyenKhoan));
            pictureBoxHienThiMa = new PictureBox();
            bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHienThiMa).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxHienThiMa
            // 
            pictureBoxHienThiMa.Location = new Point(15, 54);
            pictureBoxHienThiMa.Name = "pictureBoxHienThiMa";
            pictureBoxHienThiMa.Size = new Size(414, 282);
            pictureBoxHienThiMa.TabIndex = 0;
            pictureBoxHienThiMa.TabStop = false;
            // 
            // bunifuLabel1
            // 
            bunifuLabel1.AllowParentOverrides = false;
            bunifuLabel1.AutoEllipsis = false;
            bunifuLabel1.CursorType = Cursors.Default;
            bunifuLabel1.Font = new Font("Segoe UI", 15F);
            bunifuLabel1.Location = new Point(115, 20);
            bunifuLabel1.Name = "bunifuLabel1";
            bunifuLabel1.RightToLeft = RightToLeft.No;
            bunifuLabel1.Size = new Size(204, 28);
            bunifuLabel1.TabIndex = 1;
            bunifuLabel1.Text = "Vui lòng quét mã ở đây";
            bunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // XacNhanChuyenKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 379);
            Controls.Add(bunifuLabel1);
            Controls.Add(pictureBoxHienThiMa);
            Name = "XacNhanChuyenKhoan";
            Text = "XacNhanChuyenKhoan";
            ((System.ComponentModel.ISupportInitialize)pictureBoxHienThiMa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxHienThiMa;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}