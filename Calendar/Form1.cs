using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Calendar.UserControlDays;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace Calendar
{
    public partial class Form1 : Form
    {

        //variables
        int month, year;
        private UserControlDays ucDays;
        public static int static_month, static_year;

        //Build the Calendar
        public Form1()
        {
            InitializeComponent();
            ucDays = new UserControlDays();
        }

        //Display it
        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();
            UpdateModeLabel.Text = "Add Mode";
        }
        //Specifics on creation
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LbDate.Text = monthName + " " + year;

            static_month = month;
            static_year = year;

            DateTime startOfMonth = new DateTime(year, month, 1);
            //count days of the month

            int days = DateTime.DaysInMonth(year, month);

            //convert the startofmonth to an int
            int dayofweek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            //user control
            for(int i =1; i < dayofweek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                CalendarLayout.Controls.Add(ucBlank);
            }

            //User control for days
            for(int i = 1; i<= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                CalendarLayout.Controls.Add(ucDays);
            }
        }

        //Next Button
        private void button1_Click(object sender, EventArgs e)
        {
            //Clear Calendar
            CalendarLayout.Controls.Clear();

            //Incriment the month
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }

            static_month = month;
            static_year = year;

            //Change month title
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LbDate.Text = monthName + " " + year;

            DateTime startOfMonth = new DateTime(year, month, 1);
            //count days of the month

            int days = DateTime.DaysInMonth(year, month);

            //convert the startofmonth to an int
            int dayofweek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            //user control
            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                CalendarLayout.Controls.Add(ucBlank);
            }

            //User control for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                CalendarLayout.Controls.Add(ucDays);
            }
            UpdateModeLabel.Text = "Add Mode";
        }

        //Previous Button
        private void button2_Click(object sender, EventArgs e)
        {
            //Clear Calendar
            CalendarLayout.Controls.Clear();

            //Incriment the month
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }

            static_month = month;
            static_year = year;

            //Change month title
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LbDate.Text = monthName + " " + year;

            DateTime startOfMonth = new DateTime(year, month, 1);
            //count days of the month

            int days = DateTime.DaysInMonth(year, month);

            //convert the startofmonth to an int
            int dayofweek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            //user control
            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                CalendarLayout.Controls.Add(ucBlank);
            }

            //User control for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                CalendarLayout.Controls.Add(ucDays);
            }
            UpdateModeLabel.Text = "Add Mode";
        }

        private void addMode_Click(object sender, EventArgs e)
        {
            SetMode(CalendarMode.Add);
            UpdateModeLabel.Text = "Add Mode";
        }

        private void viewMode_Click(object sender, EventArgs e)
        {
            SetMode(CalendarMode.ViewDelete);
            UpdateModeLabel.Text = "View/Delete Mode";
        }

        private void SetMode(CalendarMode mode)
        {
            foreach (Control control in CalendarLayout.Controls)
            {
                if (control is UserControlDays ucDays)
                {
                    ucDays.SetMode(mode);
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void flowLayoutPanel1_Paint(object sender, EventArgs e)
        {

        }

    }
}
