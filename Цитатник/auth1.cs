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
    public partial class auth1 : Form
    {
        public auth1()
        {
            InitializeComponent();
        }

        

        private void insert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select id_prof from profile where id_log =(select id_log from log where log_txt ='" + log_tBox.Text + "') and id_pswrd = (select id_pswrd from psswrd where pswrd_txt ='" + pswrd_tBox.Text + "');";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    int result = 0;
                    result = Convert.ToInt32(cmDB.ExecuteScalar());
                    if (result >= 1)
                    {

                        
                        quotes Win = new quotes(result);
                        this.Hide();
                        auth0 auth0 = Application.OpenForms.OfType<auth0>().SingleOrDefault();
                        if (auth0 != null)
                        {
                            auth0.Hide();
                        }
                        Win.Show();

                    }
                    else
                    {
                        MessageBox.Show("Ошибка авторизации! Попробуйте ещё раз!");
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                }
            }
            catch
            {
                MessageBox.Show("Не оставляйте пустые поля!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
