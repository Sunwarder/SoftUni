using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;
            double a = -0.0000007;
            double b = 0.00000007;
            double result = Math.Abs(a - b);
            bool areEqual = result < eps;
            Console.WriteLine(areEqual);
        }
    }
}
