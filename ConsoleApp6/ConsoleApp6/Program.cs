using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dk1, dk2, kk1, ut, uy, uk1, uk2;
            string sekil_ad;
            

            Console.WriteLine("Şekil giriniz(Üçgen(ucgen), Dikdörtgen, Kare(Lütfen küçük harfle giriniz!!)):");

            sekil_ad = Console.ReadLine();

            if (sekil_ad == "ucgen")
            {
                Console.WriteLine("Alan hesaplanacak ise(küçük harfle alan yazın.),Çevre hesaplanacak ise(küçük harfle cevre yazın.):");
                string x = Console.ReadLine();

                if (x == "alan")
                {
                    Console.WriteLine("üçgenin taban değerini giriniz:");
                    ut = Convert.ToDouble(Console.ReadLine());


                    Console.WriteLine("üçgenin yükseklik değerini giriniz:");
                    uy = Convert.ToDouble(Console.ReadLine());


                    Console.Write("toplam: " + (ut + uy) / 2);
                }
                else if (x == "cevre")
                {
                    Console.WriteLine("üçgenin taban değerini giriniz:");
                    ut = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("üçgenin 1. kenarını giriniz.");
                    uk1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("üçgenin 2. kenarını giriniz.");
                    uk2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("toplam: " + (uk1 + uk2 + ut));
                }
                else
                {
                    Console.Write("yanlş değer girdiniz tekrar deneyiz.");
                }
            }
            else if (sekil_ad == "dikdörtgen") 
            {
                Console.WriteLine("Alan hesaplanacak ise(küçük harfle alan yazın.),Çevre hesaplanacak ise(küçük harfle cevre yazın.):");
                string x = Console.ReadLine();

                if(x == "alan")
                {
                    Console.WriteLine("dikdörtgenin kenarını girin: ");
                    dk1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("didörtgenin kısa kenarını girin: ");
                    dk2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("toplam: " +  dk1 * dk2);             
                }
                else if(x == "cevre")
                {
                    Console.WriteLine("dikdörtgenin kenarını girin: ");
                    dk1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("didörtgenin kısa kenarını girin: ");
                    dk2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("toplam: " + dk1 * dk1 * dk2 * dk2);
                }
                else
                {
                    Console.Write("yanlş değer girdiniz tekrar deneyiz.");
                }
                
            }
            else if(sekil_ad == "kare")
            {
                Console.WriteLine("Alan hesaplanacak ise(küçük harfle alan yazın.),Çevre hesaplanacak ise(küçük harfle cevre yazın.):");
                string x = Console.ReadLine();

                if (x == "alan")
                {
                    Console.WriteLine("karenin kenarını giriniz: ");
                    kk1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("toplam: " + (kk1 * kk1));
                }
                else if(x == "cevre")
                {
                    Console.WriteLine("karenin kenarını giriniz: ");
                    kk1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("toplam: " + (kk1 * 4));
                }
                else
                {
                    Console.Write("yanlş değer girdiniz tekrar deneyiz.");
                }     
            }
            else
            {
                Console.Write("yanlş değer girdiniz tekrar deneyiz.");
            }
            Console.ReadKey();
            
            
            
            
            
        }
    }
}
