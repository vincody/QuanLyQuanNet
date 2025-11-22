namespace QuanLyQuanNet.GUI.Menu
{
    partial class ThongTinKhachNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinKhachNew));
            bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            SuspendLayout();
            // 
            // bunifuPanel1
            // 
            bunifuPanel1.BackgroundColor = Color.Transparent;
            bunifuPanel1.BackgroundImage = (Image)resources.GetObject("bunifuPanel1.BackgroundImage");
            bunifuPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuPanel1.BorderColor = Color.Transparent;
            bunifuPanel1.BorderRadius = 3;
            bunifuPanel1.BorderThickness = 1;
            bunifuPanel1.Location = new Point(0, 0);
            bunifuPanel1.Name = "bunifuPanel1";
            bunifuPanel1.ShowBorders = true;
            bunifuPanel1.Size = new Size(338, 44);
            bunifuPanel1.TabIndex = 0;
            // 
            // ThongTinKhachNew
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 450);
            Controls.Add(bunifuPanel1);
            Name = "ThongTinKhachNew";
            Text = "ThongTinKhachNew";
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
    }
}