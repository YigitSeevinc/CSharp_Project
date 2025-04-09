using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resim_seçip_gösterme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gorsel_ac_Click(object sender, EventArgs e)
        {
            OpenFileDialog  resim = new OpenFileDialog();
            resim.ShowDialog();
            resim_alani.ImageLocation = resim.FileName;
        }
    }
}
