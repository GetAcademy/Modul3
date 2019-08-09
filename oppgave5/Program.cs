using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oppgave5
{
    class Program
    {
        
        static void Main()
        {
            Console.WriteLine("Cæsars Cipher: Ciphering Program");
            Console.WriteLine();
            Console.WriteLine("Input PlainText to Cipher!");
            Console.WriteLine();
            string PlainText = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Input the Cipher [KEY] here (a Digit between 1 and 15 preferrably)");
            int Key;
            Int32.TryParse(Console.ReadLine(), out Key);
            string CipherText = "";
            foreach(char Character in PlainText.ToUpper())
            {
                if((int)Character == 32)
                {
                    CipherText += (char)32;
                }
                else
                {
                    CipherText += (char)((int)Character + Key);
                }
            }
            Console.WriteLine();
            Console.WriteLine("The Ciphered Text:");
            Console.WriteLine();
            Console.WriteLine(CipherText);
            Console.WriteLine();
            Console.WriteLine("Take Care of the [KEY] for i wont!");
            Console.WriteLine();
            Console.WriteLine("Part 2 Decoding");
            string Decoded = "";
            Console.WriteLine();
            foreach (char Character in CipherText)
            {
                if((int)Character == 32)
                {
                    Decoded += (char)32;
                }
                else
                {
                    Decoded += (char)((int)Character - Key);
                }
            }
            Console.WriteLine("Decoded Text:");
            Console.WriteLine();
            Console.WriteLine(Decoded);
        }
    }
}
