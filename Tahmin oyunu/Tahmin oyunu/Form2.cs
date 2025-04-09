using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tahmin_oyunu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Karsılama_label_Click(object sender, EventArgs e)
        {
            
            
        }
        public Form2(string veri)
        {
           

        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)

        {
            Random rnd = new Random();
            int r = rnd.Next(0, 101);
            

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tahmininizi girin: ");
                Tahmin.Text = Convert.ToInt(Console.ReadLine());
                i++;

                if (Tahmin.Text > r)
                {
                    MessageBox.Show("Daha küçük bir sayı girin");
                }
                else if (tahmin < r)
                {
                    MessageBox.Show("Daha büyük bir sayı girin");
                }
                else
                {
                    MessageBox.Show("Tebrikler, doğru tahmin! Sayı: " + r);
                    break;
                }
            }
        }
    }
}
