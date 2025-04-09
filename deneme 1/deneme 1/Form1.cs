namespace deneme_1
{
    public partial class ana_ekran : Form
    {
        kayit kayit1;
        oturum oturum;
        public ana_ekran()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            




            
            

            
            
            
            
            
            
            
            oturum oturum = new oturum();
            oturum.Owner = this;
            oturum.Show();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayit kayit = new kayit();
            kayit.Owner = this;           
            kayit.Show();

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }
    }
}