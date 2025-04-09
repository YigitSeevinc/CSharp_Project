using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._124._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        string[] isimler = new string[5];
        int[] notlar = new int[5];
        int index = 0;
        private void button3_Click(object sender, EventArgs e)
        {

            int enyuksek =  notlar[0];
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] > enyuksek)
                {
                    enyuksek = notlar[i];
                }
            }
            textBox5.Text = enyuksek.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
