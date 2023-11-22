namespace DentalAppointment.Forms
{
    partial class Form_Landing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Landing));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.SidebarMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SidebarT = new System.Windows.Forms.Timer(this.components);
            this.bunifuDatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.homeBt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.loginBt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SidebarMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // SidebarMenu
            // 
            this.SidebarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SidebarMenu.Controls.Add(this.panel1);
            this.SidebarMenu.Controls.Add(this.panel3);
            this.SidebarMenu.Controls.Add(this.panel2);
            this.SidebarMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarMenu.Location = new System.Drawing.Point(0, 0);
            this.SidebarMenu.MaximumSize = new System.Drawing.Size(222, 703);
            this.SidebarMenu.MinimumSize = new System.Drawing.Size(65, 703);
            this.SidebarMenu.Name = "SidebarMenu";
            this.SidebarMenu.Size = new System.Drawing.Size(65, 703);
            this.SidebarMenu.TabIndex = 0;
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
            // SidebarT
            // 
            this.SidebarT.Interval = 1;
            this.SidebarT.Tick += new System.EventHandler(this.sidebarTimer);
            // 
            // bunifuDatePicker1
            // 
            this.bunifuDatePicker1.BackColor = System.Drawing.Color.White;
            this.bunifuDatePicker1.BorderRadius = 1;
            this.bunifuDatePicker1.CalendarForeColor = System.Drawing.Color.White;
            this.bunifuDatePicker1.CalendarMonthBackground = System.Drawing.Color.AliceBlue;
            this.bunifuDatePicker1.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.bunifuDatePicker1.Color = System.Drawing.Color.Silver;
            this.bunifuDatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.bunifuDatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDatePicker1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.DisplayWeekNumbers = false;
            this.bunifuDatePicker1.DPHeight = 0;
            this.bunifuDatePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bunifuDatePicker1.FillDatePicker = false;
            this.bunifuDatePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDatePicker1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatePicker1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDatePicker1.Icon")));
            this.bunifuDatePicker1.IconColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDatePicker1.LeftTextMargin = 5;
            this.bunifuDatePicker1.Location = new System.Drawing.Point(110, 80);
            this.bunifuDatePicker1.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.bunifuDatePicker1.MinimumSize = new System.Drawing.Size(4, 32);
            this.bunifuDatePicker1.Name = "bunifuDatePicker1";
            this.bunifuDatePicker1.Size = new System.Drawing.Size(452, 32);
            this.bunifuDatePicker1.TabIndex = 2;
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.homeBt.CustomizableEdges = borderEdges3;
            this.homeBt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.homeBt.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.homeBt.DisabledFillColor = System.Drawing.Color.Transparent;
            this.homeBt.DisabledForecolor = System.Drawing.Color.Transparent;
            this.homeBt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
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
            this.homeBt.TabIndex = 1;
            this.homeBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.homeBt.TextMarginLeft = 0;
            this.homeBt.TextPadding = new System.Windows.Forms.Padding(0);
            this.homeBt.UseDefaultRadiusAndThickness = true;
            this.homeBt.Click += new System.EventHandler(this.bunifuButton2_Click);
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
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.loginBt.CustomizableEdges = borderEdges4;
            this.loginBt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginBt.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.loginBt.DisabledFillColor = System.Drawing.Color.Transparent;
            this.loginBt.DisabledForecolor = System.Drawing.Color.Transparent;
            this.loginBt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
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
            this.loginBt.TabIndex = 4;
            this.loginBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginBt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginBt.TextMarginLeft = 0;
            this.loginBt.TextPadding = new System.Windows.Forms.Padding(0);
            this.loginBt.UseDefaultRadiusAndThickness = true;
            this.loginBt.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // Form_Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1230, 703);
            this.Controls.Add(this.bunifuDatePicker1);
            this.Controls.Add(this.SidebarMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Landing";
            this.Text = "Appointment Page";
            this.SidebarMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SidebarMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton loginBt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton homeBt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer SidebarT;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker1;
    }
}