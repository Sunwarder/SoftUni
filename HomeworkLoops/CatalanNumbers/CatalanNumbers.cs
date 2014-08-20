using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorial2N = 1;
            BigInteger factorialN1 = 1;
            for (int i = 1; i <= 2*n; i++)
            {
                if (i<=n)
                {
                    factorialN *= i;
                }
                if (i<=n+1)
                {
                    factorialN1 *= i;
                }
                factorial2N *= i;
            }
            Console.WriteLine(factorial2N/(factorialN*factorialN1));
        }
    }
}
