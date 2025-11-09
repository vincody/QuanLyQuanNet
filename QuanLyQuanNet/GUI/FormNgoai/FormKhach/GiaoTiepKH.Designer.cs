namespace QuanLyQuanNet.GUI.FormNgoai.FormKhach
{
    partial class GiaoTiepKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoTiepKH));
            panel1 = new Panel();
            btnCloseKH = new Button();
            labelChat = new Label();
            textBoxGuiKH = new TextBox();
            btnChatKH = new Button();
            richTextBoxNhanKH = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(btnCloseKH);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 35);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnCloseKH
            // 
            btnCloseKH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseKH.FlatAppearance.BorderSize = 0;
            btnCloseKH.FlatStyle = FlatStyle.Flat;
            btnCloseKH.Image = (Image)resources.GetObject("btnCloseKH.Image");
            btnCloseKH.Location = new Point(650, 4);
            btnCloseKH.Name = "btnCloseKH";
            btnCloseKH.Size = new Size(27, 23);
            btnCloseKH.TabIndex = 5;
            btnCloseKH.UseVisualStyleBackColor = true;
            btnCloseKH.Click += btnCloseKH_Click;
            // 
            // labelChat
            // 
            labelChat.AutoSize = true;
            labelChat.Font = new Font("Segoe UI", 20F);
            labelChat.Image = (Image)resources.GetObject("labelChat.Image");
            labelChat.ImageAlign = ContentAlignment.MiddleLeft;
            labelChat.Location = new Point(25, 38);
            labelChat.Name = "labelChat";
            labelChat.Size = new Size(128, 37);
            labelChat.TabIndex = 2;
            labelChat.Text = "        Chat";
            labelChat.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxGuiKH
            // 
            textBoxGuiKH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxGuiKH.Location = new Point(25, 325);
            textBoxGuiKH.Multiline = true;
            textBoxGuiKH.Name = "textBoxGuiKH";
            textBoxGuiKH.Size = new Size(533, 75);
            textBoxGuiKH.TabIndex = 3;
            // 
            // btnChatKH
            // 
            btnChatKH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChatKH.Image = (Image)resources.GetObject("btnChatKH.Image");
            btnChatKH.Location = new Point(564, 325);
            btnChatKH.Name = "btnChatKH";
            btnChatKH.Size = new Size(92, 75);
            btnChatKH.TabIndex = 4;
            btnChatKH.UseVisualStyleBackColor = true;
            btnChatKH.Click += btnChatKH_Click;
            // 
            // richTextBoxNhanKH
            // 
            richTextBoxNhanKH.Location = new Point(25, 78);
            richTextBoxNhanKH.Name = "richTextBoxNhanKH";
            richTextBoxNhanKH.Size = new Size(631, 241);
            richTextBoxNhanKH.TabIndex = 5;
            richTextBoxNhanKH.Text = "";
            // 
            // GiaoTiepKH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 413);
            Controls.Add(richTextBoxNhanKH);
            Controls.Add(btnChatKH);
            Controls.Add(textBoxGuiKH);
            Controls.Add(labelChat);
            Controls.Add(panel1);
            Name = "GiaoTiepKH";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label labelChat;
        private TextBox textBoxGuiKH;
        private Button btnChatKH;
        private Button btnCloseKH;
        private RichTextBox richTextBoxNhanKH;
    }
}