/*
 Specification: https://tinyurl.com/mrakmb2n
 */

namespace PiratesA
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

            int minLootIndex = 0;
            int minValue = hunts[0].l;

            for (int i = 1; i < hunts.Length; i++)
            {
                if (hunts[i].l < minValue)
                {
                    minLootIndex = i;
                    minValue = hunts[i].l;
                }
            }

            Console.WriteLine(hunts[minLootIndex].p);
        }
    }
}
