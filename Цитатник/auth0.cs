using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Цитатник
{
    public partial class auth0 : Form
    {
        public auth0()
        {
            InitializeComponent();
        }

        private void auth0_Load(object sender, EventArgs e)
        {
            auth1 auth1 = new auth1() { TopLevel = false, TopMost = true };
            panel1.Controls.Add(auth1);
            auth1.BringToFront();
            auth1.Show();
        }


        private void reg_lb_Click(object sender, EventArgs e)
        {
            reg reg = new reg() { TopLevel = false, TopMost = true };
            panel1.Controls.Add(reg);
            reg.BringToFront();
            reg.Show();
            label3.Visible = false;
            reg_lb.Visible = false;
            bck_lb.Visible = true;
        }

        private void bck_lb_Click(object sender, EventArgs e)
        {
            auth1 auth1 = new auth1() { TopLevel = false, TopMost = true };
            panel1.Controls.Add(auth1);
            auth1.BringToFront();
            auth1.Show();
            label3.Visible = true;
            reg_lb.Visible = true;
            bck_lb.Visible = false;
        }
    }
}
