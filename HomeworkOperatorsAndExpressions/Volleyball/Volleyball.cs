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
            float p = float.Parse(Console.ReadLine());
            float h = float.Parse(Console.ReadLine());
            float result = ((48 - h) * 3 / 4)+(p*2/3)+h;
            if (isLeap=="leap")
            {
                result *= 1.15f;
            }
            Console.WriteLine((int)result);
        }
    }
}
