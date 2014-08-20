using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesAndStrings
{
    class QuotesAndStrings
    {
        static void Main(string[] args)
        {
            string notQuoted = "The \"use\" of quotations causes difficulties";
            string quoted = @"The ""use"" of quotations causes difficulties";
            Console.WriteLine(notQuoted);
            Console.WriteLine(quoted);
        }
    }
}
