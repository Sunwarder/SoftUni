using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitFlipper
{
    class BitFlipper
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            string bits = Convert.ToString((long)n, 2).PadLeft(64,'0');
            char[] bitsArr=bits.ToCharArray();
            for (int i = 0; i < bitsArr.Length; i++)
            {
                if (i+2<bitsArr.Length)
                {
                    if (bitsArr[i]=='0'&&bitsArr[i+1]=='0'&&bitsArr[i+2]=='0')
                    {
                        bitsArr[i] = '1';
                        bitsArr[i+1] = '1';
                        bitsArr[i+2] = '1';
                        i += 2;
                    }
                    else if (bitsArr[i] == '1' && bitsArr[i + 1] == '1' && bitsArr[i + 2] == '1')
                    {
                        bitsArr[i] = '0';
                        bitsArr[i+1] = '0';
                        bitsArr[i+2] = '0';
                        i += 2;
                    }
                }
            }
            bits = new string(bitsArr);
            ulong newNum = Convert.ToUInt64(bits, 2);
            Console.WriteLine(newNum);
        }
    }
}
