namespace CP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            int[] cubes = new int[n];

            for (int i = 0; i < n; i++)
            {
                cubes[i] = int.Parse(Console.ReadLine()!);
            }

            int volume = 0;
            int min = 0;

            for (int i = 0; i < n;i++)
            {
                int cube = cubes[i] * cubes[i] * cubes[i];
                volume += cube;

                if (cubes[min] > cubes[i])
                {
                    min = i;
                }
            }

            Console.WriteLine(volume);
            Console.WriteLine(min+1);
        }
    }
}
