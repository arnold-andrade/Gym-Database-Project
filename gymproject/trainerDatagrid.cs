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
    public partial class trainerDatagrid : Form
    {
        MySqlConnection conn;
        DataTable dt;
        DataSet ds;
        DataRow dr;
        MySqlDataAdapter da;
        private string connectionString = "server=localhost;uid=root;password=jerome;database=project";
        public trainerDatagrid()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void trainerDatagrid_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "select trainerid,name,ph_num,service,salary,password,join_date from trainer;";
                    using (MySqlCommand comm = new MySqlCommand(query, connection))
                    {

                        // Create the INSERT query
                        //string query = "select trainerid,name,service from trainer;";
                        comm.CommandText = "select trainerid,name,ph_num,service,salary,password,join_date from trainer";
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
    }
}
