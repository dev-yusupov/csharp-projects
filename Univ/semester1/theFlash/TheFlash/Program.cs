namespace TheFlash
{
    internal class Program
    {
        public struct Race
        {
            public string id;
            public int laps;
            public int time;
        }

        public static string maxAvg(Race[] races)
        {
            double maxAvg = double.MinValue;
            string maxAvgId = string.Empty;

            foreach (var race in races)
            {
                double avg = (double)race.laps / race.time;
                if (avg > maxAvg)
                {
                    maxAvg = avg;
                    maxAvgId = race.id;
                }
            }

            return maxAvgId;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            Race[] races = new Race[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()!.Split();

                races[i].id = input[0];
                races[i].laps = int.Parse(input[1]);
                races[i].time = int.Parse(input[2]);
            }

            string minAvgId = maxAvg(races);
            Console.WriteLine(minAvgId);
        }
    }
}
