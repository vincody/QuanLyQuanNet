namespace QuanLyQuanNet.GUI.Menu
{
    partial class MenuKhach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuKhach));
            panelMenu = new Panel();
            btnNapTien = new Button();
            btnGame = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelTitle = new Panel();
            labelList = new Label();
            panelChild = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.AliceBlue;
            panelMenu.Controls.Add(btnNapTien);
            panelMenu.Controls.Add(btnGame);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 597);
            panelMenu.TabIndex = 0;
            // 
            // btnNapTien
            // 
            btnNapTien.Dock = DockStyle.Top;
            btnNapTien.FlatAppearance.BorderSize = 0;
            btnNapTien.FlatStyle = FlatStyle.Flat;
            btnNapTien.Image = (Image)resources.GetObject("btnNapTien.Image");
            btnNapTien.ImageAlign = ContentAlignment.MiddleLeft;
            btnNapTien.Location = new Point(0, 164);
            btnNapTien.Name = "btnNapTien";
            btnNapTien.Padding = new Padding(12, 0, 0, 0);
            btnNapTien.Size = new Size(220, 45);
            btnNapTien.TabIndex = 5;
            btnNapTien.Text = "Nạp tiền ";
            btnNapTien.TextAlign = ContentAlignment.MiddleLeft;
            btnNapTien.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNapTien.UseVisualStyleBackColor = true;
            btnNapTien.Click += btnNapTien_Click;
            // 
            // btnGame
            // 
            btnGame.Dock = DockStyle.Top;
            btnGame.FlatAppearance.BorderSize = 0;
            btnGame.FlatStyle = FlatStyle.Flat;
            btnGame.Image = (Image)resources.GetObject("btnGame.Image");
            btnGame.ImageAlign = ContentAlignment.MiddleLeft;
            btnGame.Location = new Point(0, 119);
            btnGame.Name = "btnGame";
            btnGame.Padding = new Padding(12, 0, 0, 0);
            btnGame.Size = new Size(220, 45);
            btnGame.TabIndex = 3;
            btnGame.Text = "Menu Game";
            btnGame.TextAlign = ContentAlignment.MiddleLeft;
            btnGame.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGame.UseVisualStyleBackColor = true;
            btnGame.Click += btnGame_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 119);
            panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(58, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 119);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.AliceBlue;
            panelTitle.Controls.Add(labelList);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(220, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(816, 119);
            panelTitle.TabIndex = 7;
            panelTitle.MouseDown += panelTitle_MouseDown;
            // 
            // labelList
            // 
            labelList.AutoSize = true;
            labelList.Font = new Font("Segoe UI", 20F);
            labelList.Location = new Point(25, 41);
            labelList.Name = "labelList";
            labelList.Size = new Size(97, 37);
            labelList.TabIndex = 6;
            labelList.Text = "TenList";
            // 
            // panelChild
            // 
            panelChild.Dock = DockStyle.Fill;
            panelChild.Location = new Point(220, 119);
            panelChild.Name = "panelChild";
            panelChild.Size = new Size(816, 478);
            panelChild.TabIndex = 7;
            // 
            // MenuKhach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 597);
            Controls.Add(panelChild);
            Controls.Add(panelTitle);
            Controls.Add(panelMenu);
            Name = "MenuKhach";
            Text = "MenuKhach";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Button btnGame;
        private Button btnNapTien;
        private Panel panelTitle;
        private Label labelList;
        private Panel panelChild;
    }
}