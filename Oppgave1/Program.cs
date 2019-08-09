using System;

namespace Oppgave1
{
    class Program
    {
        static void Main()
        {
            var range = 250;
            var counts = new int[range]; // an int array with a capacity of 250
            string text = "something";
            Console.WriteLine("Write something Stupid!");
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                foreach (char character in text.ToUpper() ?? string.Empty)
                {
                    counts[(int)character]++; // gjør om character til tall sånn at den kan brukes til å finne riktig index i counts arrayen for å øke verdien med 1 på den indexen.
                }
                for (int i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        Console.WriteLine(character + " - " + $"{counts[i],4}"); // denne dollartegn tingen formaterer texten til høyre hvor den tar utgangspunkt i opp til fire sifrede tall.
                        counts[i] = 0;
                    }
                }
            }
        }
    }
}
