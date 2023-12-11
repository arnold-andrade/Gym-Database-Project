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
    public partial class clientprofile : Form
    {   
        private string connectionString = "server=localhost;uid=root;password=jerome;database=project";
        public clientprofile()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
               
               // Form1 frm = new Form1();
                //frm.Show();
                this.Hide();


            }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            membership frm = new membership(Form1.clientRegno);
            frm.ShowDialog();
        }

        private void clientprofile_Load(object sender, EventArgs e)
        {
            name.Text = Form1.clientName;
            regno.Text = Form1.clientRegno.ToString();
            phnno.Text = Form1.clientPhoneno.ToString();
            address.Text = Form1.clientAddress;
            email.Text = Form1.clientEmail;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            uploadfeedback frm = new uploadfeedback();
            frm.ShowDialog();
        }
    }
}
