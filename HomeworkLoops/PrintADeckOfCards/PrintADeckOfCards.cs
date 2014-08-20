using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintADeckOfCards
{
    class PrintADeckOfCards
    {
        static void Main(string[] args)
        {
            char[] face={'♣','♦','♥','♠'};
            string card = null;
            for (int i = 2; i <= 14; i++)
            {
                switch (i)
                {
                    case 11: card = "J";
                        break;
                    case 12: card = "Q";
                        break;
                    case 13: card = "K";
                        break;
                    case 14: card = "A";
                        break;
                    default: card = Convert.ToString(i);
                        break;
                }
                for (int k = 0; k < 4; k++)
                {
                    Console.Write("{0}{1}",card,face[k]);
                    if (k==3)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
