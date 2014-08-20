using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNames
{
    class RemoveNames
    {
        static void Main(string[] args)
        {
            string[] namesArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] namesToRemoveArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> names = new List<string>();
            List<string> namesToRemove = new List<string>();
            for (int i = 0; i < namesArr.Length; i++)
            {
                names.Add(namesArr[i]);
            }
            for (int i = 0; i < namesToRemoveArr.Length; i++)
            {
                namesToRemove.Add(namesToRemoveArr[i]);
            }
            List<string> namesCopy = new List<string>(names);
            foreach (var name in names)
            {
                for (int i = 0; i < namesToRemove.Count; i++)
                {
                    if (namesToRemove[i]==name)
                    {
                        namesCopy.Remove(name);
                    }
                }
            }
            for (int i = 0; i < namesCopy.Count; i++)
            {
                if (i==namesCopy.Count-1)
                {
                    Console.WriteLine(namesCopy[i]);
                }
                else
                {
                    Console.Write("{0} ",namesCopy[i]);
                }
            }
        }
    }
}
