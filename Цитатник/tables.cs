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
    public partial class tables : Form
    {
        public int ID = 0;
        public tables(int ID_log)
        {
            InitializeComponent();
            getInfo(ID_log);
            ID = ID_log;
            
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
                        name_lb.Text = rd.GetString(0) ;
                    }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }
        public void DGV(string query, DataGridView dgv)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                sda.Fill(dt);
                dgv.DataSource = dt;
                dgv.ClearSelection();
                dgv.Columns[0].Visible = false; 
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденая ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void tables_Load(object sender, EventArgs e)
        {
            DGV("select id_quo, quo_txt as 'Цитата', (select FIO_auth from author where id_author = quote.id_author) as 'Автор' from quote", quo_DGV);
        }

        private void updt_btn_Click(object sender, EventArgs e)
        {
            DGV("select id_quo, quo_txt as 'Цитата', (select FIO_auth from author where id_author = quote.id_author) as 'Автор' from quote", quo_DGV);
            search_tB.Text = "";
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            DGV("select id_quo, quo_txt as 'Цитата', (select FIO_auth from author where id_author = quote.id_author) as 'Автор' from quote where id_author = (select id_author from author where FIO_auth = '"+search_tB.Text+"')", quo_DGV);
            
        }

        private void tables_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void quo_DGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            doAction("update quote set quo_txt = '" + quo_DGV[1, quo_DGV.CurrentRow.Index].Value.ToString() + "' where id_quo = " + quo_DGV[0, quo_DGV.CurrentRow.Index].Value.ToString() + ";");
            doAction("update author set FIO_auth = '" + quo_DGV[2, quo_DGV.CurrentRow.Index].Value.ToString() + "' where id_author = (select id_author from quote where id_quo = " + quo_DGV[0, quo_DGV.CurrentRow.Index].Value.ToString() + ")");
        }
        public void doAction(string query)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmDB.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошли технические шоколадки!" + Environment.NewLine + ex.Message);
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            addquo addquo = new addquo(ID);
            addquo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            quotes quotes = new quotes(ID);
            this.Hide();
            quotes.Show();
        }

        private void search_tB_TextChanged(object sender, EventArgs e)
        {
            DGV("select id_quo, quo_txt as 'Цитата', (select FIO_auth from author where id_author = quote.id_author) as 'Автор' from quote where id_author = (select id_author from author where FIO_auth like  '%" + search_tB.Text + "%');", quo_DGV);


        }
    }

}
