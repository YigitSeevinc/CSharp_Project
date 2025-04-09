using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Stok_Sistemi
{
    public partial class Form1 : Form
    {
        private List<Urun> urunler = new List<Urun>();
        private List<Musteri> musteriler = new List<Musteri>();
        DataTable tablo1 = new DataTable();
        DataTable tablo2 = new DataTable(); 
        DataTable tablo3 = new DataTable();
        DataTable tablo4 = new DataTable();
        public Form1()
        {
            InitializeComponent();
            urunler.Add(new Urun { Adi = "Kalem", Fiyat = 2.5m });
            urunler.Add(new Urun { Adi = "Defter", Fiyat = 5m });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tablo1.Columns.Add("Ürün Adı",typeof(string));
            tablo1.Columns.Add("Ürün Fiyatı", typeof(int));
            tablo2.Columns.Add("Müşteri Adı", typeof(string));
            tablo3.Columns.Add("Ürün Miktarı", typeof(int));
            tablo3.Columns.Add("Taksit Miktarı", typeof(int));
            tablo4.Columns.Add("Veresiye",typeof(double));
            dataGridView1.DataSource = tablo1;
            dataGridView2.DataSource = tablo2;
            dataGridView3.DataSource = tablo3;
            dataGridView4.DataSource = tablo4;

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {   
            
            
        }

        private void btnUrunSatısı_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTaksitBelirle_Click(object sender, EventArgs e)
        {
            
        }
        public class Urun
        {
            public string Adi { get; set; }
            public decimal Fiyat { get; set; }
        }

        public class Musteri
        {
            public string Adi { get; set; }
            public List<Urun> AldigiUrunler { get; set; }
            public decimal Borc { get; set; }
            public decimal TaksitMiktari { get; set; }
            public List<DateTime> TaksitDetaylari { get; set; }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            string urunAdi = txtUrunAdi.Text;
            decimal fiyat;
            if (decimal.TryParse(txtUrunFiyati.Text, out fiyat))
            {
                urunler.Add(new Urun { Adi = urunAdi, Fiyat = fiyat });
                MessageBox.Show("Ürün başarıyla eklendi.");
            }
            else
            {
                MessageBox.Show("Geçerli bir fiyat giriniz.");
            }
            
        }

        private void btnMusteriEkle_Click_1(object sender, EventArgs e)
        {
            if (txtMusteriAdi.Text == "")
            {
                MessageBox.Show("Lütfen Müşteri adı giriniz !!!");
            }
            else
            {
                string musteriAdi = txtMusteriAdi.Text;
                musteriler.Add(new Musteri { Adi = musteriAdi, AldigiUrunler = new List<Urun>(), Borc = 0, TaksitMiktari = 0, TaksitDetaylari = new List<DateTime>() });
                MessageBox.Show("Müşteri başarıyla eklendi.");
            }
            
            
        }

        private void btnUrunSatısı_Click_1(object sender, EventArgs e)
        {
            string musteriAdi = txtMusteriAdiSat.Text;
            string urunAdi = txtUrunAdiSat.Text;
            decimal miktar;
            if (decimal.TryParse(txtUrunMiktariSat.Text, out miktar))
            {
                var musteri = musteriler.Find(m => m.Adi == musteriAdi);
                var urun = urunler.Find(u => u.Adi == urunAdi);
                if (musteri != null && urun != null)
                {
                    musteri.AldigiUrunler.Add(urun);
                    musteri.Borc += urun.Fiyat * miktar;
                    MessageBox.Show("Satış başarıyla gerçekleştirildi.");
                }
                else
                {
                    MessageBox.Show("Müşteri veya ürün bulunamadı!");
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir miktar giriniz.");
            }
            
            
        }

        public void btnTaksitBelirle_Click_1(object sender, EventArgs e)
        {
            string musteriAdi = txtMusteriAdiTaksit.Text;
            decimal taksitMiktari;
            if (decimal.TryParse(txtTaksitMiktari.Text, out taksitMiktari))
            {
                List<DateTime> taksitler = new List<DateTime>();
                taksitler.Add(DateTime.Now);
                taksitler.Add(DateTime.Now.AddMonths(1));
                taksitler.Add(DateTime.Now.AddMonths(2));

                var musteri = musteriler.Find(m => m.Adi == musteriAdi);
                if (musteri != null)
                {
                    musteri.TaksitMiktari = taksitMiktari;
                    musteri.TaksitDetaylari = taksitler;
                    MessageBox.Show("Taksit bilgileri başarıyla kaydedildi.");
                }
                else
                {
                    MessageBox.Show("Müşteri bulunamadı!");
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir taksit miktarı giriniz.");
            }

            int UrunFiyat = Convert.ToInt32(txtUrunFiyati.Text);
            int UrunMiktar = Convert.ToInt32(txtUrunMiktariSat.Text);
            int TaksitMiktar = Convert.ToInt32(txtTaksitMiktari.Text);
            int toplam;
            if(taksitMiktari == 0)
            {
                 toplam = (UrunFiyat * UrunMiktar);
            }
            else
            {
                 toplam = ((UrunFiyat * UrunMiktar) / TaksitMiktar);
            }
           


            tablo1.Rows.Add(txtUrunAdi.Text, txtUrunFiyati.Text);
            dataGridView1.DataSource = tablo1;
            tablo2.Rows.Add(txtMusteriAdi.Text);
            dataGridView2.DataSource = tablo2;
            tablo3.Rows.Add(txtUrunMiktariSat.Text, txtTaksitMiktari.Text);
            dataGridView3.DataSource = tablo3;
            tablo4.Rows.Add(toplam);
            dataGridView4.DataSource = tablo4;

            /*txtMusteriAdi.Text = "";
            txtMusteriAdiSat.Text = "";
            txtMusteriAdiTaksit.Text = "";
            txtTaksitMiktari.Text = "";
            txtUrunAdi.Text = "";
            txtUrunAdiSat.Text = "";
            txtUrunFiyati.Text = "";
            txtUrunMiktariSat.Text = "";*/


           
            



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "word|*.doc";
            kaydet.InitialDirectory = "c://";
            kaydet.OverwritePrompt = true;

            if(kaydet.ShowDialog() == DialogResult.OK)
            {
                StreamWriter dosya = new StreamWriter(kaydet.FileName);
                dosya.WriteLine("Ürün Adı: " + txtUrunAdi.Text);
                dosya.WriteLine("Ürün Fiyatı: " + txtUrunFiyati.Text);
                dosya.WriteLine("Müşteri Adı: " + txtMusteriAdi.Text);
                dosya.WriteLine("Ürün Miktarı: " + txtUrunMiktariSat.Text);
                dosya.WriteLine("Taksit Miktarı: " + txtTaksitMiktari.Text);
                dosya.WriteLine("Aylık Fiyat: " + tablo4);
                
                dosya.Close();
            }
        }
    }
    
}
