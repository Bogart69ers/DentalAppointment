using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalAppointment.Forms
{
    public partial class Form_Appointment : Form
    {
        int month, year;
        bool sidebarExpand;
        public static int static_month, static_year;
        public Form_Appointment()
        {
            InitializeComponent();
        }

        private void homeBt_Click(object sender, EventArgs e)
        {
            new Form_Landing().Show();
            this.Hide();
        }

        private void loginBt_Click(object sender, EventArgs e)
        {
            new Form_Login().Show();
            this.Hide();
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Form_Appointment_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbMonthyr.Text = monthname + " " + year;

            static_month = month;
            static_year = year;


            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for(int i = 1; i <= dayoftheweek; i++) 
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }

            for(int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }

        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            SidebarT.Start();
        }
        private void AppointmentT(object sender, EventArgs e)
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

        private void SidebarMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {
            SidebarT.Start();
        }

        private void BTPrevious_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            month--;     

            if (month < 1)
            {
                month = 12;
                year--;
            }


            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbMonthyr.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days;

            if (month == 2 && DateTime.IsLeapYear(year))
            {                
                days = 29;
            }
            else
            {           
                days = DateTime.DaysInMonth(year, month);
            }

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 1; i <= dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }


        private void BTnext_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            month++;
            
            if (month > 12)
            {
                month = 1;
                year++;
            }


            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbMonthyr.Text = monthname + " " + year;


            DateTime startofthemonth = new DateTime(year, month, 1);
            int days;

            if (month == 2 && DateTime.IsLeapYear(year))
            {
                days = 29;
            }
            else
            {
                days = DateTime.DaysInMonth(year, month);
            }

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 1; i <= dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }

    }
}

