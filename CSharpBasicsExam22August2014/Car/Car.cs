using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        static void Main(string[] args)
        {
            byte input = byte.Parse(Console.ReadLine());
            byte roofBodyHeight = (byte)(input / 2);
            byte wheelsHeight = (byte)(input / 2 - 1);
            for (int i = 0; i < roofBodyHeight + 1; i++)
            {
                string outerDots = new string('.', input - i);
                string middleDots = new string('.', 3 * input - 2 * (input - i) - 2);
                if (i==0)
                {
                    middleDots = new string('*', 3 * input - 2 * (input - i) - 2);
                }
                if (i == roofBodyHeight)
                {
                    outerDots = new string('*', input - i);
                }
                Console.WriteLine("{0}*{1}*{0}",outerDots,middleDots);  
            }
            for (int i = 0; i < roofBodyHeight-1; i++)
            {
                string dots = new string('.', 3 * input - 2);
                if (i==roofBodyHeight-2)
                {
                    dots = new string('*', 3 * input - 2);
                }
                Console.WriteLine("*{0}*",dots);
            }
            for (int i = 0; i < wheelsHeight; i++)
            {
                string outerDots = new string('.', input / 2);
                string middleDots = new string('.', input - 2);
                string tyreDots = new string('.', wheelsHeight);
                if (i==wheelsHeight-1)
                {
                    tyreDots = new string('*', wheelsHeight);
                }
                Console.WriteLine("{0}*{1}*{2}*{1}*{0}",outerDots,tyreDots,middleDots);
            }
        }
    }
}
