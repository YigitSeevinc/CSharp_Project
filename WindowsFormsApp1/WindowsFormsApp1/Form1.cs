using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void btnAH_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int K = Convert.ToInt32(txtKK.Text);
            int Dik1 = Convert.ToInt32(txtDikUK.Text);
            int Dik2 = Convert.ToInt32(txtDikKK.Text);
            int U1 = Convert.ToInt32(txtUK1.Text);
            int U2 = Convert.ToInt32(txtUK2.Text);
            int U3 = Convert.ToInt32(txtUK3.Text);
            int Uh = Convert.ToInt32(txtUh.Text);
            int Dr = Convert.ToInt32(txtDr.Text);
            int Pi = Convert.ToInt32(pi);

            int KAS = K * K;
            string kas = Convert.ToString(KAS);
            int DikAS = Dik1 * Dik2;
            string dikas = Convert.ToString(DikAS);
            int UAS = (U3 * Uh) / 2;   
            string uas = Convert.ToString(UAS);
            int DAS = Pi * (Dr * Dr);
            string das = Convert.ToString(DAS);

            if(txtDikUK.Text =="" || txtDikKK.Text == "" || txtUK1.Text == "" || txtUK2.Text == "" || txtUK3.Text == "" || 
                txtUh.Text == "" || txtDr.Text == "")
            {
                lblKS.Text = kas;
            }
            else if(txtKK.Text == ""|| txtUK1.Text == "" || txtUK2.Text == "" || txtUK3.Text == "" ||
                txtUh.Text == "" || txtDr.Text == "")
            {
                lblDikS.Text = dikas;
            }
            else if(txtKK.Text == "" || txtDikKK.Text == "" || txtUK1.Text == "" || txtDr.Text == "")
            {
                lblUS.Text = uas;
            }
            else if(txtKK.Text == "" || txtDikUK.Text == "" || txtDikKK.Text == "" || txtUK1.Text == "" || txtUK2.Text == "" || txtUK3.Text == "" ||
                txtUh.Text == "")
            {
                lblDS.Text = das;
            }
            else
            {
                lblKS.Text = kas;
                lblDikS.Text = dikas;
                lblUS.Text = uas;
                lblDS.Text = das;
            }
            
            
            
            

        }

        public void btnCH_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int K = Convert.ToInt32(txtKK.Text);
            int Dik1 = Convert.ToInt32(txtDikUK.Text);
            int Dik2 = Convert.ToInt32(txtDikKK.Text);
            int U1 = Convert.ToInt32(txtUK1.Text);
            int U2 = Convert.ToInt32(txtUK2.Text);
            int U3 = Convert.ToInt32(txtUK3.Text);
            int Uh = Convert.ToInt32(txtUh.Text);
            int Dr = Convert.ToInt32(txtDr.Text);
            int Pi = Convert.ToInt32(pi);

            int KCS = K * 4;
            string kcs = Convert.ToString(KCS);
            int DikCS = (Dik1 + Dik2)*2;
            string dikcs = Convert.ToString(DikCS);
            int UCS = U1+U2+U3;
            string ucs = Convert.ToString(UCS);
            int DCS = (2*Pi)*Dr;
            string dcs = Convert.ToString(DCS);

            
            lblKS.Text = kcs;
            lblDikS.Text = dikcs;
            lblUS.Text = ucs;
            lblDS.Text = dcs;
        }
    }
}
