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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form2 aab = new Form2();
        }

        private void GİRİS_Click(object sender, EventArgs e)
        {
            
            Form2 frm2 = new Form2();
            

            string isimsoyisim;
            isimsoyisim = İS_textBox.Text;

            if(!(İS_textBox.Text == ""))
            {
                frm2.Show();
                MessageBox.Show( "Hoşgeldiniz " + İS_textBox.Text);
            }
            else
            {
                MessageBox.Show("Lütfen isim soyisim girin");
            }
            
        }
    }
}
