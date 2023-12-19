namespace DentalAppointment.Forms
{
    partial class Form_Dentist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dentist));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
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
            this.dvg_Appointments = new System.Windows.Forms.DataGridView();
            this.BTaccept = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BTdecline = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BTcomplete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SidebarMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Appointments)).BeginInit();
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
            this.SidebarMenu.TabIndex = 1;
            this.SidebarMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.SidebarMenu_Paint);
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
            this.btAppointments.Click += new System.EventHandler(this.btAppointments_Click);
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
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // SidebarT
            // 
            this.SidebarT.Interval = 1;
            this.SidebarT.Tick += new System.EventHandler(this.dentistT);
            // 
            // dvg_Appointments
            // 
            this.dvg_Appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_Appointments.Location = new System.Drawing.Point(386, 24);
            this.dvg_Appointments.Name = "dvg_Appointments";
            this.dvg_Appointments.Size = new System.Drawing.Size(832, 660);
            this.dvg_Appointments.TabIndex = 2;
            this.dvg_Appointments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_Appointments_CellClick_1);
            this.dvg_Appointments.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvg_Appointments_DataBindingComplete);
            // 
            // BTaccept
            // 
            this.BTaccept.AllowAnimations = true;
            this.BTaccept.AllowMouseEffects = true;
            this.BTaccept.AllowToggling = false;
            this.BTaccept.AnimationSpeed = 200;
            this.BTaccept.AutoGenerateColors = false;
            this.BTaccept.AutoRoundBorders = false;
            this.BTaccept.AutoSizeLeftIcon = true;
            this.BTaccept.AutoSizeRightIcon = true;
            this.BTaccept.BackColor = System.Drawing.Color.Transparent;
            this.BTaccept.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTaccept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTaccept.BackgroundImage")));
            this.BTaccept.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTaccept.ButtonText = "Accept";
            this.BTaccept.ButtonTextMarginLeft = 0;
            this.BTaccept.ColorContrastOnClick = 45;
            this.BTaccept.ColorContrastOnHover = 45;
            this.BTaccept.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.BTaccept.CustomizableEdges = borderEdges4;
            this.BTaccept.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTaccept.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BTaccept.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BTaccept.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BTaccept.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BTaccept.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTaccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTaccept.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTaccept.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BTaccept.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BTaccept.IconMarginLeft = 11;
            this.BTaccept.IconPadding = 10;
            this.BTaccept.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTaccept.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BTaccept.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BTaccept.IconSize = 25;
            this.BTaccept.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTaccept.IdleBorderRadius = 40;
            this.BTaccept.IdleBorderThickness = 1;
            this.BTaccept.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTaccept.IdleIconLeftImage = null;
            this.BTaccept.IdleIconRightImage = null;
            this.BTaccept.IndicateFocus = false;
            this.BTaccept.Location = new System.Drawing.Point(101, 73);
            this.BTaccept.Name = "BTaccept";
            this.BTaccept.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BTaccept.OnDisabledState.BorderRadius = 40;
            this.BTaccept.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTaccept.OnDisabledState.BorderThickness = 1;
            this.BTaccept.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BTaccept.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BTaccept.OnDisabledState.IconLeftImage = null;
            this.BTaccept.OnDisabledState.IconRightImage = null;
            this.BTaccept.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BTaccept.onHoverState.BorderRadius = 40;
            this.BTaccept.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTaccept.onHoverState.BorderThickness = 1;
            this.BTaccept.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BTaccept.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BTaccept.onHoverState.IconLeftImage = null;
            this.BTaccept.onHoverState.IconRightImage = null;
            this.BTaccept.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTaccept.OnIdleState.BorderRadius = 40;
            this.BTaccept.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTaccept.OnIdleState.BorderThickness = 1;
            this.BTaccept.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTaccept.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTaccept.OnIdleState.IconLeftImage = null;
            this.BTaccept.OnIdleState.IconRightImage = null;
            this.BTaccept.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTaccept.OnPressedState.BorderRadius = 40;
            this.BTaccept.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTaccept.OnPressedState.BorderThickness = 1;
            this.BTaccept.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTaccept.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BTaccept.OnPressedState.IconLeftImage = null;
            this.BTaccept.OnPressedState.IconRightImage = null;
            this.BTaccept.Size = new System.Drawing.Size(239, 52);
            this.BTaccept.TabIndex = 10;
            this.BTaccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTaccept.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTaccept.TextMarginLeft = 0;
            this.BTaccept.TextPadding = new System.Windows.Forms.Padding(0);
            this.BTaccept.UseDefaultRadiusAndThickness = true;
            this.BTaccept.Click += new System.EventHandler(this.BTaccept_Click);
            // 
            // BTdecline
            // 
            this.BTdecline.AllowAnimations = true;
            this.BTdecline.AllowMouseEffects = true;
            this.BTdecline.AllowToggling = false;
            this.BTdecline.AnimationSpeed = 200;
            this.BTdecline.AutoGenerateColors = false;
            this.BTdecline.AutoRoundBorders = false;
            this.BTdecline.AutoSizeLeftIcon = true;
            this.BTdecline.AutoSizeRightIcon = true;
            this.BTdecline.BackColor = System.Drawing.Color.Transparent;
            this.BTdecline.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTdecline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTdecline.BackgroundImage")));
            this.BTdecline.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTdecline.ButtonText = "Decline";
            this.BTdecline.ButtonTextMarginLeft = 0;
            this.BTdecline.ColorContrastOnClick = 45;
            this.BTdecline.ColorContrastOnHover = 45;
            this.BTdecline.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.BTdecline.CustomizableEdges = borderEdges5;
            this.BTdecline.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTdecline.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BTdecline.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BTdecline.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BTdecline.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BTdecline.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTdecline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTdecline.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTdecline.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BTdecline.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BTdecline.IconMarginLeft = 11;
            this.BTdecline.IconPadding = 10;
            this.BTdecline.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTdecline.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BTdecline.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BTdecline.IconSize = 25;
            this.BTdecline.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTdecline.IdleBorderRadius = 40;
            this.BTdecline.IdleBorderThickness = 1;
            this.BTdecline.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTdecline.IdleIconLeftImage = null;
            this.BTdecline.IdleIconRightImage = null;
            this.BTdecline.IndicateFocus = false;
            this.BTdecline.Location = new System.Drawing.Point(101, 149);
            this.BTdecline.Name = "BTdecline";
            this.BTdecline.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BTdecline.OnDisabledState.BorderRadius = 40;
            this.BTdecline.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTdecline.OnDisabledState.BorderThickness = 1;
            this.BTdecline.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BTdecline.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BTdecline.OnDisabledState.IconLeftImage = null;
            this.BTdecline.OnDisabledState.IconRightImage = null;
            this.BTdecline.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BTdecline.onHoverState.BorderRadius = 40;
            this.BTdecline.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTdecline.onHoverState.BorderThickness = 1;
            this.BTdecline.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BTdecline.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BTdecline.onHoverState.IconLeftImage = null;
            this.BTdecline.onHoverState.IconRightImage = null;
            this.BTdecline.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTdecline.OnIdleState.BorderRadius = 40;
            this.BTdecline.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTdecline.OnIdleState.BorderThickness = 1;
            this.BTdecline.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTdecline.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTdecline.OnIdleState.IconLeftImage = null;
            this.BTdecline.OnIdleState.IconRightImage = null;
            this.BTdecline.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTdecline.OnPressedState.BorderRadius = 40;
            this.BTdecline.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTdecline.OnPressedState.BorderThickness = 1;
            this.BTdecline.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTdecline.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BTdecline.OnPressedState.IconLeftImage = null;
            this.BTdecline.OnPressedState.IconRightImage = null;
            this.BTdecline.Size = new System.Drawing.Size(239, 52);
            this.BTdecline.TabIndex = 11;
            this.BTdecline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTdecline.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTdecline.TextMarginLeft = 0;
            this.BTdecline.TextPadding = new System.Windows.Forms.Padding(0);
            this.BTdecline.UseDefaultRadiusAndThickness = true;
            this.BTdecline.Click += new System.EventHandler(this.BTdecline_Click);
            // 
            // BTcomplete
            // 
            this.BTcomplete.AllowAnimations = true;
            this.BTcomplete.AllowMouseEffects = true;
            this.BTcomplete.AllowToggling = false;
            this.BTcomplete.AnimationSpeed = 200;
            this.BTcomplete.AutoGenerateColors = false;
            this.BTcomplete.AutoRoundBorders = false;
            this.BTcomplete.AutoSizeLeftIcon = true;
            this.BTcomplete.AutoSizeRightIcon = true;
            this.BTcomplete.BackColor = System.Drawing.Color.Transparent;
            this.BTcomplete.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTcomplete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTcomplete.BackgroundImage")));
            this.BTcomplete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTcomplete.ButtonText = "Complete";
            this.BTcomplete.ButtonTextMarginLeft = 0;
            this.BTcomplete.ColorContrastOnClick = 45;
            this.BTcomplete.ColorContrastOnHover = 45;
            this.BTcomplete.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.BTcomplete.CustomizableEdges = borderEdges6;
            this.BTcomplete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTcomplete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BTcomplete.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BTcomplete.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BTcomplete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BTcomplete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTcomplete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTcomplete.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTcomplete.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BTcomplete.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BTcomplete.IconMarginLeft = 11;
            this.BTcomplete.IconPadding = 10;
            this.BTcomplete.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTcomplete.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BTcomplete.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BTcomplete.IconSize = 25;
            this.BTcomplete.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTcomplete.IdleBorderRadius = 40;
            this.BTcomplete.IdleBorderThickness = 1;
            this.BTcomplete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTcomplete.IdleIconLeftImage = null;
            this.BTcomplete.IdleIconRightImage = null;
            this.BTcomplete.IndicateFocus = false;
            this.BTcomplete.Location = new System.Drawing.Point(101, 225);
            this.BTcomplete.Name = "BTcomplete";
            this.BTcomplete.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BTcomplete.OnDisabledState.BorderRadius = 40;
            this.BTcomplete.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTcomplete.OnDisabledState.BorderThickness = 1;
            this.BTcomplete.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BTcomplete.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BTcomplete.OnDisabledState.IconLeftImage = null;
            this.BTcomplete.OnDisabledState.IconRightImage = null;
            this.BTcomplete.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BTcomplete.onHoverState.BorderRadius = 40;
            this.BTcomplete.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTcomplete.onHoverState.BorderThickness = 1;
            this.BTcomplete.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BTcomplete.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BTcomplete.onHoverState.IconLeftImage = null;
            this.BTcomplete.onHoverState.IconRightImage = null;
            this.BTcomplete.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTcomplete.OnIdleState.BorderRadius = 40;
            this.BTcomplete.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTcomplete.OnIdleState.BorderThickness = 1;
            this.BTcomplete.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTcomplete.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTcomplete.OnIdleState.IconLeftImage = null;
            this.BTcomplete.OnIdleState.IconRightImage = null;
            this.BTcomplete.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTcomplete.OnPressedState.BorderRadius = 40;
            this.BTcomplete.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTcomplete.OnPressedState.BorderThickness = 1;
            this.BTcomplete.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTcomplete.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BTcomplete.OnPressedState.IconLeftImage = null;
            this.BTcomplete.OnPressedState.IconRightImage = null;
            this.BTcomplete.Size = new System.Drawing.Size(239, 52);
            this.BTcomplete.TabIndex = 12;
            this.BTcomplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTcomplete.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTcomplete.TextMarginLeft = 0;
            this.BTcomplete.TextPadding = new System.Windows.Forms.Padding(0);
            this.BTcomplete.UseDefaultRadiusAndThickness = true;
            this.BTcomplete.Click += new System.EventHandler(this.BTcomplete_Click);
            // 
            // Form_Dentist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1230, 703);
            this.Controls.Add(this.BTcomplete);
            this.Controls.Add(this.BTdecline);
            this.Controls.Add(this.BTaccept);
            this.Controls.Add(this.dvg_Appointments);
            this.Controls.Add(this.SidebarMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Dentist";
            this.Text = "Dentist Dashboard";
            this.Load += new System.EventHandler(this.Form_Dentist_Load);
            this.SidebarMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Appointments)).EndInit();
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
        private System.Windows.Forms.Timer SidebarT;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btLogout;
        private System.Windows.Forms.DataGridView dvg_Appointments;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BTaccept;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BTdecline;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BTcomplete;
    }
}