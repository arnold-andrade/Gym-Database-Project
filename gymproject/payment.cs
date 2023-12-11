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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace gymproject
{
    public partial class payment : Form
    {
        public static string MemberName, MemberAddress, MemberEmail, MemberDuration, MemberService, MemberPhnno;
        public static int MemberRegno;
        public static int Memberid;
        private string connectionString = "server=localhost;uid=root;password=jerome;database=project";
        public payment()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           //membership frm = new membership();
           //frm.Show();
           this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(card.Checked || upi.Checked)
            {   
                DialogResult res = MessageBox.Show("Payment Successful", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    DialogResult res2 = MessageBox.Show("Do you want to choose a trainer?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (res == DialogResult.OK)
                    {
                        choosetrainer frm = new choosetrainer();
                        frm.Show();
                    }
                    if (res == DialogResult.Cancel)
                    {
                        clientprofile frm = new clientprofile();
                        frm.Show();
                    }
                }

                MemberName = Form1.clientName;
                MemberRegno = Form1.clientRegno;
                MemberPhnno = Form1.clientPhoneno;
                MemberAddress = Form1.clientAddress;
                MemberEmail = Form1.clientEmail;
                MemberDuration = "1 Month";
                MemberService = membership.membershipName;
                Memberid++;
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string getMaxIdQuery = "SELECT MAX(memid) FROM membership";
                        using (MySqlCommand getMaxIdCmd = new MySqlCommand(getMaxIdQuery, connection))
                        {
                            object maxIdObj = getMaxIdCmd.ExecuteScalar();

                            if (maxIdObj != DBNull.Value)
                            {
                                Memberid = Convert.ToInt32(maxIdObj) + 1;
                            }
                            else
                            {
                                Memberid = 1;  // If the table is empty, start from 1
                            }
                        }

                        // Create the INSERT query
                        string query = "INSERT INTO membership (regno, memid, service, duration) " +
                                       "VALUES (@regno, @memid, @service, @duration)";

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            // Replace these with actual parameter types and lengths from your database schema
                            cmd.Parameters.AddWithValue("@regno", MemberRegno);
                            cmd.Parameters.AddWithValue("@memid", Memberid);
                            cmd.Parameters.AddWithValue("@service", MemberService);
                            cmd.Parameters.AddWithValue("@duration", MemberDuration);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                               // MessageBox.Show("Data inserted successfully!");
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
            
            
           
        }

        private void payment_Load(object sender, EventArgs e)
        {

        }
    }
}