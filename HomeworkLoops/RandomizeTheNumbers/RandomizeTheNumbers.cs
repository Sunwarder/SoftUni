using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeTheNumbers
{
    class RandomizeTheNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = i+1;
            }
            Shuffle(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        public static void Shuffle<arr>(arr[] array)
        {
            Random rnd=new Random();
            for (int i = array.Length; i >1; i--)
			{
                int j = rnd.Next(i);
                arr temp = array[j];
                array[j] = array[i - 1];
                array[i - 1] = temp;
			}
        }
    }
}
