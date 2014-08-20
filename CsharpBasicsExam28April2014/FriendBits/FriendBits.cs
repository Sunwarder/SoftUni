using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendBits
{
    class FriendBits
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("0");
                Console.WriteLine("0");
            }
            else
            {
                string num = Convert.ToString(n, 2);
                string friendBitsString = null;
                string aloneBitsString = null;
                char[] bits = num.ToCharArray();
                for (int i = 0; i < bits.Length; i++)
                {
                    if (i == 0)
                    {
                        if (bits[i] == bits[i + 1])
                        {
                            friendBitsString += bits[i];
                        }
                        else
                        {
                            aloneBitsString += bits[i];
                        }
                    }
                    else if (i < bits.Length - 1)
                    {
                        if (bits[i] == bits[i + 1] || bits[i] == bits[i - 1])
                        {
                            friendBitsString += bits[i];
                        }
                        else
                        {
                            aloneBitsString += bits[i];
                        }
                    }
                    else
                    {
                        if (bits[i] == bits[i - 1])
                        {
                            friendBitsString += bits[i];
                        }
                        else
                        {
                            aloneBitsString += bits[i];
                        }
                    }
                }
                uint friendBits = Convert.ToUInt32(friendBitsString, 2);
                uint aloneBits = Convert.ToUInt32(aloneBitsString, 2);
                Console.WriteLine(friendBits);
                Console.WriteLine(aloneBits);
            }
        }
    }
}
