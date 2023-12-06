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
    public partial class Form_Dentist : Form
    {
        bool sidebarExpand;
        public Form_Dentist()
        {
            InitializeComponent();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            new Form_Login().Show();
            this.Hide();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            SidebarT.Start();
        }

        private void dentistT(object sender, EventArgs e)
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

        private void btAppointments_Click(object sender, EventArgs e)
        {
            new Form_Dentist_Appointments().Show();
            this.Hide();
        }

        private void SidebarMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
