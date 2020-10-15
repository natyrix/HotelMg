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
    public partial class bookedrooms : UserControl
    {
        public bookedrooms()
        {
            InitializeComponent();
            loadrooms();
        }
        private void loadrooms()
        {
            listBox1.Items.Clear();
            string[] x = Model.getBookedRooms();
            int i = Convert.ToInt32(x[0]);
            for (int j = 1; j < i; j++)
            {
                listBox1.Items.Add(x[j]);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] x = listBox1.SelectedItem.ToString().Split(':');
                releasebooking.rno = x[0];
                releasebooking rl = new releasebooking();
                rl.ShowDialog();
                loadrooms();
            }
            catch(Exception ee)
            {
                string x = ee.Message;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            loadrooms();
        }
    }
}
