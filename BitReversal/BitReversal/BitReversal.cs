using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitReversal
{
    class BitReversal
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            string num = Convert.ToString((long)n, 2);
            ulong[] bitsArray = num.Select(c => ulong.Parse(c.ToString())).ToArray();
            ulong[] reversedBitsArray = bitsArray;
            Array.Reverse(reversedBitsArray);
            string newNum = null;
            for (int i = 0; i < reversedBitsArray.Length; i++)
            {
                newNum += Convert.ToString(reversedBitsArray[i]);
            }
            ulong newN = Convert.ToUInt64(newNum, 2);
            Console.WriteLine(newN);
        }
    }
}