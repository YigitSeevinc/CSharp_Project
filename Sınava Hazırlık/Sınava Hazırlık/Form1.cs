using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınava_hazırlık
{
    public partial class Form1 : Form
    {

        İSLEMLER isl = new İSLEMLER();
        public Form1()
        {
            InitializeComponent();
            

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void  btnKareAH_Click(object sender, EventArgs e)
        {
            

            int kk1 = Convert.ToInt32(txtKareK.Text);
            isl.KareA(kk1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void btnKareCH_Click(object sender, EventArgs e)
        {
            int kk1 = Convert.ToInt32(txtKareK.Text);
            isl.KareC(kk1);
            
        }

        public  void btnDikdörtgenAH_Click(object sender, EventArgs e)
        {
            int dk = Convert.ToInt32(txtDikdörtgenKK.Text);
            int du = Convert.ToInt32(txtDikdörgenUK.Text);
            isl.DikA(du, dk);
        }

        public void btnDikdörtgenCH_Click(object sender, EventArgs e)
        {
            int dk = Convert.ToInt32(txtDikdörtgenKK.Text);
            int du = Convert.ToInt32(txtDikdörgenUK.Text);
            isl.DikC(du, dk);
        }

        private void btnDaireAH_Click(object sender, EventArgs e)
        {
            int dr = Convert.ToInt32(txtDaireYÇ.Text);
            isl.DaireA(dr);
        }

        private void btnDaireCH_Click(object sender, EventArgs e)
        {
            int dr = Convert.ToInt32(txtDaireYÇ.Text);
            isl.DaireA(dr);
        }

        private void btnUcgenAH_Click(object sender, EventArgs e)
        {
            int u1 = Convert.ToInt32(txtUcgenK1.Text);
            int u2 = Convert.ToInt32(txtUcgenK2.Text);
            int u3 = Convert.ToInt32(txtUcgenK3.Text);
            int h = Convert.ToInt32(txtYukseklik.Text);


            isl.UcgenA(u3, h);
        }

        private void btnUcgenCH_Click(object sender, EventArgs e)
        {
            int u1 = Convert.ToInt32(txtUcgenK1.Text);
            int u2 = Convert.ToInt32(txtUcgenK2.Text);
            int u3 = Convert.ToInt32(txtUcgenK3.Text);
            int h = Convert.ToInt32(txtYukseklik.Text);

            isl.UcgenC(u1,u2,u3);
        }
    }

    public class İSLEMLER
    {
       

        public int pi = 3;


        public int KareA(int k1)
        {
            return k1*k1;
            
            
        }
        public int KareC(int k1) 
        {
            return k1 * 4;
        }
        public int DikA(int k1, int k2) 
        {
            return k1*k2;
        }
        public int DikC(int k1, int k2) 
        { 
            return (k1 + k2)*2;
        }
        public int DaireA( int r)
        {
            return pi * (r * r);
        }
        public int DaireC(int r)
        {
            return 2 * pi * r;
        }
        public int UcgenA(int k3, int h)
        {
            return 1 / 2 * (k3 * h);
        }
        public int UcgenC(int k1, int k2, int k3)
        {
            return k1 + k2 + k3;
        }
    }
}
