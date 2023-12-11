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
    public partial class addinventory : Form
    {
        MySqlConnection conn;
        DataTable dt;
        DataSet ds;
        DataRow dr;
        MySqlDataAdapter da;
        private string connectionString = "server=localhost;uid=root;password=jerome;database=project";
        public addinventory()
        {
            InitializeComponent();
        }

        private void addinventory_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "select equipid,name,manufacturer from inventory;";
                    using (MySqlCommand comm = new MySqlCommand(query, connection))
                    {

                        // Create the INSERT query
                        //string query = "select trainerid,name,service from trainer;";
                        comm.CommandText = "select equipid,name,manufacturer from inventory";
                        ds = new DataSet();
                        da = new MySqlDataAdapter(comm.CommandText, connection);
                        da.Fill(ds, "inventory");
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

                    // Create the INSERT query
                    string query = "INSERT INTO inventory (equipid, name, manufacturer) " +
                                   "VALUES (@equipid, @name, @manufacturer)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Replace these with actual parameter types and lengths from your database schema
                        cmd.Parameters.AddWithValue("@equipid", textBox1.Text);
                        cmd.Parameters.AddWithValue("@name", textBox2.Text);
                        cmd.Parameters.AddWithValue("@manufacturer", textBox3.Text);

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Create the UPDATE query
                    string query = "UPDATE inventory SET name = @name, manufacturer = @manufacturer WHERE equipid = @equipid";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Replace these with actual parameter types and lengths from your database schema
                        cmd.Parameters.AddWithValue("@equipid", textBox1.Text);
                        cmd.Parameters.AddWithValue("@name", textBox2.Text);
                        cmd.Parameters.AddWithValue("@manufacturer", textBox3.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No record found for the specified equipid. Please check your input.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating data in the database: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Create the DELETE query
                    string query = "DELETE FROM inventory WHERE equipid = @equipid";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Replace these with actual parameter types and lengths from your database schema
                        cmd.Parameters.AddWithValue("@equipid", textBox1.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Row deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No record found for the specified equipid. Please check your input.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting data from the database: " + ex.Message);
            }
        }
    }
}
