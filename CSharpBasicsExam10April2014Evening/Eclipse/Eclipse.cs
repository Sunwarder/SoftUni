using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eclipse
{
    class Eclipse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i==0||i==n-1)
                {
                    string frame = new string('*', 2*n - 2);
                    string bridge = new string(' ', n - 1);
                    Console.WriteLine(" {0} {1} {0} ",frame,bridge);
                }
                else
                {
                    string lense = new string('/', 2 * n - 2);
                    string bridge = new string(' ', n - 1);
                    if (i==(n-1)/2)
                    {
                        bridge = new string('-', n - 1);
                    }
                    Console.WriteLine("*{0}*{1}*{0}*",lense,bridge);
                }
            }
        }
    }
}
