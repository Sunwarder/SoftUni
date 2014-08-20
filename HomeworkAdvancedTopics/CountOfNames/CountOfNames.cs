using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfNames
{
    class CountOfNames
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> names = ConvertToList(input);
            Dictionary<string, int> result = GetLettersAndOccurances(names);
            foreach (var name in result)
            {
                Console.WriteLine("{0} -> {1}", name.Key, name.Value);
            }
        }
        private static List<string> ConvertToList(string[] array)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < array.Length; i++)
            {
                list.Add(array[i]);
            }
            return list;
        }
        private static Dictionary<string, int> GetLettersAndOccurances(List<string> list)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
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
