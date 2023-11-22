namespace DentalAppointment.Forms
{
    partial class Form_Dentist_Appointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dentist_Appointments));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.SidebarMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btDashboard = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btAppointments = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btLogout = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SidebarT = new System.Windows.Forms.Timer(this.components);
            this.SidebarMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidebarMenu
            // 
            this.SidebarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SidebarMenu.Controls.Add(this.panel1);
            this.SidebarMenu.Controls.Add(this.panel3);
            this.SidebarMenu.Controls.Add(this.panel2);
            this.SidebarMenu.Controls.Add(this.panel4);
            this.SidebarMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarMenu.Location = new System.Drawing.Point(0, 0);
            this.SidebarMenu.MaximumSize = new System.Drawing.Size(222, 703);
            this.SidebarMenu.MinimumSize = new System.Drawing.Size(65, 703);
            this.SidebarMenu.Name = "SidebarMenu";
            this.SidebarMenu.Size = new System.Drawing.Size(65, 703);
            this.SidebarMenu.TabIndex = 2;
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
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btDashboard);
            this.panel3.Location = new System.Drawing.Point(3, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 48);
            this.panel3.TabIndex = 4;
            // 
            // btDashboard
            // 
            this.btDashboard.AllowAnimations = true;
            this.btDashboard.AllowMouseEffects = true;
            this.btDashboard.AllowToggling = false;
            this.btDashboard.AnimationSpeed = 200;
            this.btDashboard.AutoGenerateColors = false;
            this.btDashboard.AutoRoundBorders = false;
            this.btDashboard.AutoSizeLeftIcon = true;
            this.btDashboard.AutoSizeRightIcon = true;
            this.btDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btDashboard.BackColor1 = System.Drawing.Color.Transparent;
            this.btDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDashboard.BackgroundImage")));
            this.btDashboard.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btDashboard.ButtonText = "               Dashboard";
            this.btDashboard.ButtonTextMarginLeft = 0;
            this.btDashboard.ColorContrastOnClick = 45;
            this.btDashboard.ColorContrastOnHover = 45;
            this.btDashboard.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btDashboard.CustomizableEdges = borderEdges1;
            this.btDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btDashboard.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btDashboard.DisabledFillColor = System.Drawing.Color.Transparent;
            this.btDashboard.DisabledForecolor = System.Drawing.Color.Transparent;
            this.btDashboard.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.btDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDashboard.ForeColor = System.Drawing.Color.Transparent;
            this.btDashboard.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDashboard.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btDashboard.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btDashboard.IconMarginLeft = 11;
            this.btDashboard.IconPadding = 10;
            this.btDashboard.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDashboard.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btDashboard.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btDashboard.IconSize = 25;
            this.btDashboard.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btDashboard.IdleBorderRadius = 1;
            this.btDashboard.IdleBorderThickness = 1;
            this.btDashboard.IdleFillColor = System.Drawing.Color.Transparent;
            this.btDashboard.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btDashboard.IdleIconLeftImage")));
            this.btDashboard.IdleIconRightImage = null;
            this.btDashboard.IndicateFocus = false;
            this.btDashboard.Location = new System.Drawing.Point(0, 0);
            this.btDashboard.Name = "btDashboard";
            this.btDashboard.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btDashboard.OnDisabledState.BorderRadius = 1;
            this.btDashboard.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btDashboard.OnDisabledState.BorderThickness = 1;
            this.btDashboard.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btDashboard.OnDisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.btDashboard.OnDisabledState.IconLeftImage = null;
            this.btDashboard.OnDisabledState.IconRightImage = null;
            this.btDashboard.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btDashboard.onHoverState.BorderRadius = 1;
            this.btDashboard.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btDashboard.onHoverState.BorderThickness = 1;
            this.btDashboard.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btDashboard.onHoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btDashboard.onHoverState.IconLeftImage = null;
            this.btDashboard.onHoverState.IconRightImage = null;
            this.btDashboard.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btDashboard.OnIdleState.BorderRadius = 1;
            this.btDashboard.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btDashboard.OnIdleState.BorderThickness = 1;
            this.btDashboard.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btDashboard.OnIdleState.ForeColor = System.Drawing.Color.Transparent;
            this.btDashboard.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btDashboard.OnIdleState.IconLeftImage")));
            this.btDashboard.OnIdleState.IconRightImage = null;
            this.btDashboard.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btDashboard.OnPressedState.BorderRadius = 1;
            this.btDashboard.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btDashboard.OnPressedState.BorderThickness = 1;
            this.btDashboard.OnPressedState.FillColor = System.Drawing.Color.AliceBlue;
            this.btDashboard.OnPressedState.ForeColor = System.Drawing.Color.Transparent;
            this.btDashboard.OnPressedState.IconLeftImage = null;
            this.btDashboard.OnPressedState.IconRightImage = null;
            this.btDashboard.Size = new System.Drawing.Size(219, 49);
            this.btDashboard.TabIndex = 1;
            this.btDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDashboard.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btDashboard.TextMarginLeft = 0;
            this.btDashboard.TextPadding = new System.Windows.Forms.Padding(0);
            this.btDashboard.UseDefaultRadiusAndThickness = true;
            this.btDashboard.Click += new System.EventHandler(this.btDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btAppointments);
            this.panel2.Location = new System.Drawing.Point(3, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 48);
            this.panel2.TabIndex = 3;
            // 
            // btAppointments
            // 
            this.btAppointments.AllowAnimations = true;
            this.btAppointments.AllowMouseEffects = true;
            this.btAppointments.AllowToggling = false;
            this.btAppointments.AnimationSpeed = 200;
            this.btAppointments.AutoGenerateColors = false;
            this.btAppointments.AutoRoundBorders = false;
            this.btAppointments.AutoSizeLeftIcon = true;
            this.btAppointments.AutoSizeRightIcon = true;
            this.btAppointments.BackColor = System.Drawing.Color.Transparent;
            this.btAppointments.BackColor1 = System.Drawing.Color.Transparent;
            this.btAppointments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAppointments.BackgroundImage")));
            this.btAppointments.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btAppointments.ButtonText = "               Appointments";
            this.btAppointments.ButtonTextMarginLeft = 0;
            this.btAppointments.ColorContrastOnClick = 45;
            this.btAppointments.ColorContrastOnHover = 45;
            this.btAppointments.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btAppointments.CustomizableEdges = borderEdges2;
            this.btAppointments.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btAppointments.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btAppointments.DisabledFillColor = System.Drawing.Color.Transparent;
            this.btAppointments.DisabledForecolor = System.Drawing.Color.Transparent;
            this.btAppointments.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.btAppointments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAppointments.ForeColor = System.Drawing.Color.Transparent;
            this.btAppointments.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAppointments.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btAppointments.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btAppointments.IconMarginLeft = 11;
            this.btAppointments.IconPadding = 10;
            this.btAppointments.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAppointments.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btAppointments.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btAppointments.IconSize = 25;
            this.btAppointments.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btAppointments.IdleBorderRadius = 1;
            this.btAppointments.IdleBorderThickness = 1;
            this.btAppointments.IdleFillColor = System.Drawing.Color.Transparent;
            this.btAppointments.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btAppointments.IdleIconLeftImage")));
            this.btAppointments.IdleIconRightImage = null;
            this.btAppointments.IndicateFocus = false;
            this.btAppointments.Location = new System.Drawing.Point(0, 0);
            this.btAppointments.Name = "btAppointments";
            this.btAppointments.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btAppointments.OnDisabledState.BorderRadius = 1;
            this.btAppointments.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btAppointments.OnDisabledState.BorderThickness = 1;
            this.btAppointments.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btAppointments.OnDisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.btAppointments.OnDisabledState.IconLeftImage = null;
            this.btAppointments.OnDisabledState.IconRightImage = null;
            this.btAppointments.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btAppointments.onHoverState.BorderRadius = 1;
            this.btAppointments.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btAppointments.onHoverState.BorderThickness = 1;
            this.btAppointments.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btAppointments.onHoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btAppointments.onHoverState.IconLeftImage = null;
            this.btAppointments.onHoverState.IconRightImage = null;
            this.btAppointments.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btAppointments.OnIdleState.BorderRadius = 1;
            this.btAppointments.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btAppointments.OnIdleState.BorderThickness = 1;
            this.btAppointments.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btAppointments.OnIdleState.ForeColor = System.Drawing.Color.Transparent;
            this.btAppointments.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btAppointments.OnIdleState.IconLeftImage")));
            this.btAppointments.OnIdleState.IconRightImage = null;
            this.btAppointments.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btAppointments.OnPressedState.BorderRadius = 1;
            this.btAppointments.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btAppointments.OnPressedState.BorderThickness = 1;
            this.btAppointments.OnPressedState.FillColor = System.Drawing.Color.AliceBlue;
            this.btAppointments.OnPressedState.ForeColor = System.Drawing.Color.Transparent;
            this.btAppointments.OnPressedState.IconLeftImage = null;
            this.btAppointments.OnPressedState.IconRightImage = null;
            this.btAppointments.Size = new System.Drawing.Size(219, 48);
            this.btAppointments.TabIndex = 4;
            this.btAppointments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAppointments.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btAppointments.TextMarginLeft = 0;
            this.btAppointments.TextPadding = new System.Windows.Forms.Padding(0);
            this.btAppointments.UseDefaultRadiusAndThickness = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btLogout);
            this.panel4.Location = new System.Drawing.Point(3, 188);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(219, 48);
            this.panel4.TabIndex = 5;
            // 
            // btLogout
            // 
            this.btLogout.AllowAnimations = true;
            this.btLogout.AllowMouseEffects = true;
            this.btLogout.AllowToggling = false;
            this.btLogout.AnimationSpeed = 200;
            this.btLogout.AutoGenerateColors = false;
            this.btLogout.AutoRoundBorders = false;
            this.btLogout.AutoSizeLeftIcon = true;
            this.btLogout.AutoSizeRightIcon = true;
            this.btLogout.BackColor = System.Drawing.Color.Transparent;
            this.btLogout.BackColor1 = System.Drawing.Color.Transparent;
            this.btLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btLogout.BackgroundImage")));
            this.btLogout.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btLogout.ButtonText = "               Logout";
            this.btLogout.ButtonTextMarginLeft = 0;
            this.btLogout.ColorContrastOnClick = 45;
            this.btLogout.ColorContrastOnHover = 45;
            this.btLogout.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btLogout.CustomizableEdges = borderEdges3;
            this.btLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btLogout.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btLogout.DisabledFillColor = System.Drawing.Color.Transparent;
            this.btLogout.DisabledForecolor = System.Drawing.Color.Transparent;
            this.btLogout.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.btLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.Color.Transparent;
            this.btLogout.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogout.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btLogout.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btLogout.IconMarginLeft = 11;
            this.btLogout.IconPadding = 10;
            this.btLogout.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLogout.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btLogout.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btLogout.IconSize = 25;
            this.btLogout.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btLogout.IdleBorderRadius = 1;
            this.btLogout.IdleBorderThickness = 1;
            this.btLogout.IdleFillColor = System.Drawing.Color.Transparent;
            this.btLogout.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btLogout.IdleIconLeftImage")));
            this.btLogout.IdleIconRightImage = null;
            this.btLogout.IndicateFocus = false;
            this.btLogout.Location = new System.Drawing.Point(0, 0);
            this.btLogout.Name = "btLogout";
            this.btLogout.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btLogout.OnDisabledState.BorderRadius = 1;
            this.btLogout.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btLogout.OnDisabledState.BorderThickness = 1;
            this.btLogout.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btLogout.OnDisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.btLogout.OnDisabledState.IconLeftImage = null;
            this.btLogout.OnDisabledState.IconRightImage = null;
            this.btLogout.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btLogout.onHoverState.BorderRadius = 1;
            this.btLogout.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btLogout.onHoverState.BorderThickness = 1;
            this.btLogout.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btLogout.onHoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btLogout.onHoverState.IconLeftImage = null;
            this.btLogout.onHoverState.IconRightImage = null;
            this.btLogout.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btLogout.OnIdleState.BorderRadius = 1;
            this.btLogout.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btLogout.OnIdleState.BorderThickness = 1;
            this.btLogout.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btLogout.OnIdleState.ForeColor = System.Drawing.Color.Transparent;
            this.btLogout.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btLogout.OnIdleState.IconLeftImage")));
            this.btLogout.OnIdleState.IconRightImage = null;
            this.btLogout.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btLogout.OnPressedState.BorderRadius = 1;
            this.btLogout.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btLogout.OnPressedState.BorderThickness = 1;
            this.btLogout.OnPressedState.FillColor = System.Drawing.Color.AliceBlue;
            this.btLogout.OnPressedState.ForeColor = System.Drawing.Color.Transparent;
            this.btLogout.OnPressedState.IconLeftImage = null;
            this.btLogout.OnPressedState.IconRightImage = null;
            this.btLogout.Size = new System.Drawing.Size(219, 48);
            this.btLogout.TabIndex = 4;
            this.btLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogout.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btLogout.TextMarginLeft = 0;
            this.btLogout.TextPadding = new System.Windows.Forms.Padding(0);
            this.btLogout.UseDefaultRadiusAndThickness = true;
            // 
            // SidebarT
            // 
            this.SidebarT.Interval = 1;
            this.SidebarT.Tick += new System.EventHandler(this.appointmentsT);
            // 
            // Form_Dentist_Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1230, 703);
            this.Controls.Add(this.SidebarMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Dentist_Appointments";
            this.Text = "Dentist Appointments";
            this.SidebarMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SidebarMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btDashboard;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btAppointments;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btLogout;
        private System.Windows.Forms.Timer SidebarT;
    }
}