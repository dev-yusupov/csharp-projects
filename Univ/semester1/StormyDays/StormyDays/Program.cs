namespace StormyDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            int stormyDays = 0;
            for (int i = 0; i < n; i++)
            {
                int windSpeed = int.Parse(Console.ReadLine()!);
                if (windSpeed < 100 && windSpeed > 0)
                {
                    stormyDays++;
                }
            }

            Console.WriteLine(stormyDays);
        }
    }
}
