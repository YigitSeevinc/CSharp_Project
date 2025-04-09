using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kütüphane_Sistemi
{   
    public partial class formAnaSayfa : Form
    {
        public formAnaSayfa()
        {
            
            
            InitializeComponent();
        }   


        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            formKitap kitap = new formKitap();
            kitap.ShowDialog();
        }

        private void btnOgrenciİ_Click(object sender, EventArgs e)
        {
            formOgrenci Ogrenci = new formOgrenci();
            Ogrenci.ShowDialog();
        }

        private void btnTur_Click(object sender, EventArgs e)
        {
            formTur tur = new formTur();
            tur.ShowDialog();
        }

        private void btnOdunc_Click(object sender, EventArgs e)
        {
            formOdunc odunc = new formOdunc();
            odunc.ShowDialog();
        }
    }
}
