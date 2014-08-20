using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            uint bits3Through5 = number & (7<<3);
            uint bits24Through26 = number & (7<<24);
            uint mask=4177526727;
            number = number & mask;
            number = (number | (bits3Through5 << 21)) | (bits24Through26 >> 21);
            Console.WriteLine(number);
        }
    }
}
