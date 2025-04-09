using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iki_sayı_hangiisi_büyük
{
    internal class Program
    {
        public static void Main(string[] args)
        {       
            while (true)
            {
                sınıfım k = new sınıfım();

                Console.WriteLine("");      
                Console.Write("1. sayıyı gir: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("2. sayıyı gir: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                k.karşılaştırma(sayi1, sayi2);

                Console.ReadKey();
            }
               
            
            
        }

         public class sınıfım
        {
            public void karşılaştırma(int sayi1 , int sayi2) 
            {
                if(sayi1 > sayi2)
                {
                    Console.Write("1. sayı büyüktür.");
                    Console.WriteLine("");
                }
                else if(sayi1 < sayi2)
                {
                    Console.Write("2. sayı büyüktür.");
                    Console.WriteLine("");
                }
                else
                {
                    Console.Write("Sayılar eşittir.");
                    Console.WriteLine("");
                }                 
            }
           

        }
    }
}
