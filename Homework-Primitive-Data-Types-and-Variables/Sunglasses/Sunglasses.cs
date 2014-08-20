using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if(i==0||i==n-1)
                {
                    PrintTopBottomPart(n);
                }
                else 
                {
                    PrintMiddlePart(n, i);
                }
            }
        }
        private static void PrintTopBottomPart(int n)
        {
            string frame = new string('*', 2 * n);
            string emptySpace = new string(' ', n);
            Console.WriteLine("{0}{1}{2}",frame,emptySpace,frame);
        }
        private static void PrintMiddlePart(int n, int i)
        {
            string lens = new string('/', n*2 - 2);
            string middleFrame = string.Format("{0}{1}{0}", '*', lens);
            string bridge = new string(' ', n);
            if(i==n/2)
            {
                bridge = new string('|', n);
            }
            Console.WriteLine("{0}{1}{0}",middleFrame,bridge);
        }

    }
}
