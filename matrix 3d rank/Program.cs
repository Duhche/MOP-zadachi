using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_3d_rank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];

            Console.WriteLine("Enter the elements of the 3x3 matrix.");
            Console.WriteLine("Enter each row on a new line, separated by spaces:");

            
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Row {i + 1}: ");
                string[] input = Console.ReadLine().Split(' ');

                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }

            
            int determinant =
                  matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
                - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
                + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

            Console.WriteLine($"\nDeterminant: {determinant}");
        }
    }
}
