using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace FruitMarket
{
    class FruitMarket
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string dayOfWeek = Console.ReadLine();
            double quantity1 = double.Parse(Console.ReadLine());
            string product1 = Console.ReadLine();
            double quantity2 = double.Parse(Console.ReadLine());
            string product2 = Console.ReadLine();
            double quantity3 = double.Parse(Console.ReadLine());
            string product3 = Console.ReadLine();
            string[] productsToBuy = { product1, product2, product3 };
            double[] quantities = { quantity1, quantity2, quantity3 };
            string[] products = { "banana", "cucumber", "tomato", "orange", "apple" };
            double[] prices = { 1.80, 2.75, 3.20, 1.60, 0.86 };
            double result = 0;
            switch (dayOfWeek)
            {
                case "Friday": 
                    for (int i = 0; i < productsToBuy.Length; i++)
                    {
                        for (int j = 0; j < products.Length; j++)
                        {
                            if (productsToBuy[i]==products[j])
                            {
                                result += quantities[i] * prices[j] * 0.90;
                                break;
                            }
                        }
                    }
                    break;
                case "Sunday":
                    for (int i = 0; i < productsToBuy.Length; i++)
                    {
                        for (int j = 0; j < products.Length; j++)
                        {
                            if (productsToBuy[i] == products[j])
                            {
                                result += quantities[i] * prices[j] * 0.95;
                                break;
                            }
                        }
                    }
                    break;
                case "Tuesday":
                    for (int i = 0; i < productsToBuy.Length; i++)
                    {
                        for (int j = 0; j < products.Length; j++)
                        {
                            if (productsToBuy[i] == products[j])
                            {
                                if (isVegetable(products[j])==false)
                                {
                                    result += quantities[i] * (prices[j] * 0.80);
                                break;
                                }
                                else
                                {
                                    result += quantities[i] * prices[j];
                                    break;
                                }
                            }
                        }
                    }
                    break;
                case "Wednesday":
                    for (int i = 0; i < productsToBuy.Length; i++)
                    {
                        for (int j = 0; j < products.Length; j++)
                        {
                            if (productsToBuy[i] == products[j])
                            {
                                if (isVegetable(products[j]))
                                {
                                    result += quantities[i] * prices[j] * 0.90;
                                    break;
                                }
                                else
                                {
                                    result += quantities[i] * prices[j];
                                    break;
                                }
                            }
                        }
                    }
                    break;
                case "Thursday": 
                    for (int i = 0; i < productsToBuy.Length; i++)
                    {
                        for (int j = 0; j < products.Length; j++)
                        {
                            if (productsToBuy[i] == products[j])
                            {
                                if (productsToBuy[i]=="banana")
                                {
                                    result += quantities[i] * prices[j] * 0.70;
                                    break;
                                }
                                else
                                {
                                    result += quantities[i] * prices[j];
                                    break;
                                }
                            }
                        }
                    }
                    break;
                default:
                    for (int i = 0; i < productsToBuy.Length; i++)
                    {
                        for (int j = 0; j < products.Length; j++)
                        {
                            if (productsToBuy[i] == products[j])
                            {
                                result += quantities[i] * prices[j];
                                break;
                            }
                        }
                    }
                    break;
            }
            Console.WriteLine("{0}", result);
        }
        private static bool isVegetable(string product)
        {
            if (product=="tomato"||product=="cucumber")
            {
                return true;
            }
            return false;
        }
    }
}
