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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            panel4.Height = home1.Height;
            panel4.Top = home1.Top;
            //mennu.ForeColor = Color.Wheat;
            homepage1.BringToFront();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();

        }

        private void home_Click(object sender, EventArgs e)
        {
            mennu.Text = "Home";
            panel4.Height = home1.Height;
            panel4.Top = home1.Top;
            homepage1.BringToFront();
            
        }

        private void Room_Click(object sender, EventArgs e)
        {
            mennu.Text = "Rooms";
            panel4.Height = room1.Height;
            panel4.Top = room1.Top;
            room11.BringToFront();
        }

        private void users_Click(object sender, EventArgs e)
        {
            mennu.Text = "Users";
            panel4.Height = userss.Height;
            panel4.Top = userss.Top;
            users1.BringToFront();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel4.Height = bdrooms.Height;
            panel4.Top = bdrooms.Top;
            adminbookedroom1.BringToFront();

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            panel4.Top = searbtn.Top;
            panel4.Height = searbtn.Height;
            searchguest1.BringToFront();
        }

        private void bunifuFlatButton1_Click_2(object sender, EventArgs e)
        {
            panel4.Height = normreser.Height;
            panel4.Top = normreser.Top;
            normres1.BringToFront();
        }

        private void bunifuFlatButton1_Click_3(object sender, EventArgs e)
        {
            panel4.Top = occa.Top;
            panel4.Height = occa.Height;
            occasionss1.BringToFront();
        }
    }
}
