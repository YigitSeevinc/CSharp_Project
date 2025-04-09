using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ses_ayarı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int ses = trackBar1.Value;

            if (ses == 0)
            {
                label1.Text = " SES YOK";
                label1.ForeColor = Color.Black;
            }
            if (ses > 0 && ses <= 10)
            {
                label1.Text = "NORMAL SES SEVİYESİ";
                label1.ForeColor = Color.Green;
            }
            if (ses >= 11)
            {
                label1.Text = "YÜKSEK SES SEVİYESİ";
                label1.ForeColor = Color.Red;
            }

        }
    }
}
