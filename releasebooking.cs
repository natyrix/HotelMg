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
    public partial class releasebooking : Form
    {
        public static string rno;
        int guest_id;
        int reciept_id;
        public releasebooking()
        {
            InitializeComponent();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            roommno.Text = rno;
            getids();
            loadguestInfo();
            loadrecieptInfo();
        }
        private void loadguestInfo()
        {
            string[] x = Model.getGuestInfo(guest_id);
            foreach (string y in x)
            {
                listBox1.Items.Add(y);
            }
        }
        private void loadrecieptInfo()
        {
            string[] x = Model.getRecieptInfo(reciept_id);
            foreach (string y in x)
            {
                listBox2.Items.Add(y);
            }
        }
        private void getids()
        {
            string x = Model.getguestidandrecid(Convert.ToInt32(roommno.Text));
            string[] y = x.Split(':');
            guest_id = Convert.ToInt32(y[0]);
            reciept_id = Convert.ToInt32(y[1]);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string datte = DateTime.Now.ToString();
            Model.releasebooking(Convert.ToInt32(roommno.Text), guest_id, reciept_id, datte);
            Model.delfrombooked(Convert.ToInt32(roommno.Text));
            this.Close();
        }
    }
}
