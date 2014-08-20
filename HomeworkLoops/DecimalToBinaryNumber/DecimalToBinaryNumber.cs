using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinaryNumber
{
    class DecimalToBinaryNumber
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string[] binary=new string[64];
            for (int i = 0; i < int.MaxValue; i++)
            {
                if (n==0)
                {
                    break;
                }
                binary[i] = Convert.ToString(n%2);
                n /= 2;
            }
            Array.Reverse(binary);
            foreach (var bit in binary)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
        }
    }
}
