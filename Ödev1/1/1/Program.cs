using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        void Topla_Carp(int a,int b, ref int add, ref int mult)
        {
            add = a + b;
            mult = a * b;
           
        }

        static void Main(string[] args)
        {
            int a = 5, b = 10, add = 0, mult = 0;
            Program p = new Program();
            p.Topla_Carp(a, b, ref add, ref mult);
            Console.WriteLine("Toplam: {0} Çarpım: {1}", add, mult);
            Console.ReadKey();
        }
    }
}
