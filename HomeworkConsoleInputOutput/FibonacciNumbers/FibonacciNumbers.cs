using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c = 0;
            Console.Write("0 1");
            for (int i = 0; i < n-2; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write(" {0}", c);
            }
            Console.WriteLine();
        }
    }
}
