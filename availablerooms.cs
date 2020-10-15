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
    public partial class availablerooms : UserControl
    {
        public availablerooms()
        {
            InitializeComponent();
            Loadrooms();
        }
        private void Loadrooms()
        {
            listBox1.Items.Clear();
            string[] x = Model.getRooms();
            int i = Convert.ToInt32(x[0]);
            for(int j=1;j< i; j++)
            {
                listBox1.Items.Add(x[j]);
            }

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bookguest.rno = listBox1.SelectedItem.ToString();
                bookguest bg = new bookguest();
                bg.ShowDialog();
                Loadrooms();
            }
            catch(Exception ee)
            {
                string p = ee.Message;   
            }
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Loadrooms();
        }
    }
}
