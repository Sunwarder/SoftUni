using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int divisionsCount = 0;
            for (int i = 2; i <=number/2; i++)
            {
                if(number%i==0)
                {
                    divisionsCount++;
                }
            }
            Console.WriteLine(divisionsCount>2?"The number is not prime":"The number is prime");
        }
    }
}
