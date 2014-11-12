using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessQueens
{
    class ChessQueens
    {
        static void Main(string[] args)
        {
            byte size = byte.Parse(Console.ReadLine());
            byte distance = byte.Parse(Console.ReadLine());
            int counter = 0;
            string[,] board = new string[size, size];
            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++)
                {
                    board[row, column] = "" + (char)('a' + row) + (column+1);
                }
            }
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int column = 0; column < board.GetLength(1); column++)
                {
                    if (row+distance+1<board.GetLength(0))
                    {
                        Console.WriteLine("{0} - {1}", board[row, column]
                            , board[row + distance + 1, column]);
                        Console.WriteLine("{1} - {0}", board[row, column]
                            , board[row + distance + 1, column]);
                        counter += 2;
                    }
                    if (column+distance+1<board.GetLength(1))
                    {
                        Console.WriteLine("{0} - {1}", board[row, column]
                            , board[row, column + distance + 1]);
                        Console.WriteLine("{1} - {0}", board[row, column]
                            , board[row, column + distance + 1]);
                    }
                    if (row+distance+1<board.GetLength(0)&&column+distance+1<board.GetLength(1))
                    {
                        Console.WriteLine("{0} - {1}", board[row, column]
                            , board[row + distance + 1, column + distance + 1]);
                        Console.WriteLine("{1} - {0}", board[row, column]
                            , board[row + distance + 1, column + distance + 1]);
                    }
                    if (row+distance+1<board.GetLength(0)&&column-distance-1>=0)
                    {
                        Console.WriteLine("{0} - {1}", board[row, column]
                            , board[row + distance + 1, column - distance - 1]);
                        Console.WriteLine("{1} - {0}", board[row, column]
                            , board[row + distance + 1, column - distance - 1]);
                    }
                }
            }
            if (counter==0)
            {
                Console.WriteLine("No valid positions");
            }
        }
    }
}
