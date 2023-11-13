namespace DentalAppointment
{
    partial class Form_Login
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
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.BTLogin = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.CkbShow = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TBUsername
            // 
            this.TBUsername.Location = new System.Drawing.Point(52, 71);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(216, 20);
            this.TBUsername.TabIndex = 0;
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(52, 116);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(216, 20);
            this.TBPassword.TabIndex = 1;
            this.TBPassword.UseSystemPasswordChar = true;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(54, 55);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(55, 13);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(54, 100);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // BTLogin
            // 
            this.BTLogin.Location = new System.Drawing.Point(89, 186);
            this.BTLogin.Name = "BTLogin";
            this.BTLogin.Size = new System.Drawing.Size(120, 24);
            this.BTLogin.TabIndex = 4;
            this.BTLogin.Text = "Login";
            this.BTLogin.UseVisualStyleBackColor = true;
            this.BTLogin.Click += new System.EventHandler(this.BTLogin_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CkbShow
            // 
            this.CkbShow.AutoSize = true;
            this.CkbShow.Location = new System.Drawing.Point(52, 142);
            this.CkbShow.Name = "CkbShow";
            this.CkbShow.Size = new System.Drawing.Size(102, 17);
            this.CkbShow.TabIndex = 3;
            this.CkbShow.Text = "Show Password";
            this.CkbShow.UseVisualStyleBackColor = true;
            this.CkbShow.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 320);
            this.Controls.Add(this.CkbShow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTLogin);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBUsername);
            this.Name = "Form_Login";
            this.Text = "DENTAL APPOINTMENT";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BTLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox CkbShow;
    }
}

