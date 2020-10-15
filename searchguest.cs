using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMg
{
    public partial class searchguest : UserControl
    {
        public searchguest()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (nameonlyname.Text.Length == 0)
            {
                dateandnameerr.Text = "";
                nameonlyerr.Text = "Name required";
            }
            else
            {
                nameonlyerr.Text = "";
                string[] x = Model.searchGuest(nameonlyname.Text);
                if (x != null)
                {
                    searcherr.Text = "";
                    listBox1.Items.Clear();
                    int j = Convert.ToInt32(x[0]);
                    for(int i=1;i< j; i++)
                    {
                        listBox1.Items.Add(x[i]);
                    }
                }
                else
                {
                    listBox1.Items.Clear();
                    searcherr.Text = "No Guest Found By name: " + nameonlyname.Text;
                }

            }
        }
        private void check1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (dateandname.Text.Length == 0)
            {
                dateandnameerr.Text = "Name required";
                nameonlyerr.Text = "";
            }
            else
            {
                string[] datte = datedate.Value.ToString().Split(' ');
                dateandnameerr.Text = "";
                string[] x = Model.searchguestbydate(dateandname.Text,datte[0]);
                if (x != null)
                {
                    searcherr.Text = "";
                    listBox1.Items.Clear();
                    int j = Convert.ToInt32(x[0]);
                    for (int i = 1; i < j; i++)
                    {
                        listBox1.Items.Add(x[i]);
                    }
                }
                else
                {
                    listBox1.Items.Clear();
                    searcherr.Text = "No Guest Found By name: " + dateandname.Text;
                }

            }
        }
    }
}
