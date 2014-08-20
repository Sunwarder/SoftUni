using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfLetters
{
    class CountOfLetters
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<char> letters = ConvertToList(input);
            Dictionary<char, int> result = GetLettersAndOccurances(letters);
            foreach (var letter in result)
            {
                Console.WriteLine("{0} -> {1}", letter.Key, letter.Value);
            }
        }
        private static List<char> ConvertToList(string[] array)
        {
            List<char> list = new List<char>();
            for (int i = 0; i < array.Length; i++)
            {
                list.Add(char.Parse(array[i]));
            }
            return list;
        }
        private static Dictionary<char, int> GetLettersAndOccurances(List<char> list)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();
            list.Sort();
            int i = 0;
            int counter = 1;
            do
            {
                if (i == list.Count - 1)
                {
                    result.Add(list[i], counter);
                    i++;
                }
                else
                {
                    if (list[i] == list[i + 1])
                    {
                        counter++;
                        i++;
                    }
                    else
                    {
                        result.Add(list[i], counter);
                        counter = 1;
                        i++;
                    }
                }
            } while (i + 1 <= list.Count);
            return result;
        }
    }
}
