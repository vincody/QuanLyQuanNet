namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    partial class KHang
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
            panel1 = new Panel();
            dataGridViewTK = new DataGridView();
            panel2 = new Panel();
            btnSuaThongTin = new Button();
            btnThemTaiKhoan = new Button();
            textBoxSDT = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTK).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dataGridViewTK);
            panel1.Location = new Point(0, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 394);
            panel1.TabIndex = 0;
            // 
            // dataGridViewTK
            // 
            dataGridViewTK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTK.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTK.BackgroundColor = Color.White;
            dataGridViewTK.BorderStyle = BorderStyle.None;
            dataGridViewTK.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewTK.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(0, 0, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewTK.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTK.Location = new Point(0, 0);
            dataGridViewTK.Name = "dataGridViewTK";
            dataGridViewTK.ReadOnly = true;
            dataGridViewTK.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(0, 0, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewTK.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTK.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTK.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTK.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTK.Size = new Size(800, 394);
            dataGridViewTK.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSuaThongTin);
            panel2.Controls.Add(btnThemTaiKhoan);
            panel2.Controls.Add(textBoxSDT);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 50);
            panel2.TabIndex = 1;
            // 
            // btnSuaThongTin
            // 
            btnSuaThongTin.BackColor = Color.AliceBlue;
            btnSuaThongTin.Font = new Font("Segoe UI", 12F);
            btnSuaThongTin.Location = new Point(464, 12);
            btnSuaThongTin.Name = "btnSuaThongTin";
            btnSuaThongTin.Size = new Size(192, 29);
            btnSuaThongTin.TabIndex = 2;
            btnSuaThongTin.Text = "Sửa thông tin";
            btnSuaThongTin.UseVisualStyleBackColor = false;
            btnSuaThongTin.Click += btnSuaThongTin_Click;
            // 
            // btnThemTaiKhoan
            // 
            btnThemTaiKhoan.BackColor = Color.AliceBlue;
            btnThemTaiKhoan.Font = new Font("Segoe UI", 12F);
            btnThemTaiKhoan.Location = new Point(266, 11);
            btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            btnThemTaiKhoan.Size = new Size(192, 29);
            btnThemTaiKhoan.TabIndex = 1;
            btnThemTaiKhoan.Text = "Thêm tài khoản";
            btnThemTaiKhoan.UseVisualStyleBackColor = false;
            btnThemTaiKhoan.Click += btnThemTaiKhoan_Click;
            // 
            // textBoxSDT
            // 
            textBoxSDT.BackColor = Color.AliceBlue;
            textBoxSDT.Font = new Font("Segoe UI", 12F);
            textBoxSDT.Location = new Point(12, 12);
            textBoxSDT.Name = "textBoxSDT";
            textBoxSDT.PlaceholderText = "Tìm theo số điện thoại";
            textBoxSDT.Size = new Size(248, 29);
            textBoxSDT.TabIndex = 0;
            textBoxSDT.TextChanged += textBoxSDT_TextChanged;
            // 
            // KHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "KHang";
            Text = "Tài khoản";
            Load += KHang_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTK).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBoxSDT;
        private DataGridView dataGridViewTK;
        private Button btnThemTaiKhoan;
        private Button btnSuaThongTin;
    }
}