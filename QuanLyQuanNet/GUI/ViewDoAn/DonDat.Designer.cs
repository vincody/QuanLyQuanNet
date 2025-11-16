namespace QuanLyQuanNet.GUI.ViewDoAn
{
    partial class DonDat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxAnhMonAn = new PictureBox();
            labelSoLuong = new Label();
            labelTenMA = new Label();
            labelGiaMonAn = new Label();
            labelThanhTien = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnhMonAn).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAnhMonAn
            // 
            pictureBoxAnhMonAn.Location = new Point(3, 3);
            pictureBoxAnhMonAn.Name = "pictureBoxAnhMonAn";
            pictureBoxAnhMonAn.Size = new Size(121, 110);
            pictureBoxAnhMonAn.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAnhMonAn.TabIndex = 0;
            pictureBoxAnhMonAn.TabStop = false;
            // 
            // labelSoLuong
            // 
            labelSoLuong.AutoSize = true;
            labelSoLuong.Font = new Font("Segoe UI", 15F);
            labelSoLuong.Location = new Point(264, 40);
            labelSoLuong.Name = "labelSoLuong";
            labelSoLuong.Size = new Size(90, 28);
            labelSoLuong.TabIndex = 1;
            labelSoLuong.Text = "SoLuong";
            // 
            // labelTenMA
            // 
            labelTenMA.AutoSize = true;
            labelTenMA.Font = new Font("Segoe UI", 15F);
            labelTenMA.Location = new Point(130, 40);
            labelTenMA.Name = "labelTenMA";
            labelTenMA.Size = new Size(72, 28);
            labelTenMA.TabIndex = 2;
            labelTenMA.Text = "TenMA";
            // 
            // labelGiaMonAn
            // 
            labelGiaMonAn.AutoSize = true;
            labelGiaMonAn.Font = new Font("Segoe UI", 15F);
            labelGiaMonAn.Location = new Point(389, 40);
            labelGiaMonAn.Name = "labelGiaMonAn";
            labelGiaMonAn.Size = new Size(112, 28);
            labelGiaMonAn.TabIndex = 3;
            labelGiaMonAn.Text = "Giá món ăn";
            // 
            // labelThanhTien
            // 
            labelThanhTien.AutoSize = true;
            labelThanhTien.Font = new Font("Segoe UI", 15F);
            labelThanhTien.Location = new Point(529, 40);
            labelThanhTien.Name = "labelThanhTien";
            labelThanhTien.Size = new Size(101, 28);
            labelThanhTien.TabIndex = 4;
            labelThanhTien.Text = "ThanhTien";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 14);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "Tên món";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 14);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 6;
            label2.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 14);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 7;
            label3.Text = "Giá món";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(544, 14);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 8;
            label4.Text = "Thành tiền";
            // 
            // DonDat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelThanhTien);
            Controls.Add(labelGiaMonAn);
            Controls.Add(labelTenMA);
            Controls.Add(labelSoLuong);
            Controls.Add(pictureBoxAnhMonAn);
            Name = "DonDat";
            Size = new Size(659, 116);
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnhMonAn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pictureBoxAnhMonAn;
        public Label labelSoLuong;
        public Label labelTenMA;
        public Label labelGiaMonAn;
        public Label labelThanhTien;
        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
    }
}
