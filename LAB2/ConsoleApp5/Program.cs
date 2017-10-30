using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            double result;
            x = Console.ReadLine();
            double a;
            a = double.Parse(x);
            if (a >= 0)
            {
                a = 3*(Math.Sqrt(61-a));
                Console.WriteLine("{0:F4}" ,a);
            }
            else
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
            }
        }
    }
}