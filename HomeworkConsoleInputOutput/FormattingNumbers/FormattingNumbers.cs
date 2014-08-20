using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            short a = short.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            string binery = Convert.ToString(a,2).PadLeft(10, '0');
            Console.WriteLine("|{0,-10:X}|{1:0000000000}|{2,10:0.00}|{3,-10:0.000}|",a,binery,b,c);
        }
    }
}
