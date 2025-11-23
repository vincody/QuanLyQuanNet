namespace QuanLyQuanNet.GUI.FormNgoai.FormKhach
{
    partial class GoiMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoiMon));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            CagetoryMonAn = new FlowLayoutPanel();
            MenuDoAn = new FlowLayoutPanel();
            panel1 = new Panel();
            bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            ListMonAnDat = new FlowLayoutPanel();
            panelThanhToan = new Panel();
            labelTongTien = new Label();
            btnDatMon = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextBox();
            checkBoxSoDu = new CheckBox();
            checkBoxTienMat = new CheckBox();
            textBoxTimMonAn = new Bunifu.UI.WinForms.BunifuTextBox();
            panel1.SuspendLayout();
            panelThanhToan.SuspendLayout();
            SuspendLayout();
            // 
            // CagetoryMonAn
            // 
            CagetoryMonAn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CagetoryMonAn.BackColor = Color.FromArgb(84, 93, 110);
            CagetoryMonAn.Location = new Point(0, 42);
            CagetoryMonAn.Name = "CagetoryMonAn";
            CagetoryMonAn.Size = new Size(125, 587);
            CagetoryMonAn.TabIndex = 0;
            // 
            // MenuDoAn
            // 
            MenuDoAn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MenuDoAn.AutoScroll = true;
            MenuDoAn.BackColor = Color.FromArgb(84, 93, 110);
            MenuDoAn.Location = new Point(133, 40);
            MenuDoAn.Name = "MenuDoAn";
            MenuDoAn.Size = new Size(995, 589);
            MenuDoAn.TabIndex = 0;
            MenuDoAn.Paint += MenuDoAn_Paint;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(bunifuLabel1);
            panel1.Controls.Add(ListMonAnDat);
            panel1.Controls.Add(panelThanhToan);
            panel1.Location = new Point(1134, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 629);
            panel1.TabIndex = 0;
            // 
            // bunifuLabel1
            // 
            bunifuLabel1.AllowParentOverrides = false;
            bunifuLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bunifuLabel1.AutoEllipsis = false;
            bunifuLabel1.CursorType = Cursors.Default;
            bunifuLabel1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuLabel1.ForeColor = Color.White;
            bunifuLabel1.Location = new Point(90, 8);
            bunifuLabel1.Name = "bunifuLabel1";
            bunifuLabel1.RightToLeft = RightToLeft.No;
            bunifuLabel1.Size = new Size(206, 28);
            bunifuLabel1.TabIndex = 1;
            bunifuLabel1.Text = "Đơn đặt món của bạn";
            bunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ListMonAnDat
            // 
            ListMonAnDat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ListMonAnDat.AutoScroll = true;
            ListMonAnDat.BackColor = Color.FromArgb(84, 93, 110);
            ListMonAnDat.Location = new Point(3, 40);
            ListMonAnDat.Name = "ListMonAnDat";
            ListMonAnDat.Size = new Size(369, 375);
            ListMonAnDat.TabIndex = 0;
            // 
            // panelThanhToan
            // 
            panelThanhToan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelThanhToan.Controls.Add(labelTongTien);
            panelThanhToan.Controls.Add(btnDatMon);
            panelThanhToan.Controls.Add(bunifuTextBox1);
            panelThanhToan.Controls.Add(checkBoxSoDu);
            panelThanhToan.Controls.Add(checkBoxTienMat);
            panelThanhToan.Location = new Point(3, 367);
            panelThanhToan.Name = "panelThanhToan";
            panelThanhToan.Size = new Size(372, 255);
            panelThanhToan.TabIndex = 0;
            // 
            // labelTongTien
            // 
            labelTongTien.AutoSize = true;
            labelTongTien.BackColor = Color.FromArgb(16, 178, 248);
            labelTongTien.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTongTien.ForeColor = Color.White;
            labelTongTien.Location = new Point(17, 202);
            labelTongTien.Name = "labelTongTien";
            labelTongTien.Size = new Size(74, 28);
            labelTongTien.TabIndex = 1;
            labelTongTien.Text = "0 VNĐ";
            labelTongTien.Click += labelTongTien_Click;
            // 
            // btnDatMon
            // 
            btnDatMon.AllowAnimations = true;
            btnDatMon.AllowMouseEffects = true;
            btnDatMon.AllowToggling = false;
            btnDatMon.AnimationSpeed = 200;
            btnDatMon.AutoGenerateColors = false;
            btnDatMon.AutoRoundBorders = false;
            btnDatMon.AutoSizeLeftIcon = true;
            btnDatMon.AutoSizeRightIcon = true;
            btnDatMon.BackColor = Color.Transparent;
            btnDatMon.BackColor1 = Color.FromArgb(51, 122, 183);
            btnDatMon.BackgroundImage = (Image)resources.GetObject("btnDatMon.BackgroundImage");
            btnDatMon.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDatMon.ButtonText = "Đặt món";
            btnDatMon.ButtonTextMarginLeft = 0;
            btnDatMon.ColorContrastOnClick = 45;
            btnDatMon.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btnDatMon.CustomizableEdges = borderEdges1;
            btnDatMon.DialogResult = DialogResult.None;
            btnDatMon.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnDatMon.DisabledFillColor = Color.Empty;
            btnDatMon.DisabledForecolor = Color.Empty;
            btnDatMon.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnDatMon.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatMon.ForeColor = Color.White;
            btnDatMon.IconLeft = null;
            btnDatMon.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnDatMon.IconLeftCursor = Cursors.Default;
            btnDatMon.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnDatMon.IconMarginLeft = 11;
            btnDatMon.IconPadding = 10;
            btnDatMon.IconRight = null;
            btnDatMon.IconRightAlign = ContentAlignment.MiddleRight;
            btnDatMon.IconRightCursor = Cursors.Default;
            btnDatMon.IconRightPadding = new Padding(3, 3, 7, 3);
            btnDatMon.IconSize = 25;
            btnDatMon.IdleBorderColor = Color.Empty;
            btnDatMon.IdleBorderRadius = 0;
            btnDatMon.IdleBorderThickness = 0;
            btnDatMon.IdleFillColor = Color.Empty;
            btnDatMon.IdleIconLeftImage = null;
            btnDatMon.IdleIconRightImage = null;
            btnDatMon.IndicateFocus = false;
            btnDatMon.Location = new Point(3, 188);
            btnDatMon.Name = "btnDatMon";
            btnDatMon.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnDatMon.OnDisabledState.BorderRadius = 15;
            btnDatMon.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDatMon.OnDisabledState.BorderThickness = 1;
            btnDatMon.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnDatMon.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnDatMon.OnDisabledState.IconLeftImage = null;
            btnDatMon.OnDisabledState.IconRightImage = null;
            btnDatMon.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnDatMon.onHoverState.BorderRadius = 15;
            btnDatMon.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDatMon.onHoverState.BorderThickness = 1;
            btnDatMon.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnDatMon.onHoverState.ForeColor = Color.White;
            btnDatMon.onHoverState.IconLeftImage = null;
            btnDatMon.onHoverState.IconRightImage = null;
            btnDatMon.OnIdleState.BorderColor = Color.DodgerBlue;
            btnDatMon.OnIdleState.BorderRadius = 15;
            btnDatMon.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDatMon.OnIdleState.BorderThickness = 1;
            btnDatMon.OnIdleState.FillColor = Color.FromArgb(16, 178, 248);
            btnDatMon.OnIdleState.ForeColor = Color.White;
            btnDatMon.OnIdleState.IconLeftImage = null;
            btnDatMon.OnIdleState.IconRightImage = null;
            btnDatMon.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnDatMon.OnPressedState.BorderRadius = 15;
            btnDatMon.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDatMon.OnPressedState.BorderThickness = 1;
            btnDatMon.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            btnDatMon.OnPressedState.ForeColor = Color.White;
            btnDatMon.OnPressedState.IconLeftImage = null;
            btnDatMon.OnPressedState.IconRightImage = null;
            btnDatMon.Size = new Size(360, 54);
            btnDatMon.TabIndex = 6;
            btnDatMon.TextAlign = ContentAlignment.MiddleRight;
            btnDatMon.TextAlignment = HorizontalAlignment.Center;
            btnDatMon.TextMarginLeft = 0;
            btnDatMon.TextPadding = new Padding(0);
            btnDatMon.UseDefaultRadiusAndThickness = true;
            btnDatMon.Click += btnDatMon_Click;
            // 
            // bunifuTextBox1
            // 
            bunifuTextBox1.AcceptsReturn = false;
            bunifuTextBox1.AcceptsTab = false;
            bunifuTextBox1.AnimationSpeed = 200;
            bunifuTextBox1.AutoCompleteMode = AutoCompleteMode.None;
            bunifuTextBox1.AutoCompleteSource = AutoCompleteSource.None;
            bunifuTextBox1.AutoSizeHeight = true;
            bunifuTextBox1.BackColor = Color.Transparent;
            bunifuTextBox1.BackgroundImage = (Image)resources.GetObject("bunifuTextBox1.BackgroundImage");
            bunifuTextBox1.BorderColorActive = Color.DodgerBlue;
            bunifuTextBox1.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            bunifuTextBox1.BorderColorHover = Color.FromArgb(105, 181, 255);
            bunifuTextBox1.BorderColorIdle = Color.Silver;
            bunifuTextBox1.BorderRadius = 15;
            bunifuTextBox1.BorderThickness = 1;
            bunifuTextBox1.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            bunifuTextBox1.CharacterCasing = CharacterCasing.Normal;
            bunifuTextBox1.DefaultFont = new Font("Segoe UI", 9.25F);
            bunifuTextBox1.DefaultText = "";
            bunifuTextBox1.FillColor = Color.FromArgb(139, 149, 163);
            bunifuTextBox1.ForeColor = Color.White;
            bunifuTextBox1.HideSelection = true;
            bunifuTextBox1.IconLeft = null;
            bunifuTextBox1.IconLeftCursor = Cursors.IBeam;
            bunifuTextBox1.IconPadding = 10;
            bunifuTextBox1.IconRight = null;
            bunifuTextBox1.IconRightCursor = Cursors.IBeam;
            bunifuTextBox1.Location = new Point(3, 54);
            bunifuTextBox1.MaxLength = 32767;
            bunifuTextBox1.MinimumSize = new Size(1, 1);
            bunifuTextBox1.Modified = false;
            bunifuTextBox1.Multiline = false;
            bunifuTextBox1.Name = "bunifuTextBox1";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            bunifuTextBox1.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            bunifuTextBox1.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            bunifuTextBox1.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.FromArgb(139, 149, 163);
            stateProperties4.ForeColor = Color.White;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            bunifuTextBox1.OnIdleState = stateProperties4;
            bunifuTextBox1.Padding = new Padding(3);
            bunifuTextBox1.PasswordChar = '\0';
            bunifuTextBox1.PlaceholderForeColor = Color.White;
            bunifuTextBox1.PlaceholderText = "Note cho quán";
            bunifuTextBox1.ReadOnly = false;
            bunifuTextBox1.ScrollBars = ScrollBars.None;
            bunifuTextBox1.SelectedText = "";
            bunifuTextBox1.SelectionLength = 0;
            bunifuTextBox1.SelectionStart = 0;
            bunifuTextBox1.ShortcutsEnabled = true;
            bunifuTextBox1.Size = new Size(366, 86);
            bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            bunifuTextBox1.TabIndex = 5;
            bunifuTextBox1.TextAlign = HorizontalAlignment.Left;
            bunifuTextBox1.TextMarginBottom = 0;
            bunifuTextBox1.TextMarginLeft = 3;
            bunifuTextBox1.TextMarginTop = 1;
            bunifuTextBox1.TextPlaceholder = "Note cho quán";
            bunifuTextBox1.UseSystemPasswordChar = false;
            bunifuTextBox1.WordWrap = true;
            // 
            // checkBoxSoDu
            // 
            checkBoxSoDu.AutoSize = true;
            checkBoxSoDu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxSoDu.ForeColor = Color.White;
            checkBoxSoDu.Location = new Point(124, 157);
            checkBoxSoDu.Name = "checkBoxSoDu";
            checkBoxSoDu.Size = new Size(239, 25);
            checkBoxSoDu.TabIndex = 4;
            checkBoxSoDu.Text = "Dùng số dư trong tài khoản";
            checkBoxSoDu.UseVisualStyleBackColor = true;
            // 
            // checkBoxTienMat
            // 
            checkBoxTienMat.AutoSize = true;
            checkBoxTienMat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxTienMat.ForeColor = Color.White;
            checkBoxTienMat.Location = new Point(10, 157);
            checkBoxTienMat.Name = "checkBoxTienMat";
            checkBoxTienMat.Size = new Size(96, 25);
            checkBoxTienMat.TabIndex = 1;
            checkBoxTienMat.Text = "Tiền mặt";
            checkBoxTienMat.UseVisualStyleBackColor = true;
            // 
            // textBoxTimMonAn
            // 
            textBoxTimMonAn.AcceptsReturn = false;
            textBoxTimMonAn.AcceptsTab = false;
            textBoxTimMonAn.AnimationSpeed = 200;
            textBoxTimMonAn.AutoCompleteMode = AutoCompleteMode.None;
            textBoxTimMonAn.AutoCompleteSource = AutoCompleteSource.None;
            textBoxTimMonAn.AutoSizeHeight = true;
            textBoxTimMonAn.BackColor = Color.Transparent;
            textBoxTimMonAn.BackgroundImage = (Image)resources.GetObject("textBoxTimMonAn.BackgroundImage");
            textBoxTimMonAn.BorderColorActive = Color.DodgerBlue;
            textBoxTimMonAn.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            textBoxTimMonAn.BorderColorHover = Color.FromArgb(105, 181, 255);
            textBoxTimMonAn.BorderColorIdle = Color.Silver;
            textBoxTimMonAn.BorderRadius = 15;
            textBoxTimMonAn.BorderThickness = 1;
            textBoxTimMonAn.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            textBoxTimMonAn.CharacterCasing = CharacterCasing.Normal;
            textBoxTimMonAn.DefaultFont = new Font("Segoe UI", 9.25F);
            textBoxTimMonAn.DefaultText = "";
            textBoxTimMonAn.FillColor = Color.FromArgb(139, 149, 163);
            textBoxTimMonAn.HideSelection = true;
            textBoxTimMonAn.IconLeft = null;
            textBoxTimMonAn.IconLeftCursor = Cursors.IBeam;
            textBoxTimMonAn.IconPadding = 10;
            textBoxTimMonAn.IconRight = null;
            textBoxTimMonAn.IconRightCursor = Cursors.IBeam;
            textBoxTimMonAn.Location = new Point(2, 5);
            textBoxTimMonAn.MaxLength = 32767;
            textBoxTimMonAn.MinimumSize = new Size(1, 1);
            textBoxTimMonAn.Modified = false;
            textBoxTimMonAn.Multiline = false;
            textBoxTimMonAn.Name = "textBoxTimMonAn";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            textBoxTimMonAn.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            textBoxTimMonAn.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            textBoxTimMonAn.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Silver;
            stateProperties8.FillColor = Color.FromArgb(139, 149, 163);
            stateProperties8.ForeColor = Color.Empty;
            stateProperties8.PlaceholderForeColor = Color.Empty;
            textBoxTimMonAn.OnIdleState = stateProperties8;
            textBoxTimMonAn.Padding = new Padding(3);
            textBoxTimMonAn.PasswordChar = '\0';
            textBoxTimMonAn.PlaceholderForeColor = Color.White;
            textBoxTimMonAn.PlaceholderText = "Tìm kiếm";
            textBoxTimMonAn.ReadOnly = false;
            textBoxTimMonAn.ScrollBars = ScrollBars.None;
            textBoxTimMonAn.SelectedText = "";
            textBoxTimMonAn.SelectionLength = 0;
            textBoxTimMonAn.SelectionStart = 0;
            textBoxTimMonAn.ShortcutsEnabled = true;
            textBoxTimMonAn.Size = new Size(125, 31);
            textBoxTimMonAn.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            textBoxTimMonAn.TabIndex = 1;
            textBoxTimMonAn.TextAlign = HorizontalAlignment.Left;
            textBoxTimMonAn.TextMarginBottom = 0;
            textBoxTimMonAn.TextMarginLeft = 3;
            textBoxTimMonAn.TextMarginTop = 1;
            textBoxTimMonAn.TextPlaceholder = "Tìm kiếm";
            textBoxTimMonAn.UseSystemPasswordChar = false;
            textBoxTimMonAn.WordWrap = true;
            // 
            // GoiMon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 93, 110);
            ClientSize = new Size(1512, 629);
            Controls.Add(textBoxTimMonAn);
            Controls.Add(panel1);
            Controls.Add(CagetoryMonAn);
            Controls.Add(MenuDoAn);
            Name = "GoiMon";
            Text = "Gọi món";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelThanhToan.ResumeLayout(false);
            panelThanhToan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel CagetoryMonAn;
        private FlowLayoutPanel MenuDoAn;
        private Panel panel1;
        private FlowLayoutPanel ListMonAnDat;
        private Panel panelThanhToan;
        private Label labelTongTien;
        private CheckBox checkBoxTienMat;
        private CheckBox checkBoxSoDu;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDatMon;
        private Bunifu.UI.WinForms.BunifuTextBox textBoxTimMonAn;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}