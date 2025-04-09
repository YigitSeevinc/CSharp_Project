using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaçan_buton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_click(object sender, MouseEventArgs e)
        {
           
        }

        private void button1_down(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();//random sınıfından rnd adlı nesne üretir.
            int x,y;// int veri tipinde x ve y değişkeni.

            x =this.ClientSize.Width - button1.Width; //form alanının yüksekliğinden button alanının yüksekliğini çıkarır.
            y = this.ClientSize.Height - button1.Height;//form alanının genişliğinden buton alanının genişliğini çıkarır.
            
            button1.Location = new Point(rnd.Next(x),rnd.Next(y));//yer değiştirecek butonun yeni konumunu belirler.
            //MessageBox.Show("Değdi");
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
