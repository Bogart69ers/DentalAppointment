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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DentalAppointment.Forms
{
    public partial class Form_Appointmentform : Form
    {
        public List<Service> listServices;
        public List<Sex> listSex;
        public List<TimeSet> listTimeSets;        
        
        public Form_Appointmentform()
        {
            InitializeComponent();
            listServices = new List<Service>();
        }

        private void Form_Appointmentform_Load(object sender, EventArgs e)
        {
            loadcbService();
            loadcbSex();
            loadCbTime();
                     
            TbDate.Text =Form_Appointment.static_month+"/"+ UserControlDays.static_day + "/" + Form_Appointment.static_year;
        }

        private void loadcbService()
        {
            using (var db = new DentalAppointmentSystemEntity())
            {

                listServices = db.Services.ToList();

                cbService.DisplayMember = "ServiceName";
                cbService.ValueMember = "ServiceDescription";
                cbService.DataSource = listServices;
            }
        }
        private void loadcbSex()
        {
            using (var db = new DentalAppointmentSystemEntity())
            {

                listSex = db.Sexes.ToList();

                cbSex.DisplayMember = "SexName";
                cbSex.ValueMember = "SexDescription";
                cbSex.DataSource = listSex;
            }
        }

        private void loadCbTime()
        {
            using(var db = new DentalAppointmentSystemEntity())
            {
                listTimeSets = db.TimeSets.ToList();

                CbTime.DisplayMember = "TimeName";
                CbTime.ValueMember = "TimeDiscription";
                CbTime.DataSource = listTimeSets;
                
            }
        }


        private void BTbookapp_Click(object sender, EventArgs e)
        {
            if (DetailsFilled())
            {                
                Patient newPatient = new Patient();
                newPatient.FirstName = tbApFirstName.Text;
                newPatient.LastName = tbApLastName.Text;
                newPatient.ContactNumber = tbApContact.Text;
                newPatient.Sex = cbSex.Text;
                newPatient.Email = TbEmail.Text;

                Appointment newAppointment = new Appointment();
                //Appointment.PatientId = Patient.PatientId;
                newAppointment.PatientName = tbApFirstName.Text + " " + tbApLastName.Text;
                newAppointment.AppointmentPurpose = cbService.Text;
                newAppointment.DateAndTime = TbDate.Text + " " + CbTime.Text;
                newAppointment.Status = "Pending";
                newAppointment.Email = TbEmail.Text;

                if (UserRepo.GetInstance().NewBookAppointment(newPatient, newAppointment))
                {

                    Func.ShowResultMessageBox("Successfully Booked!", ErrorCode.Success);
                    this.DialogResult = DialogResult.Yes;
                    
                    this.Dispose();
                }
                else
                {
                    Func.ShowResultMessageBox("Failed to create Booking.", ErrorCode.Error);
                    this.DialogResult = DialogResult.Yes;
                }
            }



        }
        private Boolean DetailsFilled()
        {
            bool proceed = true;
            errorProvider1.Clear();
            if (String.IsNullOrEmpty(tbApFirstName.Text))
            {
                errorProvider1.SetError(tbApFirstName, "Field is empty.");
                proceed = false;
            }
            if (String.IsNullOrEmpty(tbApLastName.Text))
            {
                errorProvider1.SetError(tbApLastName, "Field is empty.");
                proceed = false;
            }
            if (String.IsNullOrEmpty(tbApContact.Text))
            {
                errorProvider1.SetError(tbApContact, "Field is empty.");
                proceed = false;
            }
            if (cbService.SelectedIndex < 0)
            {
                errorProvider1.SetError(cbService, "No Selected Entry.");
                proceed = false;
            }
            if (cbSex.SelectedIndex < 0)
            {
                errorProvider1.SetError(cbSex, "No Selected Entry.");
                proceed = false;
            }  
            if (String.IsNullOrEmpty(TbEmail.Text))
            {
                errorProvider1.SetError(TbDate, "Field is empty.");
                proceed = false;
            }
            return proceed;
        }


        private void TbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
