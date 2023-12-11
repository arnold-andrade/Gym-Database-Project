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
    public partial class adminviewfeedback : Form
    {
        MySqlConnection conn;
        DataTable dt;
        DataSet ds;
        DataRow dr;
        MySqlDataAdapter da;
        private string connectionString = "server=localhost;uid=root;password=jerome;database=project";
        public adminviewfeedback()
        {
            InitializeComponent();
        }

        private void adminviewfeedback_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Use a parameterized query to prevent SQL injection
                    string query = "SELECT * FROM feedback ORDER BY trainerid";
                    using (MySqlCommand comm = new MySqlCommand(query, connection))
                    {
                        // Use the existing DataAdapter and DataSet
                        ds = new DataSet();
                        da = new MySqlDataAdapter(comm);
                        da.Fill(ds, "feedback");

                        dataGridView1.DataSource = ds.Tables["feedback"];
                    }

                    // No need to explicitly close the connection; using statement takes care of it
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving data from the database: " + ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
