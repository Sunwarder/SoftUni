using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInCircle
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if(x*x+y*y<4)
            { 
                Console.WriteLine("The point is inside the circle");
            }
            else
            {
                Console.WriteLine("The point is outside the circle");
            }
        }
    }
}
