using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSum
{
    class HalfSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1=0;
            for (int i = 0; i < n; i++)
            {
                int c = int.Parse(Console.ReadLine());
                sum1 += c;
            }
            int sum2=0;
            for (int i = 0; i < n; i++)
            {
                int c = int.Parse(Console.ReadLine());
                sum2 += c;
            }
            int diff = Math.Abs(sum1 - sum2);
            if(diff==0)
            {
                Console.WriteLine("Yes, sum={0}",sum1);
            }
            else
            {
                Console.WriteLine("No, diff={0}",diff);
            }
        }
    }
}
