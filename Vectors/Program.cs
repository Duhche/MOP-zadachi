using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number of vectors N: ");
            int n = int.Parse(Console.ReadLine());

            
            double minLength = double.MaxValue;
            double minX = 0, minY = 0, minZ = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"enter cordinates of vectors {i + 1} (x y z):");
                string[] parts = Console.ReadLine().Split();

                double x = double.Parse(parts[0]);
                double y = double.Parse(parts[1]);
                double z = double.Parse(parts[2]);

                
                double length = Math.Sqrt(x * x + y * y + z * z);

                if (length < minLength)
                {
                    minLength = length;
                    minX = x;
                    minY = y;
                    minZ = z;
                }
            }

            Console.WriteLine("\nshortest vectro is:");
            Console.WriteLine($"({minX}, {minY}, {minZ})");
            Console.WriteLine($"Length: {minLength:F4}");
        }
    }
}
