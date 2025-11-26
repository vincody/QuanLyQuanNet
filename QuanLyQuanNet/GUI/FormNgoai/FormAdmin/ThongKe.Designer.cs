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
            bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            bunifuButton3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
            labelTongDoanhThuGiua.Location = new Point(142, 183);
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
            // 
            // bunifuButton1
            // 
            bunifuButton1.AllowAnimations = true;
            bunifuButton1.AllowMouseEffects = true;
            bunifuButton1.AllowToggling = false;
            bunifuButton1.AnimationSpeed = 200;
            bunifuButton1.AutoGenerateColors = false;
            bunifuButton1.AutoRoundBorders = false;
            bunifuButton1.AutoSizeLeftIcon = true;
            bunifuButton1.AutoSizeRightIcon = true;
            bunifuButton1.BackColor = Color.Transparent;
            bunifuButton1.BackColor1 = Color.FromArgb(51, 122, 183);
            bunifuButton1.BackgroundImage = (Image)resources.GetObject("bunifuButton1.BackgroundImage");
            bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.ButtonText = "Hôm qua";
            bunifuButton1.ButtonTextMarginLeft = 0;
            bunifuButton1.ColorContrastOnClick = 45;
            bunifuButton1.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            bunifuButton1.CustomizableEdges = borderEdges2;
            bunifuButton1.DialogResult = DialogResult.None;
            bunifuButton1.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton1.DisabledFillColor = Color.Empty;
            bunifuButton1.DisabledForecolor = Color.Empty;
            bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            bunifuButton1.Font = new Font("Segoe UI", 9F);
            bunifuButton1.ForeColor = Color.DodgerBlue;
            bunifuButton1.IconLeft = null;
            bunifuButton1.IconLeftAlign = ContentAlignment.MiddleLeft;
            bunifuButton1.IconLeftCursor = Cursors.Default;
            bunifuButton1.IconLeftPadding = new Padding(11, 3, 3, 3);
            bunifuButton1.IconMarginLeft = 11;
            bunifuButton1.IconPadding = 10;
            bunifuButton1.IconRight = null;
            bunifuButton1.IconRightAlign = ContentAlignment.MiddleRight;
            bunifuButton1.IconRightCursor = Cursors.Default;
            bunifuButton1.IconRightPadding = new Padding(3, 3, 7, 3);
            bunifuButton1.IconSize = 25;
            bunifuButton1.IdleBorderColor = Color.Empty;
            bunifuButton1.IdleBorderRadius = 0;
            bunifuButton1.IdleBorderThickness = 0;
            bunifuButton1.IdleFillColor = Color.Empty;
            bunifuButton1.IdleIconLeftImage = null;
            bunifuButton1.IdleIconRightImage = null;
            bunifuButton1.IndicateFocus = false;
            bunifuButton1.Location = new Point(168, 12);
            bunifuButton1.Name = "bunifuButton1";
            bunifuButton1.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton1.OnDisabledState.BorderRadius = 15;
            bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.OnDisabledState.BorderThickness = 1;
            bunifuButton1.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuButton1.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuButton1.OnDisabledState.IconLeftImage = null;
            bunifuButton1.OnDisabledState.IconRightImage = null;
            bunifuButton1.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            bunifuButton1.onHoverState.BorderRadius = 15;
            bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.onHoverState.BorderThickness = 1;
            bunifuButton1.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            bunifuButton1.onHoverState.ForeColor = Color.White;
            bunifuButton1.onHoverState.IconLeftImage = null;
            bunifuButton1.onHoverState.IconRightImage = null;
            bunifuButton1.OnIdleState.BorderColor = Color.DodgerBlue;
            bunifuButton1.OnIdleState.BorderRadius = 15;
            bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.OnIdleState.BorderThickness = 1;
            bunifuButton1.OnIdleState.FillColor = Color.White;
            bunifuButton1.OnIdleState.ForeColor = Color.DodgerBlue;
            bunifuButton1.OnIdleState.IconLeftImage = null;
            bunifuButton1.OnIdleState.IconRightImage = null;
            bunifuButton1.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            bunifuButton1.OnPressedState.BorderRadius = 15;
            bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.OnPressedState.BorderThickness = 1;
            bunifuButton1.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            bunifuButton1.OnPressedState.ForeColor = Color.White;
            bunifuButton1.OnPressedState.IconLeftImage = null;
            bunifuButton1.OnPressedState.IconRightImage = null;
            bunifuButton1.Size = new Size(150, 39);
            bunifuButton1.TabIndex = 5;
            bunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton1.TextAlignment = HorizontalAlignment.Center;
            bunifuButton1.TextMarginLeft = 0;
            bunifuButton1.TextPadding = new Padding(0);
            bunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuButton2
            // 
            bunifuButton2.AllowAnimations = true;
            bunifuButton2.AllowMouseEffects = true;
            bunifuButton2.AllowToggling = false;
            bunifuButton2.AnimationSpeed = 200;
            bunifuButton2.AutoGenerateColors = false;
            bunifuButton2.AutoRoundBorders = false;
            bunifuButton2.AutoSizeLeftIcon = true;
            bunifuButton2.AutoSizeRightIcon = true;
            bunifuButton2.BackColor = Color.Transparent;
            bunifuButton2.BackColor1 = Color.FromArgb(51, 122, 183);
            bunifuButton2.BackgroundImage = (Image)resources.GetObject("bunifuButton2.BackgroundImage");
            bunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton2.ButtonText = "7 ngày qua";
            bunifuButton2.ButtonTextMarginLeft = 0;
            bunifuButton2.ColorContrastOnClick = 45;
            bunifuButton2.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            bunifuButton2.CustomizableEdges = borderEdges3;
            bunifuButton2.DialogResult = DialogResult.None;
            bunifuButton2.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton2.DisabledFillColor = Color.Empty;
            bunifuButton2.DisabledForecolor = Color.Empty;
            bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            bunifuButton2.Font = new Font("Segoe UI", 9F);
            bunifuButton2.ForeColor = Color.DodgerBlue;
            bunifuButton2.IconLeft = null;
            bunifuButton2.IconLeftAlign = ContentAlignment.MiddleLeft;
            bunifuButton2.IconLeftCursor = Cursors.Default;
            bunifuButton2.IconLeftPadding = new Padding(11, 3, 3, 3);
            bunifuButton2.IconMarginLeft = 11;
            bunifuButton2.IconPadding = 10;
            bunifuButton2.IconRight = null;
            bunifuButton2.IconRightAlign = ContentAlignment.MiddleRight;
            bunifuButton2.IconRightCursor = Cursors.Default;
            bunifuButton2.IconRightPadding = new Padding(3, 3, 7, 3);
            bunifuButton2.IconSize = 25;
            bunifuButton2.IdleBorderColor = Color.Empty;
            bunifuButton2.IdleBorderRadius = 0;
            bunifuButton2.IdleBorderThickness = 0;
            bunifuButton2.IdleFillColor = Color.Empty;
            bunifuButton2.IdleIconLeftImage = null;
            bunifuButton2.IdleIconRightImage = null;
            bunifuButton2.IndicateFocus = false;
            bunifuButton2.Location = new Point(324, 12);
            bunifuButton2.Name = "bunifuButton2";
            bunifuButton2.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton2.OnDisabledState.BorderRadius = 15;
            bunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton2.OnDisabledState.BorderThickness = 1;
            bunifuButton2.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuButton2.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuButton2.OnDisabledState.IconLeftImage = null;
            bunifuButton2.OnDisabledState.IconRightImage = null;
            bunifuButton2.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            bunifuButton2.onHoverState.BorderRadius = 15;
            bunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton2.onHoverState.BorderThickness = 1;
            bunifuButton2.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            bunifuButton2.onHoverState.ForeColor = Color.White;
            bunifuButton2.onHoverState.IconLeftImage = null;
            bunifuButton2.onHoverState.IconRightImage = null;
            bunifuButton2.OnIdleState.BorderColor = Color.DodgerBlue;
            bunifuButton2.OnIdleState.BorderRadius = 15;
            bunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton2.OnIdleState.BorderThickness = 1;
            bunifuButton2.OnIdleState.FillColor = Color.White;
            bunifuButton2.OnIdleState.ForeColor = Color.DodgerBlue;
            bunifuButton2.OnIdleState.IconLeftImage = null;
            bunifuButton2.OnIdleState.IconRightImage = null;
            bunifuButton2.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            bunifuButton2.OnPressedState.BorderRadius = 15;
            bunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton2.OnPressedState.BorderThickness = 1;
            bunifuButton2.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            bunifuButton2.OnPressedState.ForeColor = Color.White;
            bunifuButton2.OnPressedState.IconLeftImage = null;
            bunifuButton2.OnPressedState.IconRightImage = null;
            bunifuButton2.Size = new Size(150, 39);
            bunifuButton2.TabIndex = 6;
            bunifuButton2.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton2.TextAlignment = HorizontalAlignment.Center;
            bunifuButton2.TextMarginLeft = 0;
            bunifuButton2.TextPadding = new Padding(0);
            bunifuButton2.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuButton3
            // 
            bunifuButton3.AllowAnimations = true;
            bunifuButton3.AllowMouseEffects = true;
            bunifuButton3.AllowToggling = false;
            bunifuButton3.AnimationSpeed = 200;
            bunifuButton3.AutoGenerateColors = false;
            bunifuButton3.AutoRoundBorders = false;
            bunifuButton3.AutoSizeLeftIcon = true;
            bunifuButton3.AutoSizeRightIcon = true;
            bunifuButton3.BackColor = Color.Transparent;
            bunifuButton3.BackColor1 = Color.FromArgb(51, 122, 183);
            bunifuButton3.BackgroundImage = (Image)resources.GetObject("bunifuButton3.BackgroundImage");
            bunifuButton3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton3.ButtonText = "30 ngày qua";
            bunifuButton3.ButtonTextMarginLeft = 0;
            bunifuButton3.ColorContrastOnClick = 45;
            bunifuButton3.ColorContrastOnHover = 45;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            bunifuButton3.CustomizableEdges = borderEdges4;
            bunifuButton3.DialogResult = DialogResult.None;
            bunifuButton3.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton3.DisabledFillColor = Color.Empty;
            bunifuButton3.DisabledForecolor = Color.Empty;
            bunifuButton3.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            bunifuButton3.Font = new Font("Segoe UI", 9F);
            bunifuButton3.ForeColor = Color.DodgerBlue;
            bunifuButton3.IconLeft = null;
            bunifuButton3.IconLeftAlign = ContentAlignment.MiddleLeft;
            bunifuButton3.IconLeftCursor = Cursors.Default;
            bunifuButton3.IconLeftPadding = new Padding(11, 3, 3, 3);
            bunifuButton3.IconMarginLeft = 11;
            bunifuButton3.IconPadding = 10;
            bunifuButton3.IconRight = null;
            bunifuButton3.IconRightAlign = ContentAlignment.MiddleRight;
            bunifuButton3.IconRightCursor = Cursors.Default;
            bunifuButton3.IconRightPadding = new Padding(3, 3, 7, 3);
            bunifuButton3.IconSize = 25;
            bunifuButton3.IdleBorderColor = Color.Empty;
            bunifuButton3.IdleBorderRadius = 0;
            bunifuButton3.IdleBorderThickness = 0;
            bunifuButton3.IdleFillColor = Color.Empty;
            bunifuButton3.IdleIconLeftImage = null;
            bunifuButton3.IdleIconRightImage = null;
            bunifuButton3.IndicateFocus = false;
            bunifuButton3.Location = new Point(480, 12);
            bunifuButton3.Name = "bunifuButton3";
            bunifuButton3.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton3.OnDisabledState.BorderRadius = 15;
            bunifuButton3.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton3.OnDisabledState.BorderThickness = 1;
            bunifuButton3.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuButton3.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuButton3.OnDisabledState.IconLeftImage = null;
            bunifuButton3.OnDisabledState.IconRightImage = null;
            bunifuButton3.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            bunifuButton3.onHoverState.BorderRadius = 15;
            bunifuButton3.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton3.onHoverState.BorderThickness = 1;
            bunifuButton3.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            bunifuButton3.onHoverState.ForeColor = Color.White;
            bunifuButton3.onHoverState.IconLeftImage = null;
            bunifuButton3.onHoverState.IconRightImage = null;
            bunifuButton3.OnIdleState.BorderColor = Color.DodgerBlue;
            bunifuButton3.OnIdleState.BorderRadius = 15;
            bunifuButton3.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton3.OnIdleState.BorderThickness = 1;
            bunifuButton3.OnIdleState.FillColor = Color.White;
            bunifuButton3.OnIdleState.ForeColor = Color.DodgerBlue;
            bunifuButton3.OnIdleState.IconLeftImage = null;
            bunifuButton3.OnIdleState.IconRightImage = null;
            bunifuButton3.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            bunifuButton3.OnPressedState.BorderRadius = 15;
            bunifuButton3.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton3.OnPressedState.BorderThickness = 1;
            bunifuButton3.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            bunifuButton3.OnPressedState.ForeColor = Color.White;
            bunifuButton3.OnPressedState.IconLeftImage = null;
            bunifuButton3.OnPressedState.IconRightImage = null;
            bunifuButton3.Size = new Size(150, 39);
            bunifuButton3.TabIndex = 7;
            bunifuButton3.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton3.TextAlignment = HorizontalAlignment.Center;
            bunifuButton3.TextMarginLeft = 0;
            bunifuButton3.TextPadding = new Padding(0);
            bunifuButton3.UseDefaultRadiusAndThickness = true;
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
            Controls.Add(bunifuButton3);
            Controls.Add(bunifuButton2);
            Controls.Add(bunifuButton1);
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton3;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuLabel labelDoanhThu;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
    }
}