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
    public partial class viewfeedback : Form
    {
        MySqlConnection conn;
        DataTable dt;
        DataSet ds;
        DataRow dr;
        MySqlDataAdapter da;
        private string connectionString = "server=localhost;uid=root;password=jerome;database=project";
        public viewfeedback()
        {
            InitializeComponent();
        }

        private void viewfeedback_Load(object sender, EventArgs e)
        {
            
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Use a parameterized query to prevent SQL injection
                    string query = "SELECT trainerid, regno, feedback FROM feedback WHERE trainerid = @TrainerID";
                    using (MySqlCommand comm = new MySqlCommand(query, connection))
                    {
                        // Use the ID of the currently logged-in trainer
                        comm.Parameters.AddWithValue("@TrainerID", Form1.TrainerID);

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
    }
}
