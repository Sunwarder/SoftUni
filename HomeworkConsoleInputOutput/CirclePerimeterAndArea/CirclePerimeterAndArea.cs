using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter: {0:0.00}. Area: {1:0.00}",2*r*Math.PI,r*r*Math.PI);
        }
    }
}
