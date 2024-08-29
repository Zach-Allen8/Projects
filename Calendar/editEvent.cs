using MySql.Data.MySqlClient;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Calendar
{
    public partial class editEvent : Form
    {
        String connString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;password=Maroon@21?;";
        private int eventId;

        public editEvent()
        {
            InitializeComponent();
        }

        // Properties
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Load event details
        public void editEvent_Load(object sender, EventArgs e)
        {
            txtEvent.Text = EventName;
            dateTimePickerStart.Value = StartDate;
            dateTimePickerEndDate.Value = EndDate;
        }

        private void txtEvent_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePickerStartTime_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get the event details from the form
            string eventName = txtEvent.Text;
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEndDate.Value;

            // Validate the end date
            if (endDate < startDate)
            {
                MessageBox.Show("End date cannot be before start date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate the event name
            if (string.IsNullOrWhiteSpace(eventName))
            {
                MessageBox.Show("Name can't be left empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the event in the database
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string sql = "UPDATE JacJallenIndividual SET event_name = @eventName, start_date = @startDate, end_date = @endDate WHERE event_id = @eventId";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@eventName", eventName);
                    cmd.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@endDate", endDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@eventId", eventId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Event has been updated.", "Alert");
                DialogResult = DialogResult.OK;
                Close();

                // Refresh the ListView in the EventDisplayForm
                EventDisplayForm displayForm = Application.OpenForms.OfType<EventDisplayForm>().FirstOrDefault();
                displayForm?.DisplayEvents(displayForm.selectedDate, displayForm.monthlyMode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckForConflicts(DateTime startDate, DateTime endDate, int eventId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM JacJallenIndividual WHERE (@startDate < end_date) AND (@endDate > start_date) AND event_id != @eventId";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@endDate", endDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@eventId", eventId);
                    int conflictCount = Convert.ToInt32(cmd.ExecuteScalar());
                    return conflictCount > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking for conflicts: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void SetEventId(int id)
        {
            eventId = id;
        }
    }
}
