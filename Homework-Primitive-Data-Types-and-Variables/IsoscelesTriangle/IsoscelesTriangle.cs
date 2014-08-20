using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char copyright = '\u00A9';
            Console.WriteLine("   {0}",copyright);
            Console.WriteLine("  {0} {1}",copyright,copyright);
            Console.WriteLine(" {0}   {1}",copyright,copyright);
            Console.WriteLine("{0} {1} {2} {3}",copyright,copyright,copyright,copyright);
        }
    }
}
