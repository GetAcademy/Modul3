using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_Obligatorisk_1
{
    class Program
    {
        static int Identity = 0;
        static List<Person> Relatives = new List<Person>();
        static List<Person> People = new List<Person>();

        static void Main()
        {
            bool End = false;
            CreatePeople();
            CreateRelatives();
            Console.WriteLine("Familietre oppgave bruk 'help' kommandoen om du ønsker en liste med kommandoer");
            while (!End)
            {
                Console.WriteLine();
                Console.WriteLine("skriv inn en kommando!");
                Console.WriteLine();
                string input = Input();
                switch (input)
                {
                    case "HELP":
                        Console.WriteLine("'liste': vil vise deg en liste over alle personer i familietre registeret");
                        Console.WriteLine("'vis': vil gi deg mulighet til å skrive inn ID nummeret til en slektning som da hentes frem");
                        Console.WriteLine("'slutt': vil avslutte slektstre programmet");
                        break;
                    case "LISTE":
                        Liste();
                        break;
                    case "VIS":
                        Console.WriteLine("input slektnings ID:");
                        Vis(Convert.ToInt32(Input()));
                        break;
                    case "SLUTT":
                        Console.WriteLine("Hade");
                        End = true;
                        break;

                }
            }
        }

        static void Liste()
        {
            foreach (Person Relative in Relatives.ToArray())
            {
                if (Relative.Dad != null && Relative.Mom != null && Relative.MyChildren.ToArray().Length > 0)
                {
                    Relative.Show("Family");
                }
                else if (Relative.Dad != null && Relative.Mom != null)
                {
                    Relative.Show("Parents");
                }
                else if (Relative.MyChildren.ToArray().Length > 0)
                {
                    Relative.Show("Children");
                }
                else
                {
                    Relative.Show("Default");
                }
            }
        }

        static void Vis(int SlektningID)
        {
            Person[] array = Relatives.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Person Relative = array[i];
                if(Relative.Id == SlektningID)
                {
                    if(Relative.Dad != null && Relative.Mom != null && Relative.MyChildren.ToArray().Length > 0)
                    {
                        Relative.Show("Family");
                    }
                    else if (Relative.Dad != null && Relative.Mom != null)
                    {
                        Relative.Show("Parents");
                    }
                    else if(Relative.MyChildren.ToArray().Length > 0)
                    {
                        Relative.Show("Children");
                    }
                    else
                    {
                        Relative.Show("Default");
                    }
                }
            }
        }

        static string Input()
        {
            return Console.ReadLine().ToUpper();
        }

        static void CreatePeople()
        {
            People.Add(new Person("Jonas", "Brattås", Identity, "1712", "Uknown"));
            Identity++;
            People.Add(new Person("Lise", "Brattås", Identity, "1710", "1754"));
            Identity++;
            People.Add(new Person("Geir", "Brattås", Identity, "1728", "1759"));
            Identity++;
            People.Add(new Person("Linea", "Brattås", Identity, "1725", "1762"));
            Identity++;
            People.Add(new Person("Silje", "Brattås", Identity, "1730", "1767"));
            Identity++;
            People.Add(new Person("Hans", "Brattås", Identity, "1750", "1790"));
        }

        static void CreateRelatives()
        {
            Relatives.Add(new Person(new Person[] {People[2],People[4]},People[0].FrstName, People[0].LstName, People[0].Id, People[0].BrthYear, People[0].DthYear));
            Relatives.Add(new Person(new Person[] { People[2], People[4] }, People[1].FrstName, People[1].LstName, People[1].Id, People[1].BrthYear, People[1].DthYear));
            Relatives.Add(new Person(Relatives[0], Relatives[1], new Person[] { People[5] }, People[2].FrstName, People[2].LstName, People[2].Id, People[2].BrthYear, People[2].DthYear));
            Relatives.Add(new Person(new Person[] { People[5] }, People[3].FrstName, People[3].LstName, People[3].Id, People[3].BrthYear, People[3].DthYear));
            Relatives.Add(new Person(Relatives[0], Relatives[1], People[4].FrstName, People[4].LstName, People[4].Id, People[4].BrthYear, People[4].DthYear));
            Relatives.Add(new Person(Relatives[2], Relatives[3], People[5].FrstName, People[5].LstName, People[5].Id, People[5].BrthYear, People[5].DthYear));
        }
    }
}

