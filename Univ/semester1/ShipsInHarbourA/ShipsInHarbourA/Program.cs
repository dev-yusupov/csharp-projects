namespace ShipsInHarbourA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int[] ships = new int[n];

            for (int i = 0; i < n; i++)
            {
                ships[i] = int.Parse(Console.ReadLine()!);
            }

            int totalNoShipDay = m-1;

            for (int i = 0; i < n - 1; i++)
            {
                if (ships[i] != ships[i - 1])
                {
                    totalNoShipDay--;
                }
            }

            int singleday = -1;

            for (int i = 2; i<=m-1; i++)
            {
                if (ships[i] > 0 && ships[i - 1] == 0 && ships[i + 1] == 0)
                {
                    singleday = i;
                    break;
                }
            }

            Console.WriteLine(singleday);

            int maxInterval = 0;

            for (int i = 1;i < n; i++)
            {
                int interval = ships[i] - ships[i - 1];

                if (interval > maxInterval)
                {
                    maxInterval = interval;
                }
            }

            Console.WriteLine(maxInterval);
        }
    }
}
