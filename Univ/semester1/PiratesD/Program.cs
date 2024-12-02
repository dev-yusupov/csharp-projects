/*
 Specification: https://tinyurl.com/mrakmb2n
 */

namespace Pirates1
{
    struct Hunt
    {
        public int l;
        public string r;
        public string p;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] initialInputs = Console.ReadLine()!.Split(' ');

            int n = int.Parse(initialInputs[0]);
            int t = int.Parse(initialInputs[1]);

            Hunt[] hunts = new Hunt[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()!.Split(" ");

                Hunt hunt = new Hunt();
                hunt.l = int.Parse(input[0]);
                hunt.r = input[1];
                hunt.p = input[2];

                hunts[i] = hunt;
            }

            int jackIndex = -1;
            int summ = 0;

            for (int i = 0; i < n; i++)
            {
                if (hunts[i].l >= t)
                {

                    if (hunts[i].p == "Jack" & jackIndex == -1)
                    {
                        jackIndex = i;
                    }
                }

                if (hunts[i].p == "Jack")
                {
                    summ += hunts[i].l;
                }
            }

            Console.WriteLine(jackIndex + 1);
            Console.WriteLine($"Jack {summ}");


        }
    }
}
