using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace BookOrders
{
    class BookOrders
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            int ordersCount = int.Parse(Console.ReadLine());
            int totalBooks = 0;
            double totalPrice = 0;
            for (int i = 0; i < ordersCount; i++)
            {
                
                int numberOfPackets = int.Parse(Console.ReadLine());
                int booksPerPacket = int.Parse(Console.ReadLine());
                double bookPrice = double.Parse(Console.ReadLine());
                totalBooks += numberOfPackets * booksPerPacket;
                double discount = new double();
                if (numberOfPackets<10)
                {
                    discount = 1; 
                }
                else if (numberOfPackets>=10&&numberOfPackets<=109)
                {
                    discount =(100 - (numberOfPackets / 10 + 4)) / 100.0;
                }
                else
                {
                    discount = (100 - 15) / 100.0;
                }
                totalPrice += numberOfPackets * booksPerPacket
                    * bookPrice * discount;
            }
            Console.WriteLine(totalBooks);
            Console.WriteLine("{0:F2}",totalPrice);
        }
    }
}
