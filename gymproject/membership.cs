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
    public partial class membership : Form
    {
        public static string membershipTotal = "";
        public static string membershipName = "";
        public membership(int memberRegno)
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // clientprofile frm = new clientprofile();
            //  frm.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (steam.Checked)
            {
                membershipTotal += 500;
                membershipName = "steam and sauna";
            }
            if (swimming.Checked)
            {
                membershipTotal += 600;
                membershipName = "swimming pool";
            }
            if (tennis.Checked)
            {
                membershipTotal += 750;
                membershipName = "tennis";
            }
            if (cricket.Checked)
            {
                membershipTotal += 1000;
                membershipName = "cricket";
            }
            if (basketball.Checked)
            {
                membershipTotal += 1000;
                membershipName = "basketball";
            }
            if (squash.Checked)
            {
                membershipTotal += 750;
                membershipName = "squash";
            }
            if (badminton.Checked)
            {
                membershipTotal += 1250;
                membershipName = "badminton";
            }
            if (gym.Checked)
            {
                membershipTotal += 2000;
                membershipName = "gym";
            }
            if (all.Checked)
            {
                membershipTotal += 3600;
                membershipName = "all facilities";
            }
            MessageBox.Show("Rs" + membershipTotal);
            payment frm = new payment();
            frm.ShowDialog();
        }

        private void membership_Load(object sender, EventArgs e)
        {
            
           
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
