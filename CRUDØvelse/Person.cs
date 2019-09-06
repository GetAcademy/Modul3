using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDØvelse
{
    class Person
    {
        public string Name;
        public int BirthYear;
        public int Age;
        public string Mother;
        public string Father;

        public Person()
        {
        }

        public Person(string name, int birthyear, int age, string mother, string father)
        {
            name = name;
            BirthYear = birthyear;
            Age = age;
            Mother = mother;
            Father = father;
        }

        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine($"Navn: {Name}");
            Console.WriteLine($"Alder: {Age}År");
            Console.WriteLine($"Fødtselsår: {BirthYear}");
            Console.WriteLine($"Mor: {Mother}");
            Console.WriteLine($"Far: {Father}");
        }
    }
}
