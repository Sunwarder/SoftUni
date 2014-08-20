using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanNumbersAttempt2
{
    class HayvanNumbers
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int ghi = 555; ghi <= 999; ghi++)
            {
                for (int def = 555; def <= 999; def++)
                {
                    for (int abc = 555; abc <= 999; abc++)
                    {
                        if (isAllowedNumber(abc)&&isAllowedNumber(def)&&isAllowedNumber(ghi)&&(abc<def)&&(def<ghi)&&(ghi-def==diff)&&(def-abc==diff)
                            &&(CalcSumOfDigits(abc)+CalcSumOfDigits(def)+CalcSumOfDigits(ghi)==sum))
                        {
                            Console.WriteLine(string.Concat(abc,def,ghi));
                            counter++;
                        }
                    }
                }
            }
            if (counter==0)
            {
                Console.WriteLine("No");
            }
        }
        private static int CalcSumOfDigits (int number)
        {
            int result = number % 10 + ((number / 10) % 10) + ((number / 100) % 10);
            return result;
        }
        private static bool isAllowedNumber(int number)
        {
            if (number%10>4&&number%10<10&&(number/10)%10>4&&(number/10)%10<10&&(number/100)%10>4&&(number/100)%10<10)
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
