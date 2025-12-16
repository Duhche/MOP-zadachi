using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_mode_median_convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            string input = Console.ReadLine();

            List<double> numbers = input
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => double.Parse(s, CultureInfo.InvariantCulture))
                .ToList();

            // Sum
            double sum = numbers.Sum();

            // Mode
            double mode = numbers
                .GroupBy(n => n)
                .OrderByDescending(g => g.Count())
                .ThenBy(g => g.Key)
                .First()
                .Key;

            // Median
            numbers.Sort();
            double median;
            int count = numbers.Count;

            if (count % 2 == 0)
                median = (numbers[count / 2 - 1] + numbers[count / 2]) / 2.0;
            else
                median = numbers[count / 2];

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Mode: {mode}");
            Console.WriteLine($"Median: {median}");
        }
    }
}
