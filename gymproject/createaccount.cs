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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gymproject
{
    public partial class createaccount : Form
    {
        public static string enteredRegnoText;
        public static string enteredName;
        public static string enteredPhNum;
        public static string enteredAddress;
        public static string enteredGmail;
        public static string enteredPassword;
        private string connectionString = "server=localhost;uid=root;password=jerome;database=project";
        public createaccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            enteredRegnoText = regno.Text;
            enteredName = name.Text;
            enteredPhNum = contactno.Text;
            enteredAddress = address.Text;
            enteredGmail = emailid.Text;
            enteredPassword = confirmPassword.Text;
            try
            {   if ((enteredPhNum.Length==10)&& (enteredName!=null)&& (enteredRegnoText != null) && (enteredGmail.Contains("@"))){
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Create the INSERT query
                        string query = "INSERT INTO reg_client (regno, name, ph_num, address, gmail, password) " +
                                       "VALUES (@regno, @name, @ph_num, @address, @gmail, @password)";

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            // Replace these with actual parameter types and lengths from your database schema
                            cmd.Parameters.AddWithValue("@regno", enteredRegnoText);
                            cmd.Parameters.AddWithValue("@name", enteredName);
                            cmd.Parameters.AddWithValue("@ph_num", enteredPhNum);
                            cmd.Parameters.AddWithValue("@address", enteredAddress);
                            cmd.Parameters.AddWithValue("@gmail", enteredGmail);
                            cmd.Parameters.AddWithValue("@password", enteredPassword);

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
                else
                {
                    MessageBox.Show("Fields cannot be empty");
                }
            }
               
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting data into the database: " + ex.Message);
            }

            Form1 frm = new Form1();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createaccount_Load(object sender, EventArgs e)
        {

        }
    }
}
