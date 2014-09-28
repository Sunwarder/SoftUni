using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShooter
{
    class BitShooter
    {
        static void Main(string[] args)
        {
            ulong input = ulong.Parse(Console.ReadLine());
            string binary = Convert.ToString((long)input, 2).PadLeft(64,'0');
            char[] bitField = binary.ToCharArray();
            Array.Reverse(bitField);
            string[] shot = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] shot1 = new int[2];
            for (int i = 0; i < shot.Length; i++)
            {
                shot1[i] = int.Parse(shot[i]);
            }
            shot = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] shot2 = new int[2];
            for (int i = 0; i < shot.Length; i++)
            {
                shot2[i] = int.Parse(shot[i]);
            }
            shot = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] shot3 = new int[2];
            for (int i = 0; i < shot.Length; i++)
            {
                shot3[i] = int.Parse(shot[i]);
            }
            for (int i = shot1[0]; i <= shot1[0]+shot1[1]/2; i++)
            {
                if (i<=63)
                {
                    if (bitField[i] == '1')
                    {
                        bitField[i] = '0';
                    }
                }
            }
            for (int i = shot1[0]; i >=shot1[0]-shot1[1]/2; i--)
            {
                if (i>=0)
                {
                    if (bitField[i]=='1')
                    {
                        bitField[i] = '0';
                    }
                }
                else
                {
                    break;
                }
            }
            for (int i = shot2[0]; i <= shot2[0] + shot2[1] / 2; i++)
            {
                if (i <= 63)
                {
                    if (bitField[i] == '1')
                    {
                        bitField[i] = '0';
                    }
                }
            }
            for (int i = shot2[0]; i >= shot2[0] - shot2[1] / 2; i--)
            {
                if (i >= 0)
                {
                    if (bitField[i] == '1')
                    {
                        bitField[i] = '0';
                    }
                }
                else
                {
                    break;
                }
            }
            for (int i = shot3[0]; i <= shot3[0] + shot3[1] / 2; i++)
            {
                if (i <= 63)
                {
                    if (bitField[i] == '1')
                    {
                        bitField[i] = '0';
                    }
                }
            }
            for (int i = shot3[0]; i >= shot3[0] - shot3[1] / 2; i--)
            {
                if (i >= 0)
                {
                    if (bitField[i] == '1')
                    {
                        bitField[i] = '0';
                    }
                }
                else
                {
                    break;
                }
            }
            int left = 0;
            int right = 0;
            for (int i = 0; i <= 31; i++)
            {
                if (bitField[i]=='1')
                {
                    right++;
                }
            }
            for (int i = 32; i <= 63; i++)
            {
                if (bitField[i]=='1')
                {
                    left++;
                }
            }
            Console.WriteLine("left: {0}", left);
            Console.WriteLine("right: {0}", right);
        }
    }
}
