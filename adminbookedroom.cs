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
    public partial class adminbookedroom : UserControl
    {
        public adminbookedroom()
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
                adminviewinfo.rno =x[0];
                adminviewinfo adm = new adminviewinfo();
                adm.ShowDialog();
                loadrooms();
            }
            catch (Exception ee)
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
