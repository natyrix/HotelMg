using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HotelMg
{
    public partial class Security : Form
    {
        public Security()
        {
            InitializeComponent();
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.InitialDirectory = @"E:\hms";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            loadocassions();
        }
        private void loadocassions()
        {
            listBox1.Items.Clear();
            string[] x = Model.getoccasions1();
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
                listBox1.Items.Add("No Occasions for today");
            }
            
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            login l = new login();
            this.Hide();
            l.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] ocid = listBox1.SelectedItem.ToString().Split(':');
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                    occc.Text = "Occasion ID for the occasion you select is: " + ocid[0];
                }
            }
            catch (Exception ee)
            {
                string d = ee.Message;
            }
        }
    }
}
