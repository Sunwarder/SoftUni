using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyABitAtAGivenPosition
{
    class ModifyABitAtAGivenPosition
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            if(v==0)
            {
                int mask = ~(1 << p);
                int result=n & mask;
                Console.WriteLine(result);
            }
            else
            {
                int mask = 1 << p;
                int result = n | mask;
                Console.WriteLine(result);
            }
        }
    }
}
