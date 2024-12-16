namespace Ants
{
    internal class Program
    {
        static int countDay(int[,] data, int dayIndex, int m)
        {
            int sum = 0;
            for (int i = 0; i < m / 2; i++)
            {
                sum += data[dayIndex, i];
            }
            return sum;
        }

        static int countNight(int[,] data, int dayIndex, int m)
        {
            int sum = 0;
            for (int i = m / 2; i < m; i++)
            {
                sum += data[dayIndex, i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()!.Split(' ');

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int[,] data = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()!.Split(' ');
                for (int j = 0; j < m; j++)
                {
                    data[i, j] = int.Parse(line[j]);
                }
            }

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (countDay(data, i, m) < countNight(data, i, m))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
