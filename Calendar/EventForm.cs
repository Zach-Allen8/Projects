using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Calendar
{
    public partial class EventForm : Form
    {
        //Connection String
        String connString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;password=Maroon@21?;";


        public EventForm()
        {
            InitializeComponent();
        }

        //add event
        public void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Parse(txtDate.Text).Date + dateTimePickerStartTime.Value.TimeOfDay;
            DateTime endDate = dateTimePickerEndDate.Value;

            if (endDate < startDate)
            {
                MessageBox.Show("End date cannot be before start date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }

            if (string.IsNullOrWhiteSpace(txtEvent.Text))
            {
                MessageBox.Show("Name can't be left empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            // Check if the table exists, if not, create it
            String tableCheckSql = "CREATE TABLE IF NOT EXISTS JacJallenIndividual (" +
                                   "event_id INT NOT NULL AUTO_INCREMENT, " +
                                   "event_name VARCHAR(255) NOT NULL, " +
                                   "start_date DATETIME NOT NULL, " +
                                   "end_date DATETIME NOT NULL, " +
                                   "PRIMARY KEY (event_id)" +
                                   ")";
            MySqlCommand tableCheckCmd = new MySqlCommand(tableCheckSql, conn);
            tableCheckCmd.ExecuteNonQuery();
            tableCheckCmd.Dispose();

            // Check for event time conflicts
            String conflictCheckSql = "SELECT COUNT(*) FROM JacJallenIndividual WHERE (start_date <= @endDate) AND (end_date >= @startDate)";
            MySqlCommand conflictCheckCmd = new MySqlCommand(conflictCheckSql, conn);
            conflictCheckCmd.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd HH:mm:ss"));
            conflictCheckCmd.Parameters.AddWithValue("@endDate", endDate.ToString("yyyy-MM-dd HH:mm:ss"));
            int conflictCount = Convert.ToInt32(conflictCheckCmd.ExecuteScalar());

            conflictCheckCmd.Dispose();

            if (conflictCount > 0)
            {
                MessageBox.Show("Event time conflicts with existing event(s)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return; // Exit the method
            }

            // No conflicts, proceed with adding the event
            String sql = "INSERT INTO JacJallenIndividual (event_name, start_date, end_date) VALUES (@eventName, @startDate, @endDate)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@eventName", txtEvent.Text);
            cmd.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@endDate", endDate.ToString("yyyy-MM-dd HH:mm:ss"));

            cmd.ExecuteNonQuery();
            MessageBox.Show("Event has been saved.", "Alert");
            cmd.Dispose();
            conn.Close();
        }


        private void EventForm_Load(object sender, EventArgs e)
        {
            //Call static vairables
            txtDate.Text = Form1.static_month + "/" + UserControlDays.static_day + "/" + Form1.static_year;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
