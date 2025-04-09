using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kademeler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte sinif;
            sinif = Convert.ToByte(comboBox1.Text);

            if(sinif > 0 && sinif < 5)
            {
                MessageBox.Show("İLKOKUL ÖĞRENCİSİ");
            }

            else if (sinif > 5 && sinif < 8)
            {
                MessageBox.Show("ORTAOKUL ÖĞRENCİSİ");
            }

            else if(sinif > 8 && sinif < 12)
            {
                MessageBox.Show("LİSE ÖĞRENCİSİ");
            }














        }
    }
}
