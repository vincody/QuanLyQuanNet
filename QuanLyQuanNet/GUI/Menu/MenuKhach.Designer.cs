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
            btnXemPhim = new Button();
            btnGoiMon = new Button();
            btnNapTien = new Button();
            btnGame = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelTitle = new Panel();
            btnCloseK = new Button();
            btnMaximizeK = new Button();
            btnMinimizeK = new Button();
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
            panelMenu.Controls.Add(btnXemPhim);
            panelMenu.Controls.Add(btnGoiMon);
            panelMenu.Controls.Add(btnNapTien);
            panelMenu.Controls.Add(btnGame);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 637);
            panelMenu.TabIndex = 0;
            // 
            // btnXemPhim
            // 
            btnXemPhim.Dock = DockStyle.Top;
            btnXemPhim.FlatAppearance.BorderSize = 0;
            btnXemPhim.FlatStyle = FlatStyle.Flat;
            btnXemPhim.Image = (Image)resources.GetObject("btnXemPhim.Image");
            btnXemPhim.ImageAlign = ContentAlignment.MiddleLeft;
            btnXemPhim.Location = new Point(0, 254);
            btnXemPhim.Name = "btnXemPhim";
            btnXemPhim.Padding = new Padding(12, 0, 0, 0);
            btnXemPhim.Size = new Size(220, 45);
            btnXemPhim.TabIndex = 7;
            btnXemPhim.Text = "Xem phim";
            btnXemPhim.TextAlign = ContentAlignment.MiddleLeft;
            btnXemPhim.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXemPhim.UseVisualStyleBackColor = true;
            btnXemPhim.Click += btnXemPhim_Click;
            // 
            // btnGoiMon
            // 
            btnGoiMon.Dock = DockStyle.Top;
            btnGoiMon.FlatAppearance.BorderSize = 0;
            btnGoiMon.FlatStyle = FlatStyle.Flat;
            btnGoiMon.Image = (Image)resources.GetObject("btnGoiMon.Image");
            btnGoiMon.ImageAlign = ContentAlignment.MiddleLeft;
            btnGoiMon.Location = new Point(0, 209);
            btnGoiMon.Name = "btnGoiMon";
            btnGoiMon.Padding = new Padding(12, 0, 0, 0);
            btnGoiMon.Size = new Size(220, 45);
            btnGoiMon.TabIndex = 6;
            btnGoiMon.Text = "Gọi món";
            btnGoiMon.TextAlign = ContentAlignment.MiddleLeft;
            btnGoiMon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGoiMon.UseVisualStyleBackColor = true;
            btnGoiMon.Click += btnGoiMon_Click;
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
            panelTitle.Controls.Add(btnCloseK);
            panelTitle.Controls.Add(btnMaximizeK);
            panelTitle.Controls.Add(btnMinimizeK);
            panelTitle.Controls.Add(labelList);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(220, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(868, 119);
            panelTitle.TabIndex = 7;
            panelTitle.MouseDown += panelTitle_MouseDown;
            // 
            // btnCloseK
            // 
            btnCloseK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseK.FlatAppearance.BorderSize = 0;
            btnCloseK.FlatStyle = FlatStyle.Flat;
            btnCloseK.Image = (Image)resources.GetObject("btnCloseK.Image");
            btnCloseK.Location = new Point(836, 3);
            btnCloseK.Name = "btnCloseK";
            btnCloseK.Size = new Size(27, 23);
            btnCloseK.TabIndex = 9;
            btnCloseK.UseVisualStyleBackColor = true;
            btnCloseK.Click += btnCloseK_Click;
            // 
            // btnMaximizeK
            // 
            btnMaximizeK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizeK.FlatAppearance.BorderSize = 0;
            btnMaximizeK.FlatStyle = FlatStyle.Flat;
            btnMaximizeK.Image = (Image)resources.GetObject("btnMaximizeK.Image");
            btnMaximizeK.Location = new Point(803, 2);
            btnMaximizeK.Name = "btnMaximizeK";
            btnMaximizeK.Size = new Size(27, 23);
            btnMaximizeK.TabIndex = 8;
            btnMaximizeK.UseVisualStyleBackColor = true;
            btnMaximizeK.Click += btnMaximizeK_Click;
            // 
            // btnMinimizeK
            // 
            btnMinimizeK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizeK.FlatAppearance.BorderSize = 0;
            btnMinimizeK.FlatStyle = FlatStyle.Flat;
            btnMinimizeK.Image = (Image)resources.GetObject("btnMinimizeK.Image");
            btnMinimizeK.Location = new Point(770, 3);
            btnMinimizeK.Name = "btnMinimizeK";
            btnMinimizeK.Size = new Size(27, 23);
            btnMinimizeK.TabIndex = 7;
            btnMinimizeK.UseVisualStyleBackColor = true;
            btnMinimizeK.Click += btnMinimizeK_Click;
            // 
            // labelList
            // 
            labelList.AutoSize = true;
            labelList.Font = new Font("Segoe UI", 20F);
            labelList.Location = new Point(25, 41);
            labelList.Name = "labelList";
            labelList.Size = new Size(85, 37);
            labelList.TabIndex = 6;
            labelList.Text = "Menu";
            // 
            // panelChild
            // 
            panelChild.AutoScroll = true;
            panelChild.Dock = DockStyle.Fill;
            panelChild.Location = new Point(220, 119);
            panelChild.Name = "panelChild";
            panelChild.Size = new Size(868, 518);
            panelChild.TabIndex = 7;
            // 
            // MenuKhach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 637);
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
        private Button btnMinimizeK;
        private Button btnCloseK;
        private Button btnMaximizeK;
        private Button btnGoiMon;
        private Button btnXemPhim;
    }
}