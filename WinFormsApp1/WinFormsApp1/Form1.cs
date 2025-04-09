namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 + sayi2;
            textBox3.Text = sonuc.ToString();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 - sayi2;
            textBox3.Text = sonuc.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 * sayi2;
            textBox3.Text = sonuc.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 / sayi2;
            textBox3.Text = sonuc.ToString();
        }
    }
}