using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateGCD
{
    class CalculateGCD
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int currentDivisor = b;
            do
            {
                currentDivisor = a % b;
                if (currentDivisor == 0)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    a = b;
                    b = currentDivisor;
                }
            }
            while (currentDivisor != 0);
        }
    }
}
