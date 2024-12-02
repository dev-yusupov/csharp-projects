/*
 Specification: https://tinyurl.com/4phfmap6
 */

namespace AverageSteps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            int[] steps = new int[n];

            for (int i = 0; i < n; i++)
            {
                int step = int.Parse(Console.ReadLine()!);
                steps[i] = step;
            }

            int count = 0;
            float summ = 0;

            for (int i = 0;i < n; i++)
            {
                if (steps[i] > 10000)
                {
                    count++;
                }

                summ += (float)steps[i];
            }

            Console.WriteLine(count);
            float average = summ / n;

            Console.WriteLine($"{average:F2}");
        }
    }
}
