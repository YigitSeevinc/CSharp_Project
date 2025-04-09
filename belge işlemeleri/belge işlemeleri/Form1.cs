using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace belge_işlemeleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte ortalama;
            ortalama = Convert.ToByte(textBox1.Text);

            if (ortalama >= 50)
            {
                if (ortalama >= 85)
                {
                    label2.Text = "takdir belgesi almaya hak kazandınız";
                }
                else if (ortalama >= 70)
                {
                    label2.Text = "teşekkür belgesi almaya hak kazandınız";
                }
                else
                {
                    label2.Text = "belge alamadan sınıfı geçtiniz";
                }
            }
            else
            {
                label2.Text = "sınıfı geçmek için yeterli not alamadınız";
            }
        }
    }
}
