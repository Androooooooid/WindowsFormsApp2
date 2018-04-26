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
    public partial class paraday : UserControl
    {
        public paraday()
        {
            InitializeComponent();
            
        }

        

        private void paraday_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
      

        }
        public void timeinstail(string time)
        {
            label1.Text = time;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            boxpara dlg1 = new boxpara();
            dlg1.ShowDialog();
            button1.Text = dlg1.output;
            button1.BackColor = Color.Green;
        }

        private void button1_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked) 
            {
                button2.Visible = false;
                button1.Width = 334;
            
            }
            else
            {
                button2.Visible = true;
                button1.Width = 165;
            }
        }
    }
}
