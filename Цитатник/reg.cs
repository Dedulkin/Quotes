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
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            try
            {
                doAction("insert into log values((select max(id_log)+1 from (select id_log from log) as t1),'" + log_tB.Text + "');");
                doAction("insert into psswrd values((select max(id_pswrd)+1 from (select id_pswrd from psswrd) as t1),'" + pswrd_tB.Text + "');");
                doAction("insert into profile values((select max(id_prof)+1 from (select id_prof from profile) as t1), '" + user_tB.Text + "', (select max(id_pswrd) from psswrd), (select max(id_log) from log));");
                MessageBox.Show("Добавлен новый аккаунт. Возращайтесь и авторизируйтесь.");
            }
            catch 
            {
                MessageBox.Show("При создании аккаунта возникла ошибка попробуйте ещё раз!");
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
