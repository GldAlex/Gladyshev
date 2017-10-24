using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double b;
            b = Convert.ToDouble(Console.ReadLine());
            if (b <= 0)
            {
                Console.WriteLine("Значение base должно быть положительным");
                return;
            }
            double h;
            h = Convert.ToDouble(Console.ReadLine());
            if (h <= 0)
            {
                Console.WriteLine("Значение height должно быть положительным");
                return;
            }
            double area;
            area = b * h / 2;
            Console.WriteLine("{0:F2}", area);





        }
    }
}
