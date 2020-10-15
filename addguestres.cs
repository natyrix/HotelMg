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
    public partial class addguestres : Form
    {
        public static string res_id;
        public addguestres()
        {
            InitializeComponent();
            reserv_id.Text = res_id;
            loadreserguest();
        }
        private void loadreserguest()
        {
            listBox1.Items.Clear();
            int res = Convert.ToInt32(reserv_id.Text);
            int[] x = Model.getguestidfromres(res);
            for(int i = 1; i < x[0]; i++)
            {
                string[] info = Model.getGuestInfo(x[i]);
                listBox1.Items.Add(string.Format("{0} \t {1} \t{2} \t {3} \t ",info[0], info[1], info[2], info[3]));

            }
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (fname.Text.Length == 0 || Lname.Text.Length == 0 || pno.Text.Length == 0)
            {
                if(fname.Text.Length == 0 || Lname.Text.Length == 0 || pno.Text.Length == 0)
                {
                    errr.Text = "Fields can not be empty";
                }
                else if (fname.Text.Length == 0)
                {
                    errr.Text = "First name can not be empty";
                }
                else if(Lname.Text.Length == 0)
                {
                    errr.Text = "Last name can not be empty";
                }
                else if (pno.Text.Length == 0)
                {
                    errr.Text = "Phone number can not be empty";
                }
            }
            else
            {
                int res_ii = Convert.ToInt32(reserv_id.Text);
                int x = Model.getCount(res_ii);
                int y = Model.checkcount(res_ii);
                if (y < x)
                {
                    string h = DateTime.Now.ToString();
                    Model.addGuests(fname.Text,Lname.Text,Convert.ToInt32(pno.Text),"Adress",h);
                    int guest_id = Model.guestId(h);
                    Model.reserveGuest(guest_id,res_ii);
                    fname.Text = "";
                    Lname.Text = "";
                    pno.Text = "";

                    loadreserguest();

                }
                else
                {
                    errr.Text = "Reservation has reached maximum number of guest";
                }
            }
        }
    }
}
