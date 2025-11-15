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
            dataGridViewMenu = new DataGridView();
            pictureBoxMenu = new PictureBox();
            textBoxTimKiem = new TextBox();
            btnThemMon = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button1 = new Button();
            textBoxTenMA = new TextBox();
            textBoxGia = new TextBox();
            textBoxPL = new TextBox();
            label1 = new Label();
            labelGia = new Label();
            labelPL = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMenu
            // 
            dataGridViewMenu.AllowUserToAddRows = false;
            dataGridViewMenu.AllowUserToDeleteRows = false;
            dataGridViewMenu.AllowUserToResizeColumns = false;
            dataGridViewMenu.AllowUserToResizeRows = false;
            dataGridViewMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMenu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewMenu.BackgroundColor = Color.White;
            dataGridViewMenu.BorderStyle = BorderStyle.None;
            dataGridViewMenu.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewMenu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(0, 0, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewMenu.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMenu.GridColor = Color.AliceBlue;
            dataGridViewMenu.Location = new Point(12, 72);
            dataGridViewMenu.Name = "dataGridViewMenu";
            dataGridViewMenu.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMenu.Size = new Size(473, 418);
            dataGridViewMenu.TabIndex = 0;
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
            // button2
            // 
            button2.BackColor = Color.AliceBlue;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(334, 27);
            button2.Name = "button2";
            button2.Size = new Size(151, 29);
            button2.TabIndex = 4;
            button2.Text = "Xóa món";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(button1);
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
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(17, 171);
            button1.Name = "button1";
            button1.Size = new Size(266, 31);
            button1.TabIndex = 6;
            button1.Text = "Sửa chi tiết món ăn";
            button1.UseVisualStyleBackColor = false;
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
            // MenuDA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 493);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(btnThemMon);
            Controls.Add(textBoxTimKiem);
            Controls.Add(pictureBoxMenu);
            Controls.Add(dataGridViewMenu);
            Name = "MenuDA";
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMenu;
        private PictureBox pictureBoxMenu;
        private TextBox textBoxTimKiem;
        private Button btnThemMon;
        private Button button2;
        private Panel panel1;
        private Label labelPL;
        private TextBox textBoxTenMA;
        private TextBox textBoxGia;
        private TextBox textBoxPL;
        private Label label1;
        private Label labelGia;
        private Button button1;
    }
}