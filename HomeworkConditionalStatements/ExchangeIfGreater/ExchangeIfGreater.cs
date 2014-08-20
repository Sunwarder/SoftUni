using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (a>b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            Console.Write("{0} {1}\n", a, b);
        }
    }
}
