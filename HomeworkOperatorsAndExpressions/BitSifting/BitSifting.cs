﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class BitSifting
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        int numberOfSieves = int.Parse(Console.ReadLine());
        for (int index = 0; index < numberOfSieves; index++)
        {
            long sieve = long.Parse(Console.ReadLine());
            int count = 0;
            while (sieve > 0)
            {
                int bitToSieve = (int)(sieve & 1);
                int bitToCheck = (int)((number >> count) & 1);

                if (bitToSieve == 1 && bitToCheck == 1)
                {
                    number ^= (long)1 << count;
                }
                sieve >>= 1;
                count++;
            }
        }
        int result = 0;
        while (number > 0)
        {
            int check = (int)(number & 1);
            if (check == 1)
            {
                result++;
            }
            number >>= 1;
        }
        Console.WriteLine(result);
    }
}