using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 999; i++)
            {
                if (i % 2 == 1)
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
