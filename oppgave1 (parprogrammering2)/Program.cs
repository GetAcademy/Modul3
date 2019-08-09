using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oppgave1__parprogrammering2_
{
    class Program
    {
        static void Main()
        {
            int range = 250;
            int[] counts = new int[range];
            string text = "something";
            Console.WriteLine("Write some Gay shit yo!");
            while (!string.IsNullOrWhiteSpace(text))
            {
                int Total = 0;
                text = Console.ReadLine();
                foreach (char character in text.ToUpper() ?? string.Empty)
                {
                    counts[(int)character]++;
                    Total++;
                }
                for (int i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        char character = (char)i;
                        float Percent = (counts[i] * 100) / Total;
                        Console.WriteLine(character + " - " + $"{Percent/100,4:P}");
                        counts[i] = 0;
                    }
                }
            }
        }
    }
}
