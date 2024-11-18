namespace NoBite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            int[] f = new int[n];

            for (int i = 0; i < n; i++)
            {
                f[i] = int.Parse(Console.ReadLine()!);
            }

            bool foundZero = false;
            for (int i = 0; i < n; i++)
            {
                if (f[i] == 0)
                {
                    Console.WriteLine(i + 1);
                    foundZero = true;
                    break;
                }
            }

            if (!foundZero)
            {
                Console.WriteLine(-1);
            }
        }
    }
}
