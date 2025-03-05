namespace AISewerPipes
{
	partial class Form1
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
            this.guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.AIdetectroButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.UploadButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.mainTab = new Guna.UI2.WinForms.Guna2TabControl();
            this.InputsTab = new System.Windows.Forms.TabPage();
            this.UploadTab = new System.Windows.Forms.TabPage();
            this.browseButton = new Guna.UI2.WinForms.Guna2Button();
            this.BrowseTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.PlusImageButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.AiDetectorTab = new System.Windows.Forms.TabPage();
            this.StartAIdetectorButton = new Guna.UI2.WinForms.Guna2Button();
            this.VidePathLabel = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.BackButton = new Guna.UI2.WinForms.Guna2Button();
            this.NextButton = new Guna.UI2.WinForms.Guna2Button();
            this.TopPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.CloseButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox7 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.InputsTab.SuspendLayout();
            this.UploadTab.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.AiDetectorTab.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm2
            // 
            this.guna2BorderlessForm2.ContainerControl = this;
            this.guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel1.Controls.Add(this.AIdetectroButton);
            this.guna2Panel1.Controls.Add(this.UploadButton);
            this.guna2Panel1.Controls.Add(this.guna2TileButton1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(174, 644);
            this.guna2Panel1.TabIndex = 1;
            // 
            // AIdetectroButton
            // 
            this.AIdetectroButton.Animated = true;
            this.AIdetectroButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AIdetectroButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AIdetectroButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AIdetectroButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AIdetectroButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AIdetectroButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.AIdetectroButton.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.AIdetectroButton.ForeColor = System.Drawing.Color.Transparent;
            this.AIdetectroButton.Image = global::AISewerPipes.Properties.Resources.microchip;
            this.AIdetectroButton.ImageSize = new System.Drawing.Size(45, 45);
            this.AIdetectroButton.Location = new System.Drawing.Point(0, 282);
            this.AIdetectroButton.Name = "AIdetectroButton";
            this.AIdetectroButton.Size = new System.Drawing.Size(172, 114);
            this.AIdetectroButton.TabIndex = 8;
            this.AIdetectroButton.Text = "AI Detector";
            this.AIdetectroButton.Click += new System.EventHandler(this.AIdetectroButton_Click);
            // 
            // UploadButton
            // 
            this.UploadButton.Animated = true;
            this.UploadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UploadButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UploadButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UploadButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UploadButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UploadButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.UploadButton.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.UploadButton.ForeColor = System.Drawing.Color.Transparent;
            this.UploadButton.Image = global::AISewerPipes.Properties.Resources.cloud_computing;
            this.UploadButton.ImageSize = new System.Drawing.Size(45, 45);
            this.UploadButton.Location = new System.Drawing.Point(-2, 190);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(174, 98);
            this.UploadButton.TabIndex = 7;
            this.UploadButton.Text = "Upload";
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.Animated = true;
            this.guna2TileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.guna2TileButton1.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.guna2TileButton1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2TileButton1.Image = global::AISewerPipes.Properties.Resources.document;
            this.guna2TileButton1.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2TileButton1.Location = new System.Drawing.Point(0, 84);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.Size = new System.Drawing.Size(172, 109);
            this.guna2TileButton1.TabIndex = 6;
            this.guna2TileButton1.Text = "Inputs";
            this.guna2TileButton1.Click += new System.EventHandler(this.guna2TileButton1_Click);
            // 
            // mainTab
            // 
            this.mainTab.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.mainTab.Controls.Add(this.InputsTab);
            this.mainTab.Controls.Add(this.UploadTab);
            this.mainTab.Controls.Add(this.AiDetectorTab);
            this.mainTab.ItemSize = new System.Drawing.Size(180, 40);
            this.mainTab.Location = new System.Drawing.Point(174, 47);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(880, 474);
            this.mainTab.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.mainTab.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.mainTab.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.mainTab.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.mainTab.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.mainTab.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.mainTab.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.mainTab.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.mainTab.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.mainTab.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.mainTab.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.mainTab.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.mainTab.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.mainTab.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.mainTab.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.mainTab.TabButtonSize = new System.Drawing.Size(180, 40);
            this.mainTab.TabIndex = 4;
            this.mainTab.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.mainTab.TabMenuVisible = false;
            // 
            // InputsTab
            // 
            this.InputsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.InputsTab.Controls.Add(this.guna2TextBox3);
            this.InputsTab.Controls.Add(this.guna2TextBox7);
            this.InputsTab.Controls.Add(this.guna2TextBox6);
            this.InputsTab.Controls.Add(this.guna2TextBox5);
            this.InputsTab.Controls.Add(this.guna2TextBox4);
            this.InputsTab.Controls.Add(this.guna2TextBox2);
            this.InputsTab.Controls.Add(this.guna2TextBox1);
            this.InputsTab.Location = new System.Drawing.Point(5, 4);
            this.InputsTab.Name = "InputsTab";
            this.InputsTab.Padding = new System.Windows.Forms.Padding(3);
            this.InputsTab.Size = new System.Drawing.Size(871, 466);
            this.InputsTab.TabIndex = 0;
            this.InputsTab.Text = "tabPage4";
            // 
            // UploadTab
            // 
            this.UploadTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.UploadTab.Controls.Add(this.browseButton);
            this.UploadTab.Controls.Add(this.BrowseTextbox);
            this.UploadTab.Controls.Add(this.guna2Panel4);
            this.UploadTab.Location = new System.Drawing.Point(5, 4);
            this.UploadTab.Name = "UploadTab";
            this.UploadTab.Padding = new System.Windows.Forms.Padding(3);
            this.UploadTab.Size = new System.Drawing.Size(1089, 583);
            this.UploadTab.TabIndex = 1;
            this.UploadTab.Text = "tabPage5";
            // 
            // browseButton
            // 
            this.browseButton.Animated = true;
            this.browseButton.BackColor = System.Drawing.Color.Transparent;
            this.browseButton.BorderRadius = 5;
            this.browseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.browseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.browseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.browseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.browseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.browseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.browseButton.ForeColor = System.Drawing.Color.White;
            this.browseButton.IndicateFocus = true;
            this.browseButton.Location = new System.Drawing.Point(633, 327);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(110, 44);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "Browse";
            this.browseButton.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // BrowseTextbox
            // 
            this.BrowseTextbox.AcceptsTab = true;
            this.BrowseTextbox.Animated = true;
            this.BrowseTextbox.AutoRoundedCorners = true;
            this.BrowseTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.BrowseTextbox.BorderRadius = 21;
            this.BrowseTextbox.BorderThickness = 2;
            this.BrowseTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BrowseTextbox.DefaultText = "";
            this.BrowseTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BrowseTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BrowseTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BrowseTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BrowseTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BrowseTextbox.FocusedState.BorderColor = System.Drawing.Color.SkyBlue;
            this.BrowseTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BrowseTextbox.ForeColor = System.Drawing.Color.Transparent;
            this.BrowseTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BrowseTextbox.Location = new System.Drawing.Point(253, 327);
            this.BrowseTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BrowseTextbox.Name = "BrowseTextbox";
            this.BrowseTextbox.PasswordChar = '\0';
            this.BrowseTextbox.PlaceholderText = "Video Path";
            this.BrowseTextbox.SelectedText = "";
            this.BrowseTextbox.Size = new System.Drawing.Size(345, 44);
            this.BrowseTextbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.BrowseTextbox.TabIndex = 3;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.guna2Panel4.BorderRadius = 15;
            this.guna2Panel4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2Panel4.BorderThickness = 3;
            this.guna2Panel4.Controls.Add(this.PlusImageButton);
            this.guna2Panel4.Location = new System.Drawing.Point(273, 31);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(305, 243);
            this.guna2Panel4.TabIndex = 2;
            // 
            // PlusImageButton
            // 
            this.PlusImageButton.AllowDrop = true;
            this.PlusImageButton.AnimatedGIF = true;
            this.PlusImageButton.BackColor = System.Drawing.Color.Transparent;
            this.PlusImageButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.PlusImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlusImageButton.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.PlusImageButton.Image = global::AISewerPipes.Properties.Resources.more__1_;
            this.PlusImageButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.PlusImageButton.ImageRotate = 0F;
            this.PlusImageButton.ImageSize = new System.Drawing.Size(40, 40);
            this.PlusImageButton.Location = new System.Drawing.Point(10, 15);
            this.PlusImageButton.Name = "PlusImageButton";
            this.PlusImageButton.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.PlusImageButton.ShadowDecoration.Color = System.Drawing.Color.White;
            this.PlusImageButton.Size = new System.Drawing.Size(283, 211);
            this.PlusImageButton.TabIndex = 0;
            this.PlusImageButton.UseTransparentBackground = true;
            this.PlusImageButton.DragDrop += new System.Windows.Forms.DragEventHandler(this.PlusImageButton_DragDrop);
            this.PlusImageButton.DragEnter += new System.Windows.Forms.DragEventHandler(this.PlusImageButton_DragEnter);
            // 
            // AiDetectorTab
            // 
            this.AiDetectorTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.AiDetectorTab.Controls.Add(this.StartAIdetectorButton);
            this.AiDetectorTab.Controls.Add(this.VidePathLabel);
            this.AiDetectorTab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AiDetectorTab.Location = new System.Drawing.Point(5, 4);
            this.AiDetectorTab.Name = "AiDetectorTab";
            this.AiDetectorTab.Size = new System.Drawing.Size(1089, 583);
            this.AiDetectorTab.TabIndex = 2;
            this.AiDetectorTab.Text = "AI Detector";
            // 
            // StartAIdetectorButton
            // 
            this.StartAIdetectorButton.Animated = true;
            this.StartAIdetectorButton.AutoRoundedCorners = true;
            this.StartAIdetectorButton.BorderRadius = 27;
            this.StartAIdetectorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartAIdetectorButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StartAIdetectorButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StartAIdetectorButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StartAIdetectorButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StartAIdetectorButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.StartAIdetectorButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartAIdetectorButton.ForeColor = System.Drawing.Color.Transparent;
            this.StartAIdetectorButton.Location = new System.Drawing.Point(336, 188);
            this.StartAIdetectorButton.Name = "StartAIdetectorButton";
            this.StartAIdetectorButton.Size = new System.Drawing.Size(180, 56);
            this.StartAIdetectorButton.TabIndex = 2;
            this.StartAIdetectorButton.Text = "Start AI Detector";
            this.StartAIdetectorButton.Click += new System.EventHandler(this.StartAIdetectorButton_Click);
            // 
            // VidePathLabel
            // 
            this.VidePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.VidePathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.VidePathLabel.Location = new System.Drawing.Point(45, 76);
            this.VidePathLabel.Name = "VidePathLabel";
            this.VidePathLabel.Size = new System.Drawing.Size(778, 40);
            this.VidePathLabel.TabIndex = 1;
            this.VidePathLabel.Text = "Video Path:";
            this.VidePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.guna2Panel2.Controls.Add(this.BackButton);
            this.guna2Panel2.Controls.Add(this.NextButton);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(174, 536);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(892, 108);
            this.guna2Panel2.TabIndex = 2;
            // 
            // BackButton
            // 
            this.BackButton.Animated = true;
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BorderRadius = 5;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.IndicateFocus = true;
            this.BackButton.Location = new System.Drawing.Point(192, 31);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(165, 51);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Animated = true;
            this.NextButton.BackColor = System.Drawing.Color.Transparent;
            this.NextButton.BorderRadius = 5;
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NextButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NextButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NextButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NextButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.NextButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.IndicateFocus = true;
            this.NextButton.Location = new System.Drawing.Point(524, 31);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(165, 51);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "Next";
            this.NextButton.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TopPanel.Controls.Add(this.MinimizeButton);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(174, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(892, 41);
            this.TopPanel.TabIndex = 3;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.HoverState.ImageSize = new System.Drawing.Size(17, 17);
            this.MinimizeButton.Image = global::AISewerPipes.Properties.Resources.minimize_sign;
            this.MinimizeButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.MinimizeButton.ImageRotate = 0F;
            this.MinimizeButton.ImageSize = new System.Drawing.Size(16, 16);
            this.MinimizeButton.IndicateFocus = true;
            this.MinimizeButton.Location = new System.Drawing.Point(817, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.MinimizeButton.Size = new System.Drawing.Size(33, 38);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.HoverState.ImageSize = new System.Drawing.Size(17, 17);
            this.CloseButton.Image = global::AISewerPipes.Properties.Resources.close;
            this.CloseButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.CloseButton.ImageRotate = 0F;
            this.CloseButton.ImageSize = new System.Drawing.Size(16, 16);
            this.CloseButton.IndicateFocus = true;
            this.CloseButton.Location = new System.Drawing.Point(856, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.CloseButton.Size = new System.Drawing.Size(36, 38);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Processor";
            this.performanceCounter1.CounterName = "% Processor Time";
            this.performanceCounter1.InstanceName = "_Total";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AcceptsTab = true;
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.guna2TextBox1.BorderRadius = 24;
            this.guna2TextBox1.BorderThickness = 2;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(226, 55);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Project Name";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(433, 51);
            this.guna2TextBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox1.TabIndex = 0;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.AcceptsTab = true;
            this.guna2TextBox2.Animated = true;
            this.guna2TextBox2.AutoRoundedCorners = true;
            this.guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.guna2TextBox2.BorderRadius = 24;
            this.guna2TextBox2.BorderThickness = 2;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.ForeColor = System.Drawing.Color.Transparent;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(226, 257);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "Location";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(205, 51);
            this.guna2TextBox2.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox2.TabIndex = 3;
            this.guna2TextBox2.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.AcceptsTab = true;
            this.guna2TextBox4.Animated = true;
            this.guna2TextBox4.AutoRoundedCorners = true;
            this.guna2TextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.guna2TextBox4.BorderRadius = 24;
            this.guna2TextBox4.BorderThickness = 2;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox4.ForeColor = System.Drawing.Color.Transparent;
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.guna2TextBox4.Location = new System.Drawing.Point(226, 344);
            this.guna2TextBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderText = "Pipe Material Type";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.Size = new System.Drawing.Size(205, 51);
            this.guna2TextBox4.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox4.TabIndex = 5;
            // 
            // guna2TextBox5
            // 
            this.guna2TextBox5.AcceptsTab = true;
            this.guna2TextBox5.Animated = true;
            this.guna2TextBox5.AutoRoundedCorners = true;
            this.guna2TextBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.guna2TextBox5.BorderRadius = 24;
            this.guna2TextBox5.BorderThickness = 2;
            this.guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox5.DefaultText = "";
            this.guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.guna2TextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox5.ForeColor = System.Drawing.Color.Transparent;
            this.guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.guna2TextBox5.Location = new System.Drawing.Point(449, 257);
            this.guna2TextBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox5.Name = "guna2TextBox5";
            this.guna2TextBox5.PasswordChar = '\0';
            this.guna2TextBox5.PlaceholderText = "Date";
            this.guna2TextBox5.SelectedText = "";
            this.guna2TextBox5.Size = new System.Drawing.Size(210, 51);
            this.guna2TextBox5.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox5.TabIndex = 4;
            // 
            // guna2TextBox6
            // 
            this.guna2TextBox6.AcceptsTab = true;
            this.guna2TextBox6.Animated = true;
            this.guna2TextBox6.AutoRoundedCorners = true;
            this.guna2TextBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.guna2TextBox6.BorderRadius = 24;
            this.guna2TextBox6.BorderThickness = 2;
            this.guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox6.DefaultText = "";
            this.guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.guna2TextBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox6.ForeColor = System.Drawing.Color.Transparent;
            this.guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.guna2TextBox6.Location = new System.Drawing.Point(454, 166);
            this.guna2TextBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox6.Name = "guna2TextBox6";
            this.guna2TextBox6.PasswordChar = '\0';
            this.guna2TextBox6.PlaceholderText = "Inspercor Name";
            this.guna2TextBox6.SelectedText = "";
            this.guna2TextBox6.Size = new System.Drawing.Size(205, 51);
            this.guna2TextBox6.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox6.TabIndex = 2;
            // 
            // guna2TextBox7
            // 
            this.guna2TextBox7.AcceptsTab = true;
            this.guna2TextBox7.Animated = true;
            this.guna2TextBox7.AutoRoundedCorners = true;
            this.guna2TextBox7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.guna2TextBox7.BorderRadius = 24;
            this.guna2TextBox7.BorderThickness = 2;
            this.guna2TextBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox7.DefaultText = "";
            this.guna2TextBox7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox7.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.guna2TextBox7.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.guna2TextBox7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox7.ForeColor = System.Drawing.Color.Transparent;
            this.guna2TextBox7.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.guna2TextBox7.Location = new System.Drawing.Point(454, 344);
            this.guna2TextBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox7.Name = "guna2TextBox7";
            this.guna2TextBox7.PasswordChar = '\0';
            this.guna2TextBox7.PlaceholderText = "Manhole Length";
            this.guna2TextBox7.SelectedText = "";
            this.guna2TextBox7.Size = new System.Drawing.Size(205, 51);
            this.guna2TextBox7.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox7.TabIndex = 6;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.AcceptsTab = true;
            this.guna2TextBox3.Animated = true;
            this.guna2TextBox3.AutoRoundedCorners = true;
            this.guna2TextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.guna2TextBox3.BorderRadius = 24;
            this.guna2TextBox3.BorderThickness = 2;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox3.ForeColor = System.Drawing.Color.Transparent;
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.guna2TextBox3.Location = new System.Drawing.Point(226, 166);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "Employer Name";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(205, 51);
            this.guna2TextBox3.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox3.TabIndex = 1;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1066, 644);
            this.Controls.Add(this.mainTab);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.InputsTab.ResumeLayout(false);
            this.UploadTab.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.AiDetectorTab.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TabControl mainTab;
        private System.Windows.Forms.TabPage InputsTab;
        private System.Windows.Forms.TabPage UploadTab;
        private Guna.UI2.WinForms.Guna2Panel TopPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        private Guna.UI2.WinForms.Guna2TileButton UploadButton;
        private Guna.UI2.WinForms.Guna2ImageButton PlusImageButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2TextBox BrowseTextbox;
        private Guna.UI2.WinForms.Guna2Button browseButton;
        private Guna.UI2.WinForms.Guna2Button BackButton;
        private Guna.UI2.WinForms.Guna2Button NextButton;
        private Guna.UI2.WinForms.Guna2TileButton AIdetectroButton;
        private System.Windows.Forms.TabPage AiDetectorTab;
        private System.Windows.Forms.Label VidePathLabel;
        private Guna.UI2.WinForms.Guna2Button StartAIdetectorButton;
        private Guna.UI2.WinForms.Guna2ImageButton CloseButton;
        private Guna.UI2.WinForms.Guna2ImageButton MinimizeButton;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox7;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox6;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
    }
}

