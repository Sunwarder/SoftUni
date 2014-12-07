using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star
{
    class Star
    {
        static void Main(string[] args)
        {
            //Get input
            int n = int.Parse(Console.ReadLine());

            //Declare size variables
            int width = 2 * n + 1;
            int topMiddleHeight = n / 2;
            int legsHeight = n / 2 + 1;

            //Declare string variables
            string outerDots = new string('.', n);
            string innerDots;
            string legDots;

            //Static first line
            Console.WriteLine("{0}*{0}", outerDots, outerDots);

            //Top part
            for (int i = 1; i < topMiddleHeight; i++)
            {
                outerDots = new string('.', n - i);
                innerDots = new string('.', width - (2 * (n - i)) - 2);
                Console.WriteLine("{0}*{1}*{0}", outerDots, innerDots, outerDots);
            }

            //Static middle line
            outerDots = new string('*', legsHeight);
            innerDots = new string('.', width - (2 * legsHeight));
            Console.WriteLine("{0}{1}{0}", outerDots, innerDots, outerDots);

            //Middle part
            for (int i = 1; i < topMiddleHeight; i++)
            {
                outerDots = new string('.', i);
                innerDots = new string('.', width - 2 * i - 2);
                Console.WriteLine("{0}*{1}*{0}", outerDots, innerDots, outerDots);
            }

            //Static top of legs line
            outerDots = new string('.', legsHeight - 1);
            legDots = new string('.', topMiddleHeight - 1);
            Console.WriteLine("{0}*{1}*{1}*{0}", outerDots, legDots, legDots, outerDots);

            //Legs part
            for (int i = 1; i < legsHeight - 1; i++)
            {
                outerDots = new string('.', legsHeight - i - 1);
                legDots = new string('.', topMiddleHeight - 1);
                innerDots = new string('.', width - (2 * legDots.Length + 2 * outerDots.Length + 4));
                Console.WriteLine("{0}*{1}*{2}*{1}*{0}", outerDots, legDots, innerDots, legDots, outerDots);
            }

            //Static last line
            legDots = new string('*', legsHeight - 2);
            innerDots = new string('.', width - 2 * legsHeight);
            Console.WriteLine("*{0}*{1}*{0}*", legDots, innerDots, legDots);
        }
    }
}
