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
            labelMKHT = new Label();
            label1 = new Label();
            label2 = new Label();
            textBoxMKHT = new TextBox();
            textBoxMKM = new TextBox();
            textBoxConfirm = new TextBox();
            btnXacNhan = new Button();
            SuspendLayout();
            // 
            // labelMKHT
            // 
            labelMKHT.AutoSize = true;
            labelMKHT.Location = new Point(41, 29);
            labelMKHT.Name = "labelMKHT";
            labelMKHT.Size = new Size(102, 15);
            labelMKHT.TabIndex = 0;
            labelMKHT.Text = "Mật khẩu hiện tại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 71);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Mật khẩu mới:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 120);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 2;
            label2.Text = "Xác nhận mật khẩu mới:";
            // 
            // textBoxMKHT
            // 
            textBoxMKHT.Location = new Point(43, 45);
            textBoxMKHT.Name = "textBoxMKHT";
            textBoxMKHT.Size = new Size(283, 23);
            textBoxMKHT.TabIndex = 3;
            // 
            // textBoxMKM
            // 
            textBoxMKM.Location = new Point(43, 89);
            textBoxMKM.Name = "textBoxMKM";
            textBoxMKM.Size = new Size(283, 23);
            textBoxMKM.TabIndex = 4;
            // 
            // textBoxConfirm
            // 
            textBoxConfirm.Location = new Point(43, 138);
            textBoxConfirm.Name = "textBoxConfirm";
            textBoxConfirm.Size = new Size(283, 23);
            textBoxConfirm.TabIndex = 5;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(130, 167);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(104, 23);
            btnXacNhan.TabIndex = 6;
            btnXacNhan.Text = "Đổi mật khẩu";
            btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // DoiMK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 199);
            Controls.Add(btnXacNhan);
            Controls.Add(textBoxConfirm);
            Controls.Add(textBoxMKM);
            Controls.Add(textBoxMKHT);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelMKHT);
            Name = "DoiMK";
            Text = "DoiMK";
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
    }
}