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
            CagetoryGames = new FlowLayoutPanel();
            flowPanelGame = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // CagetoryGames
            // 
            CagetoryGames.Dock = DockStyle.Top;
            CagetoryGames.Location = new Point(0, 0);
            CagetoryGames.Name = "CagetoryGames";
            CagetoryGames.Size = new Size(808, 57);
            CagetoryGames.TabIndex = 9;
            // 
            // flowPanelGame
            // 
            flowPanelGame.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowPanelGame.AutoScroll = true;
            flowPanelGame.Location = new Point(0, 55);
            flowPanelGame.Name = "flowPanelGame";
            flowPanelGame.Size = new Size(808, 395);
            flowPanelGame.TabIndex = 8;
            // 
            // MenuGames
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 450);
            Controls.Add(CagetoryGames);
            Controls.Add(flowPanelGame);
            Name = "MenuGames";
            Text = "Menu games";
            ResumeLayout(false);
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
    }
}