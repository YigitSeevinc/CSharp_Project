namespace sınav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);

            if (textBox1.Text == " ")
            {
                label2.Text = "Sayı Yok.";


            }
            else
            {
                if (sayi % 2 == 0)
                {
                    label2.Text = "Sayı Çifttir.";
                }
                else
                {
                    label2.Text = "Sayı Tektir.";
                }
            }
            

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int i, sayi;
            for (i = 0; i < 10; i++)
            {
                sayi = r.Next(-200, 200);
                listBox1.Items.Add(sayi);


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (int a in listBox1.Items)
            {
                if (a >= 0)
                {
                    listBox2.Items.Add(a);
                }
                else
                {
                    listBox3.Items.Add(a);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(textBox2.Text);
            sayi2 = Convert.ToInt32(textBox3.Text);
            sonuc = sayi1 + sayi2;
            textBox4.Text = sonuc.ToString();


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(textBox2.Text);
            sayi2 = Convert.ToInt32(textBox3.Text);
            sonuc = sayi1 - sayi2;
            textBox4.Text = sonuc.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(textBox2.Text);
            sayi2 = Convert.ToInt32(textBox3.Text);
            sonuc = sayi1 * sayi2;
            textBox4.Text = sonuc.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(textBox2.Text);
            sayi2 = Convert.ToInt32(textBox3.Text);
            sonuc = sayi1 / sayi2;
            textBox4.Text = sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int girilensayi;
            girilensayi = Convert.ToInt32(textBox5.Text);

            if (textBox5.Text == "")
            {
                label12.Text = "Lütfen sayı girin.";
            }
            else
            {
                listBox4.Items.Add(girilensayi);
                listBox5.Items.Add(girilensayi * girilensayi);
                listBox6.Items.Add(girilensayi * girilensayi * girilensayi);
            }

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Yellow;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Size = new Size(50, 50);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Size = new Size(100, 100);
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Size = new Size(200, 50);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
        }
    }
}