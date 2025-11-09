namespace QuanLyQuanNet.GUI.FormNgoai.FormKhach
{
    partial class NapTien
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
            labelTKN = new Label();
            panel1 = new Panel();
            btnNap = new Button();
            textBoxSTN = new TextBox();
            labelSTN = new Label();
            checkBoxTienMat = new CheckBox();
            textBoxTKN = new TextBox();
            pictureBoxQR = new PictureBox();
            labelYCNap = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQR).BeginInit();
            SuspendLayout();
            // 
            // labelTKN
            // 
            labelTKN.AutoSize = true;
            labelTKN.Location = new Point(16, 22);
            labelTKN.Name = "labelTKN";
            labelTKN.Size = new Size(84, 15);
            labelTKN.TabIndex = 0;
            labelTKN.Text = "Tài khoản nạp:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnNap);
            panel1.Controls.Add(textBoxSTN);
            panel1.Controls.Add(labelSTN);
            panel1.Controls.Add(checkBoxTienMat);
            panel1.Controls.Add(textBoxTKN);
            panel1.Controls.Add(labelTKN);
            panel1.Location = new Point(24, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 326);
            panel1.TabIndex = 1;
            // 
            // btnNap
            // 
            btnNap.Location = new Point(149, 104);
            btnNap.Name = "btnNap";
            btnNap.Size = new Size(75, 23);
            btnNap.TabIndex = 5;
            btnNap.Text = "Nạp tiền";
            btnNap.UseVisualStyleBackColor = true;
            btnNap.Click += btnNap_Click;
            // 
            // textBoxSTN
            // 
            textBoxSTN.Location = new Point(106, 75);
            textBoxSTN.Name = "textBoxSTN";
            textBoxSTN.Size = new Size(151, 23);
            textBoxSTN.TabIndex = 4;
            // 
            // labelSTN
            // 
            labelSTN.AutoSize = true;
            labelSTN.Location = new Point(16, 75);
            labelSTN.Name = "labelSTN";
            labelSTN.Size = new Size(69, 15);
            labelSTN.TabIndex = 3;
            labelSTN.Text = "Số tiền nạp:";
            // 
            // checkBoxTienMat
            // 
            checkBoxTienMat.AutoSize = true;
            checkBoxTienMat.Location = new Point(109, 48);
            checkBoxTienMat.Name = "checkBoxTienMat";
            checkBoxTienMat.Size = new Size(73, 19);
            checkBoxTienMat.TabIndex = 2;
            checkBoxTienMat.Text = "Tiền mặt\r\n";
            checkBoxTienMat.UseVisualStyleBackColor = true;
            // 
            // textBoxTKN
            // 
            textBoxTKN.Location = new Point(106, 19);
            textBoxTKN.Name = "textBoxTKN";
            textBoxTKN.ReadOnly = true;
            textBoxTKN.Size = new Size(151, 23);
            textBoxTKN.TabIndex = 1;
            // 
            // pictureBoxQR
            // 
            pictureBoxQR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxQR.Location = new Point(449, 48);
            pictureBoxQR.Name = "pictureBoxQR";
            pictureBoxQR.Size = new Size(339, 326);
            pictureBoxQR.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxQR.TabIndex = 5;
            pictureBoxQR.TabStop = false;
            // 
            // labelYCNap
            // 
            labelYCNap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelYCNap.AutoSize = true;
            labelYCNap.Font = new Font("Segoe UI", 15F);
            labelYCNap.Location = new Point(502, 17);
            labelYCNap.Name = "labelYCNap";
            labelYCNap.Size = new Size(248, 28);
            labelYCNap.TabIndex = 6;
            labelYCNap.Text = "Vui lòng quét mã QR ở đây";
            labelYCNap.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(142, 17);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 7;
            label1.Text = "Thông tin nạp";
            // 
            // NapTien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(labelYCNap);
            Controls.Add(pictureBoxQR);
            Controls.Add(panel1);
            Name = "NapTien";
            Text = "Nạp tiền";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTKN;
        private Panel panel1;
        private TextBox textBoxSTN;
        private Label labelSTN;
        private CheckBox checkBoxTienMat;
        private TextBox textBoxTKN;
        private PictureBox pictureBoxQR;
        private Button btnNap;
        private Label labelYCNap;
        private Label label1;
    }
}