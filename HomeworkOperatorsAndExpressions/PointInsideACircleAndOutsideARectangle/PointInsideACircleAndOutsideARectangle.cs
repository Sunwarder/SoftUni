using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInsideACircleAndOutsideARectangle
{
    class PointInsideACircleAndOutsideARectangle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if((x-1)*(x-1)+(y-1)*(y-1)<1.5*1.5)
            {
                if((x>1||x<5)&&((y<1)||(y>-1)))
                {
                    Console.WriteLine("No");
                }
                else
                {
                    Console.WriteLine("Yes");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
