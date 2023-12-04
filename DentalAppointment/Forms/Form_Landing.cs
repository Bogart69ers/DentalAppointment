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
    public partial class Form_Landing : Form
    {
        bool sidebarExpand;
        public Form_Landing()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            new Form_Login().Show();
            this.Hide();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void sidebarTimer(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                SidebarMenu.Width -= 10;
                if(SidebarMenu.Width == SidebarMenu.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SidebarT.Stop();
                }
            }
            else
            {
                SidebarMenu.Width += 10;
                if(SidebarMenu.Width == SidebarMenu.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SidebarT.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            SidebarT.Start();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Landing_Load(object sender, EventArgs e)
        {

        }

        private void tbApFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SidebarMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            new Form_Appointment().Show();
            this.Hide();
        }

        private void BTbookappointment_Click(object sender, EventArgs e)
        {
            new Form_Appointment().Show();
            this.Hide();
        }
    }
}
