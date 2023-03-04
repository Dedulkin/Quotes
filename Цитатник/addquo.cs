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
    public partial class addquo : Form
    {
        public int ID = 0;
        public addquo(int ID_log)
        {
            InitializeComponent();
            getInfo(ID_log);
            ID = ID_log;
            auth_cB.Items.Add("Я");
            auth_cB.Items.Add("Кто-то, кто не я");
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
                        name_lb.Text = rd.GetString(0);
                    }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void auth_cB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = auth_cB.Items[auth_cB.SelectedIndex].ToString();
            switch (result)
            {
                case "Я":
                    add_btn.Visible = true;
                    break;
                case "Кто-то, кто не я":
                    label3.Visible = true;
                    auth_tB.Visible = true;
                    add_btn.Visible = true;
                    break;
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string result = auth_cB.Items[auth_cB.SelectedIndex].ToString();
                switch (result)
                {
                    case "Я":
                        doAction("insert into author values ((select max(id_author)+1 from (select id_author from author) as t1),'" + name_lb.Text + "');");
                        break;
                    case "Кто-то, кто не я":
                        doAction("insert into author values ((select max(id_author)+1 from (select id_author from author) as t1),'" + auth_tB.Text + "');");
                        break;
                }
                doAction("insert into quote values((select max(id_quo)+1 from (select id_quo from quote) as t1), '" + txt_tB.Text + "', (select max(id_author) from author));");
                MessageBox.Show("Цитата добавлена");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ой-ой, кажется что-то пошло не так! Попробуйте ещё раз или спросите кого-то кто разбирается." + Environment.NewLine + ex.Message);
            }
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
    }
}
