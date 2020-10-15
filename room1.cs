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
    public partial class room1 : UserControl
    {
        public room1()
        {
            InitializeComponent();
            regroomtype.SelectedItem = "Normal";
            updateroomtype.SelectedItem = "Normal";
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Room Number",150);
            listView1.Columns.Add("Room Type",130);
            listView1.Columns.Add("Room Price Birr",150);
            LoadRooms();
        }
        private void LoadRooms()
        {
            //listView1.Clear();
            ListViewItem[] lvi = Model.loadRooms();
            int i = Convert.ToInt32(lvi[0].SubItems[0].Text);
            for(int x=1;x<i;x++)
            {
                listView1.Items.Add(lvi[x]);
            }
        }

        private void AddRoom_Click(object sender, EventArgs e)
        {
            if (!(regroomno.Text.Length == 0))
            {
                regroomerr.Text = "";
                Model.AddRoom(Convert.ToInt32(regroomno.Text),regroomtype.SelectedItem.ToString());
                regroomno.Text = "";
                regroomtype.Text = "Normal";
                listView1.Items.Clear();
                LoadRooms();
            }
            else
            {
                regroomerr.Text = "Room Number Required";
            }
            
        }

        private void check(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (!(delroomno.Text.Length == 0))
            {
                delroomerr.Text = "";
                Model.delroom(Convert.ToInt32(delroomno.Text));
                delroomno.Text = "";
                listView1.Items.Clear();
                LoadRooms();
            }
            else
            {
                delroomerr.Text = "Room number Required";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!(updateroomno.Text.Length == 0))
            {
                Model.updateRoom(Convert.ToInt32(updateroomno.Text),updateroomtype.SelectedItem.ToString());
                updateroomno.Text = "";
                updateroomtype.SelectedItem = "Normal";
                listView1.Items.Clear();
                LoadRooms();
            }
            else
            {
                updateroomerr.Text = "Room number Required";
            }
        }
    }
}
