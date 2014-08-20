using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isOdd = ((num % 2) == 1);
            Console.WriteLine("It is {0} that {1} is odd", isOdd, num);
        }
    }
}
