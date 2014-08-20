using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexademicalToDecimal
{
    class HexademicalToDecimal
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            char[] hexArray = hex.ToCharArray();
            Array.Reverse(hexArray);
            string hexNew = new string(hexArray);
            long number = 0;
            for (int i = 0; i <hexNew.Length; i++)
            {
                switch (hexNew[i])
                {
                    case '0':
                        break;
                    case '1': number +=(long)Math.Pow(16, i);
                        break;
                    case '2': number += 2 * (long)Math.Pow(16, i);
                        break;
                    case '3': number += 3 * (long)Math.Pow(16, i);
                        break;
                    case '4': number += 4 * (long)Math.Pow(16, i);
                        break;
                    case '5': number += 5 * (long)Math.Pow(16, i);
                        break;
                    case '6': number += 6 * (long)Math.Pow(16, i);
                        break;
                    case '7': number += 7 * (long)Math.Pow(16, i);
                        break;
                    case '8': number += 8 * (long)Math.Pow(16, i);
                        break;
                    case '9': number += 9 * (long)Math.Pow(16, i);
                        break;
                    case 'A': number += 10 * (long)Math.Pow(16, i);
                        break;
                    case 'B': number += 11 * (long)Math.Pow(16, i);
                        break;
                    case 'C': number += 12 * (long)Math.Pow(16, i);
                        break;
                    case 'D': number += 13 * (long)Math.Pow(16, i);
                        break;
                    case 'E': number += 14 * (long)Math.Pow(16, i);
                        break;
                    case 'F': number += 15 * (long)Math.Pow(16, i);
                        break;
                }
            }
            Console.WriteLine(number);
        }
    }
}
