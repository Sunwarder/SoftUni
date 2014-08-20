using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanNumbers
{
    class HayvanNumbers
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int a = 5; a < 10; a++)
            {
                for (int b = 5; b < 10; b++)
                {
                    for (int c = 5; c < 10; c++)
                    {
                        for (int d = 5; d < 10; d++)
                        {
                            for (int e = 5; e < 10; e++)
                            {
                                for (int f = 5; f < 10; f++)
                                {
                                    for (int g = 5; g < 10; g++)
                                    {
                                        for (int h = 5; h < 10; h++)
                                        {
                                            for (int i = 5; i < 10; i++)
                                            {
                                                string ghiS = string.Concat(g, h, i);
                                                int ghi = Convert.ToInt32(ghiS);
                                                string defS = string.Concat(d, e, f);
                                                int def = Convert.ToInt32(defS);
                                                string abcS = string.Concat(a, b, c);
                                                int abc = Convert.ToInt32(abcS);
                                                if (a+b+c+d+e+f+g+h+i==sum&&(abc<def)&&(def<ghi)&&(ghi-def==diff)&&(def-abc==diff))
                                                {
                                                    Console.WriteLine(string.Concat(a,b,c,d,e,f,g,h,i));
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
