using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymproject
{
    public partial class uploadfeedback : Form
    {
        private string connectionString = "server=localhost;uid=root;password=jerome;database=project";
        public uploadfeedback()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            clientprofile frm = new clientprofile();
            frm.ShowDialog();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Feedback Submitted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                DialogResult res1 = MessageBox.Show("Upload another feedback?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    if(textBox1.Text != null && richTextBox1.Text != null)
                    {
                        try
                        {
                           
                            using (MySqlConnection connection = new MySqlConnection(connectionString))
                            {
                                connection.Open();

                                // Create the INSERT query
                                string query = "INSERT INTO feedback (regno , trainerid , feedback) " +
                                               "VALUES (@regno, @trainerid, @m_description)";

                                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                                {
                                    // Replace these with actual parameter types and lengths from your database schema
                                    cmd.Parameters.AddWithValue("@regno", Form1.clientRegno);
                                    cmd.Parameters.AddWithValue("@trainerid", textBox1.Text);
                                    cmd.Parameters.AddWithValue("@m_description", richTextBox1.Text);

                                    int rowsAffected = cmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Data inserted successfully!");
                                        uploadfeedback frm2 = new uploadfeedback();
                                        frm2.ShowDialog();
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
                    uploadfeedback frm = new uploadfeedback();
                    frm.ShowDialog();
                }
                if (res1 == DialogResult.Cancel)
                {
                    clientprofile frm = new clientprofile();
                    frm.ShowDialog();
                }
            }
        }

        private void uploadfeedback_Load(object sender, EventArgs e)
        {

        }
    }
}
