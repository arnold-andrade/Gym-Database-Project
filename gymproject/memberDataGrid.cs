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
    public partial class memberDataGrid : Form
    {
        MySqlConnection conn;
        DataTable dt;
        DataSet ds;
        DataRow dr;
        MySqlDataAdapter da;
        private string connectionString = "server=localhost;uid=root;password=jerome;database=project";
        public memberDataGrid()
        {
            InitializeComponent();
        }

        private void memberDataGrid_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "select regno,memid,service,duration from membership;";
                    using (MySqlCommand comm = new MySqlCommand(query, connection))
                    {

                        // Create the INSERT query
                        //string query = "select trainerid,name,service from trainer;";
                        comm.CommandText = "select regno,memid,service,duration from membership";
                        ds = new DataSet();
                        da = new MySqlDataAdapter(comm.CommandText, connection);
                        da.Fill(ds, "membership");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
