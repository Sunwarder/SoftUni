using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort3NumbersWithNestedIfs
{
    class Sort3NumbersWithNestedIfs
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a>=b)
            {
                if (b>=c)
                {
                    Console.Write("{0} {1} {2}\n", a, b, c);
                }
                else
                {
                    b = b + c;
                    c = b - c;
                    b = b - c;
                    if (a>=b)
                    {
                          Console.Write("{0} {1} {2}\n", a, b, c);          
                    }
                    else
                    {
                        a = a + b;
                        b = a - b;
                        a = a - b;
                        Console.Write("{0} {1} {2}\n", a, b, c);
                    }
                }
            }
            else
            {
                a = a + b;
                b = a - b;
                a = a - b;
                if (b>=c)
                {
                    Console.Write("{0} {1} {2}\n", a, b, c);
                }
                else
                {
                    b = b + c;
                    c = b - c;
                    b = b - c;
                    if (a>=b)
                    {
                        Console.Write("{0} {1} {2}\n", a, b, c);
                    }
                    else
                    {
                        a = a + b;
                        b = a - b;
                        a = a - b;
                        Console.Write("{0} {1} {2}\n", a, b, c);
                    }
                }
            }
        }
    }
}
