using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWordInText
{
    class LongestWordInText
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(GetLongest(text));
        }
        private static string GetLongest (string[] array)
        {
            string longest = null;
            int maxLength = int.MinValue;
            foreach (var word in array)
            {
                char[] letters = word.ToCharArray();
                if (letters.Length > maxLength)
                {
                    longest = word;
                    maxLength = letters.Length;
                }
            }
            return longest;
        }
    }
}
