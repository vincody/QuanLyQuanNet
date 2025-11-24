namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    partial class MenuDA
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pictureBoxMenu = new PictureBox();
            textBoxTimKiem = new TextBox();
            btnThemMon = new Button();
            btnXoaMonAn = new Button();
            panel1 = new Panel();
            btnSuaChiTietMon = new Button();
            textBoxTenMA = new TextBox();
            textBoxGia = new TextBox();
            textBoxPL = new TextBox();
            label1 = new Label();
            labelGia = new Label();
            labelPL = new Label();
            dataGridViewMenu = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMenu
            // 
            pictureBoxMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMenu.Location = new Point(491, 72);
            pictureBoxMenu.Name = "pictureBoxMenu";
            pictureBoxMenu.Size = new Size(297, 189);
            pictureBoxMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMenu.TabIndex = 1;
            pictureBoxMenu.TabStop = false;
            // 
            // textBoxTimKiem
            // 
            textBoxTimKiem.BackColor = Color.AliceBlue;
            textBoxTimKiem.Font = new Font("Segoe UI", 12F);
            textBoxTimKiem.Location = new Point(12, 27);
            textBoxTimKiem.Name = "textBoxTimKiem";
            textBoxTimKiem.PlaceholderText = "Tìm kiếm món ăn";
            textBoxTimKiem.Size = new Size(176, 29);
            textBoxTimKiem.TabIndex = 2;
            textBoxTimKiem.TextChanged += textBoxTimKiem_TextChanged;
            // 
            // btnThemMon
            // 
            btnThemMon.BackColor = Color.AliceBlue;
            btnThemMon.Font = new Font("Segoe UI", 12F);
            btnThemMon.Location = new Point(194, 27);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(134, 29);
            btnThemMon.TabIndex = 3;
            btnThemMon.Text = "Thêm món";
            btnThemMon.UseVisualStyleBackColor = false;
            btnThemMon.Click += btnThemMon_Click;
            // 
            // btnXoaMonAn
            // 
            btnXoaMonAn.BackColor = Color.AliceBlue;
            btnXoaMonAn.Font = new Font("Segoe UI", 12F);
            btnXoaMonAn.Location = new Point(334, 27);
            btnXoaMonAn.Name = "btnXoaMonAn";
            btnXoaMonAn.Size = new Size(151, 29);
            btnXoaMonAn.TabIndex = 4;
            btnXoaMonAn.Text = "Xóa món";
            btnXoaMonAn.UseVisualStyleBackColor = false;
            btnXoaMonAn.Click += btnXoaMonAn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(btnSuaChiTietMon);
            panel1.Controls.Add(textBoxTenMA);
            panel1.Controls.Add(textBoxGia);
            panel1.Controls.Add(textBoxPL);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelGia);
            panel1.Controls.Add(labelPL);
            panel1.Location = new Point(491, 267);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 224);
            panel1.TabIndex = 5;
            // 
            // btnSuaChiTietMon
            // 
            btnSuaChiTietMon.BackColor = SystemColors.Control;
            btnSuaChiTietMon.FlatAppearance.BorderSize = 0;
            btnSuaChiTietMon.FlatStyle = FlatStyle.Flat;
            btnSuaChiTietMon.Font = new Font("Segoe UI", 12F);
            btnSuaChiTietMon.Location = new Point(17, 171);
            btnSuaChiTietMon.Name = "btnSuaChiTietMon";
            btnSuaChiTietMon.Size = new Size(266, 31);
            btnSuaChiTietMon.TabIndex = 6;
            btnSuaChiTietMon.Text = "Sửa chi tiết món ăn";
            btnSuaChiTietMon.UseVisualStyleBackColor = false;
            btnSuaChiTietMon.Click += btnSuaChiTietMon_Click;
            // 
            // textBoxTenMA
            // 
            textBoxTenMA.BackColor = SystemColors.Control;
            textBoxTenMA.BorderStyle = BorderStyle.None;
            textBoxTenMA.Font = new Font("Segoe UI", 12F);
            textBoxTenMA.Location = new Point(111, 20);
            textBoxTenMA.Name = "textBoxTenMA";
            textBoxTenMA.Size = new Size(170, 22);
            textBoxTenMA.TabIndex = 5;
            // 
            // textBoxGia
            // 
            textBoxGia.BackColor = SystemColors.Control;
            textBoxGia.BorderStyle = BorderStyle.None;
            textBoxGia.Font = new Font("Segoe UI", 12F);
            textBoxGia.Location = new Point(110, 76);
            textBoxGia.Name = "textBoxGia";
            textBoxGia.Size = new Size(170, 22);
            textBoxGia.TabIndex = 4;
            // 
            // textBoxPL
            // 
            textBoxPL.BackColor = SystemColors.Control;
            textBoxPL.BorderStyle = BorderStyle.None;
            textBoxPL.Font = new Font("Segoe UI", 12F);
            textBoxPL.Location = new Point(110, 131);
            textBoxPL.Name = "textBoxPL";
            textBoxPL.Size = new Size(170, 22);
            textBoxPL.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(15, 18);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 2;
            label1.Text = "Tên món ăn";
            // 
            // labelGia
            // 
            labelGia.AutoSize = true;
            labelGia.Font = new Font("Segoe UI", 12F);
            labelGia.Location = new Point(21, 76);
            labelGia.Name = "labelGia";
            labelGia.Size = new Size(80, 21);
            labelGia.TabIndex = 1;
            labelGia.Text = "Giá (VNĐ)";
            // 
            // labelPL
            // 
            labelPL.AutoSize = true;
            labelPL.Font = new Font("Segoe UI", 12F);
            labelPL.Location = new Point(24, 131);
            labelPL.Name = "labelPL";
            labelPL.Size = new Size(74, 21);
            labelPL.TabIndex = 0;
            labelPL.Text = "Phân loại";
            // 
            // dataGridViewMenu
            // 
            dataGridViewMenu.AllowCustomTheming = false;
            dataGridViewMenu.AllowUserToAddRows = false;
            dataGridViewMenu.AllowUserToDeleteRows = false;
            dataGridViewMenu.AllowUserToOrderColumns = true;
            dataGridViewMenu.AllowUserToResizeColumns = false;
            dataGridViewMenu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMenu.BorderStyle = BorderStyle.None;
            dataGridViewMenu.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewMenu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMenu.ColumnHeadersHeight = 40;
            dataGridViewMenu.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewMenu.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewMenu.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dataGridViewMenu.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewMenu.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dataGridViewMenu.CurrentTheme.BackColor = Color.White;
            dataGridViewMenu.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            dataGridViewMenu.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            dataGridViewMenu.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewMenu.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dataGridViewMenu.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewMenu.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            dataGridViewMenu.CurrentTheme.Name = null;
            dataGridViewMenu.CurrentTheme.RowsStyle.BackColor = Color.White;
            dataGridViewMenu.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewMenu.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dataGridViewMenu.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewMenu.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewMenu.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewMenu.EnableHeadersVisualStyles = false;
            dataGridViewMenu.GridColor = Color.FromArgb(221, 238, 255);
            dataGridViewMenu.HeaderBackColor = Color.DodgerBlue;
            dataGridViewMenu.HeaderBgColor = Color.Empty;
            dataGridViewMenu.HeaderForeColor = Color.White;
            dataGridViewMenu.Location = new Point(12, 72);
            dataGridViewMenu.Name = "dataGridViewMenu";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewMenu.RowHeadersVisible = false;
            dataGridViewMenu.RowTemplate.Height = 40;
            dataGridViewMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMenu.Size = new Size(473, 418);
            dataGridViewMenu.TabIndex = 7;
            dataGridViewMenu.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // MenuDA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 493);
            Controls.Add(dataGridViewMenu);
            Controls.Add(panel1);
            Controls.Add(btnXoaMonAn);
            Controls.Add(btnThemMon);
            Controls.Add(textBoxTimKiem);
            Controls.Add(pictureBoxMenu);
            Name = "MenuDA";
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxMenu;
        private TextBox textBoxTimKiem;
        private Button btnThemMon;
        private Button btnXoaMonAn;
        private Panel panel1;
        private Label labelPL;
        private TextBox textBoxTenMA;
        private TextBox textBoxGia;
        private TextBox textBoxPL;
        private Label label1;
        private Label labelGia;
        private Button btnSuaChiTietMon;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewMenu;
    }
}