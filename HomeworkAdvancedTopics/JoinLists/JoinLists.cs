using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinLists
{
    class JoinLists
    {
        static void Main(string[] args)
        {
            string[] num1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] num2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> numbers1 = ConvertToList(num1);
            List<int> numbers2 = ConvertToList(num2);
            List<int> result = JoinAndSort(numbers1, numbers2);
            PrintList(result);
        }
        private static List<int> JoinAndSort(List<int> a, List<int> b)
        {
            List<int> newList = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                int counter = 0;
                foreach (var num in newList)
                {
                    if (a[i]==num)
                    {
                        counter++;
                    }
                }
                if (counter==0)
                {
                    newList.Add(a[i]);
                }
            }
            for (int i = 0; i < b.Count; i++)
            {
                int counter = 0;
                foreach (var num in newList)
                {
                    if (b[i] == num)
                    {
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    newList.Add(b[i]);
                }
            }
            newList.Sort();
            return newList;
        }
        private static List<int> ConvertToList(string[] array)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                list.Add(int.Parse(array[i]));
            }
            return list;
        }
        private static void PrintList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1)
                {
                    Console.WriteLine(list[i]);
                }
                else
                {
                    Console.Write("{0} ", list[i]);
                }
            }
        }
    }
}
