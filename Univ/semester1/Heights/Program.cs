/*
 * Specification https://progalap.elte.hu/specifikacio/?data=H4sIAAAAAAAAClWOwYoCMQyGXyXkpNAdWj0sBCt4WRCGVbyOcyhjHQNulLZzEmGPfc55kmVmRfEQSEK%2BL%2F8N49U3fOTGJb4IEq6FQPqcvxWcPLenFIehMkUh9T7sZahNlwhYmuBdZGn7nMthvQ2ewCysLKzRGpwcoM%2B%2F3Of8jwPB5OGsuF5ao6cjdolvOvu12a3KcsJ2VhTyjDEiz%2F7D1FNUmHxMEam64cElh4RCMB%2Bkj0OCaqYVzLWCTz3mf%2F0hSKHzqFDcj0dCVBh87M4Jydzr%2Bx%2FhIakIGwEAAA%3D%3D
 * Structogram: https://progalap.elte.hu/stuki/?data=H4sIAAAAAAAACq1Wa0%2FbMBT9K9VFQpvkbm4LhYSHNKaxwWBsAvFcP7j2dWNIneK43QLKf5%2BcNq472CQe%2BZKbE%2Fuce%2B61ndyDEhADfUdpu0ujTrcd0Xa3G3U6bSCQZBM0ewJiPU5TAjmmyC2KOaIzgTnE9zC6TY4OcOW7iytGDxAYMYPaziclSgjUEEuW5kjAFiOEGHK8HaPmCAR4olJhUO%2BJHOIriC6%2Ffd9fV0Mg0MmzzsHH9iEQ%2BCrGakdFEyBQtPpmSM%2FOoVeS%2Beg6k2D6PJMwv3%2FkY5nFIWoLBCz%2BthDDno4bejMfMd3IbZHi1k%2BQmbZNyYYqLeLGhJk3zWZuzZjbZvDm7UajesrVHT42yuFvN37CNmkkqAaJza96m%2B%2BdzvZm32xDSeB8%2FWzAztSad%2BWBBVcRmxTykop%2FutJZNnJ8fqCv0nzmS%2FvlU3Pt8B2rhYIWvrAdSnODLFd6EG%2BdmDGShoq3Ws7dxeFukR%2Bc7XtRDyyIBkvoqR4vb%2BmhOJXXlUfPU8sFxE%2Fx%2BCtRaaWVaaGsyrQzuZzaDQ0E%2Bpkojmf57C14Kgns3tztj6hVPgMPLGTgs3664YGZnN4WN6IyfHdyURx%2FuG55OQ%2B8ltz1j5Pru1b%2FMxA4%2Fq3l7qfhh0rZU9bKgUagHPT7cWUl%2F6pzvfFUr7E8sBtbfieqZqvn1pwZ445hmicLTQjqXAk8MsTXpiRzW3X6gc8g%2FaCcz9oNu26w0%2FO1q%2FU88GK9o7GNG17IL49ayAMLQkG5nr3NnZw%2F8Ws5D7z4VKl8TXVKAtNjOhsYNnTr8h40G7qJh0y5TTlhRrF%2B6r6BAARMlj0QzpPs1%2Bl82EzfoV%2BQCTQzqCSe%2Bz%2B8wSn9gOFxqbLn1nmameozPfV4BUtSUkopEFhyd%2Bl2w5KU3GN9uuojWUVrtENZFXFkcn0NetOS7TB%2BMzDZWIsZcb%2Fdd%2F8OS%2B5eEyOvMVzjrI5kFYkVTrHt6NzfxCvSBb17wOqumWfOeeWKc15jsl1jKAWfYlE0fUvpOo9WXYSIK6IbVqQs%2FwAaSbMfUAkAAA%3D%3D
 */

namespace Heights
{
    struct Height
    {
        public string name;
        public int height; // Change to int for easy comparison of heights
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            Height[] heights = new Height[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()!.Split(' ');
                string name = input[0];
                int height = int.Parse(input[1]);

                heights[i] = new Height { name = name, height = height };
            }

            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i].height < heights[i - 1].height)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }
    }
}
