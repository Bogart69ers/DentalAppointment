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
    public partial class Form_Dentist : Form
    {

        int userSelectedId = -1;
        bool sidebarExpand;
        private void loadUser()
        {
            dvg_Appointments.DataSource = UserRepo.GetInstance().GetAppointments();
        }
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

        private void Form_Dentist_Load(object sender, EventArgs e)
        {
            loadAppointments();
        }

        private void loadAppointments()
        {
            dvg_Appointments.DataSource = UserRepo.GetInstance().GetAppointments();
        }

        private void BTaccept_Click(object sender, EventArgs e)
        {
            Appointment accept = new Appointment();
            accept.Status = "Accepted";
            if (UserRepo.GetInstance().AcceptAppointment(userSelectedId, accept))
            {

                Func.ShowResultMessageBox("Appointment Accepted", ErrorCode.Success);
                this.DialogResult = DialogResult.Yes;
                loadUser();
            }
            else
            {
                Func.ShowResultMessageBox("Failed to Accept Appointment.", ErrorCode.Error);
                this.DialogResult = DialogResult.Yes;
            }

        }
        private void BTdecline_Click(object sender, EventArgs e)
        {
            Appointment decline = new Appointment();
            decline.Status = "Declined";
            if (UserRepo.GetInstance().AcceptAppointment(userSelectedId, decline))
            {

                Func.ShowResultMessageBox("Appointment Declined", ErrorCode.Success);
                this.DialogResult = DialogResult.Yes;
                loadUser();
            }
            else
            {
                Func.ShowResultMessageBox("Failed to Decline Appointment.", ErrorCode.Error);
                this.DialogResult = DialogResult.Yes;
            }
        }
        private void BTcomplete_Click(object sender, EventArgs e)
        {
            Appointment complete = new Appointment();
            complete.Status = "Completed";
            if (UserRepo.GetInstance().AcceptAppointment(userSelectedId, complete))
            {

                Func.ShowResultMessageBox("Appointment Completed", ErrorCode.Success);
                this.DialogResult = DialogResult.Yes;
                loadUser();
            }
            else
            {
                Func.ShowResultMessageBox("Failed to Complete Appointment.", ErrorCode.Error);
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void dvg_Appointments_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dvg_Appointments.Rows[0].Selected = true;
                userSelectedId = (int)dvg_Appointments.CurrentRow.Cells[0].Value;
            }
            catch
            { }
        }
        private void dvg_Appointments_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dvg_Appointments.CurrentRow.Selected = true;
            userSelectedId = (int)dvg_Appointments.CurrentRow.Cells[0].Value;
        }

       
    }
}
