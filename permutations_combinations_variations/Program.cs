namespace permutations_combinations_variations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());

            if (n < 0 || k < 0 || k > n)
            {
                Console.WriteLine("Unvalid data!");
                return;
            }

            long permutations = Factorial(n);
            long combinations = Factorial(n) / (Factorial(k) * Factorial(n - k));
            long variations = Factorial(n) / Factorial(n - k);

            Console.WriteLine($"Permutations P({n}) = {permutations}");
            Console.WriteLine($"Combinations C({n},{k}) = {combinations}");
            Console.WriteLine($"Variations V({n},{k}) = {variations}");
        }

        static long Factorial(int number)
        {
            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
