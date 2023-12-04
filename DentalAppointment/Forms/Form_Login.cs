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
        bool sidebarExpand;
        UserRepo Repos;
        public Form_Login()
        {
            InitializeComponent();

            Repos = new UserRepo();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void BTLogin_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TBUsername.Text))
            {
                errorProvider1.SetError(TBUsername, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(tbPassword.Text))
            {
                errorProvider1.SetError(tbPassword, "Empty Field!");
                return;
            }

            var userLogged = Repos.GetUserByUsername(TBUsername.Text);

            if (userLogged != null)
            {
                if (userLogged.Password.Equals(tbPassword.Text))
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
                        /*case Roles.Patient:
                            // Load Admin Dashboard
                            new Form_Landing().Show();
                            this.Hide();
                            break;*/
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


        private void TBPassword_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            SidebarT.Start();

        }

        private void SidebarT_Tick(object sender, EventArgs e)
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


        private void bunifuToggleSwitch1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (tbShowpass.Checked)
            {
                string pass = tbShowpass.Text;
                tbPassword.PasswordChar = '\0';

            }
            else
            {
                tbPassword.PasswordChar = '*';
            }
        }

        private void homeBt_Click(object sender, EventArgs e)
        {
            new Form_Landing().Show();
            this.Hide();
        }
    }
}


