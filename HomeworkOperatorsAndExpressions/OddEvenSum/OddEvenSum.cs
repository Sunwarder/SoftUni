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
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i < 2*n; i++)
            {
                if (i%2==1)
                {
                    oddSum += int.Parse(Console.ReadLine());
                }
                else
                {
                    evenSum += int.Parse(Console.ReadLine());
                }
            }
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes, sum={0}", oddSum);
            }
            else
            {
                Console.WriteLine("No, diff={0}", Math.Abs(oddSum - evenSum));
            }
        }
    }
}
