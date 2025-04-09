using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace donanım_birimleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secim;
            secim = listBox1.SelectedItems.ToString();

            if(secim == "MOUSE" || secim == "KLAVYE" || secim == "KAMERA" || secim == "TARAYICI")
            {
                MessageBox.Show("BU PARÇA , GİRİŞ BİRİMİDİR");
            }
            
            if (secim == "YAZICI" || secim == "HOPARLÖR" || secim == "PROJEKSİYON")
            {
                MessageBox.Show("BU PARÇA , ÇIKIŞ BİRİMİDR");
            }


        }
    }
}
