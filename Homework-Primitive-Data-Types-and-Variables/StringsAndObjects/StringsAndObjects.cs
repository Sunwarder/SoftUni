﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string firstWord = "Hello";
            string secondWord = "World!";
            object concat = firstWord + " " + secondWord;
            string typeCasted = (string)concat;
            Console.WriteLine(concat);
            Console.WriteLine(typeCasted);
        }
    }
}
