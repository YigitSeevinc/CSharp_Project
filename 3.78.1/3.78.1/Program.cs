using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._78._1
{
    class Ucgen
    {
        private int Pi, r;
        public Ucgen(int Pi, int r)
        {
            this.Pi = Pi;
            this.r = r;
        }
        public int AlanHesapla()
        {
            return Pi * (r * r);
        }
        public int CevreHesapla() 
        {
            return (2 * Pi) * r;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ucgen U = new Ucgen(3,2);
            Console.WriteLine("Ucgen'in alanı: {0}", U.AlanHesapla());
            Console.WriteLine("Ucgen'in çevresi: {0}", U.CevreHesapla());
        }
    }
}
