namespace QuanLyQuanNet.GUI.ViewDoAn
{
    partial class ThongTinDatMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinDatMon));
            panel1 = new Panel();
            btnXoaMon = new Button();
            labelGiaTien = new Label();
            btnThem = new Button();
            btnBot = new Button();
            SoLuong = new Label();
            labelTenMon = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnXoaMon);
            panel1.Controls.Add(labelGiaTien);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnBot);
            panel1.Controls.Add(SoLuong);
            panel1.Controls.Add(labelTenMon);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 75);
            panel1.TabIndex = 0;
            // 
            // btnXoaMon
            // 
            btnXoaMon.FlatAppearance.BorderSize = 0;
            btnXoaMon.FlatStyle = FlatStyle.Flat;
            btnXoaMon.Image = (Image)resources.GetObject("btnXoaMon.Image");
            btnXoaMon.Location = new Point(308, 5);
            btnXoaMon.Name = "btnXoaMon";
            btnXoaMon.Size = new Size(30, 32);
            btnXoaMon.TabIndex = 5;
            btnXoaMon.UseVisualStyleBackColor = true;
            btnXoaMon.Click += btnXoaMon_Click;
            // 
            // labelGiaTien
            // 
            labelGiaTien.AutoSize = true;
            labelGiaTien.Font = new Font("Segoe UI", 15F);
            labelGiaTien.Location = new Point(210, 39);
            labelGiaTien.Name = "labelGiaTien";
            labelGiaTien.Size = new Size(77, 28);
            labelGiaTien.TabIndex = 4;
            labelGiaTien.Text = "GiaTien";
            // 
            // btnThem
            // 
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.Location = new Point(55, 35);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(30, 32);
            btnThem.TabIndex = 3;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnBot
            // 
            btnBot.FlatAppearance.BorderSize = 0;
            btnBot.FlatStyle = FlatStyle.Flat;
            btnBot.Image = (Image)resources.GetObject("btnBot.Image");
            btnBot.Location = new Point(3, 35);
            btnBot.Name = "btnBot";
            btnBot.Size = new Size(30, 32);
            btnBot.TabIndex = 2;
            btnBot.UseVisualStyleBackColor = true;
            btnBot.Click += btnBot_Click;
            // 
            // SoLuong
            // 
            SoLuong.AutoSize = true;
            SoLuong.Location = new Point(35, 45);
            SoLuong.Name = "SoLuong";
            SoLuong.Size = new Size(20, 15);
            SoLuong.TabIndex = 1;
            SoLuong.Text = "So";
            // 
            // labelTenMon
            // 
            labelTenMon.AutoSize = true;
            labelTenMon.Font = new Font("Segoe UI", 15F);
            labelTenMon.Location = new Point(3, 9);
            labelTenMon.Name = "labelTenMon";
            labelTenMon.Size = new Size(82, 28);
            labelTenMon.TabIndex = 0;
            labelTenMon.Text = "TenMon";
            // 
            // ThongTinDatMon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ThongTinDatMon";
            Size = new Size(341, 75);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public Button btnBot;
        public Label SoLuong;
        public Label labelTenMon;
        public Button btnXoaMon;
        public Label labelGiaTien;
        public Button btnThem;
        private Button button3;
    }
}
