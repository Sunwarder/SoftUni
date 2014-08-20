using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInIntervalDivideableByGivenNumber
{
    class NumbersInIntervalDivideableByGivenNumber
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int p = 0;
            if (a>b)
            {
                while (b<=a)
                {
                    if (b%5==0)
                    {
                        Console.WriteLine(b);
                        p++;
                    }
                    b++;
                }
            }
            else
            {
                while (a<=b)
                {
                    if (a%5==0)
                    {
                        Console.WriteLine(a);
                        p++;
                    }
                    a++;
                }
            }
            Console.WriteLine("p={0}",p);
        }
    }
}
