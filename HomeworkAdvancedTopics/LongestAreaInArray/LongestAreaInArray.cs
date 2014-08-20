using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestAreaInArray
{
    class LongestAreaInArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] elements = new string[n];
            for (int i = 0; i < n; i++)
            {
                elements[i] = Console.ReadLine();
            }
            int maxSequence = 0;
            int currSequence = 0;
            string value = null;
            for (int i = 0; i < elements.Length; i++)
            {
                if (i+1<elements.Length)
                {
                    if (elements[i] == elements[i + 1])
                    {
                        currSequence++;
                        if (maxSequence < currSequence)
                        {
                            maxSequence = currSequence;
                            value = elements[i];
                        }
                    }
                }
            }
            Console.WriteLine(maxSequence);
            for (int i = 0; i < maxSequence; i++)
            {
                Console.WriteLine(value);
            }
        }
    }
}
