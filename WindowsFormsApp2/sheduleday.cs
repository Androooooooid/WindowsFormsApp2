using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class sheduleday : UserControl
    {
        public sheduleday()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void daynameset(string dayname) {
            groupBox1.Text = dayname;
        }
        public void timeinstail(int time)
        {
            if (time == 1)
            {
                paraday1.timeinstail("08:30");
                paraday2.timeinstail("10:15");
                paraday3.timeinstail("12:20");
                paraday4.timeinstail("14:05");
                paraday5.timeinstail("15:50");
            }
            else
            {
                paraday1.timeinstail("17:15");
                paraday2.timeinstail("08:30");
                paraday3.timeinstail("08:30");
                paraday4.timeinstail("08:30");
                paraday5.timeinstail("08:30");
            } 

           
        }

        private void paraday1_Load(object sender, EventArgs e)
        {

        }

        private void paraday4_Load(object sender, EventArgs e)
        {

        }

        private void paraday2_Load(object sender, EventArgs e)
        {

        }

        private void paraday5_Load(object sender, EventArgs e)
        {

        }

        private void paraday3_Load(object sender, EventArgs e)
        {

        }
    }
}
