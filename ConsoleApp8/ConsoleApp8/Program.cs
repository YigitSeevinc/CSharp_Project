using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] notlar = new int[4];
            
            for(int i = 1 ; i <= 4 ; i++)
            { 
                Console.Write(i+". NOTU GİR: ");
                notlar[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
            }
            

            int toplam = (notlar[0] + notlar[1] + notlar[2] + notlar[3])/4;
            Console.Write("toplam: " + toplam);

            try
            {
                if (toplam > 85)
                {
                    Console.WriteLine("");
                    Console.Write("Durumunuz çok iyi");
                }
                else if (toplam > 50 || toplam < 85)
                {
                    Console.WriteLine("");
                    Console.Write("Durumunuz iyi");
                }
                else
                {
                    Console.WriteLine("");
                    Console.Write("Durumunuz kaldı");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            Console.ReadKey();
        }
    }
    
}
