using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_1_2_3_4
{
    public partial class sifreturu : Form
    {
        public sifreturu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sifreuzunlugu;
            if(!int.TryParse(sifreUzunlugu.Text,out sifreuzunlugu) || sifreuzunlugu <= 0)
            {
                MessageBox.Show("lütfen geçerli bir şifre uzunluğu girin.","Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string karakterturu = comboBox1.SelectedItem.ToString();
            string karakterseti = "";

            if(karakterturu == "sadece rakamlar ( 0 - 9 )")
            {
                karakterseti = "0123456789";
            }
            else if (karakterturu == "yalnızca harf (A - Z)")
            {
                karakterseti = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            }
            else if (karakterturu == "rakamlar ve harfler")
            {
                karakterseti = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            }
            else if (karakterturu == "özel karakter ,harf , rakam ")
            {
                karakterseti = "! @ # $ % ^ & * ( ) _ + - = { } [ ] | \\ : ; \" ' < > , . ? / ~ `, 0123456789 + ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ";
            }
            Random random = new Random();
            string sifre = new string(Enumerable.Repeat(karakterseti, sifreuzunlugu).Select(s => s[random.Next(s.Length)]).ToArray());

            listBox1.Items.Add(sifre);
            
        }

        private void sifreturu_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("sadece rakamlar");
            comboBox1.Items.Add("sadece harfler");
            comboBox1.Items.Add("harf ve rakamlar");
            comboBox1.Items.Add("harf , rakam ve özel karakterler");

            comboBox1.SelectedIndex = 0;
        }
    }
}
