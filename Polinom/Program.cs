using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polinom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double[] polinom = Array.ConvertAll(input, double.Parse);

            if (polinom.Length == 2)
            {
                double x = -polinom[1] / polinom[2];
                Console.WriteLine(x);
            }
            else if (polinom.Length == 3)
            {
                double A = polinom[0];
                double B = polinom[1];
                double C = polinom[2];

                double D = B * B - 4 * A * C;

                if (D > 0)
                {
                    double x1 = (-B + Math.Sqrt(D)) / (2 * A);
                    double x2 = (-B - Math.Sqrt(D)) / (2 * A);
                    Console.WriteLine($"root: x1 = {x1}, x2 = {x2}");
                }
                else if (D == 0)
                {
                    double x = -B / (2 * A);
                    Console.WriteLine($"one root x = {x}");
                }
                else
                {
                    Console.WriteLine("root yok");
                }
            }
            else 
            { 
                Console.WriteLine("only lineal polynom & square polynoms");
            }
        }
    }
}
