namespace DentalAppointment.Forms
{
    partial class Form_Admin
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
            this.TBUser = new System.Windows.Forms.TextBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.userlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTRegister = new System.Windows.Forms.Button();
            this.BTUpdate = new System.Windows.Forms.Button();
            this.BTDelete = new System.Windows.Forms.Button();
            this.dgv_admin = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TBContact = new System.Windows.Forms.TextBox();
            this.CBRole = new System.Windows.Forms.ComboBox();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TBUser
            // 
            this.TBUser.Location = new System.Drawing.Point(33, 101);
            this.TBUser.Name = "TBUser";
            this.TBUser.Size = new System.Drawing.Size(160, 20);
            this.TBUser.TabIndex = 0;
            this.TBUser.TextChanged += new System.EventHandler(this.TBUser_TextChanged);
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(33, 146);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(160, 20);
            this.TBPass.TabIndex = 1;
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Location = new System.Drawing.Point(39, 82);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(55, 13);
            this.userlabel.TabIndex = 2;
            this.userlabel.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // BTRegister
            // 
            this.BTRegister.Location = new System.Drawing.Point(461, 40);
            this.BTRegister.Name = "BTRegister";
            this.BTRegister.Size = new System.Drawing.Size(150, 26);
            this.BTRegister.TabIndex = 4;
            this.BTRegister.Text = "Register";
            this.BTRegister.UseVisualStyleBackColor = true;
            this.BTRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTUpdate
            // 
            this.BTUpdate.Location = new System.Drawing.Point(461, 71);
            this.BTUpdate.Name = "BTUpdate";
            this.BTUpdate.Size = new System.Drawing.Size(150, 24);
            this.BTUpdate.TabIndex = 5;
            this.BTUpdate.Text = "Update";
            this.BTUpdate.UseVisualStyleBackColor = true;
            this.BTUpdate.Click += new System.EventHandler(this.BTUpdate_Click);
            // 
            // BTDelete
            // 
            this.BTDelete.Location = new System.Drawing.Point(461, 101);
            this.BTDelete.Name = "BTDelete";
            this.BTDelete.Size = new System.Drawing.Size(150, 24);
            this.BTDelete.TabIndex = 6;
            this.BTDelete.Text = "Delete";
            this.BTDelete.UseVisualStyleBackColor = true;
            this.BTDelete.Click += new System.EventHandler(this.BTDelete_Click);
            // 
            // dgv_admin
            // 
            this.dgv_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admin.Location = new System.Drawing.Point(12, 193);
            this.dgv_admin.Name = "dgv_admin";
            this.dgv_admin.Size = new System.Drawing.Size(617, 249);
            this.dgv_admin.TabIndex = 7;
            this.dgv_admin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_admin_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TBContact
            // 
            this.TBContact.Location = new System.Drawing.Point(226, 101);
            this.TBContact.Name = "TBContact";
            this.TBContact.Size = new System.Drawing.Size(165, 20);
            this.TBContact.TabIndex = 8;
            // 
            // CBRole
            // 
            this.CBRole.FormattingEnabled = true;
            this.CBRole.Items.AddRange(new object[] {
            "Dentist",
            "Patient",
            "Admin"});
            this.CBRole.Location = new System.Drawing.Point(226, 53);
            this.CBRole.Name = "CBRole";
            this.CBRole.Size = new System.Drawing.Size(138, 21);
            this.CBRole.TabIndex = 9;
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Location = new System.Drawing.Point(233, 37);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(29, 13);
            this.RoleLabel.TabIndex = 10;
            this.RoleLabel.Text = "Role";
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Location = new System.Drawing.Point(233, 85);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(84, 13);
            this.ContactLabel.TabIndex = 11;
            this.ContactLabel.Text = "Contact Number";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(33, 53);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(160, 20);
            this.TBName.TabIndex = 12;
            this.TBName.TextChanged += new System.EventHandler(this.TBName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.CBRole);
            this.Controls.Add(this.TBContact);
            this.Controls.Add(this.dgv_admin);
            this.Controls.Add(this.BTDelete);
            this.Controls.Add(this.BTUpdate);
            this.Controls.Add(this.BTRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userlabel);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBUser);
            this.Name = "Form_Admin";
            this.Text = "ADMIN ACCESS";
            this.Load += new System.EventHandler(this.Form_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBUser;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTRegister;
        private System.Windows.Forms.Button BTUpdate;
        private System.Windows.Forms.Button BTDelete;
        private System.Windows.Forms.DataGridView dgv_admin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.ComboBox CBRole;
        private System.Windows.Forms.TextBox TBContact;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBName;
    }
}