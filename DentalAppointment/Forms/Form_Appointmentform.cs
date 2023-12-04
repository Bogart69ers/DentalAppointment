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
        private void BTbookapp_Click(object sender, EventArgs e)
        {
            String strOutputMsg = "";
            String FirstName = tbApFirstName.Text;
            String LastName = tbApLastName.Text;
            String ContactNumber = tbApContact.Text;
            String Sex = cbSex.Text;
            String AppointmentPurpose = cbService.Text;     

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

         
            // Create new object of USER_ACCOUNT
            Patient newPatient = new Patient();
            newPatient.FirstName = tbApFirstName.Text;
            newPatient.LastName = tbApLastName.Text;
            newPatient.ContactNumber = tbApContact.Text;
            newPatient.Sex = cbSex.Text;
            newPatient.AppointmentPurpose = cbService.Text;
            

            ErrorCode retValue = Repo.NewPatient(newPatient, ref strOutputMsg);
            if (retValue == ErrorCode.Success)
            {
                //Clear the errors
                errorProvider1.Clear();
                MessageBox.Show(strOutputMsg, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
               

                tbApFirstName.Clear();
                tbApLastName.Clear();
                tbApContact.Clear();
                cbService.ResetText();
                cbSex.ResetText();
                TbDate.Clear();

            }
            else
            {
                // error 
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.Hide();



        }
    }
}
