using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFactorialDivision
{
    class CalculateFactorialDivision
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            double factoialN = 1;
            double factorialK = 1;
            double division = 0;
            if (n<=1||k>n||n>100)
            {
                Console.WriteLine("Bad Input");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i<=k)
                    {
                        factorialK *= i;
                    }
                    factoialN *= i;
                }
                Console.WriteLine(factoialN/factorialK);
            }
        }
    }
}
