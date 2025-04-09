using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Programı_Y_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void urun_kaydet_Click(object sender, EventArgs e)
        {

            if (urun_textbox.Text == "")
            {
                MessageBox.Show("Lütfen Ürün Adı'nı boş bırakmayınız!");
            }
            else
            {
                urun_sec_combobox.Items.Add(urun_textbox.Text);
                MessageBox.Show("Ürün Eklendi.");
            }
            
        }

        private void stok_liste_gizle_Click(object sender, EventArgs e)
        {
            stok_listesi.Visible = false;
            stok_liste_goster.Visible = true;
        }

        private void stok_liste_goster_Click(object sender, EventArgs e)
        {
            stok_listesi.Visible = true;
            stok_liste_goster.Visible = false;
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            


            if (miktar_textbox.Text == "")
            {
                MessageBox.Show("Lütfen Miktar alanını boş bırakmayınız!");
            }
            else
            {
                

                 liste1.Items.Add(urun_textbox.Text);
                liste2.Items.Add(miktar_textbox.Text);

                if (beden1.Checked == true)
                {
                    liste3.Items.Add(38);
                }
                else if (beden2.Checked == true)
                {
                    liste3.Items.Add(39);
                }
                else if (beden3.Checked == true)
                {
                    liste3.Items.Add(40);
                }
                else
                {
                    liste2.Items.Clear();
                    MessageBox.Show("lütfen beden giriniz");
                    
                }
            }
            


        }

        private void sifirla_Click(object sender, EventArgs e)
        {
            urun_sec_combobox.Items.Clear();
            miktar_textbox.Text = "";
        }

        private void tum_sil_Click(object sender, EventArgs e)
        {
            liste1.Items.Clear();
            liste2.Items.Clear();
            liste3.Items.Clear();
        }
    }
}
