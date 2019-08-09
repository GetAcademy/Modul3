using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Terje");
            foreach(var arg in args)
            {
                Console.WriteLine(arg);
            }
        }
    }
}
