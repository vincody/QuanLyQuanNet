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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDA));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pictureBoxMenu = new PictureBox();
            textBoxTimKiem = new TextBox();
            btnThemMon = new Button();
            btnXoaMonAn = new Button();
            panel1 = new Panel();
            textBoxPL = new Bunifu.UI.WinForms.BunifuTextBox();
            textBoxGia = new Bunifu.UI.WinForms.BunifuTextBox();
            textBoxTenMA = new Bunifu.UI.WinForms.BunifuTextBox();
            btnSuaChiTietMon = new Button();
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
            panel1.Controls.Add(textBoxPL);
            panel1.Controls.Add(textBoxGia);
            panel1.Controls.Add(textBoxTenMA);
            panel1.Controls.Add(btnSuaChiTietMon);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelGia);
            panel1.Controls.Add(labelPL);
            panel1.Location = new Point(491, 267);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 224);
            panel1.TabIndex = 5;
            // 
            // textBoxPL
            // 
            textBoxPL.AcceptsReturn = false;
            textBoxPL.AcceptsTab = false;
            textBoxPL.AnimationSpeed = 200;
            textBoxPL.AutoCompleteMode = AutoCompleteMode.None;
            textBoxPL.AutoCompleteSource = AutoCompleteSource.None;
            textBoxPL.AutoSizeHeight = true;
            textBoxPL.BackColor = Color.Transparent;
            textBoxPL.BackgroundImage = (Image)resources.GetObject("textBoxPL.BackgroundImage");
            textBoxPL.BorderColorActive = Color.DodgerBlue;
            textBoxPL.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            textBoxPL.BorderColorHover = Color.FromArgb(105, 181, 255);
            textBoxPL.BorderColorIdle = Color.Silver;
            textBoxPL.BorderRadius = 15;
            textBoxPL.BorderThickness = 1;
            textBoxPL.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            textBoxPL.CharacterCasing = CharacterCasing.Normal;
            textBoxPL.DefaultFont = new Font("Segoe UI", 9.25F);
            textBoxPL.DefaultText = "";
            textBoxPL.FillColor = Color.White;
            textBoxPL.HideSelection = true;
            textBoxPL.IconLeft = null;
            textBoxPL.IconLeftCursor = Cursors.IBeam;
            textBoxPL.IconPadding = 10;
            textBoxPL.IconRight = null;
            textBoxPL.IconRightCursor = Cursors.IBeam;
            textBoxPL.Location = new Point(111, 124);
            textBoxPL.MaxLength = 32767;
            textBoxPL.MinimumSize = new Size(1, 1);
            textBoxPL.Modified = false;
            textBoxPL.Multiline = false;
            textBoxPL.Name = "textBoxPL";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            textBoxPL.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            textBoxPL.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            textBoxPL.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            textBoxPL.OnIdleState = stateProperties4;
            textBoxPL.Padding = new Padding(3);
            textBoxPL.PasswordChar = '\0';
            textBoxPL.PlaceholderForeColor = Color.Silver;
            textBoxPL.PlaceholderText = "";
            textBoxPL.ReadOnly = true;
            textBoxPL.ScrollBars = ScrollBars.None;
            textBoxPL.SelectedText = "";
            textBoxPL.SelectionLength = 0;
            textBoxPL.SelectionStart = 0;
            textBoxPL.ShortcutsEnabled = true;
            textBoxPL.Size = new Size(170, 28);
            textBoxPL.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            textBoxPL.TabIndex = 9;
            textBoxPL.TextAlign = HorizontalAlignment.Left;
            textBoxPL.TextMarginBottom = 0;
            textBoxPL.TextMarginLeft = 3;
            textBoxPL.TextMarginTop = 1;
            textBoxPL.TextPlaceholder = "";
            textBoxPL.UseSystemPasswordChar = false;
            textBoxPL.WordWrap = true;
            // 
            // textBoxGia
            // 
            textBoxGia.AcceptsReturn = false;
            textBoxGia.AcceptsTab = false;
            textBoxGia.AnimationSpeed = 200;
            textBoxGia.AutoCompleteMode = AutoCompleteMode.None;
            textBoxGia.AutoCompleteSource = AutoCompleteSource.None;
            textBoxGia.AutoSizeHeight = true;
            textBoxGia.BackColor = Color.Transparent;
            textBoxGia.BackgroundImage = (Image)resources.GetObject("textBoxGia.BackgroundImage");
            textBoxGia.BorderColorActive = Color.DodgerBlue;
            textBoxGia.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            textBoxGia.BorderColorHover = Color.FromArgb(105, 181, 255);
            textBoxGia.BorderColorIdle = Color.Silver;
            textBoxGia.BorderRadius = 15;
            textBoxGia.BorderThickness = 1;
            textBoxGia.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            textBoxGia.CharacterCasing = CharacterCasing.Normal;
            textBoxGia.DefaultFont = new Font("Segoe UI", 9.25F);
            textBoxGia.DefaultText = "";
            textBoxGia.FillColor = Color.White;
            textBoxGia.HideSelection = true;
            textBoxGia.IconLeft = null;
            textBoxGia.IconLeftCursor = Cursors.IBeam;
            textBoxGia.IconPadding = 10;
            textBoxGia.IconRight = null;
            textBoxGia.IconRightCursor = Cursors.IBeam;
            textBoxGia.Location = new Point(111, 66);
            textBoxGia.MaxLength = 32767;
            textBoxGia.MinimumSize = new Size(1, 1);
            textBoxGia.Modified = false;
            textBoxGia.Multiline = false;
            textBoxGia.Name = "textBoxGia";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            textBoxGia.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            textBoxGia.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            textBoxGia.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Silver;
            stateProperties8.FillColor = Color.White;
            stateProperties8.ForeColor = Color.Empty;
            stateProperties8.PlaceholderForeColor = Color.Empty;
            textBoxGia.OnIdleState = stateProperties8;
            textBoxGia.Padding = new Padding(3);
            textBoxGia.PasswordChar = '\0';
            textBoxGia.PlaceholderForeColor = Color.Silver;
            textBoxGia.PlaceholderText = "";
            textBoxGia.ReadOnly = true;
            textBoxGia.ScrollBars = ScrollBars.None;
            textBoxGia.SelectedText = "";
            textBoxGia.SelectionLength = 0;
            textBoxGia.SelectionStart = 0;
            textBoxGia.ShortcutsEnabled = true;
            textBoxGia.Size = new Size(170, 32);
            textBoxGia.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            textBoxGia.TabIndex = 8;
            textBoxGia.TextAlign = HorizontalAlignment.Left;
            textBoxGia.TextMarginBottom = 0;
            textBoxGia.TextMarginLeft = 3;
            textBoxGia.TextMarginTop = 1;
            textBoxGia.TextPlaceholder = "";
            textBoxGia.UseSystemPasswordChar = false;
            textBoxGia.WordWrap = true;
            // 
            // textBoxTenMA
            // 
            textBoxTenMA.AcceptsReturn = false;
            textBoxTenMA.AcceptsTab = false;
            textBoxTenMA.AnimationSpeed = 200;
            textBoxTenMA.AutoCompleteMode = AutoCompleteMode.None;
            textBoxTenMA.AutoCompleteSource = AutoCompleteSource.None;
            textBoxTenMA.AutoSizeHeight = true;
            textBoxTenMA.BackColor = Color.Transparent;
            textBoxTenMA.BackgroundImage = (Image)resources.GetObject("textBoxTenMA.BackgroundImage");
            textBoxTenMA.BorderColorActive = Color.DodgerBlue;
            textBoxTenMA.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            textBoxTenMA.BorderColorHover = Color.FromArgb(105, 181, 255);
            textBoxTenMA.BorderColorIdle = Color.Silver;
            textBoxTenMA.BorderRadius = 15;
            textBoxTenMA.BorderThickness = 1;
            textBoxTenMA.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            textBoxTenMA.CharacterCasing = CharacterCasing.Normal;
            textBoxTenMA.DefaultFont = new Font("Segoe UI", 9.25F);
            textBoxTenMA.DefaultText = "";
            textBoxTenMA.FillColor = Color.White;
            textBoxTenMA.HideSelection = true;
            textBoxTenMA.IconLeft = null;
            textBoxTenMA.IconLeftCursor = Cursors.IBeam;
            textBoxTenMA.IconPadding = 10;
            textBoxTenMA.IconRight = null;
            textBoxTenMA.IconRightCursor = Cursors.IBeam;
            textBoxTenMA.Location = new Point(109, 18);
            textBoxTenMA.MaxLength = 32767;
            textBoxTenMA.MinimumSize = new Size(1, 1);
            textBoxTenMA.Modified = false;
            textBoxTenMA.Multiline = false;
            textBoxTenMA.Name = "textBoxTenMA";
            stateProperties9.BorderColor = Color.DodgerBlue;
            stateProperties9.FillColor = Color.Empty;
            stateProperties9.ForeColor = Color.Empty;
            stateProperties9.PlaceholderForeColor = Color.Empty;
            textBoxTenMA.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties10.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties10.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties10.PlaceholderForeColor = Color.DarkGray;
            textBoxTenMA.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties11.FillColor = Color.Empty;
            stateProperties11.ForeColor = Color.Empty;
            stateProperties11.PlaceholderForeColor = Color.Empty;
            textBoxTenMA.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = Color.Silver;
            stateProperties12.FillColor = Color.White;
            stateProperties12.ForeColor = Color.Empty;
            stateProperties12.PlaceholderForeColor = Color.Empty;
            textBoxTenMA.OnIdleState = stateProperties12;
            textBoxTenMA.Padding = new Padding(3);
            textBoxTenMA.PasswordChar = '\0';
            textBoxTenMA.PlaceholderForeColor = Color.Silver;
            textBoxTenMA.PlaceholderText = "";
            textBoxTenMA.ReadOnly = true;
            textBoxTenMA.ScrollBars = ScrollBars.None;
            textBoxTenMA.SelectedText = "";
            textBoxTenMA.SelectionLength = 0;
            textBoxTenMA.SelectionStart = 0;
            textBoxTenMA.ShortcutsEnabled = true;
            textBoxTenMA.Size = new Size(172, 31);
            textBoxTenMA.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            textBoxTenMA.TabIndex = 7;
            textBoxTenMA.TextAlign = HorizontalAlignment.Left;
            textBoxTenMA.TextMarginBottom = 0;
            textBoxTenMA.TextMarginLeft = 3;
            textBoxTenMA.TextMarginTop = 1;
            textBoxTenMA.TextPlaceholder = "";
            textBoxTenMA.UseSystemPasswordChar = false;
            textBoxTenMA.WordWrap = true;
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
            labelGia.Location = new Point(24, 72);
            labelGia.Name = "labelGia";
            labelGia.Size = new Size(80, 21);
            labelGia.TabIndex = 1;
            labelGia.Text = "Giá (VNĐ)";
            // 
            // labelPL
            // 
            labelPL.AutoSize = true;
            labelPL.Font = new Font("Segoe UI", 12F);
            labelPL.Location = new Point(24, 128);
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
            BackColor = Color.AliceBlue;
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
        private Label label1;
        private Label labelGia;
        private Button btnSuaChiTietMon;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewMenu;
        private Bunifu.UI.WinForms.BunifuTextBox textBoxTenMA;
        private Bunifu.UI.WinForms.BunifuTextBox textBoxPL;
        private Bunifu.UI.WinForms.BunifuTextBox textBoxGia;
    }
}