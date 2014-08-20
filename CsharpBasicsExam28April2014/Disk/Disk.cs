using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disk
{
    class Disk
    {
        static void Main(string[] args)
        {
            int n = byte.Parse(Console.ReadLine());
            int r = byte.Parse(Console.ReadLine());
            int distance=n/2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i-distance)*(i-distance)+(j-distance)*(j-distance)<=r*r)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
