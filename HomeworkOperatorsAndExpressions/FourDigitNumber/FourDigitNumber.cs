using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int a = (number / 1000) % 10;
            int b = (number / 100) % 10;
            int c = (number / 10) % 10;
            int d = number % 10;
            Console.WriteLine("The sum of the number's digits is: {0}",a+b+c+d);
            Console.WriteLine("The number in reversed order is: "+d+c+b+a);
            Console.WriteLine("Last digit in first position: "+d+a+b+c);
            Console.WriteLine("Exchange the second and third digits: "+a+c+b+d);
        }
    }
}
