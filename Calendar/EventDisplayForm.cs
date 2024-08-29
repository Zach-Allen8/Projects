using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Calendar
{
    public partial class EventDisplayForm : Form
    {
        // Connection String
        String connString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;password=Maroon@21?;";
        public bool monthlyMode = false;
        public DateTime selectedDate;

        public EventDisplayForm(DateTime selectedDate, bool monthlyMode)
        {
            InitializeComponent();
            this.selectedDate = selectedDate;
            this.monthlyMode = monthlyMode;
        }

        private void EventDisplayForm_Load(object sender, EventArgs e)
        {
            DisplayEvents(selectedDate, monthlyMode);
        }

        private void dayEvents_Click(object sender, EventArgs e)
        {
            monthlyMode = false;
            DisplayEvents(selectedDate, monthlyMode);
        }

        private void monthEvents_Click(object sender, EventArgs e)
        {
            monthlyMode = true;
            DisplayEvents(selectedDate, monthlyMode);
        }

        public void DisplayEvents(DateTime date, bool monthlyMode)
        {
            listView1.Items.Clear(); // Clear existing items
            listView1.Columns.Clear(); // Clear existing columns

            listView1.Columns.Add("Event ID");
            listView1.Columns.Add("Event Name");
            listView1.Columns.Add("Start Time");
            listView1.Columns.Add("End Time");

            // Set column headers
            listView1.View = View.Details;

            // Display grid lines
            listView1.GridLines = true;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    // Select events based on the mode (daily or monthly)
                    string sql;
                    if (monthlyMode)
                    {
                        sql = "SELECT event_id, event_name, start_date, end_date FROM JacJallenIndividual WHERE YEAR(start_date) = @year AND MONTH(start_date) = @month";
                    }
                    else
                    {
                        sql = "SELECT * FROM JacJallenIndividual WHERE DATE(start_date) = @date OR DATE(end_date) = @date OR (DATE(start_date) < @date AND DATE(end_date) > @date)";
                    }

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@year", date.Year);
                    cmd.Parameters.AddWithValue("@month", date.Month);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Assuming you have columns named "event_name" and "start_date" in your database
                            string eventId = reader["event_id"].ToString();
                            string eventName = reader["event_name"].ToString();
                            string startDate = reader["start_date"].ToString();
                            string endDate = reader["end_date"].ToString();

                            // Create a new ListViewItem with event details
                            ListViewItem item = new ListViewItem(eventId);
                            item.SubItems.Add(eventName);
                            item.SubItems.Add(startDate);
                            item.SubItems.Add(endDate);

                            // Add the item to the ListView
                            listView1.Items.Add(item);
                        }
                        foreach (ColumnHeader column in listView1.Columns)
                        {
                            column.Width = -2; // -2 indicates auto-size based on content
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void deleteEvent_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Get the selected item
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Assuming the ID of the event is stored in the first sub-item
                int eventId = int.Parse(selectedItem.SubItems[0].Text);

                // Delete the event from the database
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        conn.Open();
                        string sql = "DELETE FROM JacJallenIndividual WHERE event_id = @eventId";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@eventId", eventId);
                        cmd.ExecuteNonQuery();
                    }

                    // Remove the item from the ListView
                    listView1.Items.Remove(selectedItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an event to delete.", "No Event Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void editEvent_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Get the event details from the selected item
                int eventId = int.Parse(selectedItem.SubItems[0].Text);
                string eventName = selectedItem.SubItems[1].Text;
                DateTime startDate = DateTime.Parse(selectedItem.SubItems[2].Text);
                DateTime endDate = DateTime.Parse(selectedItem.SubItems[3].Text);
         
                // Open the editEvent form for editing
                editEvent editForm = new editEvent();
                editForm.EventId = eventId;
                editForm.EventName = eventName;
                editForm.StartDate = startDate;
                editForm.EndDate = endDate;
                editForm.SetEventId(eventId);
                
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    //maybe delete
                }
            }
            else
            {
                MessageBox.Show("Please select an event to edit.", "No Event Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

    }
}
