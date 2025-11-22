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
            bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            webViewPayOS = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webViewPayOS).BeginInit();
            SuspendLayout();
            // 
            // bunifuLabel1
            // 
            bunifuLabel1.AllowParentOverrides = false;
            bunifuLabel1.AutoEllipsis = false;
            bunifuLabel1.CursorType = Cursors.Default;
            bunifuLabel1.Font = new Font("Segoe UI", 15F);
            bunifuLabel1.Location = new Point(274, 27);
            bunifuLabel1.Name = "bunifuLabel1";
            bunifuLabel1.RightToLeft = RightToLeft.No;
            bunifuLabel1.Size = new Size(204, 28);
            bunifuLabel1.TabIndex = 1;
            bunifuLabel1.Text = "Vui lòng quét mã ở đây";
            bunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // webViewPayOS
            // 
            webViewPayOS.AllowExternalDrop = true;
            webViewPayOS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webViewPayOS.CreationProperties = null;
            webViewPayOS.DefaultBackgroundColor = Color.White;
            webViewPayOS.Location = new Point(12, 70);
            webViewPayOS.Name = "webViewPayOS";
            webViewPayOS.Size = new Size(735, 422);
            webViewPayOS.TabIndex = 2;
            webViewPayOS.ZoomFactor = 1D;
            // 
            // XacNhanChuyenKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 513);
            Controls.Add(webViewPayOS);
            Controls.Add(bunifuLabel1);
            Name = "XacNhanChuyenKhoan";
            Text = "XacNhanChuyenKhoan";
            Load += XacNhanChuyenKhoan_Load;
            ((System.ComponentModel.ISupportInitialize)webViewPayOS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewPayOS;
    }
}