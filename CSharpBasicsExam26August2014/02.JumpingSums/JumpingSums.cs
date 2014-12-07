using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingSums
{
    class JumpingSums
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            int[] numbers = new int[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                numbers[i] = int.Parse(line[i]);
            }
            int numberOfJumps = int.Parse(Console.ReadLine());

            int maxSum = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                int value = numbers[i];
                int currentIndex = i;
                int nextIndex = (currentIndex + value) % numbers.Length;
                int currentSum = 0;

                for (int j = 0; j <= numberOfJumps; j++)
                {
                    currentSum += value;
                    value = numbers[nextIndex];
                    currentIndex = nextIndex;
                    nextIndex = (currentIndex + value) % numbers.Length;
                }

                if (currentSum>maxSum)
                {
                    maxSum = currentSum;
                }
            }
            Console.WriteLine("max sum = {0}", maxSum);
        }
    }
}
