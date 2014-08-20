using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithIntDoubleAndString
{
    class PlayWithIntDoubleAndString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            byte choice;
            if (byte.TryParse(Console.ReadLine(),out choice))
            {
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Please enter a int");
                            int number = int.Parse(Console.ReadLine());
                            Console.WriteLine(++number);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Please enter a double");
                            double number = double.Parse(Console.ReadLine());
                            Console.WriteLine(++number);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Please enter a string");
                            string str = Console.ReadLine();
                            Console.WriteLine(str + '*');
                            break;
                        }
                    default: Console.WriteLine("Invalid choice");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
    }
}
