/*
 Specification: https://tinyurl.com/2wa6tcy7 
 */

namespace Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            int[] temperatures = new int[n];

            for (int i = 0; i < n; i++)
            {
                int temperature = int.Parse(Console.ReadLine()!);
                temperatures[i] = temperature;
            }

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (temperatures[i] > 20)
                {
                    count++;
                }
            }

            float summ = 0;

            for (int i = 0; i < n; i++)
            {
                summ += temperatures[i];
            }

            float average = (float)Math.Round(summ / n, 2);

            Console.WriteLine(count);
            Console.WriteLine(average);
        }   
    }
}
