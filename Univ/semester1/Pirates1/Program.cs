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

            Dictionary<string, int> regions = new Dictionary<string, int>();

            foreach (var hunt in hunts)
            {
                if (regions.ContainsKey(hunt.r))
                {
                    regions[hunt.r] += hunt.l;
                }
                else
                {
                    regions[hunt.r] = hunt.l;
                }
            }

            int count = 0;
            int jackIndex = -1;
            int summ = 0;

            for (int i = 0; i < n; i++)
            {
                if (hunts[i].l >= t)
                {
                    count++;

                    if (hunts[i].p == "Jack" & jackIndex == -1)
                    {
                        jackIndex = i;
                    }
                }

                if (hunts[i].p == "Jack")
                {
                    summ+=hunts[i].l;
                }
            }

            Console.WriteLine(count);

            foreach (var region in regions)
            {
                Console.WriteLine($"{region.Key} {region.Value}");
            }

            Console.WriteLine(jackIndex+1);
            Console.WriteLine($"Jack {summ}");


        }
    }
}
