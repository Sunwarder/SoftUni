using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            List<int> Primes = FindPrimesInRange(startNum, endNum);
            for (int i = 0; i < Primes.Count; i++)
            {
                Console.Write("{0}, ",Primes[i]);
                if (i==Primes.Count-1)
                {
                    Console.WriteLine(Primes[i]);
                }
            }
        }
        private static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> Primes=new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    Primes.Add(i);   
                }
            }
            return Primes;
        }
        private static bool IsPrime(long n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
