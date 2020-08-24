namespace Visual_TraceRoute
{
	partial class VisualTraceRouteForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualTraceRouteForm));
			this.domainTextBox = new Guna.UI2.WinForms.Guna2TextBox();
			this.goButton = new Guna.UI2.WinForms.Guna2Button();
			this.stopTimer = new System.Windows.Forms.Timer(this.components);
			this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
			this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
			this.resetMapButton = new Guna.UI2.WinForms.Guna2Button();
			this.mapControlsLabel1 = new System.Windows.Forms.Label();
			this.mapControlsLabel2 = new System.Windows.Forms.Label();
			this.hostLabel = new System.Windows.Forms.Label();
			this.timeoutLabel = new System.Windows.Forms.Label();
			this.timeoutNumericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.maxHopeLabel = new System.Windows.Forms.Label();
			this.maxHopsNumericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.dataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
			this.hopColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.delayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orgColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.coordinatesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.changeMapProviderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.bingdefaultToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.binghybridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bingsatelliteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.googleMapsdefaultToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.googleMapsterrainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.googleMapshybridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.googleMapssatelliteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.yandexdefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.yandexhybridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.yandexsatelliteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.timeoutNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxHopsNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// domainTextBox
			// 
			this.domainTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.domainTextBox.DefaultText = "www.google.com";
			this.domainTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.domainTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.domainTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.domainTextBox.DisabledState.Parent = this.domainTextBox;
			this.domainTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.domainTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.domainTextBox.FocusedState.Parent = this.domainTextBox;
			this.domainTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.domainTextBox.ForeColor = System.Drawing.Color.Black;
			this.domainTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.domainTextBox.HoverState.Parent = this.domainTextBox;
			this.domainTextBox.Location = new System.Drawing.Point(31, 574);
			this.domainTextBox.Name = "domainTextBox";
			this.domainTextBox.PasswordChar = '\0';
			this.domainTextBox.PlaceholderText = "";
			this.domainTextBox.SelectedText = "";
			this.domainTextBox.SelectionStart = 14;
			this.domainTextBox.ShadowDecoration.Parent = this.domainTextBox;
			this.domainTextBox.Size = new System.Drawing.Size(188, 28);
			this.domainTextBox.TabIndex = 0;
			this.domainTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DomainTextBox_KeyDown);
			// 
			// goButton
			// 
			this.goButton.CheckedState.Parent = this.goButton;
			this.goButton.CustomImages.Parent = this.goButton;
			this.goButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.goButton.ForeColor = System.Drawing.Color.White;
			this.goButton.HoverState.Parent = this.goButton;
			this.goButton.Location = new System.Drawing.Point(225, 574);
			this.goButton.Name = "goButton";
			this.goButton.ShadowDecoration.Parent = this.goButton;
			this.goButton.Size = new System.Drawing.Size(76, 28);
			this.goButton.TabIndex = 1;
			this.goButton.Text = "Go";
			this.goButton.Click += new System.EventHandler(this.GoButton_Click);
			// 
			// stopTimer
			// 
			this.stopTimer.Tick += new System.EventHandler(this.StopTimer_Tick);
			// 
			// progressBar
			// 
			this.progressBar.BorderThickness = 1;
			this.progressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.progressBar.Location = new System.Drawing.Point(869, 574);
			this.progressBar.Name = "progressBar";
			this.progressBar.ProgressColor = System.Drawing.Color.Red;
			this.progressBar.ProgressColor2 = System.Drawing.Color.Lime;
			this.progressBar.ShadowDecoration.Parent = this.progressBar;
			this.progressBar.ShowPercentage = true;
			this.progressBar.Size = new System.Drawing.Size(158, 28);
			this.progressBar.TabIndex = 4;
			this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// gMapControl
			// 
			this.gMapControl.Bearing = 0F;
			this.gMapControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gMapControl.CanDragMap = true;
			this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
			this.gMapControl.GrayScaleMode = false;
			this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
			this.gMapControl.LevelsKeepInMemmory = 5;
			this.gMapControl.Location = new System.Drawing.Point(2, 2);
			this.gMapControl.MarkersEnabled = true;
			this.gMapControl.MaxZoom = 18;
			this.gMapControl.MinZoom = 2;
			this.gMapControl.MouseWheelZoomEnabled = true;
			this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
			this.gMapControl.Name = "gMapControl";
			this.gMapControl.NegativeMode = false;
			this.gMapControl.PolygonsEnabled = true;
			this.gMapControl.RetryLoadTile = 0;
			this.gMapControl.RoutesEnabled = true;
			this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
			this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
			this.gMapControl.ShowTileGridLines = false;
			this.gMapControl.Size = new System.Drawing.Size(1025, 569);
			this.gMapControl.TabIndex = 5;
			this.gMapControl.Zoom = 2D;
			// 
			// resetMapButton
			// 
			this.resetMapButton.CheckedState.Parent = this.resetMapButton;
			this.resetMapButton.CustomImages.Parent = this.resetMapButton;
			this.resetMapButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.resetMapButton.ForeColor = System.Drawing.Color.White;
			this.resetMapButton.HoverState.Parent = this.resetMapButton;
			this.resetMapButton.Location = new System.Drawing.Point(570, 574);
			this.resetMapButton.Name = "resetMapButton";
			this.resetMapButton.ShadowDecoration.Parent = this.resetMapButton;
			this.resetMapButton.Size = new System.Drawing.Size(108, 28);
			this.resetMapButton.TabIndex = 8;
			this.resetMapButton.Text = "Reset Map Pos.";
			this.resetMapButton.Click += new System.EventHandler(this.ResetMapButton_Click);
			// 
			// mapControlsLabel1
			// 
			this.mapControlsLabel1.AutoSize = true;
			this.mapControlsLabel1.Location = new System.Drawing.Point(682, 575);
			this.mapControlsLabel1.Name = "mapControlsLabel1";
			this.mapControlsLabel1.Size = new System.Drawing.Size(183, 13);
			this.mapControlsLabel1.TabIndex = 9;
			this.mapControlsLabel1.Text = "Hold down right click to move around";
			// 
			// mapControlsLabel2
			// 
			this.mapControlsLabel2.AutoSize = true;
			this.mapControlsLabel2.Location = new System.Drawing.Point(682, 588);
			this.mapControlsLabel2.Name = "mapControlsLabel2";
			this.mapControlsLabel2.Size = new System.Drawing.Size(179, 13);
			this.mapControlsLabel2.TabIndex = 10;
			this.mapControlsLabel2.Text = "Use mouse wheel to zoon in and out";
			// 
			// hostLabel
			// 
			this.hostLabel.AutoSize = true;
			this.hostLabel.Location = new System.Drawing.Point(-1, 581);
			this.hostLabel.Name = "hostLabel";
			this.hostLabel.Size = new System.Drawing.Size(32, 13);
			this.hostLabel.TabIndex = 11;
			this.hostLabel.Text = "Host:";
			// 
			// timeoutLabel
			// 
			this.timeoutLabel.AutoSize = true;
			this.timeoutLabel.Location = new System.Drawing.Point(309, 581);
			this.timeoutLabel.Name = "timeoutLabel";
			this.timeoutLabel.Size = new System.Drawing.Size(48, 13);
			this.timeoutLabel.TabIndex = 12;
			this.timeoutLabel.Text = "Timeout:";
			// 
			// timeoutNumericUpDown
			// 
			this.timeoutNumericUpDown.BackColor = System.Drawing.Color.Transparent;
			this.timeoutNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.timeoutNumericUpDown.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.timeoutNumericUpDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.timeoutNumericUpDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.timeoutNumericUpDown.DisabledState.Parent = this.timeoutNumericUpDown;
			this.timeoutNumericUpDown.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
			this.timeoutNumericUpDown.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
			this.timeoutNumericUpDown.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.timeoutNumericUpDown.FocusedState.Parent = this.timeoutNumericUpDown;
			this.timeoutNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.timeoutNumericUpDown.ForeColor = System.Drawing.Color.Black;
			this.timeoutNumericUpDown.Location = new System.Drawing.Point(357, 574);
			this.timeoutNumericUpDown.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
			this.timeoutNumericUpDown.Name = "timeoutNumericUpDown";
			this.timeoutNumericUpDown.ShadowDecoration.Parent = this.timeoutNumericUpDown;
			this.timeoutNumericUpDown.Size = new System.Drawing.Size(72, 28);
			this.timeoutNumericUpDown.TabIndex = 13;
			this.timeoutNumericUpDown.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			// 
			// maxHopeLabel
			// 
			this.maxHopeLabel.AutoSize = true;
			this.maxHopeLabel.Location = new System.Drawing.Point(435, 581);
			this.maxHopeLabel.Name = "maxHopeLabel";
			this.maxHopeLabel.Size = new System.Drawing.Size(58, 13);
			this.maxHopeLabel.TabIndex = 14;
			this.maxHopeLabel.Text = "Max Hops:";
			// 
			// maxHopsNumericUpDown
			// 
			this.maxHopsNumericUpDown.BackColor = System.Drawing.Color.Transparent;
			this.maxHopsNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.maxHopsNumericUpDown.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.maxHopsNumericUpDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.maxHopsNumericUpDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.maxHopsNumericUpDown.DisabledState.Parent = this.maxHopsNumericUpDown;
			this.maxHopsNumericUpDown.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
			this.maxHopsNumericUpDown.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
			this.maxHopsNumericUpDown.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.maxHopsNumericUpDown.FocusedState.Parent = this.maxHopsNumericUpDown;
			this.maxHopsNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.maxHopsNumericUpDown.ForeColor = System.Drawing.Color.Black;
			this.maxHopsNumericUpDown.Location = new System.Drawing.Point(493, 574);
			this.maxHopsNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.maxHopsNumericUpDown.Name = "maxHopsNumericUpDown";
			this.maxHopsNumericUpDown.ShadowDecoration.Parent = this.maxHopsNumericUpDown;
			this.maxHopsNumericUpDown.Size = new System.Drawing.Size(72, 28);
			this.maxHopsNumericUpDown.TabIndex = 15;
			this.maxHopsNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.dataGridView.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hopColumn,
            this.delayColumn,
            this.addressColumn,
            this.orgColumn,
            this.cityColumn,
            this.countryColumn,
            this.coordinatesColumn});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView.EnableHeadersVisualStyles = false;
			this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridView.Location = new System.Drawing.Point(2, 606);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(1025, 124);
			this.dataGridView.TabIndex = 16;
			this.dataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
			this.dataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
			this.dataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dataGridView.ThemeStyle.HeaderStyle.Height = 23;
			this.dataGridView.ThemeStyle.ReadOnly = false;
			this.dataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dataGridView.ThemeStyle.RowsStyle.Height = 22;
			this.dataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridView_RowsAdded);
			// 
			// hopColumn
			// 
			this.hopColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.hopColumn.HeaderText = "# Hop";
			this.hopColumn.Name = "hopColumn";
			this.hopColumn.ReadOnly = true;
			this.hopColumn.Width = 70;
			// 
			// delayColumn
			// 
			this.delayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.delayColumn.HeaderText = "Delay (ms)";
			this.delayColumn.Name = "delayColumn";
			this.delayColumn.ReadOnly = true;
			// 
			// addressColumn
			// 
			this.addressColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.addressColumn.HeaderText = "IP Address";
			this.addressColumn.Name = "addressColumn";
			this.addressColumn.ReadOnly = true;
			this.addressColumn.Width = 150;
			// 
			// orgColumn
			// 
			this.orgColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.orgColumn.HeaderText = "Organization";
			this.orgColumn.Name = "orgColumn";
			this.orgColumn.ReadOnly = true;
			this.orgColumn.Width = 240;
			// 
			// cityColumn
			// 
			this.cityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.cityColumn.HeaderText = "City";
			this.cityColumn.Name = "cityColumn";
			this.cityColumn.ReadOnly = true;
			this.cityColumn.Width = 160;
			// 
			// countryColumn
			// 
			this.countryColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.countryColumn.HeaderText = "Country Code";
			this.countryColumn.Name = "countryColumn";
			this.countryColumn.ReadOnly = true;
			this.countryColumn.Width = 110;
			// 
			// coordinatesColumn
			// 
			this.coordinatesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.coordinatesColumn.HeaderText = "Coordinates (lat., long.)";
			this.coordinatesColumn.Name = "coordinatesColumn";
			this.coordinatesColumn.ReadOnly = true;
			this.coordinatesColumn.Width = 192;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeMapProviderToolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1029, 24);
			this.menuStrip1.TabIndex = 18;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// changeMapProviderToolStripMenuItem1
			// 
			this.changeMapProviderToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bingdefaultToolStripMenuItem1,
            this.binghybridToolStripMenuItem,
            this.bingsatelliteToolStripMenuItem,
            this.googleMapsdefaultToolStripMenuItem2,
            this.googleMapsterrainToolStripMenuItem,
            this.googleMapshybridToolStripMenuItem,
            this.googleMapssatelliteToolStripMenuItem1,
            this.yandexdefaultToolStripMenuItem,
            this.yandexhybridToolStripMenuItem,
            this.yandexsatelliteToolStripMenuItem});
			this.changeMapProviderToolStripMenuItem1.Name = "changeMapProviderToolStripMenuItem1";
			this.changeMapProviderToolStripMenuItem1.Size = new System.Drawing.Size(134, 20);
			this.changeMapProviderToolStripMenuItem1.Text = "Change map provider";
			// 
			// bingdefaultToolStripMenuItem1
			// 
			this.bingdefaultToolStripMenuItem1.Name = "bingdefaultToolStripMenuItem1";
			this.bingdefaultToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
			this.bingdefaultToolStripMenuItem1.Text = "Bing (default)";
			this.bingdefaultToolStripMenuItem1.Click += new System.EventHandler(this.BingdefaultToolStripMenuItem1_Click);
			// 
			// binghybridToolStripMenuItem
			// 
			this.binghybridToolStripMenuItem.Name = "binghybridToolStripMenuItem";
			this.binghybridToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.binghybridToolStripMenuItem.Text = "Bing (hybrid)";
			this.binghybridToolStripMenuItem.Click += new System.EventHandler(this.BinghybrideToolStripMenuItem_Click);
			// 
			// bingsatelliteToolStripMenuItem
			// 
			this.bingsatelliteToolStripMenuItem.Name = "bingsatelliteToolStripMenuItem";
			this.bingsatelliteToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.bingsatelliteToolStripMenuItem.Text = "Bing (satellite)";
			this.bingsatelliteToolStripMenuItem.Click += new System.EventHandler(this.BingsatelliteToolStripMenuItem_Click);
			// 
			// googleMapsdefaultToolStripMenuItem2
			// 
			this.googleMapsdefaultToolStripMenuItem2.Name = "googleMapsdefaultToolStripMenuItem2";
			this.googleMapsdefaultToolStripMenuItem2.Size = new System.Drawing.Size(195, 22);
			this.googleMapsdefaultToolStripMenuItem2.Text = "Google Maps (default)";
			this.googleMapsdefaultToolStripMenuItem2.Click += new System.EventHandler(this.GoogleMapsdefaultToolStripMenuItem2_Click);
			// 
			// googleMapsterrainToolStripMenuItem
			// 
			this.googleMapsterrainToolStripMenuItem.Name = "googleMapsterrainToolStripMenuItem";
			this.googleMapsterrainToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.googleMapsterrainToolStripMenuItem.Text = "Google Maps (terrain)";
			this.googleMapsterrainToolStripMenuItem.Click += new System.EventHandler(this.GoogleMapsterrainToolStripMenuItem_Click);
			// 
			// googleMapshybridToolStripMenuItem
			// 
			this.googleMapshybridToolStripMenuItem.Name = "googleMapshybridToolStripMenuItem";
			this.googleMapshybridToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.googleMapshybridToolStripMenuItem.Text = "Google Maps (hybrid)";
			this.googleMapshybridToolStripMenuItem.Click += new System.EventHandler(this.GoogleMapshybridToolStripMenuItem_Click);
			// 
			// googleMapssatelliteToolStripMenuItem1
			// 
			this.googleMapssatelliteToolStripMenuItem1.Name = "googleMapssatelliteToolStripMenuItem1";
			this.googleMapssatelliteToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
			this.googleMapssatelliteToolStripMenuItem1.Text = "Google Maps (satellite)";
			this.googleMapssatelliteToolStripMenuItem1.Click += new System.EventHandler(this.GoogleMapssatelliteToolStripMenuItem1_Click);
			// 
			// yandexdefaultToolStripMenuItem
			// 
			this.yandexdefaultToolStripMenuItem.Name = "yandexdefaultToolStripMenuItem";
			this.yandexdefaultToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.yandexdefaultToolStripMenuItem.Text = "Yandex (default)";
			this.yandexdefaultToolStripMenuItem.Click += new System.EventHandler(this.YandexdefaultToolStripMenuItem_Click);
			// 
			// yandexhybridToolStripMenuItem
			// 
			this.yandexhybridToolStripMenuItem.Name = "yandexhybridToolStripMenuItem";
			this.yandexhybridToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.yandexhybridToolStripMenuItem.Text = "Yandex (hybrid)";
			this.yandexhybridToolStripMenuItem.Click += new System.EventHandler(this.YandexhybridToolStripMenuItem_Click);
			// 
			// yandexsatelliteToolStripMenuItem
			// 
			this.yandexsatelliteToolStripMenuItem.Name = "yandexsatelliteToolStripMenuItem";
			this.yandexsatelliteToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.yandexsatelliteToolStripMenuItem.Text = "Yandex (satellite)";
			this.yandexsatelliteToolStripMenuItem.Click += new System.EventHandler(this.YandexsatelliteToolStripMenuItem_Click);
			// 
			// VisualTraceRouteForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1029, 732);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.maxHopsNumericUpDown);
			this.Controls.Add(this.maxHopeLabel);
			this.Controls.Add(this.timeoutNumericUpDown);
			this.Controls.Add(this.timeoutLabel);
			this.Controls.Add(this.hostLabel);
			this.Controls.Add(this.mapControlsLabel2);
			this.Controls.Add(this.mapControlsLabel1);
			this.Controls.Add(this.resetMapButton);
			this.Controls.Add(this.gMapControl);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.goButton);
			this.Controls.Add(this.domainTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "VisualTraceRouteForm";
			this.Text = "Visual TraceRoute v1.1.0.0 - MIT License © 2020 Clément Campagna";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.timeoutNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxHopsNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2TextBox domainTextBox;
		private Guna.UI2.WinForms.Guna2Button goButton;
		private System.Windows.Forms.Timer stopTimer;
		private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
		private GMap.NET.WindowsForms.GMapControl gMapControl;
		private Guna.UI2.WinForms.Guna2Button resetMapButton;
		private System.Windows.Forms.Label mapControlsLabel1;
		private System.Windows.Forms.Label mapControlsLabel2;
		private System.Windows.Forms.Label hostLabel;
		private System.Windows.Forms.Label timeoutLabel;
		private Guna.UI2.WinForms.Guna2NumericUpDown timeoutNumericUpDown;
		private System.Windows.Forms.Label maxHopeLabel;
		private Guna.UI2.WinForms.Guna2NumericUpDown maxHopsNumericUpDown;
		private Guna.UI2.WinForms.Guna2DataGridView dataGridView;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem changeMapProviderToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem googleMapsdefaultToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem googleMapssatelliteToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem bingdefaultToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem binghybridToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem googleMapshybridToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem googleMapsterrainToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bingsatelliteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yandexdefaultToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yandexhybridToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yandexsatelliteToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn hopColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn delayColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn orgColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cityColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn countryColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn coordinatesColumn;
	}
}

