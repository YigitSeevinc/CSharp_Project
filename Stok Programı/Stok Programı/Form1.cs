using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Programı
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

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void UKaydet_Click(object sender, EventArgs e)
        {
            
            if(UAdiTextbox.Text == "")
            {
                MessageBox.Show("Lütfen Ürün Adı'nı boş bırakmayınız!");
            }
            else
            {
                USecimiCombobox.Items.Add(UAdiTextbox.Text);
                MessageBox.Show("Ürün Eklendi.");
            }
           
        }
        private void SL_Goster(object sender, EventArgs e)
        {

        }



    }
}
