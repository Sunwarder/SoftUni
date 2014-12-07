using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XBits
{
    class XBits
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[8];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int counter = 0;
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                int topNumber = numbers[i];
                int middleNumber = numbers[i + 1];
                int bottomNumber = numbers[i + 2];
                for (int bit = 0; bit < 32; bit++)
                {
                    bool checkTop = ((topNumber >> bit) & 7) == 5;
                    bool checkMid = ((middleNumber >> bit) & 7) == 2;
                    bool checkBot = ((bottomNumber >> bit) & 7) == 5;
                    if (checkTop && checkMid && checkBot)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
