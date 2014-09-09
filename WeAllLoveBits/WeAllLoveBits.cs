using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAllLoveBits
{
    class WeAllLoveBits
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            for (int i = 0; i < amount; i++)
            {
                long n = long.Parse(Console.ReadLine());
                string num = Convert.ToString(n, 2);
                long invertedBitsNumber = n;
                for (int j = 0; j < num.Length; j++)
                {
                    invertedBitsNumber = invertedBitsNumber ^ (1 << j);
                }
                string newNumString = Reverse(num);
                long reversedBitsNumber = Convert.ToInt64(newNumString, 2);
                Console.WriteLine((n^invertedBitsNumber)&reversedBitsNumber);
            }
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
