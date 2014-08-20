using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TrailingZeroesInN
{
    class TrailingZeroesInN
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            double pow = 1;
            BigInteger factor =0;
            BigInteger trailing = 0;
            do
            {
                factor = (BigInteger)Math.Pow(5, pow);
                trailing += n / factor;
                pow++;
            } 
            while (n/factor!=0);
            Console.WriteLine(trailing);
        }
    }
}
