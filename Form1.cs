using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMg
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loggg_Click(object sender, EventArgs e)
        {
            string username = uname.Text.Trim();
            string password = pass.Text.Trim();
            if (username.Length == 0 || password.Length == 0)
            {
                if (username.Length == 0)
                {
                    errr.Text = "Username is required";
                    return;
                }
                if (password.Length == 0)
                {
                    errr.Text = "Password is required";
                    return;
                }
            }
            else
            {
                string yy = Model.checkuname(username, password);
                if (yy==null)
                {
                    errr.Text = null;
                    string title = Model.CheckTitle(username);
                    if (title.Equals("Admin"))
                    {
                        Admin ad = new Admin();
                        ad.Show();
                        this.Hide();
                    }
                    if (title.Equals("Frontoffice"))
                    {
                        Reception.rec_name = username;
                        Reception rec = new Reception();
                        rec.Show();
                        this.Hide();
                    }
                    if (title.Equals("Waiter"))
                    {
                        Waiter w = new Waiter();
                        w.Show();
                        this.Hide();
                    }
                    if (title.Equals("Security"))
                    {
                        Security sec = new Security();
                        this.Hide();
                        sec.Show();
                    }
                }
                else
                {
                    errr.Text = yy;
                }
            }
        }
    }
}
