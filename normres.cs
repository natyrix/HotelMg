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
    public partial class normres : UserControl
    {
        public normres()
        {
            InitializeComponent();
            restime.CustomFormat = "HH:mm";
            loadres();
        }
        private void loadres()
        {
            listBox1.Items.Clear();
            string[] x = Model.getreserv();
            int j = Convert.ToInt32(x[0]);
            for(int i=1;i< j; i++)
            {
                listBox1.Items.Add(x[i]);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = listBox1.SelectedItem.ToString();
            string[] h = x.Split(':');
            addguestres.res_id = h[0];
            addguestres res = new addguestres();
            res.ShowDialog();

        }

        private void normres_Load(object sender, EventArgs e)
        {
            
        }
        private void check(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (noofguest.Text.Length == 0 || reservdet.Text.Length == 0 || tableno.Text.Length==0)
            {
                if (noofguest.Text.Length == 0 && reservdet.Text.Length == 0 && tableno.Text.Length == 0)
                {
                    reserverr.Text = "Fields can not be empty";
                }
                else if (noofguest.Text.Length == 0)
                {
                    reserverr.Text = "Number of guests is required";
                }
                else if (reservdet.Text.Length == 0)
                {
                    reserverr.Text = "Reservation Detail is required";
                }
                else if(tableno.Text.Length == 0)
                {
                    reserverr.Text = "Table Number is required";
                }
            }
            else
            {
                int x = Convert.ToInt32(noofguest.Text);
                if (x < 10)
                {
                    string[] h = reservdate.Value.ToString().Split(' ');
                    string[] x1 = h[0].Split('/');
                    string[] hh = DateTime.Now.ToString().Split(' ');
                    string[] xx = hh[0].Split('/');
                    int xmonth = Convert.ToInt32(x1[0]);
                    int xday = Convert.ToInt32(x1[1]);
                    int xyear = Convert.ToInt32(x1[2]);
                    int xxmonth = Convert.ToInt32(xx[0]);
                    int xxday = Convert.ToInt32(xx[1]);
                    int xxyear = Convert.ToInt32(xx[2]);
                    if (xyear != xxyear)
                    {
                        reserverr.Text = "Occasion Can not be set for past year";
                    }
                    else if (xyear == xxyear && xmonth < xxmonth)
                    {
                        reserverr.Text = "Occasion Can not be set for past month";
                    }
                    else if (xyear == xxyear && xmonth <= xxmonth && xday < xxday)
                    {
                        reserverr.Text = "Occasion Can not be set for past day";
                    }
                    else
                    {
                        reserverr.Text = "";
                        string tim = restime.Value.Hour.ToString();
                        tim += ":" + restime.Value.Minute.ToString();
                        int tnoo = Convert.ToInt32(tableno.Text);
                        Model.regreserv(x, reservdate.Value.ToString(), reservdet.Text, tim, tnoo);
                        reservdet.Clear();
                        reservdate.Value = DateTime.Now;
                        noofguest.Text = "";
                        loadres();
                    }
                    

                }
                else
                {
                    reserverr.Text = "Number of guests can not exceed 10";
                }
            }
        }
    }
}
