using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINIFLAR
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dikdörtgen d = new Dikdörtgen();

            Console.Write("Alan hesaplamak için (A/a),Çevre hesaplamak için (C/c) yazınız: ");
            char x = Convert.ToChar(Console.ReadLine()); 
            Console.WriteLine("");       

            if(x == 'A' || x == 'a')
            {
                Console.Write("Dikdörtgenin birinci kenarını giriniz: ");
                int k = Convert.ToInt32(Console.ReadLine());                
                Console.WriteLine("");
                Console.Write("Dikdörtgenin ikinci kenarını giriniz: ");
                int l = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("Dikdörtgenin alanı: "+ d.AlanHesapla(k,l));

                Console.WriteLine("");
                Console.Write("Alan hesaplamak için (A/a), Çevre hesaplamak için (C/c), çıkış için(K/k) yazınız: ");
                x = Convert.ToChar(Console.ReadLine());
            }
            else if(x == 'C' || x == 'c')
            {
                Console.Write("Dikdörtgenin birinci kenarını giriniz: ");
                int k = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("Dikdörtgenin ikinci kenarını giriniz: ");
                int l = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("Dikdörtgenin çevresi: " + d.CevreHesapla(k, l));

                Console.WriteLine("");
                Console.Write("Alan hesaplamak için (A/a),Çevre hesaplamak için (C/c) yazınız: ");
                x = Convert.ToChar(Console.ReadLine());
            }
            else
            {
                
            }

            Console.ReadKey();
        }
         public class Dikdörtgen
        {   

            
            
            public int AlanHesapla(int a, int b)
            {
                return a * b;
            }
            public int CevreHesapla(int a, int b)
            {
                return 2*(a + b);
            }
        }
    }
}
