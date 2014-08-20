using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? nullInt=null;
            double? nullDouble=null;
            Console.WriteLine(nullInt);
            Console.WriteLine(nullDouble);
            nullInt = 5;
            nullDouble = 4.76;
            Console.WriteLine(nullInt.GetValueOrDefault());
            Console.WriteLine(nullDouble.GetValueOrDefault());
        }
    }
}
