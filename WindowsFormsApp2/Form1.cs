using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private MySqlConnection getConn()
        {
            MySqlConnectionStringBuilder mysqlCSB;
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = Settings1.Default.databaseip;
            mysqlCSB.Port = Settings1.Default.Port;
            mysqlCSB.Database = Settings1.Default.Database;
            mysqlCSB.UserID = Settings1.Default.UserID;
            mysqlCSB.Password = Settings1.Default.Password;
            mysqlCSB.CharacterSet = Settings1.Default.CharacterSet;
            return new MySqlConnection(mysqlCSB.ConnectionString);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MySqlConnection connect = getConn();
            bool isok = false;
            try
            {
                connect.Open();
                isok = true;
            }
            catch
            {
                MessageBox.Show("Ошибка подключения к базе данных! Зовите фиксиков!", "Ошибка!", MessageBoxButtons.OK);
                this.Close();
            }

            if (isok)
            {
                Grouplist_update(connect);
                Teacherlist_update(connect);
                Disciplinelist_update(connect);
                Audiencelist_update(connect);
                
            }


        }
        private void Grouplist_update(MySqlConnection connect)
        {
            using (var command = new MySqlCommand("select * from groups ", connect))
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataset = new DataTable();
                adapter.Fill(dataset);
                Grouplist.DataSource = dataset;
                Grouplist.DisplayMember = "group_name";
                Grouplist.ValueMember = "id";

            }

        }

        private void Teacherlist_update(MySqlConnection connect)
        {
            using (var command = new MySqlCommand("select * from teachers ", connect))
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataset = new DataTable();
                adapter.Fill(dataset);
                Teacherlist.DataSource = dataset;
                Teacherlist.DisplayMember = "fio";
                Teacherlist.ValueMember = "id";

            }

        }
        /// <summary>
        /// Обновить список дисциплин
        /// </summary>
        /// <param name="connect">Подключение к базе данных</param>
        private void Disciplinelist_update(MySqlConnection connect)
        {
            using (var command = new MySqlCommand("select * from discipline ", connect))
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataset = new DataTable();
                adapter.Fill(dataset);
                Disciplinelist.DataSource = dataset;
                Disciplinelist.DisplayMember = "name_discipline";
                Disciplinelist.ValueMember = "id";

            }

        }

        private void Audiencelist_update(MySqlConnection connect)
        {
            using (var command = new MySqlCommand("SELECT ID, CONCAT('корпус ', number_housing, ' | ', number_audience) AS name from audience", connect))
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataset = new DataTable();
                adapter.Fill(dataset);
                Audiencelist.DataSource = dataset;
                Audiencelist.DisplayMember = "name";
                Audiencelist.ValueMember = "id";
                
            }

        }

        private void Grouplist_SelectedIndexChanged(object sender, EventArgs e)
        {
            sheduleweek1.timeinstail(1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Disciplinelist_MouseDown(object sender, MouseEventArgs e)
        {
            int index = Disciplinelist.IndexFromPoint(e.X, e.Y);
            string s = ((DataRowView)Disciplinelist.Items[index])["name_discipline"].ToString();
            DragDropEffects dde1 = DoDragDrop(s, DragDropEffects.Copy);
        }

        private void dataGridView1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            label1.Text = (string)e.Data.GetData("fddfdf".GetType());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Audiencelist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
