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
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }
        private static long Fib(long n)
        {
            long a = 1;
            long b = 1;
            long c = 0; ;
            for (long i = 0; i < n-1; i++)
            {
                c = b + a;
                a = b;
                b = c;
            }
            return c;
        }
        //Way number 2
        //static long Fib(int n)
        //{
        //    if (n <= 2)
        //    {
        //        return 1;
        //    }
        //    return Fib(n - 1) + Fib(n - 2);
        //}
    }
}
