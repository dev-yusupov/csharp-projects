namespace Ants
{
    internal class Program
    {
        static int countDay(int[] dayData, int length)
        {
            int sum = 0;

            for (int i = 0; i < length / 2; i++)
            {
                sum += dayData[i];
            }

            return sum;
        }

        static int countNight(int[] dayData, int length)
        {
            int sum = 0;

            for (int i = length / 2; i < length; i++)
            {
                sum += dayData[i];
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
                int[] row = new int[m];
                for (int j = 0; j < m; j++)
                {
                    row[j] = data[i, j];
                }

                if (countDay(row, m) < countNight(row, m))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
