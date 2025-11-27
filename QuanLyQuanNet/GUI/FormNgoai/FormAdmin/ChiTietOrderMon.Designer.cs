namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    partial class ChiTietOrderMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietOrderMon));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            flowPanelOrder = new FlowLayoutPanel();
            panel1 = new Panel();
            btnHuyDon = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnClose = new Button();
            btnHoanThanhDon = new Button();
            labelTongTien = new Label();
            label2 = new Label();
            labelMaDon = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowPanelOrder
            // 
            flowPanelOrder.Dock = DockStyle.Bottom;
            flowPanelOrder.Location = new Point(0, 70);
            flowPanelOrder.Name = "flowPanelOrder";
            flowPanelOrder.Size = new Size(926, 380);
            flowPanelOrder.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHuyDon);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnHoanThanhDon);
            panel1.Controls.Add(labelTongTien);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(labelMaDon);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(926, 64);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnHuyDon
            // 
            btnHuyDon.AllowAnimations = true;
            btnHuyDon.AllowMouseEffects = true;
            btnHuyDon.AllowToggling = false;
            btnHuyDon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHuyDon.AnimationSpeed = 200;
            btnHuyDon.AutoGenerateColors = false;
            btnHuyDon.AutoRoundBorders = false;
            btnHuyDon.AutoSizeLeftIcon = true;
            btnHuyDon.AutoSizeRightIcon = true;
            btnHuyDon.BackColor = Color.Transparent;
            btnHuyDon.BackColor1 = Color.FromArgb(51, 122, 183);
            btnHuyDon.BackgroundImage = (Image)resources.GetObject("btnHuyDon.BackgroundImage");
            btnHuyDon.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnHuyDon.ButtonText = "Hủy đơn";
            btnHuyDon.ButtonTextMarginLeft = 0;
            btnHuyDon.ColorContrastOnClick = 45;
            btnHuyDon.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btnHuyDon.CustomizableEdges = borderEdges1;
            btnHuyDon.DialogResult = DialogResult.None;
            btnHuyDon.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnHuyDon.DisabledFillColor = Color.Empty;
            btnHuyDon.DisabledForecolor = Color.Empty;
            btnHuyDon.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnHuyDon.Font = new Font("Segoe UI", 9F);
            btnHuyDon.ForeColor = Color.Black;
            btnHuyDon.IconLeft = null;
            btnHuyDon.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnHuyDon.IconLeftCursor = Cursors.Default;
            btnHuyDon.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnHuyDon.IconMarginLeft = 11;
            btnHuyDon.IconPadding = 10;
            btnHuyDon.IconRight = null;
            btnHuyDon.IconRightAlign = ContentAlignment.MiddleRight;
            btnHuyDon.IconRightCursor = Cursors.Default;
            btnHuyDon.IconRightPadding = new Padding(3, 3, 7, 3);
            btnHuyDon.IconSize = 25;
            btnHuyDon.IdleBorderColor = Color.Empty;
            btnHuyDon.IdleBorderRadius = 0;
            btnHuyDon.IdleBorderThickness = 0;
            btnHuyDon.IdleFillColor = Color.Empty;
            btnHuyDon.IdleIconLeftImage = null;
            btnHuyDon.IdleIconRightImage = null;
            btnHuyDon.IndicateFocus = false;
            btnHuyDon.Location = new Point(696, 20);
            btnHuyDon.Name = "btnHuyDon";
            btnHuyDon.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnHuyDon.OnDisabledState.BorderRadius = 15;
            btnHuyDon.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnHuyDon.OnDisabledState.BorderThickness = 1;
            btnHuyDon.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnHuyDon.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnHuyDon.OnDisabledState.IconLeftImage = null;
            btnHuyDon.OnDisabledState.IconRightImage = null;
            btnHuyDon.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnHuyDon.onHoverState.BorderRadius = 15;
            btnHuyDon.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnHuyDon.onHoverState.BorderThickness = 1;
            btnHuyDon.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnHuyDon.onHoverState.ForeColor = Color.White;
            btnHuyDon.onHoverState.IconLeftImage = null;
            btnHuyDon.onHoverState.IconRightImage = null;
            btnHuyDon.OnIdleState.BorderColor = Color.DodgerBlue;
            btnHuyDon.OnIdleState.BorderRadius = 15;
            btnHuyDon.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnHuyDon.OnIdleState.BorderThickness = 1;
            btnHuyDon.OnIdleState.FillColor = Color.AliceBlue;
            btnHuyDon.OnIdleState.ForeColor = Color.Black;
            btnHuyDon.OnIdleState.IconLeftImage = null;
            btnHuyDon.OnIdleState.IconRightImage = null;
            btnHuyDon.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnHuyDon.OnPressedState.BorderRadius = 15;
            btnHuyDon.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnHuyDon.OnPressedState.BorderThickness = 1;
            btnHuyDon.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            btnHuyDon.OnPressedState.ForeColor = Color.White;
            btnHuyDon.OnPressedState.IconLeftImage = null;
            btnHuyDon.OnPressedState.IconRightImage = null;
            btnHuyDon.Size = new Size(185, 32);
            btnHuyDon.TabIndex = 6;
            btnHuyDon.TextAlign = ContentAlignment.MiddleCenter;
            btnHuyDon.TextAlignment = HorizontalAlignment.Center;
            btnHuyDon.TextMarginLeft = 0;
            btnHuyDon.TextPadding = new Padding(0);
            btnHuyDon.UseDefaultRadiusAndThickness = true;
            btnHuyDon.Click += btnHuyDon_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.AliceBlue;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(887, 24);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 23);
            btnClose.TabIndex = 5;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnHoanThanhDon
            // 
            btnHoanThanhDon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHoanThanhDon.Font = new Font("Segoe UI", 15F);
            btnHoanThanhDon.Location = new Point(412, 18);
            btnHoanThanhDon.Name = "btnHoanThanhDon";
            btnHoanThanhDon.Size = new Size(278, 35);
            btnHoanThanhDon.TabIndex = 4;
            btnHoanThanhDon.Text = "Hoành thành đơn";
            btnHoanThanhDon.UseVisualStyleBackColor = true;
            btnHoanThanhDon.Click += btnHoanThanhDon_Click_1;
            // 
            // labelTongTien
            // 
            labelTongTien.AutoSize = true;
            labelTongTien.Font = new Font("Segoe UI", 15F);
            labelTongTien.Location = new Point(288, 21);
            labelTongTien.Name = "labelTongTien";
            labelTongTien.Size = new Size(35, 28);
            labelTongTien.TabIndex = 3;
            labelTongTien.Text = "So";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(181, 21);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 2;
            label2.Text = "Tổng đơn:";
            // 
            // labelMaDon
            // 
            labelMaDon.AutoSize = true;
            labelMaDon.Font = new Font("Segoe UI", 15F);
            labelMaDon.Location = new Point(12, 21);
            labelMaDon.Name = "labelMaDon";
            labelMaDon.Size = new Size(35, 28);
            labelMaDon.TabIndex = 1;
            labelMaDon.Text = "So";
            // 
            // ChiTietOrderMon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 450);
            Controls.Add(panel1);
            Controls.Add(flowPanelOrder);
            Name = "ChiTietOrderMon";
            Text = "ChiTietOrderMon";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowPanelOrder;
        private Panel panel1;
        private Label labelMaDon;
        private Label label2;
        private Label labelTongTien;
        private Button btnHoanThanhDon;
        private Button btnClose;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnHuyDon;
    }
}