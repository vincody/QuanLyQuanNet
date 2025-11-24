namespace QuanLyQuanNet.GUI.FormNgoai.FormKhach
{
    partial class MenuGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGames));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            CagetoryGames = new FlowLayoutPanel();
            flowPanelGame = new FlowLayoutPanel();
            bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // CagetoryGames
            // 
            CagetoryGames.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CagetoryGames.Location = new Point(0, 57);
            CagetoryGames.Name = "CagetoryGames";
            CagetoryGames.Size = new Size(1048, 55);
            CagetoryGames.TabIndex = 9;
            // 
            // flowPanelGame
            // 
            flowPanelGame.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowPanelGame.AutoScroll = true;
            flowPanelGame.Location = new Point(0, 111);
            flowPanelGame.Name = "flowPanelGame";
            flowPanelGame.Size = new Size(1048, 417);
            flowPanelGame.TabIndex = 8;
            // 
            // bunifuLabel1
            // 
            bunifuLabel1.AllowParentOverrides = false;
            bunifuLabel1.AutoEllipsis = false;
            bunifuLabel1.CursorType = Cursors.Default;
            bunifuLabel1.Font = new Font("Segoe Script", 25F);
            bunifuLabel1.ForeColor = Color.White;
            bunifuLabel1.Location = new Point(36, 1);
            bunifuLabel1.Name = "bunifuLabel1";
            bunifuLabel1.RightToLeft = RightToLeft.No;
            bunifuLabel1.Size = new Size(114, 52);
            bunifuLabel1.TabIndex = 10;
            bunifuLabel1.Text = "Games";
            bunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2TextBox1.BorderRadius = 15;
            customizableEdges1.TopLeft = false;
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FillColor = Color.FromArgb(73, 85, 101);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.IconLeft = (Image)resources.GetObject("guna2TextBox1.IconLeft");
            guna2TextBox1.Location = new Point(183, 12);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderForeColor = Color.White;
            guna2TextBox1.PlaceholderText = "Tìm kiếm game";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(853, 36);
            guna2TextBox1.TabIndex = 11;
            // 
            // MenuGames
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(73, 85, 101);
            ClientSize = new Size(1048, 528);
            Controls.Add(guna2TextBox1);
            Controls.Add(bunifuLabel1);
            Controls.Add(CagetoryGames);
            Controls.Add(flowPanelGame);
            Name = "MenuGames";
            Text = "Menu games";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private FlowLayoutPanel CagetoryGames;
        private FlowLayoutPanel flowPanelGame;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}