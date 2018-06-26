using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fu6
{
    class Program
    {
        static double Average(double c1, double c2, double c3)
        {
            return (c1 + c2 + c3) / 3;
        }

        static void Main(string[] args)
        {
            double n, m, k;
            Console.Write("n="); n = double.Parse(Console.ReadLine());
            Console.Write("m="); m = double.Parse(Console.ReadLine());
            Console.Write("k="); k = double.Parse(Console.ReadLine());
            double ser = Average(n, m, k);
            Console.WriteLine("Average = {0} ", ser);
            Console.ReadKey();
        }
    }
}
