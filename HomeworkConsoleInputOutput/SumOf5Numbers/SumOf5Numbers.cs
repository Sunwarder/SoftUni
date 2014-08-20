using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            double a=Convert.ToDouble(numbers[0]);
            double b=Convert.ToDouble(numbers[1]);
            double c=Convert.ToDouble(numbers[2]);
            double d=Convert.ToDouble(numbers[3]);
            double e=Convert.ToDouble(numbers[4]);
            double sum=a+b+c+d+e;
            Console.WriteLine(sum);
        }
    }
}
