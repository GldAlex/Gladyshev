using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z16
{
    class Program
    {
        static void Main(string[] args)
        {
            double result,
                   x = double.Parse(Console.ReadLine()),
              y = double.Parse(Console.ReadLine());

            { Console.WriteLine("Значение y должно быть неотрицательным"); }
             
            {
                    result = -5 * Math.Sqrt(x + (Math.Sqrt(y)));
                    Console.WriteLine("{0:F4}", result);
                }
            }
        }
    }