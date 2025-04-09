using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte i;
            for( i = 0; i <= 101; i++)
            {
                byte[] x = new byte[101];
                x[i] = i;
                for (byte j = 0; j< 201; j += 2)
                {
                    
                    Console.WriteLine("Dizinin " + j + ". elemanı: " + i);
                }
                
            }
            
            Console.ReadKey();
        }
    }
}
