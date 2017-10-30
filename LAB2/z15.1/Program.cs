using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z15._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempInC;
            tempInC = Convert.ToDouble(Console.ReadLine());
            double tempInF;
            if (tempInC < -273.15)
            {
                Console.WriteLine("Температура должна быть выше абсолютного нуля");
            }
            else
            {
                tempInF = tempInC * 1.8 + 32;
                Console.WriteLine("{0:F4}", tempInF);  }
        }
    }
}
