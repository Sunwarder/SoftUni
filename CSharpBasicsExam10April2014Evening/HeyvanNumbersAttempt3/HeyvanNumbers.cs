using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeyvanNumbersAttempt3
{
    class HeyvanNumbers
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int abc = 555; abc <= 999; abc++)
            {
                int def = abc + diff;
                int ghi = def + diff;
                if (isAllowedNumber(abc)&&isAllowedNumber(def)&&isAllowedNumber(ghi)&&ghi<=999)
                {
                    if (CalcSumOfDigits(abc)+CalcSumOfDigits(def)+CalcSumOfDigits(ghi)==sum)
                    {
                        Console.WriteLine(string.Concat(abc,def,ghi));
                        counter++;
                    }
                }
            }
            if (counter==0)
            {
                Console.WriteLine("No");
            }
        }
        private static int CalcSumOfDigits(int number)
        {
            int result = number % 10 + ((number / 10) % 10) + ((number / 100) % 10);
            return result;
        }
        private static bool isAllowedNumber(int number)
        {
            if (number % 10 > 4 && number % 10 < 10 && (number / 10) % 10 > 4 && 
                (number / 10) % 10 < 10 && (number / 100) % 10 > 4 && (number / 100) % 10 < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
