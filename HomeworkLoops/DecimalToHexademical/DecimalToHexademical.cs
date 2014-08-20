using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexademical
{
    class DecimalToHexademical
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string hex = null;
            for (int i = 0; i < int.MaxValue; i++)
            {
                if (number==0)
                {
                    break;
                }
                else
                {
                    switch (number%16)
                    {
                        case 1: hex += '1'; 
                            break;
                        case 2: hex += '2'; 
                            break;
                        case 3: hex += '3'; 
                            break;
                        case 4: hex += '4'; 
                            break;
                        case 5: hex += '5'; 
                            break;
                        case 6: hex += '6'; 
                            break;
                        case 7: hex += '7'; 
                            break;
                        case 8: hex += '8'; 
                            break;
                        case 9: hex += '9'; 
                            break;
                        case 10: hex += 'A'; 
                            break;
                        case 11: hex += 'B'; 
                            break;
                        case 12: hex += 'C'; 
                            break;
                        case 13: hex += 'D'; 
                            break;
                        case 14: hex += 'E'; 
                            break;
                        case 15: hex += 'F'; 
                            break;
                    }
                    number /= 16;
                }
            }
            char[] hexArray = hex.ToCharArray();
            Array.Reverse(hexArray);
            string hexNew = new string(hexArray);
            Console.WriteLine(hexNew);
        }
    }
}
