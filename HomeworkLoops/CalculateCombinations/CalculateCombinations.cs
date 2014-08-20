using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateCombinations
{
    class CalculateCombinations
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            double factorialN = 1;
            double factorialK = 1;
            double factorialDiff = 1;
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                if (i<=k)
                {
                    factorialK *= i;
                }
            }
            for (int i = 1; i <= n-k; i++)
            {
                factorialDiff *= i;
            }
            Console.WriteLine(factorialN/(factorialK*factorialDiff));
        }
    }
}
