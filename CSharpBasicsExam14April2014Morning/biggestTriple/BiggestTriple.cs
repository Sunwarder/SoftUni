using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biggestTriple
{
    class BiggestTriple
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }
            int biggestTriple = int.MinValue;
            string biggestSequence = null;
            if (numbers.Length % 3 == 0)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i<numbers.Length)
                    {
                        int currentTriple = numbers[i] + numbers[i + 1] + numbers[i + 2];
                        if (currentTriple>biggestTriple)
                        {
                            biggestTriple = currentTriple;
                            biggestSequence = string.Concat(numbers[i]," ",numbers[i+1]," ",numbers[i+2]);
                        }
                        i += 2;
                    }
                }
            }
            if (numbers.Length % 3 == 1)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i<numbers.Length-1)
                    {
                        int currentTriple = numbers[i] + numbers[i + 1] + numbers[i + 2];
                        if (currentTriple > biggestTriple)
                        {
                            biggestTriple = currentTriple;
                            biggestSequence = string.Concat(numbers[i], " ", numbers[i + 1], " ", numbers[i + 2]);
                        }
                        i += 2;
                    }
                    if (i==numbers.Length-1)
                    {
                        if (numbers[i]>biggestTriple)
                        {
                            biggestTriple = numbers[i];
                            biggestSequence=Convert.ToString(numbers[i]);
                        }
                    }
                }
            }
            if (numbers.Length % 3 == 2)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i<numbers.Length-2)
                    {
                        
                    }
                    if (i == numbers.Length - 2)
                    {
                        if (numbers[i] + numbers[i+1]> biggestTriple)
                        {
                            biggestTriple = numbers[i]+numbers[i+1];
                            biggestSequence = string.Concat(numbers[i], " ", numbers[i + 1]);
                        }
                    }
                }
            }
            Console.WriteLine(biggestSequence);
        }
    }
}
