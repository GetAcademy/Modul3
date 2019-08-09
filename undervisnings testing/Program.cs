using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamajamjam
{
    public class Program
    {
        public static Program program;
        static void Main()
        {
            program = new Program();
            Console.ReadLine();
        }

        public Program()
        {
            var pamajamjam = new Pamajamjam(this, 1);
            pamajamjam.Start();
        }

        public void Tick(int minutes, int seconds)
        {
            Console.Clear();
            if(seconds <= 0 && minutes <= 0)
            {
                Console.WriteLine("Bytt Plass!");
                Environment.Exit(0);
            }
            Console.WriteLine($"{minutes}:" + seconds.ToString("00"));
        }
    }
}
