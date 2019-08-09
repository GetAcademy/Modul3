using System;

namespace Oppgave1__parprogrammering_
{
    class Program
    {
        static void Main()
        {
            int[] counts = new int[250];
            string text = "something";
            Console.WriteLine("write some shit!");
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                int Letters = 0;
                float TempInt;
                foreach (char character in text.ToUpper() ?? string.Empty)
                {
                    counts[(int)character]++;
                    Letters++;
                }
                for (int i = 0; i < 250; i++)
                {
                    if (counts[i] > 0)
                    {
                        char character = (char)i;
                        TempInt = (counts[i] * 100) / Letters;
                        Console.WriteLine(character + " - " + $"{TempInt/100,4:P}");
                        counts[i] = 0; // se her sett denne bokstaven til null
                    }
                }
                Letters = 0; // se her sett totale mengden bostaver til null
            }
        }
    }
}
