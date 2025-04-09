using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oyun_0._1.v1
{
    
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oyuncu1 , oyuncu2 ;
            oyuncu1 = textBox1.Text;
            oyuncu2 = textBox2.Text;
            button2.Text = oyuncu1;
            button3.Text = oyuncu2;

            MessageBox.Show("Kaydınız tamamlandı. Oyuna geçebilirsiniz.");

            
        }

        public void Form1_Load(object sender, EventArgs e)
        {
        }
        public void button2_Click(object sender, EventArgs e)
        {
            
            int rndSayi = rnd.Next(0, 101);
            int x = Convert.ToInt32(textBox3.Text);
            int p, a;
            bool mesajGosterildi = false;

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    if (x == rndSayi)
                    {
                        MessageBox.Show("Tebrikler tekte bildiniz.:)");
                        p = 100;
                        textBox3.Text = "";
                        break;
                    }
                    else if(x > rndSayi)
                    {
                        if (!mesajGosterildi)
                        {
                            MessageBox.Show("Tahmininz büyük, tekrar deneyiniz.");
                            mesajGosterildi = true; 
                        }
                        textBox3.Text = "";
                    }
                    else
                    {
                        if (!mesajGosterildi)
                        {
                            MessageBox.Show("Tahmininz küçük, tekrar deneyiniz.");
                            mesajGosterildi = true;
                        }
                        textBox3.Text = "";
                    }
                
                    if( i > 5)
                    {
                        p = 70;
                    }
                    else if (i <= 5)
                    {
                        p = 35;
                    }
                    else if (i == 0)
                    {
                        MessageBox.Show("Başka deneme hakkınız kalmadı 1. oyuncu kaybetti.");
                        p = 0;
                    }
                }
                
            }
            catch(Exception err)
            {
                MessageBox.Show($"Bir hata Oluştu!!!: {err.Message}");
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rndSayi = rnd.Next(0, 101);
            int x1 = Convert.ToInt32(textBox3.Text);
            int p1, a1;
            bool mesajGosterildi = false;

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    if (x1 == rndSayi)
                    {
                        MessageBox.Show("Tebrikler tekte bildiniz.:)");
                        p1 = 100;
                        textBox3.Text = "";
                        break;
                    }
                    else if (x1 > rndSayi)
                    {
                        if (!mesajGosterildi)
                        {
                            MessageBox.Show("Tahmininz büyük, tekrar deneyiniz.");
                            mesajGosterildi = true;
                        }
                        textBox3.Text = "";
                    }
                    else
                    {
                        if (!mesajGosterildi)
                        {
                            MessageBox.Show("Tahmininz küçük, tekrar deneyiniz.");
                            mesajGosterildi = true;
                        }
                        textBox3.Text = "";
                    }

                    if (i > 5)
                    {
                        p1 = 70;
                    }
                    else if (i <= 5)
                    {
                        p1 = 35;
                    }
                    else if (i == 0)
                    {
                        MessageBox.Show("Başka deneme hakkınız kalmadı 2.oyuncu kaybetti.");
                        p1 = 0;
                    }
                }

            }
            catch (Exception err)
            {
                MessageBox.Show($"Bir hata Oluştu!!!: {err.Message}");
            }
        }
    }

   /* public static class sayi
    {
        
        public static int xyz (int rndSayi)
        {
            Random rnd = new Random();
            return rndSayi = rnd.Next(0, 101);
             
        }
            
             
       
    }       */

    
}
