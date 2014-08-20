using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = (b * b) - (4 * a * c);
            double x1 = 0;
            double x2 = 0;
            if (d>0)
            {
                x1 = ((-b) - (Math.Sqrt(d))) / (2 * a);
                x2 = ((-b) + (Math.Sqrt(d))) / (2 * a);
                Console.WriteLine("x1={0}; x2={1}",x1,x2);
            }
            else if (d==0)
            {
                x1 = x2 = (-b) / (2 * a);
                Console.WriteLine("x1=x2={0}",x2);
            }
            else
            {
                Console.WriteLine("No real roots");
            }
        }
    }
}
