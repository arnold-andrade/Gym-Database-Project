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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace gymproject
{
    public partial class trainerprofile : Form
    {
        public trainerprofile()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void trainerprofile_Load(object sender, EventArgs e)
        {
            Tname.Text = Form1.TrainerName;
            Tid.Text = Form1.TrainerID.ToString();
            Tsalary.Text = Form1.TrainerSalary.ToString();
            Tphnno.Text = Form1.TrainerPhoneno.ToString();
            Tservice.Text = Form1.TrainerService;
            Tdate.Text = Form1.TrainerDate.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportdamage rd = new reportdamage();
            rd.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            leaverequest lr = new leaverequest();
            lr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
              //  Form1 frm = new Form1();
               // frm.Show();
               this.Hide();
            }
        }

        private void checkfeedback_Click(object sender, EventArgs e)
        {
           viewfeedback frm = new viewfeedback();
           frm.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
