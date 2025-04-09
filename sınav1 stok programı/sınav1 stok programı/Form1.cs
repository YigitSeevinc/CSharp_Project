using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınav1_stok_programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Urun_Ekle_Groupbox_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Stok_Liste_Groupbox_Enter(object sender, EventArgs e)
        {

        }

        private void Urun_Kaydet_Click(object sender, EventArgs e)
        {
            
            if(Urun_Adi_Textbox.Text == "")
            {
                MessageBox.Show("Lütfen Ürün Adını Boş Bırakmayınız !");
            }
            else
            {
                comboBox.Items.Add(Urun_Adi_Textbox.Text);
                MessageBox.Show("Ürün eklendi");
                Urun_Adi_Textbox.Text = "";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Stok_Liste_Groupbox.Visible == true)
            {
                Stok_Liste_Groupbox.Visible = false;
            }
            else
            {
                Stok_Liste_Groupbox.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox.Text == "")
            {
                MessageBox.Show("Lütfen ürün alanını boş bırakmayınız !");

            }
            else if(Miktar_Textbox.Text == "")
            {
                MessageBox.Show("Lütfen miktar alanını boş bırakmayınız !");
            } 
            
            else  
            {
                
               
                
                if(Beden1.Checked == true)
                {
                    Liste3.Items.Add(Beden1.Text);
                }
                else if(Beden2.Checked == true)
                {
                    Liste3.Items.Add(Beden2.Text);
                }
                else if (Beden3.Checked == true)
                {
                    Liste3.Items.Add(Beden3.Text);
                }
                else
                {
                    MessageBox.Show("Lütfen beden seçiniz");
                }
                if (Beden1.Checked == true || Beden2.Checked == true || Beden3.Checked == true)
                {
                    Liste1.Items.Add(comboBox.Text);
                    Liste2.Items.Add(Miktar_Textbox.Text);
                }
               
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox.Text = "";
            Miktar_Textbox.Text = "";
            Beden2.Checked = true;
        }

        private void Tumunu_Sil_Click(object sender, EventArgs e)
        {
            Liste1.Items.Clear();
            Liste2.Items.Clear();
            Liste3.Items.Clear();
        }
    }
}
