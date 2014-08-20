using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;
            for (int i = 0; i < 2*n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    sumOdd += number;
                }
                else
                {
                    sumEven += number;
                }
            }
            if (sumOdd==sumEven)
            {
                Console.WriteLine("Yes, sum={0}",sumEven);
            }
            else
            {
                Console.WriteLine("No, diff={0}",Math.Abs(sumEven-sumOdd));
            }
        }
    }
}
