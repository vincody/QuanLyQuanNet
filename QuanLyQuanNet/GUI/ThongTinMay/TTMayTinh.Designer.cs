namespace QuanLyQuanNet.GUI.ThongTinMay
{
    partial class TTMayTinh
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
            panel1 = new Panel();
            labelMaySo = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelMaySo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 104);
            panel1.TabIndex = 0;
            // 
            // labelMaySo
            // 
            labelMaySo.AutoSize = true;
            labelMaySo.Font = new Font("Segoe UI", 15F);
            labelMaySo.Location = new Point(29, 36);
            labelMaySo.Name = "labelMaySo";
            labelMaySo.Size = new Size(73, 28);
            labelMaySo.TabIndex = 0;
            labelMaySo.Text = "MaySo";
            // 
            // TTMayTinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "TTMayTinh";
            Size = new Size(150, 104);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        public Label labelMaySo;
    }
}
