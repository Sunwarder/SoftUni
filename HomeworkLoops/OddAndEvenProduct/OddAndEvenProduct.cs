using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int oddProduct = 1;
            int evenProduct = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i%2==0)
                {
                    oddProduct *= Convert.ToInt32(numbers[i]);
                }
                else
                {
                    evenProduct *= Convert.ToInt32(numbers[i]);
                }
            }
            if (oddProduct==evenProduct)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}",oddProduct);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}",oddProduct);
                Console.WriteLine("even_product = {0}",evenProduct);
            }
        }
    }
}
