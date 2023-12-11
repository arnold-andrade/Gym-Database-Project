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
    public partial class approveleave : Form
    {
        public static string enteredleaveID;
        public static string enteredtrainerID;
        MySqlConnection conn;
        DataTable dt;
        DataSet ds;
        DataRow dr;
        MySqlDataAdapter da;
        private string connectionString = "server=localhost;uid=root;password=jerome;database=project";
        public approveleave()
        {
            InitializeComponent();
        }

        private void approveleave_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "select * from leave_request";
                    using (MySqlCommand comm = new MySqlCommand(query, connection))
                    {

                        // Create the INSERT query
                        //string query = "select trainerid,name,service from trainer;";
                        comm.CommandText = "select * from leave_request";
                        ds = new DataSet();
                        da = new MySqlDataAdapter(comm.CommandText, connection);
                        da.Fill(ds, "leave_request");
                        dataGridView1.DataSource = ds.Tables[0];
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting data into the database: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enteredleaveID = textBox1.Text;
            enteredtrainerID = textBox2.Text;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Create the INSERT query
                    string query = "INSERT INTO approves (adminid, trainerid, leaveid, status) " +
                                   "VALUES (@adminid, @trainerid, @leaveid, @status)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Replace these with actual parameter types and lengths from your database schema
                        cmd.Parameters.AddWithValue("@adminid", Form1.AdminID);
                        cmd.Parameters.AddWithValue("@trainerid", enteredtrainerID);
                        cmd.Parameters.AddWithValue("@leaveid", enteredleaveID); // Assuming enteredLeaveID is correct
                        cmd.Parameters.AddWithValue("@status", "Approved"); // Set the status as needed

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Leave request approved!");
                        }
                        else
                        {
                            MessageBox.Show("Failed. Please check your input.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            enteredleaveID = textBox1.Text;
            enteredtrainerID = textBox2.Text;


            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Create the INSERT query
                    string query = "INSERT INTO approves (adminid, trainerid, leaveid, status) " +
                                   "VALUES (@adminid, @trainerid, @leaveid, @status)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Replace these with actual parameter types and lengths from your database schema
                        cmd.Parameters.AddWithValue("@adminid", Form1.AdminID);
                        cmd.Parameters.AddWithValue("@trainerid", enteredtrainerID);
                        cmd.Parameters.AddWithValue("@leaveid", enteredleaveID); // Assuming enteredLeaveID is correct
                        cmd.Parameters.AddWithValue("@status", "Rejected"); // Set the status as needed

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Leave request rejected!");
                        }
                        else
                        {
                            MessageBox.Show("Failed. Please check your input.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}

   
