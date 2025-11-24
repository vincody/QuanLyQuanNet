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
            textBoxTimKiemGame = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // CagetoryGames
            // 
            CagetoryGames.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CagetoryGames.Location = new Point(0, 57);
            CagetoryGames.Name = "CagetoryGames";
            CagetoryGames.Size = new Size(1157, 55);
            CagetoryGames.TabIndex = 9;
            // 
            // flowPanelGame
            // 
            flowPanelGame.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowPanelGame.AutoScroll = true;
            flowPanelGame.Location = new Point(0, 111);
            flowPanelGame.Name = "flowPanelGame";
            flowPanelGame.Size = new Size(1157, 417);
            flowPanelGame.TabIndex = 8;
            // 
            // bunifuLabel1
            // 
            bunifuLabel1.AllowParentOverrides = false;
            bunifuLabel1.AutoEllipsis = false;
            bunifuLabel1.CursorType = Cursors.Default;
            bunifuLabel1.Font = new Font("Segoe Script", 25F);
            bunifuLabel1.ForeColor = Color.White;
            bunifuLabel1.Location = new Point(36, 2);
            bunifuLabel1.Name = "bunifuLabel1";
            bunifuLabel1.RightToLeft = RightToLeft.No;
            bunifuLabel1.Size = new Size(114, 52);
            bunifuLabel1.TabIndex = 10;
            bunifuLabel1.Text = "Games";
            bunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // textBoxTimKiemGame
            // 
            textBoxTimKiemGame.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTimKiemGame.BorderRadius = 15;
            customizableEdges1.TopLeft = false;
            textBoxTimKiemGame.CustomizableEdges = customizableEdges1;
            textBoxTimKiemGame.DefaultText = "";
            textBoxTimKiemGame.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBoxTimKiemGame.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBoxTimKiemGame.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBoxTimKiemGame.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxTimKiemGame.FillColor = Color.FromArgb(73, 85, 101);
            textBoxTimKiemGame.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxTimKiemGame.Font = new Font("Segoe UI", 9F);
            textBoxTimKiemGame.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxTimKiemGame.IconLeft = (Image)resources.GetObject("textBoxTimKiemGame.IconLeft");
            textBoxTimKiemGame.Location = new Point(183, 12);
            textBoxTimKiemGame.Name = "textBoxTimKiemGame";
            textBoxTimKiemGame.PlaceholderForeColor = Color.White;
            textBoxTimKiemGame.PlaceholderText = "Tìm kiếm game";
            textBoxTimKiemGame.SelectedText = "";
            textBoxTimKiemGame.ShadowDecoration.CustomizableEdges = customizableEdges2;
            textBoxTimKiemGame.Size = new Size(962, 36);
            textBoxTimKiemGame.TabIndex = 11;
            textBoxTimKiemGame.TextChanged += textBoxTimKiemGame_TextChanged;
            // 
            // MenuGames
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(73, 85, 101);
            ClientSize = new Size(1157, 528);
            Controls.Add(textBoxTimKiemGame);
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
        private Guna.UI2.WinForms.Guna2TextBox textBoxTimKiemGame;
    }
}