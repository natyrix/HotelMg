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
    public partial class Waiter : Form
    {
        public Waiter()
        {
            InitializeComponent();
            loadres();
        }
        private void loadres()
        {
            listBox1.Items.Clear();
            string[] x = Model.getreserv1();
            int j = Convert.ToInt32(x[0]);
            if (j != 1)
            {
                for (int i = 1; i < j; i++)
                {
                    listBox1.Items.Add(x[i]);
                }
            }
            else
            {
                listBox1.Items.Add("No reservation for this date");
            }
            
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string xx = listBox1.SelectedItem.ToString();
            string[] h = xx.Split(':');
            int res = Convert.ToInt32(h[0]);
            int[] x = Model.getguestidfromres(res);
            for (int i = 1; i < x[0]; i++)
            {
                string[] info = Model.getGuestInfo(x[i]);
                listBox2.Items.Add(string.Format("{0} \t {1} \t{2} \t {3} \t ", info[0], info[1], info[2], info[3]));

            }
        }
    }
}
