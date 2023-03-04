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

namespace Цитатник
{
    public partial class quotes : Form
    {
        public int ID = 0;
        public quotes(int ID_log)
        {
            InitializeComponent();
            getInfo(ID_log);
            ID = ID_log;
        }

        private void quotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void quotes_Load(object sender, EventArgs e)
        {
            label("select max(id_quo) from quote",num_lb); 
            int mxdb = Int32.Parse(num_lb.Text)+1;
            Random random = new Random();
            int i = random.Next(1, mxdb);
            label("select quo_txt from quote where id_quo = "+i+";",quo_lb);
            label("select FIO_auth from author where id_author = (select id_author from quote where quo_txt = '"+ quo_lb.Text+ "');", authr_lb);
        }
        public void label(string query, Label label)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        label.Text = rd.GetString(0);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка загрузкb!" + Environment.NewLine + ex.Message);
            }
        }
       
        private void chng_btn_Click(object sender, EventArgs e)
        {
            label("select max(id_quo) from quote", num_lb);
            int mxdb = Int32.Parse(num_lb.Text) + 1;
            Random random = new Random();
            int i = random.Next(1, mxdb);
            label("select quo_txt from quote where id_quo = " + i + ";", quo_lb);
            label("select FIO_auth from author where id_author = (select id_author from quote where quo_txt = '" + quo_lb.Text + "');", authr_lb);
        }

        private void table_btn_Click(object sender, EventArgs e)
        {
            tables tables = new tables(ID);
            this.Hide();
            tables.Show();
        }
        public void getInfo(int ID)
        {
            string query = "select user from profile where id_prof=" + ID + ";";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                    while (rd.Read())
                    {
                        greet_lb.Text = "Добро пожаловать, " + rd.GetString(0) + "!";
                        
                    }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            auth0 auth0 = new auth0();
            this.Hide();
            auth0.Show();
        }
    }
}
