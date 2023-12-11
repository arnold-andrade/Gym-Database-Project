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
    public partial class dataview : Form
    {
        public dataview()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // write select count query for memcount and trainercount label
            // write code to show particular datagrid when either checkbox is selected on clicking button

            if (memdata.Checked)
            {
                memberDataGrid memfrm = new memberDataGrid();
                memfrm.ShowDialog();
            }
            else if (trainerdata.Checked)
            {
                trainerDatagrid trainfrm = new trainerDatagrid();
                trainfrm.ShowDialog();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
