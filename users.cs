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
    public partial class users : UserControl
    {
        public users()
        {
            InitializeComponent();
            regusertitle.SelectedItem = "Frontoffice";
            LoadUsers();
        }
        private void LoadUsers()
        {
            listBox1.Items.Clear();
            string[] x = Model.getUsers();
            int j = Convert.ToInt32(x[0]);
            for(int i=1;i< j; i++)
            {
                listBox1.Items.Add(x[i]);
            }
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adduser_Click(object sender, EventArgs e)
        {
            if(regusername.Text.Length==0 || reguserfrstname.Text.Length == 0 || 
                reguserlname.Text.Length == 0 || reguserpno.Text.Length == 0 ||
                reguserpass.Text.Length == 0 || reguserconpass.Text.Length == 0)
            {
                if (regusername.Text.Length == 0 && reguserfrstname.Text.Length == 0 &&
                reguserlname.Text.Length == 0 && reguserpno.Text.Length == 0 &&
                reguserpass.Text.Length == 0 && reguserconpass.Text.Length == 0)
                {
                    regusererr.Text = "Fields can not be empty";
                }

                else if (regusername.Text.Length == 0)
                {
                    regusererr.Text = "Username Required";
                }
                else if(reguserfrstname.Text.Length == 0)
                {
                    regusererr.Text = "Firstname Required";
                }
                else if (reguserlname.Text.Length == 0)
                {
                    regusererr.Text = "Lastname Required";
                }
                else if (reguserpno.Text.Length == 0)
                {
                    regusererr.Text = "Phone Number Required";
                }
                else if (reguserpass.Text.Length == 0)
                {
                    regusererr.Text = "Password Required";
                }
                else if (reguserconpass.Text.Length == 0)
                {
                    regusererr.Text = "Confirm Password Required";
                }

            }
            else
            {
                if (Model.ChekUserExist(regusername.Text))
                {
                    regusererr.Text = "Username already taken";
                }
                else
                {
                    if (!reguserpass.Text.Equals(reguserconpass.Text))
                    {
                        regusererr.Text = "Passwords do not match";
                    }
                    else
                    {
                        regusererr.Text = "";
                        Model.AddUser(regusername.Text, reguserfrstname.Text, reguserlname.Text, Convert.ToInt32(reguserpno.Text), reguserpass.Text, regusertitle.Text);
                        MessageBox.Show("User Registred");
                        regusertitle.SelectedItem = "Frontoffice";
                        reguserpno.Text = "";
                        regusername.Text = "";
                        reguserfrstname.Text = "";
                        reguserlname.Text = "";
                        reguserpass.Text = "";
                        reguserconpass.Text = "";
                        LoadUsers();
                    }
                }
                
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                updateordelete.uname = listBox1.SelectedItem.ToString();
                updateordelete upd = new updateordelete();
                upd.ShowDialog();
                LoadUsers();
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }
    }
}
