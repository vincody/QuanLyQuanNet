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
            btnChat = new Button();
            btnGame = new Button();
            btnFoods = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelThongTin = new Panel();
            panelTitle = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.AliceBlue;
            panelMenu.Controls.Add(btnNapTien);
            panelMenu.Controls.Add(btnChat);
            panelMenu.Controls.Add(btnGame);
            panelMenu.Controls.Add(btnFoods);
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
            btnNapTien.Location = new Point(0, 254);
            btnNapTien.Name = "btnNapTien";
            btnNapTien.Size = new Size(220, 45);
            btnNapTien.TabIndex = 5;
            btnNapTien.Text = "Nạp tiền ";
            btnNapTien.TextAlign = ContentAlignment.MiddleLeft;
            btnNapTien.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNapTien.UseVisualStyleBackColor = true;
            btnNapTien.Click += btnNapTien_Click;
            // 
            // btnChat
            // 
            btnChat.Dock = DockStyle.Top;
            btnChat.FlatAppearance.BorderSize = 0;
            btnChat.FlatStyle = FlatStyle.Flat;
            btnChat.Image = (Image)resources.GetObject("btnChat.Image");
            btnChat.ImageAlign = ContentAlignment.MiddleLeft;
            btnChat.Location = new Point(0, 209);
            btnChat.Name = "btnChat";
            btnChat.Size = new Size(220, 45);
            btnChat.TabIndex = 4;
            btnChat.Text = "Chat với quán";
            btnChat.TextAlign = ContentAlignment.MiddleLeft;
            btnChat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChat.UseVisualStyleBackColor = true;
            btnChat.Click += btnChat_Click;
            // 
            // btnGame
            // 
            btnGame.Dock = DockStyle.Top;
            btnGame.FlatAppearance.BorderSize = 0;
            btnGame.FlatStyle = FlatStyle.Flat;
            btnGame.Image = (Image)resources.GetObject("btnGame.Image");
            btnGame.ImageAlign = ContentAlignment.MiddleLeft;
            btnGame.Location = new Point(0, 164);
            btnGame.Name = "btnGame";
            btnGame.Size = new Size(220, 45);
            btnGame.TabIndex = 3;
            btnGame.Text = "Menu Game";
            btnGame.TextAlign = ContentAlignment.MiddleLeft;
            btnGame.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGame.UseVisualStyleBackColor = true;
            btnGame.Click += btnGame_Click;
            // 
            // btnFoods
            // 
            btnFoods.Dock = DockStyle.Top;
            btnFoods.FlatAppearance.BorderSize = 0;
            btnFoods.FlatStyle = FlatStyle.Flat;
            btnFoods.Image = (Image)resources.GetObject("btnFoods.Image");
            btnFoods.ImageAlign = ContentAlignment.MiddleLeft;
            btnFoods.Location = new Point(0, 119);
            btnFoods.Name = "btnFoods";
            btnFoods.Size = new Size(220, 45);
            btnFoods.TabIndex = 2;
            btnFoods.Text = "Đặt món";
            btnFoods.TextAlign = ContentAlignment.MiddleLeft;
            btnFoods.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFoods.UseVisualStyleBackColor = true;
            btnFoods.Click += btnFoods_Click;
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
            // panelThongTin
            // 
            panelThongTin.BackColor = Color.AliceBlue;
            panelThongTin.Dock = DockStyle.Right;
            panelThongTin.Location = new Point(836, 0);
            panelThongTin.Name = "panelThongTin";
            panelThongTin.Size = new Size(200, 597);
            panelThongTin.TabIndex = 6;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.AliceBlue;
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(220, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(616, 119);
            panelTitle.TabIndex = 7;
            // 
            // MenuKhach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 597);
            Controls.Add(panelTitle);
            Controls.Add(panelThongTin);
            Controls.Add(panelMenu);
            Name = "MenuKhach";
            Text = "MenuKhach";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Button btnFoods;
        private Button btnChat;
        private Button btnGame;
        private Button btnNapTien;
        private Panel panelThongTin;
        private Panel panelTitle;
    }
}