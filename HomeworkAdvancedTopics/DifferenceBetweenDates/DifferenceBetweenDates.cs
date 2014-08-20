using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Parse(Console.ReadLine());
            DateTime end = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(DateDifference(start,end));
        }
        private static int DateDifference(DateTime start, DateTime end)
        {
            int difference = (int)(end - start).TotalDays;
            return difference;
        }
    }
}
