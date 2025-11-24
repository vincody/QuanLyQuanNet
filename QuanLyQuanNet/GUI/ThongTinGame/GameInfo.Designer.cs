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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            bunifuLabelTenGame = new Bunifu.UI.WinForms.BunifuLabel();
            bunifuPictureBoxHinhAnhGame = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBoxHinhAnhGame).BeginInit();
            SuspendLayout();
            // 
            // bunifuLabelTenGame
            // 
            bunifuLabelTenGame.AllowDrop = true;
            bunifuLabelTenGame.AllowParentOverrides = false;
            bunifuLabelTenGame.AutoEllipsis = false;
            bunifuLabelTenGame.AutoSize = false;
            bunifuLabelTenGame.CursorType = Cursors.Default;
            bunifuLabelTenGame.Font = new Font("Segoe UI", 10F);
            bunifuLabelTenGame.ForeColor = Color.White;
            bunifuLabelTenGame.Location = new Point(16, 78);
            bunifuLabelTenGame.Name = "bunifuLabelTenGame";
            bunifuLabelTenGame.RightToLeft = RightToLeft.No;
            bunifuLabelTenGame.Size = new Size(67, 44);
            bunifuLabelTenGame.TabIndex = 1;
            bunifuLabelTenGame.Text = "TenGame";
            bunifuLabelTenGame.TextAlignment = ContentAlignment.MiddleCenter;
            bunifuLabelTenGame.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBoxHinhAnhGame
            // 
            bunifuPictureBoxHinhAnhGame.BorderRadius = 15;
            bunifuPictureBoxHinhAnhGame.CustomizableEdges = customizableEdges1;
            bunifuPictureBoxHinhAnhGame.FillColor = Color.Transparent;
            bunifuPictureBoxHinhAnhGame.ImageRotate = 0F;
            bunifuPictureBoxHinhAnhGame.Location = new Point(10, 6);
            bunifuPictureBoxHinhAnhGame.Name = "bunifuPictureBoxHinhAnhGame";
            bunifuPictureBoxHinhAnhGame.ShadowDecoration.CustomizableEdges = customizableEdges2;
            bunifuPictureBoxHinhAnhGame.Size = new Size(80, 70);
            bunifuPictureBoxHinhAnhGame.SizeMode = PictureBoxSizeMode.StretchImage;
            bunifuPictureBoxHinhAnhGame.TabIndex = 3;
            bunifuPictureBoxHinhAnhGame.TabStop = false;
            bunifuPictureBoxHinhAnhGame.UseTransparentBackground = true;
            // 
            // GameInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(bunifuPictureBoxHinhAnhGame);
            Controls.Add(bunifuLabelTenGame);
            Name = "GameInfo";
            Size = new Size(99, 129);
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBoxHinhAnhGame).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public Bunifu.UI.WinForms.BunifuLabel bunifuLabelTenGame;
        public Guna.UI2.WinForms.Guna2PictureBox bunifuPictureBoxHinhAnhGame;
    }
}
