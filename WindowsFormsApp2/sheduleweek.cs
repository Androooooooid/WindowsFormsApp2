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
    public partial class sheduleweek : UserControl
    {
        public sheduleweek()
        {
            InitializeComponent();
        }

        private void sheduleweek_Load(object sender, EventArgs e)
        {
            sheduleday1.daynameset("Понедельник");
            sheduleday2.daynameset("Вторник");
            sheduleday3.daynameset("Среда");
            sheduleday4.daynameset("Четверг");
            sheduleday5.daynameset("Пятница");
            sheduleday6.daynameset("Суббота");
        }
        public void timeinstail(int time)
        {
            sheduleday1.timeinstail(time);
            sheduleday2.timeinstail(time);
            sheduleday3.timeinstail(time);
            sheduleday4.timeinstail(time);
            sheduleday5.timeinstail(time);
            sheduleday6.timeinstail(time);
        }
    }
}
