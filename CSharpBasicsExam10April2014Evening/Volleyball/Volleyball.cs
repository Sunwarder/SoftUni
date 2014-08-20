using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string isLeap = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double result = 0;
            if (isLeap=="leap")
            {
                result = (p * 2 / 3) + ((48 - h) * 3 / 4) + h;
                Console.WriteLine((int)(result*1.15));
            }
            else
            {
                result = (p * 2 / 3) + ((48 - h) * 3 / 4) + h;
                Console.WriteLine((int)result);
            }
        }
    }
}
