using MySql.Data.MySqlClient; // MySQL database connector
using Mysqlx.Crud; // MySQL CRUD operations
using System; // Basic system functions
using System.Windows.Forms; // Windows Forms for UI
using static Org.BouncyCastle.Crypto.Engines.SM2Engine; // SM2Engine class

namespace Calendar
{
    public partial class UserControlDays : UserControl
    {
        public string selectedMode; // Stores the selected mode

        // Static Variables
        public static string static_day; // Stores the selected day
        public static DateTime selectedDate; // Stores the selected date

        // Constructor
        public UserControlDays()
        {
            InitializeComponent(); // Initialize the user control
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            // Load event handler
        }

        // Set the day label
        public void days(int numDay)
        {
            lbDays.Text = numDay + ""; // Update the day label
        }

        private void lbDays_Click(object sender, EventArgs e)
        {
            static_day = lbDays.Text; // Store the selected day
            int month = Form1.static_month; // Get the static month from Form1
            int day = int.Parse(static_day); // Parse the selected day to int
            int year = Form1.static_year; // Get the static year from Form1

            selectedDate = new DateTime(year, month, day); // Create a new DateTime object with the selected date
        }

        public enum CalendarMode
        {
            Add, // Add mode
            ViewDelete // View/Delete mode
        }

        // Mode variable in Form1
        public CalendarMode currentMode;

        // Set the mode based on user selection
        public void SetMode(CalendarMode mode)
        {
            currentMode = mode; // Set the current mode
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbDays.Text; // Store the selected day
            selectedDate = new DateTime(Form1.static_year, Form1.static_month, int.Parse(static_day)); // Create a new DateTime object with the selected date
            switch (currentMode) // Check the current mode
            {
                case CalendarMode.Add: // If in Add mode
                    OpenAddEventForm(); // Open the Add Event form
                    break;
                case CalendarMode.ViewDelete: // If in View/Delete mode
                    OpenViewDeleteEventForm(); // Open the View/Delete Event form
                    break;
                default: // If no mode selected
                    MessageBox.Show("Please select a mode first.", "Mode not selected", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show an error message
                    break;
            }
        }

        private void OpenAddEventForm()
        {
            static_day = lbDays.Text; // Store the selected day
            EventForm eventForm = new EventForm(); // Create a new instance of the EventForm
            eventForm.ShowDialog(); // Show the EventForm as a dialog
        }

        // Open the View/Delete Event Form
        private void OpenViewDeleteEventForm()
        {
            bool monthlyMode = false; // Set the default value to false or determine the mode based on your requirements

            // You can determine the selectedDate and monthlyMode based on your application logic here

            EventDisplayForm eventDisplayForm = new EventDisplayForm(selectedDate, monthlyMode); // Create a new instance of the EventDisplayForm
            eventDisplayForm.ShowDialog(); // Show the EventDisplayForm as a dialog
        }
    }
}
