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
    public partial class occasionss : UserControl
    {
        public occasionss()
        {
            InitializeComponent();
            ocdate.Value = DateTime.Now;
            ocstarttime.CustomFormat = "HH:mm";
            ocendtime.CustomFormat = "HH:mm";
            loadoccasion();
        }
        private void loadoccasion()
        {
            listBox1.Items.Clear();
            string[] x = Model.getoccasions();
            int j = Convert.ToInt32(x[0]);
            for(int i=1;i< j; i++)
            {
                listBox1.Items.Add(x[i]);
            }
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(ocname.Text.Length==0 || ocdetail.Text.Length == 0)
            {
                if (ocname.Text.Length == 0 && ocdetail.Text.Length == 0)
                {
                    ocerr.Text = "Fields can not be empty";
                }
                else if (ocname.Text.Length == 0)
                {
                    ocerr.Text = "Occasion name can not be empty";
                }
                else if (ocdetail.Text.Length == 0)
                {
                    ocerr.Text = "Occasion detail not be empty";
                }

            }
            else
            {
                string[] h = ocdate.Value.ToString().Split(' ');
                string[] x = h[0].Split('/');
                string[] hh = DateTime.Now.ToString().Split(' ');
                string[] xx = hh[0].Split('/');
                int xmonth = Convert.ToInt32(x[0]);
                int xday = Convert.ToInt32(x[1]);
                int xyear = Convert.ToInt32(x[2]);
                int xxmonth = Convert.ToInt32(xx[0]);
                int xxday = Convert.ToInt32(xx[1]);
                int xxyear = Convert.ToInt32(xx[2]);
                if (xyear != xxyear)
                {
                    ocerr.Text = "Occasion Can not be set for past year";
                }
                else if(xyear==xxyear && xmonth < xxmonth)
                {
                    ocerr.Text = "Occasion Can not be set for past month";
                }
                else if(xyear == xxyear && xmonth <= xxmonth && xday < xxday)
                {
                    ocerr.Text = "Occasion Can not be set for past day";
                }
                else
                {
                    ocerr.Text = "";
                    string strttime = ocstarttime.Value.Hour.ToString() + ":" + ocstarttime.Value.Minute.ToString();
                    string endtime = ocendtime.Value.Hour.ToString() + ":" + ocendtime.Value.Minute.ToString();
                    Model.regoccasion(ocname.Text,h[0],strttime,endtime,ocdetail.Text);
                    ocdetail.Clear();
                    ocname.Text = "";
                    ocdate.Value = DateTime.Now;
                    loadoccasion();

                }
                //ocerr.Text = xx[0] + ":" + xx[1] + ":" + x[2];

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string[] ocid = listBox1.SelectedItem.ToString().Split(':');
                occasionguest.occid = ocid[0];
                occasionguest oc = new occasionguest();
                oc.ShowDialog();
            }
            catch(Exception ee)
            {
                string d = ee.Message;
            }
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
