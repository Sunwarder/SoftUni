using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSumAverage
{
    class MinMaxSumAverage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = 0;
            int max = 0;
            double sum = 0;
            double average = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i==0)
                {
                    min = number;
                    max = number;
                }
                sum += number;
                if (number<min)
                {
                    min = number;
                }
                if (number>max)
                {
                    max = number;
                }
            }
            average = sum / n;
            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("average = {0:0.00}", average);
        }
    }
}
