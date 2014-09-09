using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                {
                    if (i == 0 || i == n - 1)
                    {
                        WriteTopBottomPart(n);
                    }
                    else
                    {
                        WriteMiddlePart(n, i);
                    }
                }
            }
        }
        private static void WriteTopBottomPart(int n)
        {
            string frame = new string('*', n);
            string spaces = new string(' ', n);
            
                Console.WriteLine("{0}{1}{0}",frame,spaces,frame);
  
        }
        private static void WriteMiddlePart(int n, int i)
        {
            string lens = new string('/', n - 2);
            string bridge = new string(' ', n);
            string middleFrame = string.Format("{0}{1}{0}", '*', lens);
            if (i==n/2)
            {
                bridge = new string('|', n);
            }
            Console.WriteLine("{0}{1}{2}",middleFrame,bridge,middleFrame);
        }
    }
}
