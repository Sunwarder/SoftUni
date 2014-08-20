using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBoxInBox
{
    class FitBoxInBox
    {
        static void Main(string[] args)
        {
            short a = short.Parse(Console.ReadLine());
            short b = short.Parse(Console.ReadLine());
            short c = short.Parse(Console.ReadLine());
            short w = short.Parse(Console.ReadLine());
            short h = short.Parse(Console.ReadLine());
            short d = short.Parse(Console.ReadLine());
            if ((a < w) && (b < h) && (c < d))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", a, b, c, w, h, d);
            }
            if ((a < w) && (b < d) && (c < h))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", a, b, c, w, d, h);
            }
            if ((a < h) && (b < w) && (c < d))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", a, b, c, h, w, d);
            }
            if ((a < h) && (b < d) && (c < w))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", a, b, c, h, d, w);
            }
            if ((a < d) && (b < h) && (c < w))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", a, b, c, d, h, w);
            }
            if ((a < d) && (b < w) && (c < h))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", a, b, c, d, w, h);
            } 
            if ((w < a) && (h < b) && (d < c))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w, h, d, a, b, c);
            }
            if ((w < a) && (h < c) && (d < b))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w, h, d, a, c, b);
            }
            if ((w < b) && (h < a) && (d < c))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w, h, d, b, a, c);
            }
            if ((w < b) && (h < c) && (d < a))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w, h, d, b, c, a);
            }
            if ((w < c) && (h < a) && (d < b))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w, h, d, c, a, b);
            }
            if ((w < c) && (h < b) && (d < a))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w, h, d, c, b, a);
            }
        }
    }
}
