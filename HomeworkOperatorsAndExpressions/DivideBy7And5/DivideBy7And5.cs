using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if ((number % 5 == 0) && (number % 7 == 0))
            {
                Console.WriteLine("The number {0} is divideable by both 7 and 5", number);
            }
            else
            {
                Console.WriteLine("The number {0} is not divideable by both 7 and 5", number);
            }
        }
    }
}