using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDowns
{
    class DoubleDowns
    {
        static void Main(string[] args)
        {
            byte amount = byte.Parse(Console.ReadLine());
            int[] numbers = new int[amount];
            int rightDiagonalCounter=0;
            int leftDiagonalCounter=0;
            int verticalCounter=0;
            for (int i = 0; i < amount; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length-1; i++)
            {
                int topNumber = numbers[i];
                int bottomNumber = numbers[i + 1];
                for (int bit = 0; bit < 32; bit++)
                {
                    int mask = 1 << bit;
                    bool checkTopBit = (topNumber & mask) > 0;
                    if (checkTopBit&&(bottomNumber&(mask>>1))>0)
                    {
                        rightDiagonalCounter++;
                    }
                    if (checkTopBit&&(bottomNumber&(mask<<1))>0)
                    {
                        leftDiagonalCounter++;
                    }
                    if (checkTopBit&&(bottomNumber&mask)>0)
                    {
                        verticalCounter++;
                    }
                }
                
            }
            Console.WriteLine(rightDiagonalCounter);
            Console.WriteLine(leftDiagonalCounter);
            Console.WriteLine(verticalCounter);
        }
    }
}
