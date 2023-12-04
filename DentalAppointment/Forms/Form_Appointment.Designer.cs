namespace DentalAppointment.Forms
{
    partial class Form_Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Appointment));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.SidebarMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SidebarT = new System.Windows.Forms.Timer(this.components);
            this.dayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.BTPrevious = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BTnext = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.homeBt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.loginBt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BtAppointment = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lbMonthyr = new Bunifu.UI.WinForms.BunifuLabel();
            this.SidebarMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // SidebarMenu
            // 
            this.SidebarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SidebarMenu.Controls.Add(this.panel1);
            this.SidebarMenu.Controls.Add(this.panel3);
            this.SidebarMenu.Controls.Add(this.panel2);
            this.SidebarMenu.Controls.Add(this.panel5);
            this.SidebarMenu.Location = new System.Drawing.Point(0, 0);
            this.SidebarMenu.MaximumSize = new System.Drawing.Size(222, 703);
            this.SidebarMenu.MinimumSize = new System.Drawing.Size(65, 703);
            this.SidebarMenu.Name = "SidebarMenu";
            this.SidebarMenu.Size = new System.Drawing.Size(65, 703);
            this.SidebarMenu.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 71);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(60, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.homeBt);
            this.panel3.Location = new System.Drawing.Point(3, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 48);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.loginBt);
            this.panel2.Location = new System.Drawing.Point(3, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 48);
            this.panel2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BtAppointment);
            this.panel5.Location = new System.Drawing.Point(3, 188);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(219, 48);
            this.panel5.TabIndex = 21;
            // 
            // SidebarT
            // 
            this.SidebarT.Interval = 1;
            // 
            // dayContainer
            // 
            this.dayContainer.Location = new System.Drawing.Point(67, 83);
            this.dayContainer.Name = "dayContainer";
            this.dayContainer.Size = new System.Drawing.Size(1151, 580);
            this.dayContainer.TabIndex = 24;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bunifuLabel1.Location = new System.Drawing.Point(119, 42);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(62, 25);
            this.bunifuLabel1.TabIndex = 27;
            this.bunifuLabel1.Text = "Sunday";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bunifuLabel2.Location = new System.Drawing.Point(282, 42);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(69, 25);
            this.bunifuLabel2.TabIndex = 28;
            this.bunifuLabel2.Text = "Monday";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bunifuLabel3.Location = new System.Drawing.Point(444, 42);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(69, 25);
            this.bunifuLabel3.TabIndex = 29;
            this.bunifuLabel3.Text = "Tuesday";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel3.Click += new System.EventHandler(this.bunifuLabel3_Click);
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bunifuLabel4.Location = new System.Drawing.Point(944, 42);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(51, 25);
            this.bunifuLabel4.TabIndex = 32;
            this.bunifuLabel4.Text = "Friday";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bunifuLabel5.Location = new System.Drawing.Point(767, 42);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(77, 25);
            this.bunifuLabel5.TabIndex = 31;
            this.bunifuLabel5.Text = "Thursday";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bunifuLabel6.Location = new System.Drawing.Point(593, 42);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(98, 25);
            this.bunifuLabel6.TabIndex = 30;
            this.bunifuLabel6.Text = "Wednesday";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AllowParentOverrides = false;
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.CursorType = null;
            this.bunifuLabel7.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bunifuLabel7.Location = new System.Drawing.Point(1093, 42);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(74, 25);
            this.bunifuLabel7.TabIndex = 33;
            this.bunifuLabel7.Text = "Saturday";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BTPrevious
            // 
            this.BTPrevious.AllowAnimations = true;
            this.BTPrevious.AllowMouseEffects = true;
            this.BTPrevious.AllowToggling = false;
            this.BTPrevious.AnimationSpeed = 200;
            this.BTPrevious.AutoGenerateColors = false;
            this.BTPrevious.AutoRoundBorders = false;
            this.BTPrevious.AutoSizeLeftIcon = true;
            this.BTPrevious.AutoSizeRightIcon = true;
            this.BTPrevious.BackColor = System.Drawing.Color.Transparent;
            this.BTPrevious.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTPrevious.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTPrevious.BackgroundImage")));
            this.BTPrevious.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTPrevious.ButtonText = "Previous";
            this.BTPrevious.ButtonTextMarginLeft = 0;
            this.BTPrevious.ColorContrastOnClick = 45;
            this.BTPrevious.ColorContrastOnHover = 45;
            this.BTPrevious.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.BTPrevious.CustomizableEdges = borderEdges6;
            this.BTPrevious.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTPrevious.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BTPrevious.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BTPrevious.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BTPrevious.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BTPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTPrevious.ForeColor = System.Drawing.Color.White;
            this.BTPrevious.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTPrevious.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BTPrevious.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BTPrevious.IconMarginLeft = 11;
            this.BTPrevious.IconPadding = 10;
            this.BTPrevious.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTPrevious.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BTPrevious.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BTPrevious.IconSize = 25;
            this.BTPrevious.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.BTPrevious.IdleBorderRadius = 10;
            this.BTPrevious.IdleBorderThickness = 1;
            this.BTPrevious.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTPrevious.IdleIconLeftImage = null;
            this.BTPrevious.IdleIconRightImage = null;
            this.BTPrevious.IndicateFocus = false;
            this.BTPrevious.Location = new System.Drawing.Point(962, 667);
            this.BTPrevious.Name = "BTPrevious";
            this.BTPrevious.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BTPrevious.OnDisabledState.BorderRadius = 10;
            this.BTPrevious.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTPrevious.OnDisabledState.BorderThickness = 1;
            this.BTPrevious.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BTPrevious.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BTPrevious.OnDisabledState.IconLeftImage = null;
            this.BTPrevious.OnDisabledState.IconRightImage = null;
            this.BTPrevious.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BTPrevious.onHoverState.BorderRadius = 10;
            this.BTPrevious.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTPrevious.onHoverState.BorderThickness = 1;
            this.BTPrevious.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BTPrevious.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BTPrevious.onHoverState.IconLeftImage = null;
            this.BTPrevious.onHoverState.IconRightImage = null;
            this.BTPrevious.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BTPrevious.OnIdleState.BorderRadius = 10;
            this.BTPrevious.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTPrevious.OnIdleState.BorderThickness = 1;
            this.BTPrevious.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTPrevious.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BTPrevious.OnIdleState.IconLeftImage = null;
            this.BTPrevious.OnIdleState.IconRightImage = null;
            this.BTPrevious.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTPrevious.OnPressedState.BorderRadius = 10;
            this.BTPrevious.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTPrevious.OnPressedState.BorderThickness = 1;
            this.BTPrevious.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTPrevious.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BTPrevious.OnPressedState.IconLeftImage = null;
            this.BTPrevious.OnPressedState.IconRightImage = null;
            this.BTPrevious.Size = new System.Drawing.Size(125, 28);
            this.BTPrevious.TabIndex = 26;
            this.BTPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTPrevious.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTPrevious.TextMarginLeft = 0;
            this.BTPrevious.TextPadding = new System.Windows.Forms.Padding(0);
            this.BTPrevious.UseDefaultRadiusAndThickness = true;
            this.BTPrevious.Click += new System.EventHandler(this.BTPrevious_Click);
            // 
            // BTnext
            // 
            this.BTnext.AllowAnimations = true;
            this.BTnext.AllowMouseEffects = true;
            this.BTnext.AllowToggling = false;
            this.BTnext.AnimationSpeed = 200;
            this.BTnext.AutoGenerateColors = false;
            this.BTnext.AutoRoundBorders = false;
            this.BTnext.AutoSizeLeftIcon = true;
            this.BTnext.AutoSizeRightIcon = true;
            this.BTnext.BackColor = System.Drawing.Color.Transparent;
            this.BTnext.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTnext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTnext.BackgroundImage")));
            this.BTnext.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTnext.ButtonText = "Next";
            this.BTnext.ButtonTextMarginLeft = 0;
            this.BTnext.ColorContrastOnClick = 45;
            this.BTnext.ColorContrastOnHover = 45;
            this.BTnext.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.BTnext.CustomizableEdges = borderEdges7;
            this.BTnext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTnext.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BTnext.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BTnext.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BTnext.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BTnext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTnext.ForeColor = System.Drawing.Color.White;
            this.BTnext.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTnext.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BTnext.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BTnext.IconMarginLeft = 11;
            this.BTnext.IconPadding = 10;
            this.BTnext.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTnext.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BTnext.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BTnext.IconSize = 25;
            this.BTnext.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.BTnext.IdleBorderRadius = 10;
            this.BTnext.IdleBorderThickness = 1;
            this.BTnext.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTnext.IdleIconLeftImage = null;
            this.BTnext.IdleIconRightImage = null;
            this.BTnext.IndicateFocus = false;
            this.BTnext.Location = new System.Drawing.Point(1093, 667);
            this.BTnext.Name = "BTnext";
            this.BTnext.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BTnext.OnDisabledState.BorderRadius = 10;
            this.BTnext.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTnext.OnDisabledState.BorderThickness = 1;
            this.BTnext.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BTnext.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BTnext.OnDisabledState.IconLeftImage = null;
            this.BTnext.OnDisabledState.IconRightImage = null;
            this.BTnext.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BTnext.onHoverState.BorderRadius = 10;
            this.BTnext.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTnext.onHoverState.BorderThickness = 1;
            this.BTnext.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BTnext.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BTnext.onHoverState.IconLeftImage = null;
            this.BTnext.onHoverState.IconRightImage = null;
            this.BTnext.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BTnext.OnIdleState.BorderRadius = 10;
            this.BTnext.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTnext.OnIdleState.BorderThickness = 1;
            this.BTnext.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTnext.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BTnext.OnIdleState.IconLeftImage = null;
            this.BTnext.OnIdleState.IconRightImage = null;
            this.BTnext.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTnext.OnPressedState.BorderRadius = 10;
            this.BTnext.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTnext.OnPressedState.BorderThickness = 1;
            this.BTnext.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTnext.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BTnext.OnPressedState.IconLeftImage = null;
            this.BTnext.OnPressedState.IconRightImage = null;
            this.BTnext.Size = new System.Drawing.Size(125, 28);
            this.BTnext.TabIndex = 25;
            this.BTnext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTnext.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTnext.TextMarginLeft = 0;
            this.BTnext.TextPadding = new System.Windows.Forms.Padding(0);
            this.BTnext.UseDefaultRadiusAndThickness = true;
            this.BTnext.Click += new System.EventHandler(this.BTnext_Click);
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(14, 21);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(29, 21);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            // 
            // homeBt
            // 
            this.homeBt.AllowAnimations = true;
            this.homeBt.AllowMouseEffects = true;
            this.homeBt.AllowToggling = false;
            this.homeBt.AnimationSpeed = 200;
            this.homeBt.AutoGenerateColors = false;
            this.homeBt.AutoRoundBorders = false;
            this.homeBt.AutoSizeLeftIcon = true;
            this.homeBt.AutoSizeRightIcon = true;
            this.homeBt.BackColor = System.Drawing.Color.Transparent;
            this.homeBt.BackColor1 = System.Drawing.Color.Transparent;
            this.homeBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeBt.BackgroundImage")));
            this.homeBt.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.homeBt.ButtonText = "               Home";
            this.homeBt.ButtonTextMarginLeft = 0;
            this.homeBt.ColorContrastOnClick = 45;
            this.homeBt.ColorContrastOnHover = 45;
            this.homeBt.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.homeBt.CustomizableEdges = borderEdges8;
            this.homeBt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.homeBt.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.homeBt.DisabledFillColor = System.Drawing.Color.Transparent;
            this.homeBt.DisabledForecolor = System.Drawing.Color.Transparent;
            this.homeBt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.homeBt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBt.ForeColor = System.Drawing.Color.Transparent;
            this.homeBt.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.homeBt.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.homeBt.IconMarginLeft = 11;
            this.homeBt.IconPadding = 10;
            this.homeBt.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeBt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.homeBt.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.homeBt.IconSize = 25;
            this.homeBt.IdleBorderColor = System.Drawing.Color.Transparent;
            this.homeBt.IdleBorderRadius = 1;
            this.homeBt.IdleBorderThickness = 1;
            this.homeBt.IdleFillColor = System.Drawing.Color.Transparent;
            this.homeBt.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("homeBt.IdleIconLeftImage")));
            this.homeBt.IdleIconRightImage = null;
            this.homeBt.IndicateFocus = false;
            this.homeBt.Location = new System.Drawing.Point(0, 0);
            this.homeBt.Name = "homeBt";
            this.homeBt.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.homeBt.OnDisabledState.BorderRadius = 1;
            this.homeBt.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.homeBt.OnDisabledState.BorderThickness = 1;
            this.homeBt.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.homeBt.OnDisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.homeBt.OnDisabledState.IconLeftImage = null;
            this.homeBt.OnDisabledState.IconRightImage = null;
            this.homeBt.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.homeBt.onHoverState.BorderRadius = 1;
            this.homeBt.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.homeBt.onHoverState.BorderThickness = 1;
            this.homeBt.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.homeBt.onHoverState.ForeColor = System.Drawing.Color.Transparent;
            this.homeBt.onHoverState.IconLeftImage = null;
            this.homeBt.onHoverState.IconRightImage = null;
            this.homeBt.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.homeBt.OnIdleState.BorderRadius = 1;
            this.homeBt.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.homeBt.OnIdleState.BorderThickness = 1;
            this.homeBt.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.homeBt.OnIdleState.ForeColor = System.Drawing.Color.Transparent;
            this.homeBt.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("homeBt.OnIdleState.IconLeftImage")));
            this.homeBt.OnIdleState.IconRightImage = null;
            this.homeBt.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.homeBt.OnPressedState.BorderRadius = 1;
            this.homeBt.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.homeBt.OnPressedState.BorderThickness = 1;
            this.homeBt.OnPressedState.FillColor = System.Drawing.Color.AliceBlue;
            this.homeBt.OnPressedState.ForeColor = System.Drawing.Color.Transparent;
            this.homeBt.OnPressedState.IconLeftImage = null;
            this.homeBt.OnPressedState.IconRightImage = null;
            this.homeBt.Size = new System.Drawing.Size(219, 49);
            this.homeBt.TabIndex = 19;
            this.homeBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.homeBt.TextMarginLeft = 0;
            this.homeBt.TextPadding = new System.Windows.Forms.Padding(0);
            this.homeBt.UseDefaultRadiusAndThickness = true;
            this.homeBt.Click += new System.EventHandler(this.homeBt_Click);
            // 
            // loginBt
            // 
            this.loginBt.AllowAnimations = true;
            this.loginBt.AllowMouseEffects = true;
            this.loginBt.AllowToggling = false;
            this.loginBt.AnimationSpeed = 200;
            this.loginBt.AutoGenerateColors = false;
            this.loginBt.AutoRoundBorders = false;
            this.loginBt.AutoSizeLeftIcon = true;
            this.loginBt.AutoSizeRightIcon = true;
            this.loginBt.BackColor = System.Drawing.Color.Transparent;
            this.loginBt.BackColor1 = System.Drawing.Color.Transparent;
            this.loginBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBt.BackgroundImage")));
            this.loginBt.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBt.ButtonText = "               Login";
            this.loginBt.ButtonTextMarginLeft = 0;
            this.loginBt.ColorContrastOnClick = 45;
            this.loginBt.ColorContrastOnHover = 45;
            this.loginBt.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            this.loginBt.CustomizableEdges = borderEdges9;
            this.loginBt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginBt.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.loginBt.DisabledFillColor = System.Drawing.Color.Transparent;
            this.loginBt.DisabledForecolor = System.Drawing.Color.Transparent;
            this.loginBt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.loginBt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBt.ForeColor = System.Drawing.Color.Transparent;
            this.loginBt.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginBt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.loginBt.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.loginBt.IconMarginLeft = 11;
            this.loginBt.IconPadding = 10;
            this.loginBt.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginBt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.loginBt.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.loginBt.IconSize = 25;
            this.loginBt.IdleBorderColor = System.Drawing.Color.Transparent;
            this.loginBt.IdleBorderRadius = 1;
            this.loginBt.IdleBorderThickness = 1;
            this.loginBt.IdleFillColor = System.Drawing.Color.Transparent;
            this.loginBt.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("loginBt.IdleIconLeftImage")));
            this.loginBt.IdleIconRightImage = null;
            this.loginBt.IndicateFocus = false;
            this.loginBt.Location = new System.Drawing.Point(0, 0);
            this.loginBt.Name = "loginBt";
            this.loginBt.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.loginBt.OnDisabledState.BorderRadius = 1;
            this.loginBt.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBt.OnDisabledState.BorderThickness = 1;
            this.loginBt.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.loginBt.OnDisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.loginBt.OnDisabledState.IconLeftImage = null;
            this.loginBt.OnDisabledState.IconRightImage = null;
            this.loginBt.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.loginBt.onHoverState.BorderRadius = 1;
            this.loginBt.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBt.onHoverState.BorderThickness = 1;
            this.loginBt.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.loginBt.onHoverState.ForeColor = System.Drawing.Color.Transparent;
            this.loginBt.onHoverState.IconLeftImage = null;
            this.loginBt.onHoverState.IconRightImage = null;
            this.loginBt.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.loginBt.OnIdleState.BorderRadius = 1;
            this.loginBt.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBt.OnIdleState.BorderThickness = 1;
            this.loginBt.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.loginBt.OnIdleState.ForeColor = System.Drawing.Color.Transparent;
            this.loginBt.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("loginBt.OnIdleState.IconLeftImage")));
            this.loginBt.OnIdleState.IconRightImage = null;
            this.loginBt.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.loginBt.OnPressedState.BorderRadius = 1;
            this.loginBt.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBt.OnPressedState.BorderThickness = 1;
            this.loginBt.OnPressedState.FillColor = System.Drawing.Color.AliceBlue;
            this.loginBt.OnPressedState.ForeColor = System.Drawing.Color.Transparent;
            this.loginBt.OnPressedState.IconLeftImage = null;
            this.loginBt.OnPressedState.IconRightImage = null;
            this.loginBt.Size = new System.Drawing.Size(219, 48);
            this.loginBt.TabIndex = 20;
            this.loginBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginBt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginBt.TextMarginLeft = 0;
            this.loginBt.TextPadding = new System.Windows.Forms.Padding(0);
            this.loginBt.UseDefaultRadiusAndThickness = true;
            this.loginBt.Click += new System.EventHandler(this.loginBt_Click);
            // 
            // BtAppointment
            // 
            this.BtAppointment.AllowAnimations = true;
            this.BtAppointment.AllowMouseEffects = true;
            this.BtAppointment.AllowToggling = false;
            this.BtAppointment.AnimationSpeed = 200;
            this.BtAppointment.AutoGenerateColors = false;
            this.BtAppointment.AutoRoundBorders = false;
            this.BtAppointment.AutoSizeLeftIcon = true;
            this.BtAppointment.AutoSizeRightIcon = true;
            this.BtAppointment.BackColor = System.Drawing.Color.Transparent;
            this.BtAppointment.BackColor1 = System.Drawing.Color.Transparent;
            this.BtAppointment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtAppointment.BackgroundImage")));
            this.BtAppointment.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtAppointment.ButtonText = "               Appointment Form";
            this.BtAppointment.ButtonTextMarginLeft = 0;
            this.BtAppointment.ColorContrastOnClick = 45;
            this.BtAppointment.ColorContrastOnHover = 45;
            this.BtAppointment.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.BtAppointment.CustomizableEdges = borderEdges10;
            this.BtAppointment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtAppointment.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.BtAppointment.DisabledFillColor = System.Drawing.Color.Transparent;
            this.BtAppointment.DisabledForecolor = System.Drawing.Color.Transparent;
            this.BtAppointment.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.BtAppointment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAppointment.ForeColor = System.Drawing.Color.Transparent;
            this.BtAppointment.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAppointment.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtAppointment.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtAppointment.IconMarginLeft = 11;
            this.BtAppointment.IconPadding = 10;
            this.BtAppointment.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtAppointment.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtAppointment.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtAppointment.IconSize = 25;
            this.BtAppointment.IdleBorderColor = System.Drawing.Color.Transparent;
            this.BtAppointment.IdleBorderRadius = 1;
            this.BtAppointment.IdleBorderThickness = 1;
            this.BtAppointment.IdleFillColor = System.Drawing.Color.Transparent;
            this.BtAppointment.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("BtAppointment.IdleIconLeftImage")));
            this.BtAppointment.IdleIconRightImage = null;
            this.BtAppointment.IndicateFocus = false;
            this.BtAppointment.Location = new System.Drawing.Point(0, 0);
            this.BtAppointment.Name = "BtAppointment";
            this.BtAppointment.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.BtAppointment.OnDisabledState.BorderRadius = 1;
            this.BtAppointment.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtAppointment.OnDisabledState.BorderThickness = 1;
            this.BtAppointment.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.BtAppointment.OnDisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.BtAppointment.OnDisabledState.IconLeftImage = null;
            this.BtAppointment.OnDisabledState.IconRightImage = null;
            this.BtAppointment.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.BtAppointment.onHoverState.BorderRadius = 1;
            this.BtAppointment.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtAppointment.onHoverState.BorderThickness = 1;
            this.BtAppointment.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.BtAppointment.onHoverState.ForeColor = System.Drawing.Color.Transparent;
            this.BtAppointment.onHoverState.IconLeftImage = null;
            this.BtAppointment.onHoverState.IconRightImage = null;
            this.BtAppointment.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.BtAppointment.OnIdleState.BorderRadius = 1;
            this.BtAppointment.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtAppointment.OnIdleState.BorderThickness = 1;
            this.BtAppointment.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.BtAppointment.OnIdleState.ForeColor = System.Drawing.Color.Transparent;
            this.BtAppointment.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("BtAppointment.OnIdleState.IconLeftImage")));
            this.BtAppointment.OnIdleState.IconRightImage = null;
            this.BtAppointment.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.BtAppointment.OnPressedState.BorderRadius = 1;
            this.BtAppointment.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtAppointment.OnPressedState.BorderThickness = 1;
            this.BtAppointment.OnPressedState.FillColor = System.Drawing.Color.AliceBlue;
            this.BtAppointment.OnPressedState.ForeColor = System.Drawing.Color.Transparent;
            this.BtAppointment.OnPressedState.IconLeftImage = null;
            this.BtAppointment.OnPressedState.IconRightImage = null;
            this.BtAppointment.Size = new System.Drawing.Size(219, 49);
            this.BtAppointment.TabIndex = 19;
            this.BtAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAppointment.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtAppointment.TextMarginLeft = 0;
            this.BtAppointment.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtAppointment.UseDefaultRadiusAndThickness = true;
            // 
            // lbMonthyr
            // 
            this.lbMonthyr.AllowParentOverrides = false;
            this.lbMonthyr.AutoEllipsis = false;
            this.lbMonthyr.AutoSize = false;
            this.lbMonthyr.CursorType = null;
            this.lbMonthyr.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbMonthyr.Location = new System.Drawing.Point(444, 11);
            this.lbMonthyr.Name = "lbMonthyr";
            this.lbMonthyr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbMonthyr.Size = new System.Drawing.Size(405, 25);
            this.lbMonthyr.TabIndex = 34;
            this.lbMonthyr.Text = "MONTH YEAR";
            this.lbMonthyr.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lbMonthyr.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Form_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1230, 703);
            this.Controls.Add(this.lbMonthyr);
            this.Controls.Add(this.bunifuLabel7);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.bunifuLabel6);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.BTPrevious);
            this.Controls.Add(this.BTnext);
            this.Controls.Add(this.dayContainer);
            this.Controls.Add(this.SidebarMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Appointment";
            this.Text = "Form_Appointment";
            this.Load += new System.EventHandler(this.Form_Appointment_Load);
            this.SidebarMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SidebarMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton homeBt;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton loginBt;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtAppointment;
        private System.Windows.Forms.Timer SidebarT;
        private System.Windows.Forms.FlowLayoutPanel dayContainer;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BTnext;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BTPrevious;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private Bunifu.UI.WinForms.BunifuLabel lbMonthyr;
    }
}