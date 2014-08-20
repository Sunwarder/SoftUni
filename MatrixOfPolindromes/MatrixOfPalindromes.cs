using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            string[,] polindromes=new string[r,c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    polindromes[i, j] = "" + (char)('a' + i) + (char)('a' + i + j) + (char)('a' + i);
                    if (j==c-1)
                    {
                        Console.WriteLine(polindromes[i,j]);
                    }
                    else
                    {
                        Console.Write("{0} ",polindromes[i,j]);
                    }
                }
            }
        }
    }
}
