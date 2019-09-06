using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using CRUDØvelse.Models;

namespace CRUDØvelse
{
    class Program
    {
        public static CrudTools DB = new CrudTools(@"(localdb)\MSSQLLocalDB", "Users");

        static public string Input()
        {
            Console.WriteLine();
            Console.Write("Command: ");
            return Console.ReadLine();
        }

        static public int InputNumber()
        {
            Console.WriteLine();
            Console.Write("Number: ");
            return Int32.Parse(Console.ReadLine());
        }

        static void Main()
        {
            Run().Wait();
        }
        static public async Task Run()
        {
            string Command;
            while (true)
            {
                Command = Input().ToLower();
                switch (Command)
                {
                    case "add":
                        Console.WriteLine("type in name");
                        string name = Input();
                        Console.WriteLine("type in Birthyear");
                        int birthyear = InputNumber();
                        Console.WriteLine("typ in Age");
                        int age = InputNumber();
                        Console.WriteLine("type in mothers name");
                        string mother = Input();
                        Console.WriteLine("type in fathers name");
                        string father = Input();
                        Task result = DB.Insert(name, birthyear, age, mother, father);
                        Console.WriteLine($"you have inserted {result} people into the database");
                        continue;
                    case "showall":
                        await DB.ShowAll();
                        continue;
                }
                Console.WriteLine("error wrong command try again");
            }
            DB.GetPersonID(1).Wait();
        }
    }
}
