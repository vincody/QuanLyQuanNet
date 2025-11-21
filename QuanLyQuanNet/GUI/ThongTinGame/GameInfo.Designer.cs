namespace QuanLyQuanNet.GUI.ThongTinGame
{
    partial class GameInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameInfo));
            bunifuPictureBoxHinhAnhGame = new Bunifu.UI.WinForms.BunifuPictureBox();
            bunifuLabelTenGame = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBoxHinhAnhGame).BeginInit();
            SuspendLayout();
            // 
            // bunifuPictureBoxHinhAnhGame
            // 
            bunifuPictureBoxHinhAnhGame.AllowFocused = false;
            bunifuPictureBoxHinhAnhGame.Anchor = AnchorStyles.None;
            bunifuPictureBoxHinhAnhGame.AutoSizeHeight = true;
            bunifuPictureBoxHinhAnhGame.BorderRadius = 23;
            bunifuPictureBoxHinhAnhGame.Image = (Image)resources.GetObject("bunifuPictureBoxHinhAnhGame.Image");
            bunifuPictureBoxHinhAnhGame.IsCircle = true;
            bunifuPictureBoxHinhAnhGame.Location = new Point(12, 3);
            bunifuPictureBoxHinhAnhGame.Name = "bunifuPictureBoxHinhAnhGame";
            bunifuPictureBoxHinhAnhGame.Size = new Size(46, 46);
            bunifuPictureBoxHinhAnhGame.SizeMode = PictureBoxSizeMode.StretchImage;
            bunifuPictureBoxHinhAnhGame.TabIndex = 0;
            bunifuPictureBoxHinhAnhGame.TabStop = false;
            bunifuPictureBoxHinhAnhGame.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuLabelTenGame
            // 
            bunifuLabelTenGame.AllowDrop = true;
            bunifuLabelTenGame.AllowParentOverrides = false;
            bunifuLabelTenGame.AutoEllipsis = false;
            bunifuLabelTenGame.AutoSize = false;
            bunifuLabelTenGame.CursorType = Cursors.Default;
            bunifuLabelTenGame.Font = new Font("Segoe UI", 9F);
            bunifuLabelTenGame.Location = new Point(0, 55);
            bunifuLabelTenGame.Name = "bunifuLabelTenGame";
            bunifuLabelTenGame.RightToLeft = RightToLeft.No;
            bunifuLabelTenGame.Size = new Size(67, 44);
            bunifuLabelTenGame.TabIndex = 1;
            bunifuLabelTenGame.Text = "TenGame";
            bunifuLabelTenGame.TextAlignment = ContentAlignment.MiddleCenter;
            bunifuLabelTenGame.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // GameInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bunifuLabelTenGame);
            Controls.Add(bunifuPictureBoxHinhAnhGame);
            Name = "GameInfo";
            Size = new Size(67, 99);
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBoxHinhAnhGame).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBoxHinhAnhGame;
        public Bunifu.UI.WinForms.BunifuLabel bunifuLabelTenGame;
    }
}
