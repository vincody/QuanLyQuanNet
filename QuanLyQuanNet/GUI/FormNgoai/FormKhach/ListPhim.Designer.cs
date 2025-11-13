namespace QuanLyQuanNet.GUI.FormNgoai.FormKhach
{
    partial class ListPhim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListPhim));
            panelListPhim = new FlowLayoutPanel();
            textBoxSoTrang = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            textBoxTimTen = new TextBox();
            SuspendLayout();
            // 
            // panelListPhim
            // 
            panelListPhim.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelListPhim.AutoScroll = true;
            panelListPhim.BackColor = SystemColors.ControlDarkDark;
            panelListPhim.Location = new Point(0, 43);
            panelListPhim.Name = "panelListPhim";
            panelListPhim.Size = new Size(800, 407);
            panelListPhim.TabIndex = 0;
            // 
            // textBoxSoTrang
            // 
            textBoxSoTrang.Location = new Point(52, 13);
            textBoxSoTrang.Name = "textBoxSoTrang";
            textBoxSoTrang.PlaceholderText = "Trang";
            textBoxSoTrang.Size = new Size(31, 23);
            textBoxSoTrang.TabIndex = 3;
            textBoxSoTrang.KeyDown += textBoxSoTrang_KeyDown;
            // 
            // btnCong
            // 
            btnCong.FlatAppearance.BorderSize = 0;
            btnCong.FlatStyle = FlatStyle.Flat;
            btnCong.Image = (Image)resources.GetObject("btnCong.Image");
            btnCong.Location = new Point(89, 10);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(34, 27);
            btnCong.TabIndex = 2;
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.FlatAppearance.BorderSize = 0;
            btnTru.FlatStyle = FlatStyle.Flat;
            btnTru.Image = (Image)resources.GetObject("btnTru.Image");
            btnTru.Location = new Point(12, 10);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(34, 27);
            btnTru.TabIndex = 0;
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // textBoxTimTen
            // 
            textBoxTimTen.Font = new Font("Segoe UI", 12F);
            textBoxTimTen.Location = new Point(129, 10);
            textBoxTimTen.Name = "textBoxTimTen";
            textBoxTimTen.PlaceholderText = "Tìm phim theo tên";
            textBoxTimTen.Size = new Size(138, 29);
            textBoxTimTen.TabIndex = 4;
            textBoxTimTen.KeyDown += textBoxTimTen_KeyDown;
            // 
            // ListPhim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxTimTen);
            Controls.Add(btnTru);
            Controls.Add(textBoxSoTrang);
            Controls.Add(btnCong);
            Controls.Add(panelListPhim);
            Name = "ListPhim";
            Text = "Xem phim";
            Load += ListPhim_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel panelListPhim;
        private Button btnTru;
        private Button btnCong;
        private TextBox textBoxSoTrang;
        private TextBox textBoxTimTen;
    }
}