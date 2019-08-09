using System;

namespace SharpieInThePooper
{
    class SharpieInThePooper
    {
        static void Main()
        {
            var Sharpie = new SharpieInThePooper();
            Sharpie.TellMeSomething();
        }

        string[] Words = new string[] { "I ", "Will ", "Vote ", "Republican!"};
        public void TellMeSomething()
        {
            for(int i = 0; i < Words.Length; i++)
            {
                Console.WriteLine(Words[i]);
            }
        }
    }
}
