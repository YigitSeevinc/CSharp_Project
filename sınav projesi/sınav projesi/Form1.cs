using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace sınav_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Convert.ToInt32(textBox1.Text);


            if (textBox1.Text == "")
            {
                label3.Text = "sayı yoks";


            }
            else
            {
                int sayi;
                sayi = Convert.ToInt16(textBox1.Text);
                if (sayi % 2 == 0)
                {
                    label3.Text = "sayı çifttir.";
                }
                else
                {
                    label3.Text = "sayı tektir";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int i, sayi;

            for (i = 0; i < 10; i++)
            {
                sayi = r.Next(-100, 101);
                listBox1.Items.Add(sayi);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(int a in listBox1.Items)
            {
                if( a >= 0)
                {
                    listBox2.Items.Add(a);
                }
                else
                {
                    listBox3.Items.Add(a);
                }
                    
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        public class degisken
        {
            public int sayi1, sayi2, sonuc;
        }

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}