using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Sistemi
{
    internal class VeriTabaniIslemleri
    {
        string baglantiCumlesi = ConfigurationManager.ConnectionStrings["kutuphaneBaglantiCumlesi"].ConnectionString;

        public MySqlConnection baglan()
        {
            MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi);
            MySqlConnection.ClearPool(baglanti);
            return baglanti;
        }
    }
}
