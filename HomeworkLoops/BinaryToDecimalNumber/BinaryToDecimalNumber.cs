using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimalNumber
{
    class BinaryToDecimalNumber
    {
        static void Main(string[] args)
        {
            string binery = Console.ReadLine();
            byte[] bineryArray = new byte[binery.Length];
            for (int i = 0; i < binery.Length; i++)
            {
                bineryArray[i] = byte.Parse(Convert.ToString(binery[i]));
            }
            Array.Reverse(bineryArray);
            long number = 0;
            long multiplier = 1;
            for (int i = 0; i < bineryArray.Length; i++)
            {
                number += bineryArray[i] * multiplier;
                multiplier *= 2;
            }
            Console.WriteLine(number);
        }
    }
}
