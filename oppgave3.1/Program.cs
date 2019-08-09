using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oppgave3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int TriangleLength = 4;
            int HashMount = 8;
            for(int i = 0; i < TriangleLength; i++)
            {
                for(int Spaces = 0; Spaces < i; Spaces++)
                {
                    Console.Write(" ");
                }
                for(int o = 0; o < HashMount; o++)
                {
                    Console.Write("#");
                }
                for (int G = 0; G < i; G++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
                HashMount -= 2;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            HashMount = 2;
            for (int i = 0; i < TriangleLength; i++)
            {
                for (int Spaces = 3; Spaces > i; Spaces--)
                {
                    Console.Write(" ");
                }
                for (int o = 0; o < HashMount; o++)
                {
                    Console.Write("#");
                }
                for (int G = 3; G > i; G--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
                HashMount += 2;
            }
            HashMount = 8;
            for (int i = 0; i < TriangleLength; i++)
            {
                for (int Spaces = 0; Spaces < i; Spaces++)
                {
                    Console.Write(" ");
                }
                for (int o = 0; o < HashMount; o++)
                {
                    Console.Write("#");
                }
                for (int G = 0; G < i; G++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
                HashMount -= 2;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            HashMount = 2;
            int SpaceAmount = 20;
            for (int i = 0; i < TriangleLength+1; i++)
            {
                for (int Spaces = 0; Spaces < i; Spaces++)
                {
                    Console.Write(" ");
                }
                SpaceAmount -= 2;
                for (int o = HashMount/2; o < HashMount; o++)
                {
                    Console.Write("#");
                }
                for (int Spaces = SpaceAmount; Spaces > i; Spaces--)
                {
                    Console.Write(" ");
                }
                SpaceAmount -= 2;
                for (int G = HashMount/2; G < HashMount; G++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                HashMount += 2;
            }
            
            for (int i = 0; i < TriangleLength + 1; i++)
            {
                switch (i)
                {
                    case 0:
                        for(int g = 0; g < 4; g++)
                        {
                            Console.Write(" ");
                        }
                        for(int g = 0; g < 10; g++)
                        {
                            Console.Write("#");
                        }
                        for (int g = 0; g < 4; g++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                        break;
                    case 1:
                        for (int g = 0; g < 3; g++)
                        {
                            Console.Write(" ");
                        }
                        for (int g = 0; g < 4; g++)
                        {
                            Console.Write("#");
                        }
                        for (int g = 0; g < 4; g++)
                        {
                            Console.Write(" ");
                        }
                        for (int g = 0; g < 4; g++)
                        {
                            Console.Write("#");
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        for (int g = 0; g < 2; g++)
                        {
                            Console.Write(" ");
                        }
                        for (int g = 0; g < 3; g++)
                        {
                            Console.Write("#");
                        }
                        for (int g = 0; g < 8; g++)
                        {
                            Console.Write(" ");
                        }
                        for (int g = 0; g < 3; g++)
                        {
                            Console.Write("#");
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        for (int g = 0; g < 1; g++)
                        {
                            Console.Write(" ");
                        }
                        for (int g = 0; g < 2; g++)
                        {
                            Console.Write("#");
                        }
                        for (int g = 0; g < 12; g++)
                        {
                            Console.Write(" ");
                        }
                        for (int g = 0; g < 2; g++)
                        {
                            Console.Write("#");
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        for (int g = 0; g < 0; g++)
                        {
                            Console.Write(" ");
                        }
                        for (int g = 0; g < 1; g++)
                        {
                            Console.Write("#");
                        }
                        for (int g = 0; g < 16; g++)
                        {
                            Console.Write(" ");
                        }
                        for (int g = 0; g < 1; g++)
                        {
                            Console.Write("#");
                        }
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
