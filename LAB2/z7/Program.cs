using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double aInGRad;
            aInGRad = Convert.ToDouble(Console.ReadLine());
            double aInRad;
           aInRad = aInGRad * Math.PI /180;
                Console.WriteLine("{0:F4}",aInRad);
          




        }
    }
}
