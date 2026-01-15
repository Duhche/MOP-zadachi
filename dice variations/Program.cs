namespace dice_variations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int throwsCount = 100000;
            int[] results = new int[6];
            Random random = new Random();

            // hvurlyane
            for (int i = 0; i < throwsCount; i++)
            {
                int dice = random.Next(1, 7); // 1 do 6
                results[dice - 1]++;
            }

            // rezultat
            Console.WriteLine("Result from throws:\n");

            for (int i = 0; i < results.Length; i++)
            {
                double probability = (double)results[i] / throwsCount;
                Console.WriteLine($"Number {i + 1}: {results[i]} times => Probability: {probability:F4}");
            }
        }
    }
}
