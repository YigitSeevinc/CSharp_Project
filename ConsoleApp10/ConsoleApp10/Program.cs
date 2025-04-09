using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + ". Sayıyı Giriniz :");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                
            }
            
            for(int j = 0; j < 5; j++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            
            Array.Sort(sayilar);
        }
    }
}
