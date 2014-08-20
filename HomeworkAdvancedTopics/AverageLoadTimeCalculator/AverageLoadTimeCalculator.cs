using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AverageLoadTimeCalculator
{
    class AverageLoadTimeCalculator
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            StreamReader reportReader = new StreamReader("../../report.txt");
            string report = reportReader.ReadToEnd();
            string[] reportItems = report.Split(new [] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, List<double>> reportTimes = new Dictionary<string, List<double>>();
            foreach (string item in reportItems)
            {
                string[] split = item.Split(' ');
                if (!reportTimes.ContainsKey(split[2]))
                {
                    reportTimes[split[2]] = new List<double>() { double.Parse(split[3]) };
                }
                else
                {
                    reportTimes[split[2]].Add(double.Parse(split[3]));
                }
            }
            foreach (var time in reportTimes)
            {
                Console.WriteLine("{0} -> {1}", time.Key, time.Value.Average());
            }
        }
    }
}
