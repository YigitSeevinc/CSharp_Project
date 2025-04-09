using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad;
            int i;

            Console.Write("Lütfen isminizi giriniz: ");
            ad = Console.ReadLine();

            for ( i=0 ; i<=10 ; i++ )
            {
                Console.WriteLine( ad );
            }
            Console.ReadKey();

        }
    }
}
