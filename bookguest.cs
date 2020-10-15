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
    
    public partial class bookguest : Form
    {
        public static string rno;
        public static string rtype;
        public static string rprice;
        public int g = 0;
        string[] rec = new string[6];
        string h;
        string name;
        float pri,tax, ma;
        int reciept_id = 0;
        public static string rec_name;
        public bookguest()
        {
            InitializeComponent();
            string[] x = rno.Split(':');
            roomno.Text = x[0];
            roomtype.Text = x[1];
            price.Text = x[2];
            guesterr.Text = rec_name;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void check(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
            this.Close();
        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bookguest_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (guestfname.Text.Length == 0 || guestlname.Text.Length==0||guestpno.Text.Length==0||guestaddress.Text.Length==0)
            {
                if(guestfname.Text.Length == 0 && guestlname.Text.Length == 0 && guestpno.Text.Length == 0 && guestaddress.Text.Length == 0)
                {
                    guesterr.Text = "Fields Cannot be empty";
                }
                else if (guestfname.Text.Length == 0)
                {
                    guesterr.Text = "Firstname Required";
                }
                else if (guestlname.Text.Length == 0)
                {
                    guesterr.Text = "Lastname Required";
                }
                else if (guestpno.Text.Length == 0)
                {
                    guesterr.Text = "Phone number Required";
                }
                else if (guestaddress.Text.Length == 0)
                {
                    guesterr.Text = "Address Required";
                }
            }
            else
            {
                guesterr.Text = "";
                if (g == 0)
                {
                    bunifuFlatButton4_Click(sender, e);
                    Model.addReciept(rec_name,name,h,ma,tax,pri);
                    reciept_id = Model.getRecieptId(h);
                    Model.addGuests(guestfname.Text, guestlname.Text, Convert.ToInt32(guestpno.Text), guestaddress.Text,h);
                    int guest_id = Model.guestId(h);
                    Model.bookguest(Convert.ToInt32(roomno.Text),guest_id, reciept_id);
                }
                else
                {
                    g=0;
                    Model.addReciept(rec_name, name, h, ma, tax, pri);
                    reciept_id = Model.getRecieptId(h);
                    Model.addGuests(guestfname.Text, guestlname.Text, Convert.ToInt32(guestpno.Text), guestaddress.Text,h);
                    int guest_id = Model.guestId(h);
                    Model.bookguest(Convert.ToInt32(roomno.Text), guest_id, reciept_id);
                }
                System.Threading.Thread.Sleep(1000);
                this.Close();
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            g = 1;
            if (guestfname.Text.Length == 0 || guestlname.Text.Length == 0 || guestpno.Text.Length == 0 || guestaddress.Text.Length == 0)
            {
                if (guestfname.Text.Length == 0 && guestlname.Text.Length == 0 && guestpno.Text.Length == 0 && guestaddress.Text.Length == 0)
                {
                    guesterr.Text = "Fields Cannot be empty";
                }
                else if (guestfname.Text.Length == 0)
                {
                    guesterr.Text = "Firstname Required";
                }
                else if (guestlname.Text.Length == 0)
                {
                    guesterr.Text = "Lastname Required";
                }
                else if (guestpno.Text.Length == 0)
                {
                    guesterr.Text = "Phone number Required";
                }
                else if (guestaddress.Text.Length == 0)
                {
                    guesterr.Text = "Address Required";
                }
            }
            else
            {
                guesterr.Text = "";
                h = DateTime.Now.ToString();
                pri = Convert.ToSingle(price.Text);
                tax = Convert.ToSingle(pri * (0.15));
                ma = pri - tax;
                rec[0] = "4 Kilo Hotel";
                rec[1] = String.Format("Name: {0} {1}",guestfname.Text,guestlname.Text);
                rec[2] = String.Format("Date: {0} ", h);
                rec[3]= String.Format("Price: {0} Birr",ma);
                rec[4]= String.Format("Tax: {0} Birr",tax);
                rec[5]= String.Format("Total Price: {0} Birr",pri);
                name = guestfname.Text + " " + guestlname.Text;
                listBox1.Items.Clear();
                foreach(string x in rec)
                {
                    listBox1.Items.Add(x);
                }

            }


        }
    }
}
