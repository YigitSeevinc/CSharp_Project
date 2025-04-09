using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Giriş_Yap
{
    public partial class HesapOlusturFrm : Form
    {
        public HesapOlusturFrm()
        {
            InitializeComponent();

            string connectionString = "Server=localhost;Database=girisyap;User ID=root;Password=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Bağlantıyı aç
                    connection.Open();
                    MessageBox.Show("Bağlantı başarılı!");

                    // Örnek bir sorgu çalıştır (örneğin, tablodaki verileri çek)
                    string query = "SELECT * FROM tabloAdi";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Sorguyu çalıştır ve sonuçları oku
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // İlk sütundaki veriyi örnek olarak yazdır
                            Console.WriteLine(reader[0].ToString());
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.szhow("Bağlantı başarısız: " + ex.Message);
                }
            }

        }


        private void btnHesapOlustur_Click(object sender, EventArgs e)
        { 

        }

            
    }
    
}
