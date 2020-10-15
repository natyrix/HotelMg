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
    public partial class occasionguest : Form
    {
        public static string occid;
        public occasionguest()
        {
            InitializeComponent();
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.InitialDirectory = @"E:\hms";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog1.InitialDirectory = @"E:\hms";
            saveFileDialog1.RestoreDirectory = true;
            ocid.Text = occid;
            setocc();
        }
        private void setocc()
        {
            int occc = Convert.ToInt32(ocid.Text);
            string x = Model.getoccs(occc);
            string[] h = x.Split(':');
            ocname.Text = h[0];
            ocdate.Text = h[1];
            ocstrtdate.Text = h[2];
            ocendtime.Text = h[3];
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                err.Text = "Please load a file or add guests ... ";
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fname = "Occasion ID =>" + ocid.Text;
                    richTextBox1.AppendText(fname);
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    MessageBox.Show("Saved Succefully");

                }
            }
            

        }
    }
}
