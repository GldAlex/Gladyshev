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
            double edge;
            edge = Convert.ToDouble(Console.ReadLine());
            double area;
            if (edge > 0)
            {
                area = 6 * edge * edge;
                Console.WriteLine(area);
            }
            else
                Console.WriteLine("Значение edge должно быть положительным");

        }
    }
}
