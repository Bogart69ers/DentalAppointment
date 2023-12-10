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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DentalAppointment.Forms
{
    public partial class Form_Appointmentform : Form
    {
        public List<Service> listServices;
        public List<Sex> listSex;
        public List<TimeSet> listTimeSets;

        UserRepo Repo;
        
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
           
            Repo = new UserRepo();
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
            String strOutputMsg = "";
            String FirstName = tbApFirstName.Text;
            String LastName = tbApLastName.Text;
            String ContactNumber = tbApContact.Text;
            String Sex = cbSex.Text;
            String AppointmentPurpose = cbService.Text;
            String Email = TbEmail.Text;
            String Time = CbTime.Text;

            if (String.IsNullOrEmpty(FirstName))
            {
                errorProvider1.SetError(tbApFirstName, "Empty Field!");
                return;
            }
            else

            if (String.IsNullOrEmpty(LastName))
            {
                errorProvider2.SetError(tbApLastName, "Empty Field!");
                return;
            }
            else

           if (String.IsNullOrEmpty(Sex))
            {
                errorProvider4.SetError(cbSex, "Empty Field!");
                return;
            }

            else

           if (String.IsNullOrEmpty(ContactNumber))
            {
                errorProvider3.SetError(tbApContact, "Empty Field!");
                return;
            }          
            else
           // Validation not allow empty or null value
           if (String.IsNullOrEmpty(AppointmentPurpose))
            {
                errorProvider5.SetError(cbService, "Empty Field!");
                return;
            }
            else

            if (String.IsNullOrEmpty(Email))
            {
                errorProvider6.SetError(TbEmail, "Empty Field");
                return;
            }
            else

            if (String.IsNullOrEmpty(Time))
            {
                errorProvider7.SetError(CbTime, "Empty Field");
                return;
            }
            // Create new object of USER_ACCOUNT
                Patient newPatient = new Patient();
                newPatient.FirstName = tbApFirstName.Text;
                newPatient.LastName = tbApLastName.Text;
                newPatient.ContactNumber = tbApContact.Text;
                newPatient.Sex = cbSex.Text;
                newPatient.AppointmentPurpose = cbService.Text;
                newPatient.Email = TbEmail.Text;

            ErrorCode retValue = Repo.NewPatient(newPatient, ref strOutputMsg);
            if (retValue == ErrorCode.Success)
            {
                int PatientId = newPatient.PatientId;

                Appointment newAppointment = new Appointment();
                //Appointment.PatientId = Patient.PatientId;
                newAppointment.PatientName = tbApFirstName.Text + " " + tbApLastName.Text;
                newAppointment.AppointmentPurpose = cbService.Text;
                newAppointment.DateAndTime = TbDate.Text + " " + CbTime.Text;
                newAppointment.Email = TbEmail.Text;
                newAppointment.Status = "Pending";
                newAppointment.PatientId = PatientId;

            ErrorCode appointmentRetValue = Repo.NewAppointment(newAppointment, ref strOutputMsg);

                //Clear the errors
                errorProvider1.Clear();
                MessageBox.Show(strOutputMsg, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
               

                tbApFirstName.Clear();
                tbApLastName.Clear();
                tbApContact.Clear();
                cbService.ResetText();
                cbSex.ResetText();
                TbDate.Clear();
                TbEmail.Clear();

            }
            else
            {
                // error 
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.Hide();



        }

        private void TbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
