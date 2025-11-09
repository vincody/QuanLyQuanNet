namespace QuanLyQuanNet.GUI.FormNgoai.FormKhach
{
    partial class DoiMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMK));
            labelMKHT = new Label();
            label1 = new Label();
            label2 = new Label();
            textBoxMKHT = new TextBox();
            textBoxMKM = new TextBox();
            textBoxConfirm = new TextBox();
            btnXacNhan = new Button();
            panel1 = new Panel();
            btnClose = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelMKHT
            // 
            labelMKHT.AutoSize = true;
            labelMKHT.Location = new Point(41, 50);
            labelMKHT.Name = "labelMKHT";
            labelMKHT.Size = new Size(102, 15);
            labelMKHT.TabIndex = 0;
            labelMKHT.Text = "Mật khẩu hiện tại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 94);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Mật khẩu mới:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 138);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 2;
            label2.Text = "Xác nhận mật khẩu mới:";
            // 
            // textBoxMKHT
            // 
            textBoxMKHT.Location = new Point(43, 68);
            textBoxMKHT.Name = "textBoxMKHT";
            textBoxMKHT.Size = new Size(283, 23);
            textBoxMKHT.TabIndex = 3;
            textBoxMKHT.TextChanged += textBoxMKHT_TextChanged;
            // 
            // textBoxMKM
            // 
            textBoxMKM.Location = new Point(41, 112);
            textBoxMKM.Name = "textBoxMKM";
            textBoxMKM.Size = new Size(283, 23);
            textBoxMKM.TabIndex = 4;
            // 
            // textBoxConfirm
            // 
            textBoxConfirm.Location = new Point(43, 156);
            textBoxConfirm.Name = "textBoxConfirm";
            textBoxConfirm.Size = new Size(283, 23);
            textBoxConfirm.TabIndex = 5;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(130, 185);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(104, 23);
            btnXacNhan.TabIndex = 6;
            btnXacNhan.Text = "Đổi mật khẩu";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 30);
            panel1.TabIndex = 7;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(331, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 23);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // DoiMK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 220);
            Controls.Add(panel1);
            Controls.Add(btnXacNhan);
            Controls.Add(textBoxConfirm);
            Controls.Add(textBoxMKM);
            Controls.Add(textBoxMKHT);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelMKHT);
            Name = "DoiMK";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMKHT;
        private Label label1;
        private Label label2;
        private TextBox textBoxMKHT;
        private TextBox textBoxMKM;
        private TextBox textBoxConfirm;
        private Button btnXacNhan;
        private Panel panel1;
        private Button btnClose;
    }
}