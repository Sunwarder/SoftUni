using System;

class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n / 2 + 1; i++)
        {
            Console.Write(new string('-', n / 2 + 1 - i));
            if (i == 1)
            {
                Console.Write('*');
            }
            else
            {
                Console.Write('*');
                Console.Write(new string('-', (2 * i) - 3));
                Console.Write('*');
            }
            Console.Write(new string('-', n / 2 + 1 - i));
            Console.WriteLine();
        }
        for (int i = 1; i <= n / 2; i++)
        {
            Console.Write(new string('-', i));
            if (i == n / 2)
            {
                Console.Write('*');
            }
            else
            {
                Console.Write('*');
                Console.Write(new string('-', n - 2 - (2 * i)));
                Console.Write('*');
            }
            Console.Write(new string('-', i));
            Console.WriteLine();
        }

    }
}