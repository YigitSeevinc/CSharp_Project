using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            

            Console.WriteLine("1.sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyi girniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("işlem seçiniz(topla,cıkar,bol,carp)");
            string islem = Console.ReadLine();

            if(islem == "topla")
            {
                Console.WriteLine(işlemler.toplama(sayi1,sayi2));
            }
            else if(islem == "cıkar")
            {
                 Console.WriteLine(işlemler.çıkarma(sayi1,sayi2));
            }
            else if(islem == "bol")
            {
                Console.WriteLine(işlemler.bölme(sayi1,sayi2));
            }
            else if(islem == "carp")
            {
                Console.WriteLine(işlemler.çarpma(sayi1,sayi2));
            }
            else
            {
                Console.WriteLine("YANLIŞ DEĞER GİRDİNİZ LÜTFEN TEKRAR DENEYİNİZ!!!");
            }
            string x;
            

            Console.WriteLine("Programı kapatmak istiyorsanız(K) Yeniden başlatmak istiyorsanız(Y) basınız.");
            x = Console.ReadLine();

            while(x == "Y")
            {
                Console.WriteLine("1.sayıyı giriniz: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. sayıyi girniz: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("işlem seçiniz(topla,cıkar,bol,carp)");
                string islem = Console.ReadLine();

                if (islem == "topla")
                {
                    Console.WriteLine(işlemler.toplama(sayi1, sayi2));
                }
                else if (islem == "cıkar")
                {
                    Console.WriteLine(işlemler.çıkarma(sayi1, sayi2));
                }
                else if (islem == "bol")
                {
                    Console.WriteLine(işlemler.bölme(sayi1, sayi2));
                }
                else if (islem == "carp")
                {
                    Console.WriteLine(işlemler.çarpma(sayi1, sayi2));
                }
                else
                {
                    Console.WriteLine("YANLIŞ DEĞER GİRDİNİZ LÜTFEN TEKRAR DENEYİNİZ!!!");
                }
            }
            
            
                

            
            
            




            Console.ReadKey();
        } 
    }

    class işlemler
    {
        public static int toplama(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static int çıkarma(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        public static int bölme(int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }

        public static int çarpma (int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }

    
}
