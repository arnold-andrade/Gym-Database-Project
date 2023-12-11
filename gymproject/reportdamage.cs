using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace gymproject
{
    public partial class reportdamage : Form
    {
        public static int E_Id;
        public static int T_id;
        public static string E_description = "";
        private string connectionString = "server=localhost;uid=root;password=jerome;database=project";
        public reportdamage()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            T_id = Form1.TrainerID;
            E_Id = int.Parse(equipID.Text);
            E_description = description.Text;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Create the INSERT query
                    string query = "INSERT INTO damage (trainerid , equipid , description) " +
                                   "VALUES (@T_id, @E_Id, @E_description)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Replace these with actual parameter types and lengths from your database schema
                        cmd.Parameters.AddWithValue("@T_id", T_id);
                        cmd.Parameters.AddWithValue("@E_Id", E_Id);
                        cmd.Parameters.AddWithValue("@E_description", E_description);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully!");
                            trainerprofile t_frm = new trainerprofile();
                            t_frm.ShowDialog();
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

            //Form1 frm = new Form1();
            //frm.ShowDialog();
        }

        private void reportdamage_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
