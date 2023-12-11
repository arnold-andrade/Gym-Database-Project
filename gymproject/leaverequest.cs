using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymproject
{


    public partial class leaverequest : Form
    {
        public static string lreq_startdate;
        public static string lreq_enddate;
        public static string lreq_reason;
        public static int lreq_trainerid;

        public static DateTime mystartDate;
        public static DateTime myendDate;

        public static int lreq_id;

        private string connectionString = "server=localhost;uid=root;password=jerome;database=project";
        public leaverequest()
        {
            InitializeComponent();
            lreq_id = GetNextLeaveId();
        }

        private int GetNextLeaveId()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Create a query to retrieve the maximum lreq_id
                    string maxLeaveIdQuery = "SELECT MAX(leaveid) FROM leave_request";

                    using (MySqlCommand maxIdCmd = new MySqlCommand(maxLeaveIdQuery, connection))
                    {
                        object result = maxIdCmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result) + 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching the next leave ID: " + ex.Message);
            }

            return 1; // Default to 1 if there's an error
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            lreq_id++;
            lreq_trainerid = Form1.TrainerID;
            //lreq_startdate = startcalendar.SelectionStart.ToShortDateString();
            //DateTime mystartDate = DateTime.ParseExact(lreq_startdate, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            //lreq_enddate = endcalendar.SelectionStart.ToShortDateString();
            //DateTime myendDate = DateTime.ParseExact(lreq_enddate, "MM-dd-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            mystartDate = startcalendar.SelectionStart;
            myendDate = endcalendar.SelectionStart;
            lreq_reason = leave_reason.Text;


            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Create the INSERT query
                    string query = "INSERT INTO leave_request (leaveid , trainerid, sdate, edate, reason) " +
                                   "VALUES (@lreq_id, @lreq_trainerid, @mystartDate, @myendDate, @lreq_reason)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Replace these with actual parameter types and lengths from your database schema
                        cmd.Parameters.AddWithValue("@lreq_id", lreq_id);
                        cmd.Parameters.AddWithValue("@lreq_trainerid", lreq_trainerid);
                        cmd.Parameters.AddWithValue("@mystartDate", mystartDate);
                        cmd.Parameters.AddWithValue("@myendDate", myendDate);
                        cmd.Parameters.AddWithValue("@lreq_reason", lreq_reason);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert data. Please check your input.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting data into the database: " + ex.Message);
            }


            trainerprofile t_frm = new trainerprofile();
            t_frm.ShowDialog();
        }


        private void Back_Click(object sender, EventArgs e)
        {
            //trainerprofile t_frm = new trainerprofile();
            //t_frm.ShowDialog();
            this.Close();
        }

        private void leaverequest_Load(object sender, EventArgs e)
        {

        }
    }
}
