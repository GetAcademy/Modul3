using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

using System.Diagnostics;
using System.Threading;

namespace Oppgave_Ordgåter
{
    class Program
    {
        [DllImport("kernel32")]
        static extern int GetCurrentThreadId();
        static void Main()
        {
            Thread t = new Thread(
            new ThreadStart(DoWork));
            t.Start();
            t.Join();
            MakeWordsHappen();
        }
        static void DoWork()
        {
            foreach (ProcessThread pt in Process.GetCurrentProcess().Threads)
            {
                int utid = GetCurrentThreadId();
                if (utid == pt.Id)
                {
                    pt.ProcessorAffinity = (IntPtr)(1); // Set affinity for this thread to CPU #1
                    Console.WriteLine("Set");
                }
            }
        }

        private static Random _random = new Random();
        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
        }


        static void MakeWordsHappen()
        {
            Console.WriteLine("Working...");
            int Index = 0;
            int counter = 0;
            int WordCount = 0;
            StreamReader MyWordBank = new StreamReader(@"D:\GitHub\GitHub\Oppgave Ordgåter\fullform_bm.txt", Encoding.UTF8);
            string[] Lines = new string[1222383];
            string[] Words = new string[144081];
            List<string> MyWords = new List<string>();

            for (int i = 0; i < Lines.Length; i++)
            {
                Lines[i] = MyWordBank.ReadLine();
                counter++;
            }
            string lastWord = null;

            foreach (string Line in Lines)
            {
                string[] parts = Line.Split('\t');
                if (parts.Length <= 2) continue;
                string baseWord = parts[1];
                if (baseWord.Length < 3 || baseWord == lastWord) continue;

                var word = parts[2];
                Words[WordCount] = word;
                WordCount++;
                lastWord = word;

            }

            File.WriteAllLines(@"D:\GitHub\GitHub\Oppgave Ordgåter\Ordliste.txt", Words);

            for (int i = 0; i < Words.Length - 1; i++)
            {
                if (i > Words.Length - 1)
                {
                    break;
                }
                string First(bool IsRest)
                {
                    int tempcount = 0;
                    string tempstring = "";
                    if (!IsRest)
                    {
                        if (Words[i] == null)
                        {
                            return null;
                        }
                        foreach (char Character in Words[i])
                        {
                            if (tempstring.Length >= 3)
                            {
                                return tempstring;
                            }
                            else
                            {
                                tempstring += Character;
                            }
                        }
                        return tempstring;
                    }
                    else
                    {
                        if (Words[i] == null)
                        {
                            return null;
                        }
                        foreach (char Character in Words[i])
                        {
                            tempcount++;
                            if (tempcount > 3)
                            {
                                tempstring += Character;
                            }
                        }
                        return tempstring;
                    }
                    
                }
                string Second(int Current, bool IsRest, int lettercount)
                {
                    string tempstring = "";
                    int tempcount = 0;
                    if (!IsRest)
                    {
                        if (Words[Current] == null)
                        {
                            return null;
                        }
                        foreach (char Character in Words[Current])
                        {
                            tempcount++;
                            if (tempstring.Length >= lettercount)
                            {
                                return tempstring;
                            }
                            else if (tempcount >= Words[Current].Length - lettercount)
                            {
                                tempstring += Character;
                            }
                        }
                        return tempstring;
                    }
                    else
                    {
                        if (Words[Current] == null)
                        {
                            return null;
                        }
                        foreach (char Character in Words[Current]) // use this in First to get the letters other than the ones compared.
                        {
                            tempcount++;
                            if (tempcount > lettercount)
                            {
                                tempstring += Character;
                            }
                        }
                        return tempstring;
                    }
                }
                for (int way = 3; way < 5; way++)
                {
                    if (Index <= 20000)
                    {
                        for (int gay = 0; gay < Words.Length; gay++)
                        {
                            if (First(false) == Second(gay, false, way) && First(false) != null && Second(gay, false, way) != null)
                            {
                                MyWords.Add(First(true) + Second(gay, true, way));
                                if (string.IsNullOrEmpty(MyWords[Index]) || MyWords[Index].Contains("-") || MyWords[Index].Contains(".") || MyWords[Index].Length < 3 || string.IsNullOrWhiteSpace(MyWords[Index]))
                                {
                                    MyWords.RemoveAt(Index);
                                    //Console.WriteLine("Removed Index");
                                    Index--;
                                }
                                Console.ForegroundColor = GetRandomConsoleColor();
                                Index++;
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            File.WriteAllLines(@"D:\GitHub\GitHub\Oppgave Ordgåter\Ordgåter.txt",MyWords.ToArray());

            MyWordBank.Close();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("There were {0} Lines.", counter);
            Console.WriteLine("There were {0} Words.", WordCount);
            Console.WriteLine("There were {0} Created Words", Index);
            Console.ResetColor();
            Console.WriteLine($"the Words array has {Words.Length - WordCount} empty elements");
            //Console.WriteLine($"the MyWords array has {MyWords.ToArray().Length - Index} empty elements");

            Console.ReadLine();
        }
    }
}
