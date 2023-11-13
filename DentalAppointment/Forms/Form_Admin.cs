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
        UserRepo Repo;
        int? userSelectedId = null;
        public Form_Admin()
        {
            InitializeComponent();
        }

        private void Form_Admin_Load(object sender, EventArgs e)
        {
            Repo = new UserRepo();
            loadUser();
        }
        private void loadUser()
        {
            dgv_admin.DataSource = Repo.UserAccounts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = TBUser.Text;
            String pass = TBPass.Text;          
            String Name = TBName.Text;
          

            String strOutputMsg = "";
            // Validation not allow empty or null value
          

            if (String.IsNullOrEmpty(Name))
            {
                errorProvider1.SetError(TBName, "Empty Field!");
                return;
            }
            else 

            if (String.IsNullOrEmpty(username))
            {
                errorProvider1.SetError(TBUser, "Empty Field!");
                return;
            }
            else
            // Validation not allow empty or null value
            if (String.IsNullOrEmpty(pass))
            {
                errorProvider1.SetError(TBPass, "Empty Field!");
                return;
            }


            // Create new object of USER_ACCOUNT
            UserAccount newUserAcc = new UserAccount();
            newUserAcc.Username = TBUser.Text;
            newUserAcc.Password = TBPass.Text;
            newUserAcc.RoleID = CBRole.SelectedIndex;
            newUserAcc.ContactInfo = TBContact.Text;
            newUserAcc.Name = TBName.Text; 

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
                TBName.Clear();
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
                TBUser.Text = dgv_admin.Rows[e.RowIndex].Cells[1].Value as String;
                TBPass.Text = dgv_admin.Rows[e.RowIndex].Cells[2].Value as String;
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

            String strOutputMsg = "";
            // Validation not allow empty or null value
            if (String.IsNullOrEmpty(username))
            {
                errorProvider1.SetError(TBUser, "Empty Field!");
                return;
            }
            else
            // Validation not allow empty or null value
            if (String.IsNullOrEmpty(pass))
            {
                errorProvider1.SetError(TBPass, "Empty Field!");
                return;
            }
            var userAccount = Repo.GetUserByUsername(username);

            ErrorCode retValue = Repo.UpdateUser(userSelectedId, userAccount, ref strOutputMsg);
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
                TBName.Clear();
                CBRole.ResetText();
            }
            else
            {
                // error 
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                TBName.Clear();
                CBRole.ResetText();
            }
            else
            {
                // error 
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TBName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

