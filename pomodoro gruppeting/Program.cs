using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Media;

namespace pomodoro_gruppeting
{
    class Program
    {
        static public string Input()
        {
            Console.WriteLine();
            Console.Write("Input: ");
            return Console.ReadLine().ToUpper();
        }

        static void PlaySong(int PlayTime, string song)
        {
            Task.Factory.StartNew(() =>
            {
                SoundPlayer MyPlayer = new SoundPlayer($@"D:\GitHub\GitHub\Modul3\pomodoro gruppeting\musikk\{song}.wav");
                MyPlayer.Play();
                Thread.Sleep(PlayTime);
                MyPlayer.Stop();
            });
        }

        static void Main()
        {
            Console.WriteLine();
            Console.WriteLine("Pomodoro super waiter timer thingy\n\nBruk 'Sett Timer' kommandoen for å sette arbeids timer du vil også bli bedt om en timer for pause som skal skje etter arbeidet.\n\nBruk 'Exit' for å avslutte");

            int Work = 0;
            int Break = 0;
            string Song = String.Empty;

            while (true)
            {
                if(Work <= 0 && Break <= 0)
                {
                    string Command = Input();
                    if(Command == "SETT TIMER")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Work Time");
                        Int32.TryParse(Input(), out Work);
                        Work = Work * 60000;
                        Console.WriteLine();
                        Console.WriteLine("Break Time");
                        Int32.TryParse(Input(), out Break);
                        Console.WriteLine();
                        Console.WriteLine("What is your BREAKTIME song of choice?\n\nyou can choose between 'Work', 'Stop' and 'PinkGuy'");
                        Song = Input();
                        Break = Break * 60000;
                        continue;
                    }
                    else if(Command == "EXIT")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("error invalid command");
                        continue;
                    }
                }
                else if(Work > 0)
                {
                    Thread.Sleep(60000);
                    Work -= 60000;
                    Console.WriteLine($"{Work / 60000} Minutes left of Work");
                    if(Work <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("BREAKTIME");
                        Console.WriteLine();
                        PlaySong(Break,Song);
                    }
                }
                else if(Work <= 0 && Break > 0)
                {
                    Thread.Sleep(60000);
                    Break -= 60000;
                    Console.WriteLine($"{Break / 60000} Minutes left of Break");
                    if (Break <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("BREAKTIME OVER GET BACK TO WORK YOU MAGGOTS");
                        Console.WriteLine();
                        Console.WriteLine("Bruk 'Sett Timer' kommandoen for å sette arbeids timer du vil også bli bedt om en timer for pause som skal skje etter arbeidet.\n\nBruk 'Exit' for å avslutte");
                    }
                }
            }
        }
    }
}
