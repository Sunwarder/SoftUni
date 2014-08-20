using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerStraight
{
    class PokerStraight
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int counter = 0;
            int[] cards = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            int[] suits = { 1, 2, 3, 4 };
            for (int card = 0; card < 14; card++)
            {
                for (int suit1 = 0; suit1 < 4; suit1++)
                {
                    for (int suit2 = 0; suit2 < 4; suit2++)
                    {
                        for (int suit3 = 0; suit3 < 4; suit3++)
                        {
                            for (int suit4 = 0; suit4 < 4; suit4++)
                            {
                                for (int suit5 = 0; suit5 < 4; suit5++)
                                {
                                        int weight = (card + 1) * 10 + suit1 + 1 +
                                                     (card + 2) * 20 + suit2 + 1 +
                                                     (card + 3) * 30 + suit3 + 1 +
                                                     (card + 4) * 40 + suit4 + 1 +
                                                     (card + 5) * 50 + suit5 + 1;
                                        if (weight==w)
                                        {
                                            counter++;
                                        }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
