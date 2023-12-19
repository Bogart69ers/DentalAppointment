using DentalAppointment.Repository;
using DentalAppointment.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DentalAppointment.Forms
{
    public partial class Form_Admin : Form
    {        
        bool sidebarExpand;
        public List<Role> listRole;
        UserRepo Repo;
        int userSelectedId = -1;
        public Form_Admin()
        {
            InitializeComponent();
            listRole = new List<Role>();    
        }

        private void Form_Admin_Load(object sender, EventArgs e)
        {
            loadCBRole();        
            Repo = new UserRepo();
            loadUser();
        }
        private void loadUser()
        {
            dgv_admin.DataSource = UserRepo.GetInstance().GetUserAccounts();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (DetailsFilled())
            {
                UserAccount newUserAcc = new UserAccount();
                newUserAcc.Username = TBUser.Text;
                newUserAcc.Password = TBPass.Text;
                newUserAcc.RoleID = CBRole.SelectedIndex;
                newUserAcc.ContactInfo = TBContact.Text;
                newUserAcc.FirstName = TBFName.Text;
                newUserAcc.LastName = TBLName.Text;

                if (UserRepo.GetInstance().NewUserAcc(newUserAcc))
                {

                    Func.ShowResultMessageBox("Successfully Booked!", ErrorCode.Success);
                    this.DialogResult = DialogResult.Yes;
                    loadUser();
                }
                else
                {
                    Func.ShowResultMessageBox("Failed to create Booking.", ErrorCode.Error);
                    this.DialogResult = DialogResult.Yes;
                }
            }



        }     

        private void dgv_admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userSelectedId = (Int32)dgv_admin.Rows[e.RowIndex].Cells[0].Value;
                TBUser.Text = dgv_admin.Rows[e.RowIndex].Cells[3].Value as String;
                TBPass.Text = dgv_admin.Rows[e.RowIndex].Cells[4].Value as String;
                TBFName.Text = dgv_admin.Rows[e.RowIndex].Cells[1].Value as String;
                TBLName.Text = dgv_admin.Rows[e.RowIndex].Cells[2].Value as String;
                TBContact.Text = dgv_admin.Rows[e.RowIndex].Cells[6].Value as String;
                CBRole.Text = dgv_admin.Rows[e.RowIndex].Cells[5].Value as String;


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception : {ex.Message}");
            }
        }

        private Boolean DetailsFilled()
        {
            bool proceed = true;
            errorProvider1.Clear();
            if (String.IsNullOrEmpty(TBUser.Text))
            {
                errorProvider1.SetError(TBUser, "Field is empty.");
                proceed = false;
            }
            if (String.IsNullOrEmpty(TBPass.Text))
            {
                errorProvider1.SetError(TBPass, "Field is empty.");
                proceed = false;
            }
            if (String.IsNullOrEmpty(TBFName.Text))
            {
                errorProvider1.SetError(TBFName, "Field is empty.");
                proceed = false;
            }
            if (CBRole.SelectedIndex < 0)
            {
                errorProvider1.SetError(CBRole, "No Selected Entry.");
                proceed = false;
            }          
            if (String.IsNullOrEmpty(TBLName.Text))
            {
                errorProvider1.SetError(TBLName, "Field is empty.");
                proceed = false;
            }
            if (String.IsNullOrEmpty(TBContact.Text))
            {
                errorProvider1.SetError(TBContact, "Field is empty.");
                proceed = false;
            }
            return proceed;
        }

        private void BTUpdate_Click(object sender, EventArgs e)
{
    String username = TBUser.Text;
    String pass = TBPass.Text;
    String fname = TBFName.Text;
    String lname = TBLName.Text;
    String con = TBContact.Text;
    int role = CBRole.SelectedIndex;


    String strOutputMsg = "";

    // Validation not allow empty or null value
    if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(pass) || String.IsNullOrEmpty(fname)) 
    {
        errorProvider1.SetError(TBUser, "All fields must be filled!");
        return;
    }

    var userAccount = Repo.GetUserByUsername(username);

    if (userAccount != null)
    {
        // Update userAccount with new values
        userAccount.Password = pass;
        userAccount.FirstName = fname;
        userAccount.LastName = lname;
        userAccount.ContactInfo = con;
        userAccount.RoleID = role;

        ErrorCode retValue = Repo.UpdateUser(userSelectedId, userAccount, ref strOutputMsg);

        if (retValue == ErrorCode.Success)
        {
            // Clear the errors
            errorProvider1.Clear();
            MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadUser();
            // Reset the selected id
            userSelectedId = -1;

            TBPass.Clear();
            TBUser.Clear();
            TBContact.Clear();
            TBFName.Clear();
            TBLName.Clear();
            CBRole.ResetText();
        }
        else
        {
            // Error
            MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
    else
    {
        // User not found
        MessageBox.Show("User not found.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
}

        private void BTDelete_Click(object sender, EventArgs e)
        {
            if (!userSelectedId.Equals(UserLogg.GetInstance().UserAccount.UserId)) //Check selected user if not self
            {
                if (UserLogg.GetInstance().UserAccount.RoleID >= (int)dgv_admin.CurrentRow.Cells[5].Value) //Check user's access privilege
                {
                    if (Func.ShowConfirmationPromptMessageBox("Are you sure to delete This User ?", "Delete Confirmation").Equals(DialogResult.Yes))
                        if (UserRepo.GetInstance().DeleteUserAccount(userSelectedId))
                        {
                            Func.ShowResultMessageBox("Successfully deleted User" , ErrorCode.Success);
                            loadUser();
                        }
                        else
                            Func.ShowResultMessageBox("Failed to delete User account.", ErrorCode.Error);
                }
                else
                    Func.ShowResultMessageBox("Insufficient Access privilege.", ErrorCode.Error);
            }
            else
                Func.ShowResultMessageBox("Unable to perform operation on own Account.", ErrorCode.Error);
        }   

        private void TBPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loadCBRole()
        {
            using (var db = new DentalAppointmentSystemEntity()) {

                listRole = db.Roles.ToList();

                CBRole.DisplayMember = "roleName";
                CBRole.ValueMember = "roleDescription";
                CBRole.DataSource = listRole;
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            SidebarT.Start();

        }

        private void AdminSideT(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                SidebarMenu.Width -= 10;
                if (SidebarMenu.Width == SidebarMenu.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SidebarT.Stop();
                }
            }
            else
            {
                SidebarMenu.Width += 10;
                if (SidebarMenu.Width == SidebarMenu.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SidebarT.Stop();
                }
            }
        }

        private void logoutBt_Click(object sender, EventArgs e)
        {
            new Form_Login().Show();
            this.Hide();
        }

        private void CBRole_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dgv_admin_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgv_admin.Rows[0].Selected = true;
                userSelectedId = (int)dgv_admin.CurrentRow.Cells[0].Value;
            }
            catch
            { }
        }

        private void dgv_admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_admin.CurrentRow.Selected = true;
            userSelectedId = (int)dgv_admin.CurrentRow.Cells[0].Value;
        }
    }
}

