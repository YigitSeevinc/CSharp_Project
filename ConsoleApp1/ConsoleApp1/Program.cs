using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] N = new byte[5];
            byte s1, s2, p1, p2;

            for (byte i = 1; i<=4; i++)
            {
                Console.Write(i + ". notu giriniz: ");
                N[i] = Convert.ToByte(Console.ReadLine());
            }

            s1 = N[1];
            s2 = N[2];
            p1 = N[3];
            p2 = N[4];
           int o = (s1 + s2 + p1 + p2) / 4;
           Console.WriteLine("Ortalamanız: " + o);

            if(o >=85 && o <= 100)
            {
                Console.Write("ÇOK İYİ");
            }
            else if(o >=70 && o < 85)
            {
                Console.WriteLine("İYİ");
            }
            else if (o >=40 && o < 70)
            {
                Console.WriteLine("ORTA");
            }
            else if(o >= 0 && o < 40)
            {
                Console.WriteLine("BAŞARISIZ");
            }
            Console.ReadKey();

            
        }
    }
}
