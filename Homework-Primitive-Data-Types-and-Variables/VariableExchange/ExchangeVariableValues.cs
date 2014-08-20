using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableExchange
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("The numbers are now a={0} and b={1}",a,b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("The numbers have now exchanged their values and are now a={0} and b={1}",a,b);
        }
    }
}
