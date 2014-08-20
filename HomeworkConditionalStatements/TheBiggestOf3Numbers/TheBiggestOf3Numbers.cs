using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestOf3Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double biggest = 0;
            if (a>b)
            {
                biggest = a;
            }
            else
            {
                biggest = b;
            }
            if (biggest>c)
            {
                Console.WriteLine(biggest);
            }
            else
            {
                biggest = c;
                Console.WriteLine(biggest);
            }
        }
    }
}
