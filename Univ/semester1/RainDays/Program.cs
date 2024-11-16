namespace RainDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine()!);
                if (m > 0)
                {
                    result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}

/*
 Specification: https://shorturl.at/Sw05y
 Structogram: https://shorturl.at/JMUhU
 */
