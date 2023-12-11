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
    public partial class adminprofile : Form
    {
        public adminprofile()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void adminprofile_Load(object sender, EventArgs e)
        {
            Aname.Text = Form1.AdminName;
            Aid.Text = Form1.AdminID.ToString();
            Aphnno.Text = Form1.AdminPhoneno;
            Aemail.Text = Form1.Adminemail;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addinventory frm = new addinventory();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            approveleave frm = new approveleave();
            frm.ShowDialog();
        }

        private void buyMembershipButton_Click(object sender, EventArgs e)
        {
            viewdamage frm1 = new viewdamage();
            frm1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminviewfeedback frm = new adminviewfeedback();
            frm.ShowDialog();   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataview frm = new dataview();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
