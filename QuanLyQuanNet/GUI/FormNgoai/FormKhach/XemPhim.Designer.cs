namespace QuanLyQuanNet.GUI.FormNgoai.FormKhach
{
    partial class XemPhim
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
            vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            ((System.ComponentModel.ISupportInitialize)vlcControl1).BeginInit();
            SuspendLayout();
            // 
            // vlcControl1
            // 
            vlcControl1.BackColor = Color.Black;
            vlcControl1.Dock = DockStyle.Fill;
            vlcControl1.Location = new Point(0, 0);
            vlcControl1.Name = "vlcControl1";
            vlcControl1.Size = new Size(800, 450);
            vlcControl1.Spu = -1;
            vlcControl1.TabIndex = 0;
            vlcControl1.Text = "vlcControl1";
            vlcControl1.VlcLibDirectory = null;
            vlcControl1.VlcMediaplayerOptions = null;
            // 
            // XemPhim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(vlcControl1);
            Name = "XemPhim";
            Text = "XemPhim";
            ((System.ComponentModel.ISupportInitialize)vlcControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Vlc.DotNet.Forms.VlcControl vlcControl1;
    }
}