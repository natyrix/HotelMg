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
    public partial class Reception : Form
    {
        string[] h = DateTime.Now.ToString().Split(' ');
        public static string rec_name;
        public Reception()
        {
            InitializeComponent();
            panel3.Top = available.Top;
            panel3.Height = available.Height;
            availablerooms1.BringToFront();
            todaydate.Text =h[0];
            recuname.Text = rec_name;
            bookguest.rec_name = rec_name;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel3.Top = available.Top;
            panel3.Height = available.Height;
            availablerooms1.BringToFront();
        }

        private void booked_Click(object sender, EventArgs e)
        {
            bookguest.rec_name = rec_name;
            panel3.Top = booked.Top;
            panel3.Height = booked.Height;
            bookedrooms1.BringToFront();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            panel3.Top = serguest.Top;
            panel3.Height = serguest.Height;
            searchguest1.BringToFront();
        }
    }
}
