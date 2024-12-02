/*
 Specification: https://tinyurl.com/mrakmb2n
 */

namespace PiratesC
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

            foreach (var region in regions)
            {
                Console.WriteLine($"{region.Key} {region.Value}");
            }
        }
    }
}
