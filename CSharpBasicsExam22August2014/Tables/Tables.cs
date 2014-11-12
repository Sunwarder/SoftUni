using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
    class Tables
    {
        static void Main(string[] args)
        {
            long bundle1 = long.Parse(Console.ReadLine());
            long bundle2 = long.Parse(Console.ReadLine());
            long bundle3 = long.Parse(Console.ReadLine());
            long bundle4 = long.Parse(Console.ReadLine());
            long tableTops = long.Parse(Console.ReadLine());
            long tablesToBeMade = long.Parse(Console.ReadLine());
            long allLegs = bundle1 * 1 + bundle2 * 2 + bundle3 * 3 + bundle4 * 4;
            long tablesPossible = Math.Min(tableTops, allLegs / 4);
            if (tablesPossible==tablesToBeMade)
            {
                Console.WriteLine("Just enough tables made: {0}",tablesToBeMade);
            }
            else if (tablesPossible>tablesToBeMade)
            {
                Console.WriteLine("more: {0}",tablesPossible-tablesToBeMade);
                Console.WriteLine("tops left: {0}, legs left: {1}"
                    , Math.Max(0,tablesPossible-tablesToBeMade), allLegs - tablesToBeMade * 4);
            }
            else
            {
                Console.WriteLine("less: {0}",tablesPossible-tablesToBeMade);
                Console.WriteLine("tops needed: {0}, legs needed: {1}"
                    ,Math.Max(0,tablesToBeMade-tableTops)
                    ,Math.Max(0,tablesToBeMade*4-allLegs));
            }
        }
    }
}
