using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsUp
{
    class BitsUp
    {
        static void Main()
        {
            {
                int n = int.Parse(Console.ReadLine());
                int step = int.Parse(Console.ReadLine());
                byte[] bytes = ReadAndWriteInArray(n);
                int index = 0;
                for (int i = 0; i < bytes.Length; i++)
                {
                    byte num = bytes[i];
                    for (int bit = 7; bit >= 0; bit--)
                    {
                        if ((index % step == 1) || (step == 1 && index > 0))
                        {
                            num |= (byte)(1 << bit);
                        }
                        index++;
                    }
                    Console.WriteLine(num);
                }
            }
        }
        private static byte[] ReadAndWriteInArray(int count)
        {
            byte[] arr = new byte[count];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = byte.Parse(Console.ReadLine());
            }
            return arr;
        }
    }
}
