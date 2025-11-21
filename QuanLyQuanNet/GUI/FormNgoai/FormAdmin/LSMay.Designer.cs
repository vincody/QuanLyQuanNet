namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    partial class LSMay
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
            btnXemDonDatMon = new Button();
            dataGridViewLSOrder = new Bunifu.UI.WinForms.BunifuDataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLSOrder).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnXemDonDatMon);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 59);
            panel1.TabIndex = 1;
            // 
            // btnXemDonDatMon
            // 
            btnXemDonDatMon.Font = new Font("Segoe UI", 15F);
            btnXemDonDatMon.Location = new Point(12, 12);
            btnXemDonDatMon.Name = "btnXemDonDatMon";
            btnXemDonDatMon.Size = new Size(196, 41);
            btnXemDonDatMon.TabIndex = 3;
            btnXemDonDatMon.Text = "Xem đơn đặt món";
            btnXemDonDatMon.UseVisualStyleBackColor = true;
            btnXemDonDatMon.Click += btnXemDonDatMon_Click;
            // 
            // dataGridViewLSOrder
            // 
            dataGridViewLSOrder.AllowCustomTheming = false;
            dataGridViewLSOrder.AllowUserToAddRows = false;
            dataGridViewLSOrder.AllowUserToDeleteRows = false;
            dataGridViewLSOrder.AllowUserToResizeColumns = false;
            dataGridViewLSOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewLSOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewLSOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewLSOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLSOrder.BorderStyle = BorderStyle.None;
            dataGridViewLSOrder.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewLSOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewLSOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewLSOrder.ColumnHeadersHeight = 40;
            dataGridViewLSOrder.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewLSOrder.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewLSOrder.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dataGridViewLSOrder.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewLSOrder.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dataGridViewLSOrder.CurrentTheme.BackColor = Color.White;
            dataGridViewLSOrder.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            dataGridViewLSOrder.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            dataGridViewLSOrder.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewLSOrder.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dataGridViewLSOrder.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewLSOrder.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            dataGridViewLSOrder.CurrentTheme.Name = null;
            dataGridViewLSOrder.CurrentTheme.RowsStyle.BackColor = Color.White;
            dataGridViewLSOrder.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewLSOrder.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dataGridViewLSOrder.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewLSOrder.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewLSOrder.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewLSOrder.EnableHeadersVisualStyles = false;
            dataGridViewLSOrder.GridColor = Color.FromArgb(221, 238, 255);
            dataGridViewLSOrder.HeaderBackColor = Color.DodgerBlue;
            dataGridViewLSOrder.HeaderBgColor = Color.Empty;
            dataGridViewLSOrder.HeaderForeColor = Color.White;
            dataGridViewLSOrder.Location = new Point(0, 59);
            dataGridViewLSOrder.Name = "dataGridViewLSOrder";
            dataGridViewLSOrder.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewLSOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewLSOrder.RowHeadersVisible = false;
            dataGridViewLSOrder.RowTemplate.Height = 40;
            dataGridViewLSOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLSOrder.Size = new Size(800, 391);
            dataGridViewLSOrder.TabIndex = 2;
            dataGridViewLSOrder.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // LSMay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewLSOrder);
            Controls.Add(panel1);
            Name = "LSMay";
            Text = "Lịch sử dụng máy";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLSOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnXemDonDatMon;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewLSOrder;
    }
}