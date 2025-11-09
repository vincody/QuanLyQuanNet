namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    partial class ChatvKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatvKH));
            panel1 = new Panel();
            btnCloseAd = new Button();
            labelTenMay = new Label();
            textBoxNhanAD = new TextBox();
            textBoxGuiAD = new TextBox();
            btnChatAd = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(btnCloseAd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 35);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnCloseAd
            // 
            btnCloseAd.FlatAppearance.BorderSize = 0;
            btnCloseAd.FlatStyle = FlatStyle.Flat;
            btnCloseAd.Image = (Image)resources.GetObject("btnCloseAd.Image");
            btnCloseAd.Location = new Point(650, 4);
            btnCloseAd.Name = "btnCloseAd";
            btnCloseAd.Size = new Size(27, 23);
            btnCloseAd.TabIndex = 0;
            btnCloseAd.UseVisualStyleBackColor = true;
            btnCloseAd.Click += btnCloseAd_Click;
            // 
            // labelTenMay
            // 
            labelTenMay.AutoSize = true;
            labelTenMay.Font = new Font("Segoe UI", 20F);
            labelTenMay.Location = new Point(25, 38);
            labelTenMay.Name = "labelTenMay";
            labelTenMay.Size = new Size(68, 37);
            labelTenMay.TabIndex = 1;
            labelTenMay.Text = "May";
            // 
            // textBoxNhanAD
            // 
            textBoxNhanAD.Location = new Point(25, 78);
            textBoxNhanAD.Multiline = true;
            textBoxNhanAD.Name = "textBoxNhanAD";
            textBoxNhanAD.ReadOnly = true;
            textBoxNhanAD.Size = new Size(631, 241);
            textBoxNhanAD.TabIndex = 3;
            // 
            // textBoxGuiAD
            // 
            textBoxGuiAD.Location = new Point(25, 325);
            textBoxGuiAD.Multiline = true;
            textBoxGuiAD.Name = "textBoxGuiAD";
            textBoxGuiAD.Size = new Size(533, 75);
            textBoxGuiAD.TabIndex = 4;
            // 
            // btnChatAd
            // 
            btnChatAd.Image = (Image)resources.GetObject("btnChatAd.Image");
            btnChatAd.Location = new Point(564, 325);
            btnChatAd.Name = "btnChatAd";
            btnChatAd.Size = new Size(92, 75);
            btnChatAd.TabIndex = 5;
            btnChatAd.UseVisualStyleBackColor = true;
            btnChatAd.Click += btnChatAd_Click;
            // 
            // ChatvKH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 413);
            Controls.Add(btnChatAd);
            Controls.Add(textBoxGuiAD);
            Controls.Add(textBoxNhanAD);
            Controls.Add(labelTenMay);
            Controls.Add(panel1);
            Name = "ChatvKH";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCloseAd;
        private Label labelTenMay;
        private TextBox textBoxNhanAD;
        private TextBox textBoxGuiAD;
        private Button btnChatAd;
    }
}