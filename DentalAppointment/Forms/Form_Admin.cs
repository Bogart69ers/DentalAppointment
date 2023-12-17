using DentalAppointment.Repository;
using DentalAppointment.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalAppointment.Forms
{
    public partial class Form_Admin : Form
    {
        bool sidebarExpand;
        public List<Role> listRole;
        UserRepo Repo;
        int? userSelectedId = null;
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
            String username = TBUser.Text;
            String pass = TBPass.Text;          
            String FirstName = TBFName.Text;
            String LastName = TBLName.Text;
            String Role = CBRole.Text;
            String Contact = TBContact.Text;
          

            String strOutputMsg = "";
            // Validation not allow empty or null value
          

            if (String.IsNullOrEmpty(FirstName))
            {
                errorProvider1.SetError(TBFName, "Empty Field!");
                return;
            }
            else

             if (String.IsNullOrEmpty(LastName))
            {
                errorProvider2.SetError(TBLName, "Empty Field!");
                return;
            }
            else

            if (String.IsNullOrEmpty(Role))
            {
                errorProvider6.SetError(CBRole, "Empty Field!");
                return;
            }
            
            else

            if (String.IsNullOrEmpty(username))
            {
                errorProvider3.SetError(TBUser, "Empty Field!");
                return;
            }
            else
            // Validation not allow empty or null value
            if (String.IsNullOrEmpty(pass))
            {
                errorProvider5.SetError(TBPass, "Empty Field!");
                return;
            }
            else
            // Validation not allow empty or null value
            if (String.IsNullOrEmpty(Contact))
            {
                errorProvider4.SetError(TBContact, "Empty Field!");
                return;
            }


            // Create new object of USER_ACCOUNT
            UserAccount newUserAcc = new UserAccount();
            newUserAcc.Username = TBUser.Text;
            newUserAcc.Password = TBPass.Text;
            newUserAcc.RoleID = CBRole.SelectedIndex;
            newUserAcc.ContactInfo = TBContact.Text;
            newUserAcc.FirstName = TBFName.Text; 
            newUserAcc.LastName = TBLName.Text;

            ErrorCode retValue = Repo.NewUser(newUserAcc, ref strOutputMsg);
            if (retValue == ErrorCode.Success)
            {
                //Clear the errors
                errorProvider1.Clear();
                MessageBox.Show(strOutputMsg, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadUser();

                TBPass.Clear();
                TBUser.Clear();
                TBContact.Clear();
                TBFName.Clear();
                TBLName.Clear();
                CBRole.ResetText();
                
            }
            else
            {
                // error 
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TBUser_TextChanged(object sender, EventArgs e)
        {

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
            userSelectedId = null;

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
            String username = TBUser.Text;
            String pass = TBPass.Text;

            String strOutputMsg = "";

            if (userSelectedId == null)
            {
                MessageBox.Show("No User Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ErrorCode retValue = Repo.RemoveUser(userSelectedId, ref strOutputMsg);
            if (retValue == ErrorCode.Success)
            {
                //Clear the errors
                errorProvider1.Clear();
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadUser();
                //reset the selected id
                userSelectedId = null;

                TBPass.Clear();
                TBUser.Clear();
                TBContact.Clear();
                TBFName.Clear();
                TBLName.Clear();
                CBRole.ResetText();
            }
            else
            {
                // error 
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
    }
}

