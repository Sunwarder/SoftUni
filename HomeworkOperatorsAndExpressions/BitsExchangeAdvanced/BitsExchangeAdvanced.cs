using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsExchangeAdvanced
{
    class BitsExchangeAdvanced
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number in range between 0 and {0}",uint.MaxValue);
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter the beginning of first sequence in range between 0 and 31");
            uint p = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter the beginning of second sequence in range between 0 and 31");
            uint q = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter sequence length");
            uint k = uint.Parse(Console.ReadLine());
            while ((q-p)<k)
            {
                Console.WriteLine("The sequences overlap. Reenter the beginnings of first and second sequence and the sequence length");
                p = uint.Parse(Console.ReadLine());
                q = uint.Parse(Console.ReadLine());
                k = uint.Parse(Console.ReadLine());
            }
            while(((p+k)>32)||((q+k)>32))
            {
                Console.WriteLine("Sequences are out of range.Reenter the beginnings of first and second sequence and the sequence length");
                p = uint.Parse(Console.ReadLine());
                q = uint.Parse(Console.ReadLine());
                k = uint.Parse(Console.ReadLine());
            }
            int mask = 0;
            int sequenceLength = (int)k - 1;
            while(sequenceLength>=0)
            {
                int temp = 1 << sequenceLength;
                mask = mask | temp;
                sequenceLength--;
            }
            if (q > p)
            {
                uint firstSequenceBits = n & ((uint)mask << (int)p);
                uint secondSequenceBits = n & ((uint)mask << (int)q);
                n = n & (~(((uint)mask) << (int)p)) & (~(((uint)mask) << (int)q));
                n = n | (firstSequenceBits << (int)(q - p)) | (secondSequenceBits >> (int)(q - p));
                Console.WriteLine(n);
            }
            else
            {
                uint firstSequenceBits = n & ((uint)mask << (int)q);
                uint secondSequenceBits = n & ((uint)mask << (int)p);
                n = n & (~(((uint)mask) << (int)q)) & (~(((uint)mask) << (int)p));
                n = n | (firstSequenceBits << (int)(p-q)) | (secondSequenceBits >> (int)(p-q));
                Console.WriteLine(n);
            } 
        }
    }
}
