using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSum
{
    class CalculateSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            double factorial = 1;
            double pow = 1;
            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                pow *= x;
                sum = sum + (factorial / pow);
            }
            Console.WriteLine("{0:0.00000}",sum);
        }
    }
}
