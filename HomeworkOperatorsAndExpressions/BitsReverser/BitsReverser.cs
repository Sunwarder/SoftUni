using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsReverser
{
    class BitsReverser
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long newNum = n;
            string num = Convert.ToString(n, 2);
            for (int i = 0; i < num.Length/2; i++)
            {
                if ((n&(1<<i))!=(n&(1<<(num.Length-1-i))))
                {
                    if ((n&(1<<i))==0)
                    {
                        newNum = newNum & (~(1 << i));
                    }
                    else
                    {
                        newNum = newNum | (1 << i);
                    }
                    if ((n & (1 << (num.Length - 1 - i))) == 0)
                    {
                        newNum = newNum & (~(1 << (num.Length - 1 - i)));
                    }
                    else
                    {
                        newNum = newNum | (1 << (num.Length - 1 - i));
                    }
                }
            }
            Console.WriteLine(num);
            Console.WriteLine(Convert.ToString(newNum,2));
        }
    }
}
