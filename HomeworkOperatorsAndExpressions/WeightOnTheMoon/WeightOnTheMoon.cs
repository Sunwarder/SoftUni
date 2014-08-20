using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightOnTheMoon
{
    class WeightOnTheMoon
    {
        static void Main(string[] args)
        {
            int weight = int.Parse(Console.ReadLine());
            double weightOnTheMoon = 0.17 * weight;
            Console.WriteLine("Your weight on the moon would be:{0}", weightOnTheMoon);
        }
    }
}
