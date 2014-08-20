using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFigure
{
    class DrawFigure
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            for (int i = 0; i < (n+1)/2; i++)
            {
                    string asterisks = new string('*', n - 2 * i);
                    string dots = new string('.', i);
                    Console.WriteLine("{0}{1}{0}", dots, asterisks);
            }
            int a = 3;
            int b = (n - 3) / 2;
            for (int i = 0; i < (n-1)/2; i++)
            {
                string asterisks = new string('*', a);
                string dots = new string('.', b);
                a += 2;
                b--;
                Console.WriteLine("{0}{1}{0}", dots, asterisks);
            }
        }
    }
}
