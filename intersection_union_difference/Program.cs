using System;
using System.Collections.Generic;
using System.Linq;
namespace intersection_union_difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vhod
            string input = Console.ReadLine();

            //razdelyaneto
            string[] parts = input.Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries);

            //preobrazuva v mnojestvo
            HashSet<int> set1 = parts[0]
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToHashSet();

            HashSet<int> set2 = parts[1]
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToHashSet();

            //sechenie
            var intersection = set1.Intersect(set2);

            //obedinenie
            var union = set1.Union(set2);

            //razlika
            var difference = set1.Except(set2);

            //izvejda
            Console.WriteLine("intersection: " + string.Join(" ", intersection));
            Console.WriteLine("union: " + string.Join(" ", union));
            Console.WriteLine("difference: " + string.Join(" ", difference));
        }
    }
}
