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
            string[] numbers = new string[amount];
            int rightDiagonalCounter = 0;
            int leftDiagonalCounter = 0;
            int verticalCounter = 0;
            for (int i = 0; i < amount; i++)
            {
                int number=int.Parse(Console.ReadLine());
                numbers[i] = Convert.ToString(number,2).PadLeft(32, '0');
                string numberAsString = numbers[i];
                char[] numbersCharacters = numberAsString.ToCharArray();
                Array.Reverse(numbersCharacters);
                numbers[i] = new string(numbersCharacters);
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine(rightDiagonalCounter);
            Console.WriteLine(leftDiagonalCounter);
            Console.WriteLine(verticalCounter);
        }
    }
}
