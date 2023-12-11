using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class choosetrainer : Form
    {
        MySqlConnection conn;
        DataTable dt;
        DataSet ds;
        DataRow dr;
        MySqlDataAdapter da;
        private string connectionString = "server=localhost;uid=root;password=jerome;database=project";

        public choosetrainer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void choosetrainer_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "select trainerid,name,service from trainer;";
                    using (MySqlCommand comm = new MySqlCommand(query, connection))
                    {

                        // Create the INSERT query
                        //string query = "select trainerid,name,service from trainer;";
                        comm.CommandText = "select trainerid,name,service from trainer";
                        ds = new DataSet();
                        da = new MySqlDataAdapter(comm.CommandText, connection);
                        da.Fill(ds, "trainer");
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
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand("CheckServiceProcedure", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Input parameters
                        cmd.Parameters.AddWithValue("@pTrainerId", textBox1.Text);
                        cmd.Parameters.AddWithValue("@pService", textBox2.Text);

                        // Output parameter
                        cmd.Parameters.Add(new MySqlParameter("@pResult", MySqlDbType.Int32));
                        cmd.Parameters["@pResult"].Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();

                        // Retrieve the output parameter value
                        int result = Convert.ToInt32(cmd.Parameters["@pResult"].Value);

                        // Check if the result is 1
                        if (result == 1)
                        {
                            // Check if memid and service exist in the membership table
                            if (CheckMembership(textBox1.Text, textBox2.Text, connection))
                            {
                                // Insert data into the trains table
                                InsertIntoTrains(textBox1.Text, Form1.clientRegno, textBox2.Text, connection);
                                MessageBox.Show("Data inserted into trains table successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Membership does not exist.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("CheckServiceProcedure returned a result other than 1.");
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        // Assuming you have a method to check membership in the membership table
        private bool CheckMembership(string memId, string service, MySqlConnection connection)
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM membership WHERE memid = @memId AND service = @service", connection))
            {
                cmd.Parameters.AddWithValue("@memId", memId);
                cmd.Parameters.AddWithValue("@service", service);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                // Return true if a record exists, indicating membership exists
                return count > 0;
            }
        }

        // Assuming you have a method to insert into the trains table
        private void InsertIntoTrains(string trainerId, int regno, string service, MySqlConnection connection)
        {
            try
            {
                // Open the connection
                connection.Open();

                // Create a MySqlCommand object with the function call
                using (MySqlCommand cmd = new MySqlCommand("SELECT check_students_count(@trainerID)", connection))
                {
                    cmd.Parameters.AddWithValue("@trainerId", trainerId);
                    // Execute the command and store the result in a variable
                    bool result = Convert.ToBoolean(cmd.ExecuteScalar());

                    // Use the result as needed
                    Console.WriteLine($"Function result: {result}");

                    if (result)
                    {
                        using (MySqlCommand cmd1 = new MySqlCommand("INSERT INTO trains (trainerid, regno, service) VALUES (@trainerId, @regno, @service)", connection))
                        {
                            cmd1.Parameters.AddWithValue("@trainerId", trainerId);
                            cmd1.Parameters.AddWithValue("@regno", regno);
                            cmd1.Parameters.AddWithValue("@service", service);

                            cmd1.ExecuteNonQuery();
                        }
                    }
                    else
                        MessageBox.Show("Trainer is already fully booked. Choose another trainer.");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }


           
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }       
}
