using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymproject
{
    
    public partial class Form1 : Form
    {
        public static string clientName = "";
        public static string clientPhoneno = "";
        public static int clientRegno=0;
        public static string clientAddress = "";
        public static string clientEmail = "";
        public static string clientMembership = "";

        public static string TrainerName;
        public static int TrainerID;
        public static int TrainerSalary;
        public static string TrainerPhoneno;
        public static string TrainerService;
        public static string TrainerPassword;
        public static string TrainerDate;

        public static string AdminName;
        public static int AdminID;
        public static string AdminPhoneno;
        public static string Adminemail;
        public static string AdminPassword;



        private string connectionString = "server=localhost;uid=root;password=jerome;database=project";
        public Form1()
        {
            InitializeComponent();
            Password.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredRegno = regno.Text;
            clientRegno = int.Parse(enteredRegno);
            string enteredPassword = Password.Text;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to retrieve username and password from the 'admins' table
                    string member_login = "SELECT * FROM reg_client";
                    string trainer_login = "SELECT * FROM trainer";
                    string admin_login = "SELECT * FROM admin";

                    if (Member.Checked)
                    {
                        using (MySqlCommand cmd = new MySqlCommand(member_login, connection))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                bool flag=false;
                                while (reader.Read())
                                {
                                    string storedRegno = reader["regno"].ToString();
                                    string storedPassword = reader["password"].ToString();
                                    if (enteredRegno == storedRegno && enteredPassword == storedPassword)
                                    {

                                        clientName = reader["name"].ToString();
                                        clientRegno = int.Parse(reader["regno"].ToString());
                                        clientPhoneno = reader["ph_num"].ToString();
                                        clientAddress = reader["address"].ToString();
                                        clientEmail = reader["gmail"].ToString();
                                        clientMembership = reader["regno"].ToString();

                                        clientprofile frm = new clientprofile();
                                        frm.ShowDialog();
                                        flag= true;
                                    }
                                }
                                if (!flag)
                                {
                                    MessageBox.Show("Wrong Username/password");

                                }
                            }
                        }
                        
                    }
                    else if (Trainer.Checked)
                    {
                        using (MySqlCommand cmd = new MySqlCommand(trainer_login, connection))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                bool flag = false;
                                while (reader.Read())
                                {
                                    string storedRegno = reader["trainerid"].ToString();
                                    string storedPassword = reader["password"].ToString();
                                    if (enteredRegno == storedRegno && enteredPassword == storedPassword)
                                    {   
                                        TrainerName = reader["name"].ToString();
                                        TrainerID = int.Parse(reader["trainerid"].ToString());
                                        TrainerSalary = int.Parse(reader["salary"].ToString());
                                        TrainerPhoneno = reader["ph_num"].ToString();
                                        TrainerService = reader["service"].ToString();
                                        TrainerPassword = reader["password"].ToString();
                                        TrainerDate = reader["join_date"].ToString();

                                        trainerprofile t_frm = new trainerprofile();
                                        t_frm.ShowDialog();
                                        flag = true;
                                    }
                                }
                                if (!flag)
                                {
                                    MessageBox.Show("wrong Username/password");

                                }
                            }
                        }

                    }
                    else if (Admin.Checked)
                    {
                        using (MySqlCommand cmd = new MySqlCommand(admin_login, connection))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                bool flag = false;
                                while (reader.Read())
                                {
                                    string storedRegno = reader["adminid"].ToString();
                                    string storedPassword = reader["password"].ToString();
                                    if (enteredRegno == storedRegno && enteredPassword == storedPassword)
                                    {
                                        AdminName = reader["name"].ToString();
                                        AdminID = int.Parse(reader["adminid"].ToString());
                                        AdminPhoneno = reader["ph_num"].ToString();
                                        Adminemail = reader["email"].ToString();
                                        AdminPassword = reader["password"].ToString();

                                        adminprofile a_frm = new adminprofile();
                                        a_frm.ShowDialog();
                                        flag = true;
                                    }
                                }
                                if (!flag)
                                {
                                    MessageBox.Show("Invalid username or password");

                                }
                            }
                        }
                    }
                    

                    // Check if the entered credentials are correct

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching data from the database: " + ex.Message);
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            createaccount frm = new createaccount();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
