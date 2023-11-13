using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DentalAppointment.Forms;
using DentalAppointment.Repository;
using DentalAppointment.Utils;

namespace DentalAppointment
{
    public partial class Form_Login : Form
    {
        UserRepo Repos;
        public Form_Login()
        {
            InitializeComponent();

            Repos = new UserRepo(); 
        }

        private void BTLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TBUsername.Text))
            {
                errorProvider1.SetError(TBUsername, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(TBPassword.Text))
            {
                errorProvider1.SetError(TBPassword, "Empty Field!");
                return;
            }

            var userLogged = Repos.GetUserByUsername(TBUsername.Text);

            if (userLogged != null)
            {
                if (userLogged.Password.Equals(TBPassword.Text))
                {
                    switch ((Roles)userLogged.RoleID)
                    {
                        case Roles.Admin:
                            // Load student Dashboard
                            new Form_Admin().Show();
                            this.Hide();
                            break;
                        case Roles.Dentist:
                            // Load Teacher Dashboard
                            new Form_Dentist().Show();
                            this.Hide();
                            break;
                        case Roles.Patient:
                            // Load Admin Dashboard
                            new Form_Patient().Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("User has no role!");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
                MessageBox.Show("Username not found");
            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TBPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form_Register frm = new Form_Register();
            frm.ShowDialog();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbShow.Checked)
            {
                TBPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TBPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
