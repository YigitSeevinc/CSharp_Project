using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinamik_dizi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            işlemler i = new işlemler();
            Console.WriteLine("toplam: " + i.Toplam(3));
            Console.WriteLine("toplam: " + i.Toplam(3,4,5));
            Console.WriteLine("toplam: " + i.Toplam(1,3,5,7,9));
            Console.ReadKey();

            int[] x = new int[3] {1,3,5};
            
        }
    }
    class işlemler
    {
        public int Toplam(params int[] sayilar)
        {
            int toplam = 0;
            foreach(var s in sayilar)
            {
                toplam += s;
            }
            return toplam;
        }
    }
}
