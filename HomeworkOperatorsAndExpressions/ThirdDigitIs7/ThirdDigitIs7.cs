using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if ((number / 100) % 10 == 7)
            {
                Console.WriteLine("The third digit is 7");
            }
            else
            {
                Console.WriteLine("The third digit is not 7");
            }
        }
    }
}