namespace market_programı
{
    public partial class Form1 : Form
    {
        Dictionary<string, decimal> meyveFiyatlari = new Dictionary<string, decimal>()
        {
            {"elma", 2.50m},
            {"armut", 3.00m},
            {"kayısı", 4.00m},
            {"şeftali", 3.50m},
            {"kiraz", 5.00m},
            {"vişne", 4.50m},
            {"karpuz", 6.00m},
            {"kavun", 5.50m},
            {"erik", 3.50m},
            {"çilek", 4.00m}
        };
        decimal toplamFiyat = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var meyve in listBox1.Items)
            {
                toplamFiyat += meyveFiyatlari[meyve.ToString()];
            }

            comboBox1.Text = "Toplam Fiyat: " + toplamFiyat.ToString("C");



        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var meyve in meyveFiyatlari.Keys)
            {
                listBox1.Items.Add(meyve);
            }
        }
    }
}