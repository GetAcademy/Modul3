using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTTEST
{
    class Program
    {
        class Animal
        {
            public string name;
            public int age;
            public float happiness;

            public void PrintBase()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Happiness: {happiness}");
            }
        }

        class Dog : Animal
        {
            public int SpotCount;
            public void Bark()
            {
                Console.WriteLine("WOOF WOOF");
            }
        }

        class Cat : Animal
        {
            public float Cuteness;
            public void Meow()
            {
                Console.WriteLine("MEOW");
            }
        }

        public static void Main()
        {

        }
    }
}
