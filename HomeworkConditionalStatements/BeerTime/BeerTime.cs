using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace BeerTime
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();
            DateTime currentTime;
            if (DateTime.TryParse(time, out currentTime))
            {
                if ((currentTime.Hour >= 13 && currentTime.Hour < 24) || (currentTime.Hour >= 0 && currentTime.Hour < 3))
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
            else
            {
                Console.WriteLine("invalid time");
            }
        }
    }
}
