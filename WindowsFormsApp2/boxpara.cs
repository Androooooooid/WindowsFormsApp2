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
    public partial class boxpara : Form
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
        public boxpara()
        {
            InitializeComponent();

        }

        public string output = "0";

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

        private void Disciplinelist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void boxpara_Load(object sender, EventArgs e)
        {
             Disciplinelist_update(getConn());
        }

        private void Disciplinelist_DoubleClick(object sender, EventArgs e)
        {
            output = ((DataRowView)Disciplinelist.SelectedItem)["name_discipline"].ToString();
            this.Close();
        }
    }
}
