using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_Obligatorisk_1
{
    class Person
    {
        public Person Dad;
        public Person Mom;
        public List<Person> MyChildren = new List<Person>();
        public string FrstName;
        public string LstName;
        public int Id;
        public string BrthYear;
        public string DthYear;

        public Person(string FirstName, string LastName, int ID, string BirthYear = "Uknown", string DeathYear = "")
        {
            FrstName = FirstName;
            LstName = LastName;
            Id = ID;
            BrthYear = BirthYear;
            DthYear = DeathYear;
        }

        public Person(Person Father, Person Mother, string FirstName, string LastName, int ID, string BirthYear = "Uknown", string DeathYear = "")
        {
            Dad = Father;
            Mom = Mother;
            FrstName = FirstName;
            LstName = LastName;
            Id = ID;
            BrthYear = BirthYear;
            DthYear = DeathYear;
        }

        public Person(Person[] Children, string FirstName, string LastName, int ID, string BirthYear = "Uknown", string DeathYear = "")
        {
            foreach(Person Child in Children)
            {
                MyChildren.Add(Child);
            }
            FrstName = FirstName;
            LstName = LastName;
            Id = ID;
            BrthYear = BirthYear;
            DthYear = DeathYear;
        }

        public Person(Person Father, Person Mother, Person[] Children, string FirstName, string LastName, int ID, string BirthYear = "Uknown", string DeathYear = "")
        {
            Dad = Father;
            Mom = Mother;
            foreach (Person Child in Children)
            {
                MyChildren.Add(Child);
            }
            FrstName = FirstName;
            LstName = LastName;
            Id = ID;
            BrthYear = BirthYear;
            DthYear = DeathYear;
        }



        public void Show(string Setting)
        {
            switch (Setting)
            {
                case "Parents":
                    Console.WriteLine();
                    Console.WriteLine($"First Name: {FrstName}");
                    Console.WriteLine();
                    Console.WriteLine($"Last Name: {LstName}");
                    Console.WriteLine();
                    Console.WriteLine($"Slektstre ID: {Id}");
                    Console.WriteLine();
                    Console.WriteLine($"Fødtselsår: {BrthYear}");
                    Console.WriteLine();
                    Console.WriteLine($"Dødtsår {DthYear}");
                    Console.WriteLine();
                    Console.WriteLine("Faren sin Profil:");
                    Console.WriteLine();
                    Console.WriteLine("********");
                    Console.WriteLine();
                    Dad.Show("Default");
                    Console.WriteLine("********");
                    Console.WriteLine();
                    Console.WriteLine("Moren sin Profil:");
                    Console.WriteLine();
                    Console.WriteLine("********");
                    Console.WriteLine();
                    Mom.Show("Default");
                    Console.WriteLine();
                    Console.WriteLine("********");
                    Console.WriteLine();
                    break;
                case "Children":
                    Console.WriteLine();
                    Console.WriteLine($"First Name: {FrstName}");
                    Console.WriteLine();
                    Console.WriteLine($"Last Name: {LstName}");
                    Console.WriteLine();
                    Console.WriteLine($"Slektstre ID: {Id}");
                    Console.WriteLine();
                    Console.WriteLine($"Fødtselsår: {BrthYear}");
                    Console.WriteLine();
                    Console.WriteLine($"Dødtsår {DthYear}");
                    Console.WriteLine();
                    Console.WriteLine("Barna sin Profil(er):");
                    foreach (Person Child in MyChildren.ToArray())
                    {
                        Console.WriteLine();
                        Console.WriteLine("********");
                        Console.WriteLine();
                        Child.Show("Default");
                        Console.WriteLine("********");
                        Console.WriteLine();
                    }
                    break;
                case "Family":
                    Console.WriteLine();
                    Console.WriteLine($"First Name: {FrstName}");
                    Console.WriteLine();
                    Console.WriteLine($"Last Name: {LstName}");
                    Console.WriteLine();
                    Console.WriteLine($"Slektstre ID: {Id}");
                    Console.WriteLine();
                    Console.WriteLine($"Fødtselsår: {BrthYear}");
                    Console.WriteLine();
                    Console.WriteLine($"Dødtsår {DthYear}");
                    Console.WriteLine();
                    Console.WriteLine("Faren sin Profil:");
                    Console.WriteLine();
                    Console.WriteLine("********");
                    Console.WriteLine();
                    Dad.Show("Default");
                    Console.WriteLine("********");
                    Console.WriteLine();
                    Console.WriteLine("Moren sin Profil:");
                    Console.WriteLine();
                    Console.WriteLine("********");
                    Console.WriteLine();
                    Mom.Show("Default");
                    Console.WriteLine();
                    Console.WriteLine("********");
                    Console.WriteLine();
                    Console.WriteLine("Barna sin Profil(er):");
                    foreach (Person Child in MyChildren.ToArray())
                    {
                        Console.WriteLine();
                        Console.WriteLine("********");
                        Console.WriteLine();
                        Child.Show("Default");
                        Console.WriteLine("********");
                        Console.WriteLine();
                    }
                    break;
                case "Default":
                    Console.WriteLine();
                    Console.WriteLine($"First Name: {FrstName}");
                    Console.WriteLine();
                    Console.WriteLine($"Last Name: {LstName}");
                    Console.WriteLine();
                    Console.WriteLine($"Slektstre ID: {Id}");
                    Console.WriteLine();
                    Console.WriteLine($"Fødtselsår: {BrthYear}");
                    Console.WriteLine();
                    Console.WriteLine($"Dødtsår {DthYear}");
                    Console.WriteLine();
                    break;
            }
        }
    }
}

