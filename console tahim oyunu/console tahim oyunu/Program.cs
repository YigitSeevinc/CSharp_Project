using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_tahim_oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string oyuncu1 , oyuncu2 ;

            Console.WriteLine("sayı tahim oyununa hoşgeldiniz!!.");
            
            Console.Write("1. oyuncunun kullanacağı adı giriniz: ");
            oyuncu1 = Console.ReadLine();
            
            Console.Write("2. oyuncunun kullanacağı adı giriniz: ");
            oyuncu2 = Console.ReadLine();
            


            Random rnd = new Random();
            int x = rnd.Next(1,101);
            int o1t,o2t;
            int haklar = 10;
            Console.WriteLine("0 ile 100 arasında bir sayı tahmininde bulunacaksınız. 10 tahmin etme hakkınız var. en az tahminle sayıyı bulan kazanır." +
                " Sırasıyla 1.oyuncu 2.oyuncu diye devam edecektir.");
            Console.Write("");

            while(haklar > 0)
            {
                int i;
                for (i = 10; i > 0; i--)
                {
                    Console.Write("1. oyuncunun tahmin edeceği sayıyı giriniz: ");
                    o1t = Convert.ToInt32(Console.ReadLine());



                    if (o1t == x)
                    {
                        Console.WriteLine("Tebrikler tekde bildinizz.");
                        break;
                       
                    }
                    else if (o1t > x)
                    {
                        Console.WriteLine("küçültmeyi deneyin.");
                        break;
                    }
                    else if (o1t < x)
                    {
                        Console.WriteLine("Büyültmeyi deneyin.");
                        break;
                    }
                    if (i == 0)
                    {
                        Console.Write("Tahmin kakkınız bitti ve 2. oyuncu kazandı üzgünüz :(");
                        
                        break;
                    }
                }

                Console.Write("");
                Console.Write("");
                Console.Write("2. oyuncunun tahmin edeceği sayıyı giriniz: ");
                o2t = Convert.ToInt32(Console.ReadLine());

                int a;
                for (a = 10; a > 0; a--)
                {
                    if (o2t == x)
                    {
                        Console.WriteLine("Tebrikler tekde bildinizz.");
                        break;
                        
                    }
                    else if (o2t > x)
                    {
                        Console.WriteLine("küçültmeyi deneyin.");
                        break;
                    }
                    else if (o2t < x)
                    {
                        Console.WriteLine("Büyültmeyi deneyin.");
                        break;
                    }
                    if (a == 0)
                    {
                        Console.Write("Tahmin kakkınız bitti ve 1. oyuncu kazandı üzgünüz :(");
                        
                        break;
                    }
                }
            }

            


            Console.ReadKey();

            /*Console.WriteLine("Hoş Geldiniz! İki oyunculu sayı tahmin oyununa başlayalım.");

            // Rastgele bir sayı oluşturma
            Random random = new Random();
            int hedefSayi = random.Next(1, 101); // 1 ile 100 arasında bir sayı seçiyoruz

            int suankiOyuncu = 1; // Şu an hangi oyuncunun sırası olduğunu belirten değişken
            bool oyunBitti = false; // Oyunun bitip bitmediğini kontrol etmek için kullanacağımız değişken

            while (!oyunBitti)
            {
                Console.WriteLine($"\nOyuncu {suankiOyuncu}, bir tahminde bulunsun:");

                // Kullanıcıdan tahmin alıyoruz
                int tahmin;
                while (true)
                {
                    Console.Write("Tahmininiz: ");
                    if (int.TryParse(Console.ReadLine(), out tahmin))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen tekrar deneyin.");
                    }
                }

                // Tahmini kontrol ediyoruz
                if (tahmin < hedefSayi)
                {
                    Console.WriteLine("Daha büyük bir sayı tahmin edin.");
                }
                else if (tahmin > hedefSayi)
                {
                    Console.WriteLine("Daha küçük bir sayı tahmin edin.");
                }
                else
                {
                    Console.WriteLine($"Tebrikler! Oyuncu {suankiOyuncu}, doğru tahmini yaptı!");
                    oyunBitti = true;
                }

                // Sırayı diğer oyuncuya geçiriyoruz
                suankiOyuncu = (suankiOyuncu == 1) ? 2 : 1;
            }

            Console.WriteLine($"Oyun bitti. Hedeflenen sayı: {hedefSayi}");
            Console.ReadKey();*/
        }
    }
}
