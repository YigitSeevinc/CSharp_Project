using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                listBox1.Items.Add = "elma";                    jmhjk

            }
            else if (checkBox2.Checked == true)
            {
                listBox1.Text = "armut";
            }
            else if (checkBox3.Checked == true)
            {
                listBox1.Text = "mandalina";
            }
            else if (checkBox4.Checked == true)
            {
                listBox1.Text = "portakal";
            }
            else if (checkBox5.Checked == true)
            {
                listBox1.Text = "viþne";
            }
            else if (checkBox6.Checked == true)
            {
                listBox1.Text = "kiraz";
            }
            else if (checkBox7.Checked == true)
            {
                listBox1.Text = "karpuz";
            }
            else if (checkBox8.Checked == true)
            {
                listBox1.Text = "kavun";
            }
            else if (checkBox9.Checked == true)
            {
                listBox1.Text = "erik";
            }
            else if (checkBox10.Checked == true)
            {
                listBox1.Text = "çilek";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                listBox1.Text = "elma";

            }
            else if (checkBox2.Checked == true)
            {
                listBox2.Text = "armut";
            }
            else if (checkBox3.Checked == true)
            {
                listBox2.Text = "mandalina";
            }
            else if (checkBox4.Checked == true)
            {
                listBox2.Text = "portakal";
            }
            else if (checkBox5.Checked == true)
            {
                listBox2.Text = "viþne";
            }
            else if (checkBox6.Checked == true)
            {
                listBox2.Text = "kiraz";
            }
            else if (checkBox7.Checked == true)
            {
                listBox2.Text = "karpuz";
            }
            else if (checkBox8.Checked == true)
            {
                listBox2.Text = "kavun";
            }
            else if (checkBox9.Checked == true)
            {
                listBox2.Text = "erik";
            }
            else if (checkBox10.Checked == true)
            {
                listBox2.Text = "çilek";
            }
        
    }
    }
}