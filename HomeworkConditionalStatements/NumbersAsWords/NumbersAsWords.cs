using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersAsWords
{
    class NumbersAsWords
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] hundreds = { "one hundred", "two hundred", "three hundred", "four hundred",
            "five hundred","six hundred","seven hundred","eight hundred","nine hundred"};
            string[] tenths = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] numbers = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                                   "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", 
                                   "seventeen", "eighteen","nineteen" };
            int hundredsIndex = 0;
            int tenthsIndex = 0;
            if (number==0)
            {
                Console.WriteLine("zero");
            }
            else if ((number/100)>0)
            {
                hundredsIndex = number / 100;
                number %= 100;
                if (number == 0)
                {
                    Console.WriteLine(hundreds[hundredsIndex - 1]);
                }
                else 
                {
                    if (number<20)
                    {
                        Console.WriteLine("{0} and {1}", hundreds[hundredsIndex - 1], numbers[number - 1]);
                    }
                    else
                    {
                        tenthsIndex = number / 10;
                        number %= 10;
                        if (number == 0)
                        {
                            Console.WriteLine("{0} and {1}", hundreds[hundredsIndex - 1], tenths[tenthsIndex - 2]);
                        }
                        else
                        {
                            Console.WriteLine("{0} and {1} {2}", hundreds[hundredsIndex - 1], tenths[tenthsIndex - 2], numbers[number - 1]);
                        }
                    }
                }
            }
            else
            {
                if (number<20)
                {
                    Console.WriteLine(numbers[number-1]);
                }
                else
                {
                    tenthsIndex = number / 10;
                    number %=10;
                    if (number==0)
                    {
                        Console.WriteLine(tenths[tenthsIndex-2]);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1}",tenths[tenthsIndex-2],numbers[number-1]);
                    }
                }
            }
        }
    }
}
