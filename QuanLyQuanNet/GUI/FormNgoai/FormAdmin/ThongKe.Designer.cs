namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    partial class ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelTongDoanhThuGiua = new Label();
            bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            labelTienMay = new Bunifu.UI.WinForms.BunifuLabel();
            bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            labelDichVu = new Bunifu.UI.WinForms.BunifuLabel();
            bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            btnHomNay = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnHomQua = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnBayNgay = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnThang = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            labelDoanhThu = new Bunifu.UI.WinForms.BunifuLabel();
            bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)chartDoanhThu).BeginInit();
            bunifuPanel1.SuspendLayout();
            bunifuPanel2.SuspendLayout();
            bunifuPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            chartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDoanhThu.Legends.Add(legend1);
            chartDoanhThu.Location = new Point(12, 57);
            chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDoanhThu.Series.Add(series1);
            chartDoanhThu.Size = new Size(355, 312);
            chartDoanhThu.TabIndex = 0;
            chartDoanhThu.Text = "chart1";
            // 
            // labelTongDoanhThuGiua
            // 
            labelTongDoanhThuGiua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTongDoanhThuGiua.AutoSize = true;
            labelTongDoanhThuGiua.BackColor = Color.White;
            labelTongDoanhThuGiua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTongDoanhThuGiua.Location = new Point(143, 183);
            labelTongDoanhThuGiua.Name = "labelTongDoanhThuGiua";
            labelTongDoanhThuGiua.Size = new Size(40, 15);
            labelTongDoanhThuGiua.TabIndex = 1;
            labelTongDoanhThuGiua.Text = "label1";
            labelTongDoanhThuGiua.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bunifuPanel1
            // 
            bunifuPanel1.BackgroundColor = Color.White;
            bunifuPanel1.BackgroundImage = (Image)resources.GetObject("bunifuPanel1.BackgroundImage");
            bunifuPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuPanel1.BorderColor = Color.Transparent;
            bunifuPanel1.BorderRadius = 15;
            bunifuPanel1.BorderThickness = 1;
            bunifuPanel1.Controls.Add(labelTienMay);
            bunifuPanel1.Controls.Add(bunifuLabel1);
            bunifuPanel1.Location = new Point(373, 142);
            bunifuPanel1.Name = "bunifuPanel1";
            bunifuPanel1.ShowBorders = true;
            bunifuPanel1.Size = new Size(200, 79);
            bunifuPanel1.TabIndex = 2;
            // 
            // labelTienMay
            // 
            labelTienMay.AllowParentOverrides = false;
            labelTienMay.AutoEllipsis = false;
            labelTienMay.CursorType = Cursors.Default;
            labelTienMay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTienMay.Location = new Point(15, 47);
            labelTienMay.Name = "labelTienMay";
            labelTienMay.RightToLeft = RightToLeft.No;
            labelTienMay.Size = new Size(101, 21);
            labelTienMay.TabIndex = 1;
            labelTienMay.Text = "bunifuLabel2";
            labelTienMay.TextAlignment = ContentAlignment.TopLeft;
            labelTienMay.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            bunifuLabel1.AllowParentOverrides = false;
            bunifuLabel1.AutoEllipsis = false;
            bunifuLabel1.CursorType = Cursors.Default;
            bunifuLabel1.Font = new Font("Segoe UI", 9F);
            bunifuLabel1.Location = new Point(15, 13);
            bunifuLabel1.Name = "bunifuLabel1";
            bunifuLabel1.RightToLeft = RightToLeft.No;
            bunifuLabel1.Size = new Size(53, 15);
            bunifuLabel1.TabIndex = 0;
            bunifuLabel1.Text = "Thuê máy";
            bunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel2
            // 
            bunifuPanel2.BackgroundColor = Color.White;
            bunifuPanel2.BackgroundImage = (Image)resources.GetObject("bunifuPanel2.BackgroundImage");
            bunifuPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuPanel2.BorderColor = Color.Transparent;
            bunifuPanel2.BorderRadius = 15;
            bunifuPanel2.BorderThickness = 1;
            bunifuPanel2.Controls.Add(labelDichVu);
            bunifuPanel2.Controls.Add(bunifuLabel4);
            bunifuPanel2.Location = new Point(373, 57);
            bunifuPanel2.Name = "bunifuPanel2";
            bunifuPanel2.ShowBorders = true;
            bunifuPanel2.Size = new Size(200, 79);
            bunifuPanel2.TabIndex = 3;
            // 
            // labelDichVu
            // 
            labelDichVu.AllowParentOverrides = false;
            labelDichVu.AutoEllipsis = false;
            labelDichVu.CursorType = Cursors.Default;
            labelDichVu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDichVu.Location = new Point(15, 47);
            labelDichVu.Name = "labelDichVu";
            labelDichVu.RightToLeft = RightToLeft.No;
            labelDichVu.Size = new Size(101, 21);
            labelDichVu.TabIndex = 1;
            labelDichVu.Text = "bunifuLabel3";
            labelDichVu.TextAlignment = ContentAlignment.TopLeft;
            labelDichVu.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            bunifuLabel4.AllowParentOverrides = false;
            bunifuLabel4.AutoEllipsis = false;
            bunifuLabel4.CursorType = Cursors.Default;
            bunifuLabel4.Font = new Font("Segoe UI", 9F);
            bunifuLabel4.Location = new Point(15, 13);
            bunifuLabel4.Name = "bunifuLabel4";
            bunifuLabel4.RightToLeft = RightToLeft.No;
            bunifuLabel4.Size = new Size(40, 15);
            bunifuLabel4.TabIndex = 0;
            bunifuLabel4.Text = "Dịch vụ";
            bunifuLabel4.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnHomNay
            // 
            btnHomNay.AllowAnimations = true;
            btnHomNay.AllowMouseEffects = true;
            btnHomNay.AllowToggling = false;
            btnHomNay.AnimationSpeed = 200;
            btnHomNay.AutoGenerateColors = false;
            btnHomNay.AutoRoundBorders = false;
            btnHomNay.AutoSizeLeftIcon = true;
            btnHomNay.AutoSizeRightIcon = true;
            btnHomNay.BackColor = Color.Transparent;
            btnHomNay.BackColor1 = Color.FromArgb(51, 122, 183);
            btnHomNay.BackgroundImage = (Image)resources.GetObject("btnHomNay.BackgroundImage");
            btnHomNay.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnHomNay.ButtonText = "Hôm nay";
            btnHomNay.ButtonTextMarginLeft = 0;
            btnHomNay.ColorContrastOnClick = 45;
            btnHomNay.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btnHomNay.CustomizableEdges = borderEdges1;
            btnHomNay.DialogResult = DialogResult.None;
            btnHomNay.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnHomNay.DisabledFillColor = Color.Empty;
            btnHomNay.DisabledForecolor = Color.Empty;
            btnHomNay.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnHomNay.Font = new Font("Segoe UI", 9F);
            btnHomNay.ForeColor = Color.DodgerBlue;
            btnHomNay.IconLeft = null;
            btnHomNay.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnHomNay.IconLeftCursor = Cursors.Default;
            btnHomNay.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnHomNay.IconMarginLeft = 11;
            btnHomNay.IconPadding = 10;
            btnHomNay.IconRight = null;
            btnHomNay.IconRightAlign = ContentAlignment.MiddleRight;
            btnHomNay.IconRightCursor = Cursors.Default;
            btnHomNay.IconRightPadding = new Padding(3, 3, 7, 3);
            btnHomNay.IconSize = 25;
            btnHomNay.IdleBorderColor = Color.Empty;
            btnHomNay.IdleBorderRadius = 0;
            btnHomNay.IdleBorderThickness = 0;
            btnHomNay.IdleFillColor = Color.Empty;
            btnHomNay.IdleIconLeftImage = null;
            btnHomNay.IdleIconRightImage = null;
            btnHomNay.IndicateFocus = false;
            btnHomNay.Location = new Point(12, 12);
            btnHomNay.Name = "btnHomNay";
            btnHomNay.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnHomNay.OnDisabledState.BorderRadius = 15;
            btnHomNay.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnHomNay.OnDisabledState.BorderThickness = 1;
            btnHomNay.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnHomNay.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnHomNay.OnDisabledState.IconLeftImage = null;
            btnHomNay.OnDisabledState.IconRightImage = null;
            btnHomNay.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnHomNay.onHoverState.BorderRadius = 15;
            btnHomNay.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnHomNay.onHoverState.BorderThickness = 1;
            btnHomNay.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnHomNay.onHoverState.ForeColor = Color.White;
            btnHomNay.onHoverState.IconLeftImage = null;
            btnHomNay.onHoverState.IconRightImage = null;
            btnHomNay.OnIdleState.BorderColor = Color.DodgerBlue;
            btnHomNay.OnIdleState.BorderRadius = 15;
            btnHomNay.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnHomNay.OnIdleState.BorderThickness = 1;
            btnHomNay.OnIdleState.FillColor = Color.White;
            btnHomNay.OnIdleState.ForeColor = Color.DodgerBlue;
            btnHomNay.OnIdleState.IconLeftImage = null;
            btnHomNay.OnIdleState.IconRightImage = null;
            btnHomNay.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnHomNay.OnPressedState.BorderRadius = 15;
            btnHomNay.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnHomNay.OnPressedState.BorderThickness = 1;
            btnHomNay.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            btnHomNay.OnPressedState.ForeColor = Color.White;
            btnHomNay.OnPressedState.IconLeftImage = null;
            btnHomNay.OnPressedState.IconRightImage = null;
            btnHomNay.Size = new Size(150, 39);
            btnHomNay.TabIndex = 4;
            btnHomNay.TextAlign = ContentAlignment.MiddleCenter;
            btnHomNay.TextAlignment = HorizontalAlignment.Center;
            btnHomNay.TextMarginLeft = 0;
            btnHomNay.TextPadding = new Padding(0);
            btnHomNay.UseDefaultRadiusAndThickness = true;
            btnHomNay.Click += btnHomNay_Click;
            // 
            // btnHomQua
            // 
            btnHomQua.AllowAnimations = true;
            btnHomQua.AllowMouseEffects = true;
            btnHomQua.AllowToggling = false;
            btnHomQua.AnimationSpeed = 200;
            btnHomQua.AutoGenerateColors = false;
            btnHomQua.AutoRoundBorders = false;
            btnHomQua.AutoSizeLeftIcon = true;
            btnHomQua.AutoSizeRightIcon = true;
            btnHomQua.BackColor = Color.Transparent;
            btnHomQua.BackColor1 = Color.FromArgb(51, 122, 183);
            btnHomQua.BackgroundImage = (Image)resources.GetObject("btnHomQua.BackgroundImage");
            btnHomQua.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnHomQua.ButtonText = "Hôm qua";
            btnHomQua.ButtonTextMarginLeft = 0;
            btnHomQua.ColorContrastOnClick = 45;
            btnHomQua.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            btnHomQua.CustomizableEdges = borderEdges2;
            btnHomQua.DialogResult = DialogResult.None;
            btnHomQua.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnHomQua.DisabledFillColor = Color.Empty;
            btnHomQua.DisabledForecolor = Color.Empty;
            btnHomQua.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnHomQua.Font = new Font("Segoe UI", 9F);
            btnHomQua.ForeColor = Color.DodgerBlue;
            btnHomQua.IconLeft = null;
            btnHomQua.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnHomQua.IconLeftCursor = Cursors.Default;
            btnHomQua.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnHomQua.IconMarginLeft = 11;
            btnHomQua.IconPadding = 10;
            btnHomQua.IconRight = null;
            btnHomQua.IconRightAlign = ContentAlignment.MiddleRight;
            btnHomQua.IconRightCursor = Cursors.Default;
            btnHomQua.IconRightPadding = new Padding(3, 3, 7, 3);
            btnHomQua.IconSize = 25;
            btnHomQua.IdleBorderColor = Color.Empty;
            btnHomQua.IdleBorderRadius = 0;
            btnHomQua.IdleBorderThickness = 0;
            btnHomQua.IdleFillColor = Color.Empty;
            btnHomQua.IdleIconLeftImage = null;
            btnHomQua.IdleIconRightImage = null;
            btnHomQua.IndicateFocus = false;
            btnHomQua.Location = new Point(168, 12);
            btnHomQua.Name = "btnHomQua";
            btnHomQua.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnHomQua.OnDisabledState.BorderRadius = 15;
            btnHomQua.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnHomQua.OnDisabledState.BorderThickness = 1;
            btnHomQua.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnHomQua.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnHomQua.OnDisabledState.IconLeftImage = null;
            btnHomQua.OnDisabledState.IconRightImage = null;
            btnHomQua.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnHomQua.onHoverState.BorderRadius = 15;
            btnHomQua.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnHomQua.onHoverState.BorderThickness = 1;
            btnHomQua.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnHomQua.onHoverState.ForeColor = Color.White;
            btnHomQua.onHoverState.IconLeftImage = null;
            btnHomQua.onHoverState.IconRightImage = null;
            btnHomQua.OnIdleState.BorderColor = Color.DodgerBlue;
            btnHomQua.OnIdleState.BorderRadius = 15;
            btnHomQua.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnHomQua.OnIdleState.BorderThickness = 1;
            btnHomQua.OnIdleState.FillColor = Color.White;
            btnHomQua.OnIdleState.ForeColor = Color.DodgerBlue;
            btnHomQua.OnIdleState.IconLeftImage = null;
            btnHomQua.OnIdleState.IconRightImage = null;
            btnHomQua.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnHomQua.OnPressedState.BorderRadius = 15;
            btnHomQua.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnHomQua.OnPressedState.BorderThickness = 1;
            btnHomQua.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            btnHomQua.OnPressedState.ForeColor = Color.White;
            btnHomQua.OnPressedState.IconLeftImage = null;
            btnHomQua.OnPressedState.IconRightImage = null;
            btnHomQua.Size = new Size(150, 39);
            btnHomQua.TabIndex = 5;
            btnHomQua.TextAlign = ContentAlignment.MiddleCenter;
            btnHomQua.TextAlignment = HorizontalAlignment.Center;
            btnHomQua.TextMarginLeft = 0;
            btnHomQua.TextPadding = new Padding(0);
            btnHomQua.UseDefaultRadiusAndThickness = true;
            btnHomQua.Click += btnHomQua_Click;
            // 
            // btnBayNgay
            // 
            btnBayNgay.AllowAnimations = true;
            btnBayNgay.AllowMouseEffects = true;
            btnBayNgay.AllowToggling = false;
            btnBayNgay.AnimationSpeed = 200;
            btnBayNgay.AutoGenerateColors = false;
            btnBayNgay.AutoRoundBorders = false;
            btnBayNgay.AutoSizeLeftIcon = true;
            btnBayNgay.AutoSizeRightIcon = true;
            btnBayNgay.BackColor = Color.Transparent;
            btnBayNgay.BackColor1 = Color.FromArgb(51, 122, 183);
            btnBayNgay.BackgroundImage = (Image)resources.GetObject("btnBayNgay.BackgroundImage");
            btnBayNgay.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnBayNgay.ButtonText = "7 ngày qua";
            btnBayNgay.ButtonTextMarginLeft = 0;
            btnBayNgay.ColorContrastOnClick = 45;
            btnBayNgay.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            btnBayNgay.CustomizableEdges = borderEdges3;
            btnBayNgay.DialogResult = DialogResult.None;
            btnBayNgay.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnBayNgay.DisabledFillColor = Color.Empty;
            btnBayNgay.DisabledForecolor = Color.Empty;
            btnBayNgay.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnBayNgay.Font = new Font("Segoe UI", 9F);
            btnBayNgay.ForeColor = Color.DodgerBlue;
            btnBayNgay.IconLeft = null;
            btnBayNgay.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnBayNgay.IconLeftCursor = Cursors.Default;
            btnBayNgay.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnBayNgay.IconMarginLeft = 11;
            btnBayNgay.IconPadding = 10;
            btnBayNgay.IconRight = null;
            btnBayNgay.IconRightAlign = ContentAlignment.MiddleRight;
            btnBayNgay.IconRightCursor = Cursors.Default;
            btnBayNgay.IconRightPadding = new Padding(3, 3, 7, 3);
            btnBayNgay.IconSize = 25;
            btnBayNgay.IdleBorderColor = Color.Empty;
            btnBayNgay.IdleBorderRadius = 0;
            btnBayNgay.IdleBorderThickness = 0;
            btnBayNgay.IdleFillColor = Color.Empty;
            btnBayNgay.IdleIconLeftImage = null;
            btnBayNgay.IdleIconRightImage = null;
            btnBayNgay.IndicateFocus = false;
            btnBayNgay.Location = new Point(324, 12);
            btnBayNgay.Name = "btnBayNgay";
            btnBayNgay.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnBayNgay.OnDisabledState.BorderRadius = 15;
            btnBayNgay.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnBayNgay.OnDisabledState.BorderThickness = 1;
            btnBayNgay.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnBayNgay.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnBayNgay.OnDisabledState.IconLeftImage = null;
            btnBayNgay.OnDisabledState.IconRightImage = null;
            btnBayNgay.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnBayNgay.onHoverState.BorderRadius = 15;
            btnBayNgay.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnBayNgay.onHoverState.BorderThickness = 1;
            btnBayNgay.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnBayNgay.onHoverState.ForeColor = Color.White;
            btnBayNgay.onHoverState.IconLeftImage = null;
            btnBayNgay.onHoverState.IconRightImage = null;
            btnBayNgay.OnIdleState.BorderColor = Color.DodgerBlue;
            btnBayNgay.OnIdleState.BorderRadius = 15;
            btnBayNgay.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnBayNgay.OnIdleState.BorderThickness = 1;
            btnBayNgay.OnIdleState.FillColor = Color.White;
            btnBayNgay.OnIdleState.ForeColor = Color.DodgerBlue;
            btnBayNgay.OnIdleState.IconLeftImage = null;
            btnBayNgay.OnIdleState.IconRightImage = null;
            btnBayNgay.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnBayNgay.OnPressedState.BorderRadius = 15;
            btnBayNgay.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnBayNgay.OnPressedState.BorderThickness = 1;
            btnBayNgay.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            btnBayNgay.OnPressedState.ForeColor = Color.White;
            btnBayNgay.OnPressedState.IconLeftImage = null;
            btnBayNgay.OnPressedState.IconRightImage = null;
            btnBayNgay.Size = new Size(150, 39);
            btnBayNgay.TabIndex = 6;
            btnBayNgay.TextAlign = ContentAlignment.MiddleCenter;
            btnBayNgay.TextAlignment = HorizontalAlignment.Center;
            btnBayNgay.TextMarginLeft = 0;
            btnBayNgay.TextPadding = new Padding(0);
            btnBayNgay.UseDefaultRadiusAndThickness = true;
            btnBayNgay.Click += btnBayNgay_Click;
            // 
            // btnThang
            // 
            btnThang.AllowAnimations = true;
            btnThang.AllowMouseEffects = true;
            btnThang.AllowToggling = false;
            btnThang.AnimationSpeed = 200;
            btnThang.AutoGenerateColors = false;
            btnThang.AutoRoundBorders = false;
            btnThang.AutoSizeLeftIcon = true;
            btnThang.AutoSizeRightIcon = true;
            btnThang.BackColor = Color.Transparent;
            btnThang.BackColor1 = Color.FromArgb(51, 122, 183);
            btnThang.BackgroundImage = (Image)resources.GetObject("btnThang.BackgroundImage");
            btnThang.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnThang.ButtonText = "30 ngày qua";
            btnThang.ButtonTextMarginLeft = 0;
            btnThang.ColorContrastOnClick = 45;
            btnThang.ColorContrastOnHover = 45;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            btnThang.CustomizableEdges = borderEdges4;
            btnThang.DialogResult = DialogResult.None;
            btnThang.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnThang.DisabledFillColor = Color.Empty;
            btnThang.DisabledForecolor = Color.Empty;
            btnThang.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnThang.Font = new Font("Segoe UI", 9F);
            btnThang.ForeColor = Color.DodgerBlue;
            btnThang.IconLeft = null;
            btnThang.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnThang.IconLeftCursor = Cursors.Default;
            btnThang.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnThang.IconMarginLeft = 11;
            btnThang.IconPadding = 10;
            btnThang.IconRight = null;
            btnThang.IconRightAlign = ContentAlignment.MiddleRight;
            btnThang.IconRightCursor = Cursors.Default;
            btnThang.IconRightPadding = new Padding(3, 3, 7, 3);
            btnThang.IconSize = 25;
            btnThang.IdleBorderColor = Color.Empty;
            btnThang.IdleBorderRadius = 0;
            btnThang.IdleBorderThickness = 0;
            btnThang.IdleFillColor = Color.Empty;
            btnThang.IdleIconLeftImage = null;
            btnThang.IdleIconRightImage = null;
            btnThang.IndicateFocus = false;
            btnThang.Location = new Point(480, 12);
            btnThang.Name = "btnThang";
            btnThang.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnThang.OnDisabledState.BorderRadius = 15;
            btnThang.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnThang.OnDisabledState.BorderThickness = 1;
            btnThang.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnThang.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnThang.OnDisabledState.IconLeftImage = null;
            btnThang.OnDisabledState.IconRightImage = null;
            btnThang.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnThang.onHoverState.BorderRadius = 15;
            btnThang.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnThang.onHoverState.BorderThickness = 1;
            btnThang.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnThang.onHoverState.ForeColor = Color.White;
            btnThang.onHoverState.IconLeftImage = null;
            btnThang.onHoverState.IconRightImage = null;
            btnThang.OnIdleState.BorderColor = Color.DodgerBlue;
            btnThang.OnIdleState.BorderRadius = 15;
            btnThang.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnThang.OnIdleState.BorderThickness = 1;
            btnThang.OnIdleState.FillColor = Color.White;
            btnThang.OnIdleState.ForeColor = Color.DodgerBlue;
            btnThang.OnIdleState.IconLeftImage = null;
            btnThang.OnIdleState.IconRightImage = null;
            btnThang.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnThang.OnPressedState.BorderRadius = 15;
            btnThang.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnThang.OnPressedState.BorderThickness = 1;
            btnThang.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            btnThang.OnPressedState.ForeColor = Color.White;
            btnThang.OnPressedState.IconLeftImage = null;
            btnThang.OnPressedState.IconRightImage = null;
            btnThang.Size = new Size(150, 39);
            btnThang.TabIndex = 7;
            btnThang.TextAlign = ContentAlignment.MiddleCenter;
            btnThang.TextAlignment = HorizontalAlignment.Center;
            btnThang.TextMarginLeft = 0;
            btnThang.TextPadding = new Padding(0);
            btnThang.UseDefaultRadiusAndThickness = true;
            btnThang.Click += btnThang_Click;
            // 
            // bunifuPanel3
            // 
            bunifuPanel3.BackgroundColor = Color.White;
            bunifuPanel3.BackgroundImage = (Image)resources.GetObject("bunifuPanel3.BackgroundImage");
            bunifuPanel3.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuPanel3.BorderColor = Color.Transparent;
            bunifuPanel3.BorderRadius = 15;
            bunifuPanel3.BorderThickness = 1;
            bunifuPanel3.Controls.Add(labelDoanhThu);
            bunifuPanel3.Controls.Add(bunifuLabel3);
            bunifuPanel3.Location = new Point(373, 227);
            bunifuPanel3.Name = "bunifuPanel3";
            bunifuPanel3.ShowBorders = true;
            bunifuPanel3.Size = new Size(200, 79);
            bunifuPanel3.TabIndex = 8;
            // 
            // labelDoanhThu
            // 
            labelDoanhThu.AllowParentOverrides = false;
            labelDoanhThu.AutoEllipsis = false;
            labelDoanhThu.CursorType = Cursors.Default;
            labelDoanhThu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDoanhThu.Location = new Point(15, 47);
            labelDoanhThu.Name = "labelDoanhThu";
            labelDoanhThu.RightToLeft = RightToLeft.No;
            labelDoanhThu.Size = new Size(101, 21);
            labelDoanhThu.TabIndex = 1;
            labelDoanhThu.Text = "bunifuLabel2";
            labelDoanhThu.TextAlignment = ContentAlignment.TopLeft;
            labelDoanhThu.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            bunifuLabel3.AllowParentOverrides = false;
            bunifuLabel3.AutoEllipsis = false;
            bunifuLabel3.CursorType = Cursors.Default;
            bunifuLabel3.Font = new Font("Segoe UI", 9F);
            bunifuLabel3.Location = new Point(15, 13);
            bunifuLabel3.Name = "bunifuLabel3";
            bunifuLabel3.RightToLeft = RightToLeft.No;
            bunifuLabel3.Size = new Size(56, 15);
            bunifuLabel3.TabIndex = 0;
            bunifuLabel3.Text = "Doanh thu";
            bunifuLabel3.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 645);
            Controls.Add(bunifuPanel3);
            Controls.Add(btnThang);
            Controls.Add(btnBayNgay);
            Controls.Add(btnHomQua);
            Controls.Add(btnHomNay);
            Controls.Add(bunifuPanel2);
            Controls.Add(bunifuPanel1);
            Controls.Add(labelTongDoanhThuGiua);
            Controls.Add(chartDoanhThu);
            Name = "ThongKe";
            Text = "Thống kê";
            Load += ThongKe_Load;
            ((System.ComponentModel.ISupportInitialize)chartDoanhThu).EndInit();
            bunifuPanel1.ResumeLayout(false);
            bunifuPanel1.PerformLayout();
            bunifuPanel2.ResumeLayout(false);
            bunifuPanel2.PerformLayout();
            bunifuPanel3.ResumeLayout(false);
            bunifuPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private Label labelTongDoanhThuGiua;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel labelTienMay;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuLabel labelDichVu;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnHomNay;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnHomQua;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBayNgay;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnThang;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuLabel labelDoanhThu;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
    }
}