using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fu5
{
    class Program
    {
        static void Kurs(double grn, double dolar, double evro)//передача параметрів у процедуру
        {
            double d, e;
            d = grn / dolar;
            e = grn / evro;
            Console.WriteLine("Гривень {0} первести в долари буде {1}\nГривнi в євро {2}", grn, d, e);
        }
        static void Main(string[] args)
        {
            double g, d, e;
            Console.Write("Введіть суму в гривнях");
            g = double.Parse(Console.ReadLine());
            Console.Write("Введіть курс долара");
            d = double.Parse(Console.ReadLine());
            Console.Write("Введіть курс євро");
            e = double.Parse(Console.ReadLine());
            Kurs(g, d, e);
            Console.ReadKey();


        }
    }
}
