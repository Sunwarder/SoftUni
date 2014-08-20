using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTheAsciiTable
{
    class PrintTheAsciiTable
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            for (int i = 0; i < 255; i++)
            {
                char ascii = (char)i;
                Console.WriteLine("The code is: {0} and the character is: {1}",i.ToString(),ascii);
            }
        }
    }
}
