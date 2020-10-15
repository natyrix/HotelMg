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
    public partial class updateordelete : Form
    {
        public static string uname;
        public updateordelete()
        {
            InitializeComponent();
            loadall();
        }
        private void loadall()
        {
            string x = Model.getInfo(uname);
            string title = Model.getTitle(uname);
            string[] arr = x.Split(':');
            updateuseruname.Text = uname;
            updateuserfrstname.Text = arr[0];
            updateuserlname.Text = arr[1];
            updateuserpno.Text = arr[2];
            updateusertitle.SelectedItem = title;
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
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adduser_Click(object sender, EventArgs e)
        {
            if (updateuseruname.Text.Length == 0 || updateuserfrstname.Text.Length == 0 ||
                updateuserlname.Text.Length == 0 || updateuserpno.Text.Length == 0 ||
                updateuserpass.Text.Length == 0 || updateuserconpass.Text.Length == 0)
            {
                if (updateuseruname.Text.Length == 0 && updateuserfrstname.Text.Length == 0 &&
                updateuserlname.Text.Length == 0 && updateuserpno.Text.Length == 0 &&
                updateuserpass.Text.Length == 0 && updateuserconpass.Text.Length == 0)
                {
                    updateusererr.Text = "Fields can not be empty";
                }

                else if (updateuseruname.Text.Length == 0)
                {
                    updateusererr.Text = "Username Required";
                }
                else if (updateuserfrstname.Text.Length == 0)
                {
                    updateusererr.Text = "Firstname Required";
                }
                else if (updateuserlname.Text.Length == 0)
                {
                    updateusererr.Text = "Lastname Required";
                }
                else if (updateuserpno.Text.Length == 0)
                {
                    updateusererr.Text = "Phone Number Required";
                }
                else if (updateuserpass.Text.Length == 0)
                {
                    updateusererr.Text = "Password Required";
                }
                else if (updateuserconpass.Text.Length == 0)
                {
                    updateusererr.Text = "Confirm Password Required";
                }
            }
            else
            {
                if (updateuserpass.Text.Equals(updateuserconpass.Text))
                {
                    Model.updateinfo(uname, updateuseruname.Text, updateuserfrstname.Text,updateuserlname.Text,Convert.ToInt32(updateuserpno.Text));
                    Model.updateuser(uname, updateuseruname.Text, updateuserpass.Text);
                    Model.updatetitle(uname, updateuseruname.Text,updateusertitle.SelectedItem.ToString());
                    MessageBox.Show("Update Successful");
                }
                else
                {
                    updateusererr.Text = "Passwords Do not match";
                }
            }

                
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Model.deletee(uname);
            MessageBox.Show("User Deleted");
        }
    }
}
