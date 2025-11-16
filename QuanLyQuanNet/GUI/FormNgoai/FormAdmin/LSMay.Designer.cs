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
            dataGridViewLSOrder = new DataGridView();
            panel1 = new Panel();
            btnXemDonDatMon = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLSOrder).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewLSOrder
            // 
            dataGridViewLSOrder.AllowUserToAddRows = false;
            dataGridViewLSOrder.AllowUserToDeleteRows = false;
            dataGridViewLSOrder.AllowUserToResizeColumns = false;
            dataGridViewLSOrder.AllowUserToResizeRows = false;
            dataGridViewLSOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLSOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewLSOrder.BackgroundColor = Color.White;
            dataGridViewLSOrder.BorderStyle = BorderStyle.None;
            dataGridViewLSOrder.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewLSOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(0, 0, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewLSOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewLSOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewLSOrder.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewLSOrder.Dock = DockStyle.Bottom;
            dataGridViewLSOrder.Location = new Point(0, 59);
            dataGridViewLSOrder.Name = "dataGridViewLSOrder";
            dataGridViewLSOrder.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewLSOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewLSOrder.RowHeadersVisible = false;
            dataGridViewLSOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLSOrder.Size = new Size(800, 391);
            dataGridViewLSOrder.TabIndex = 0;
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
            // LSMay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridViewLSOrder);
            Name = "LSMay";
            Text = "Lịch sử dụng máy";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLSOrder).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewLSOrder;
        private Panel panel1;
        private Button btnXemDonDatMon;
    }
}