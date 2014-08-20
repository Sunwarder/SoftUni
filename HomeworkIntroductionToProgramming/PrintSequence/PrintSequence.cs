using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            for (int i=0;i<=9;i++)
            {
                if(i%2==1)
                {
                    Console.WriteLine(-1 * (i + 2));
                }
                else
                {
                    Console.WriteLine(i + 2);
                }
            }
        }
    }
}
