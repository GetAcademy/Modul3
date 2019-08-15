using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SverdOgSandaler
{
    class Program
    {
        static void Main()
        {
            string Action = string.Empty;

            Magicman Thomas = new Magicman("Fireball", 7, "Thomas", 5);
            Swordman Jens = new Swordman("Big Stick", 15, "Big Johnny Bravo", 6);

            string Input()
            {
                Console.WriteLine();
                Console.Write("Action: ");
                return Console.ReadLine().ToUpper();
            }
            Console.WriteLine("Welcome to 'sverd og sandaler' where you choose a gladiator and fight to the death with them");
            Console.WriteLine("to list combatants use 'List'");
            Console.WriteLine("to start a fight say fight you will then be prompted to enter the name of the first gladiator and then the second after.");
            while (true)
            {
                Console.WriteLine();
                Action = Input();
                switch (Action)
                {
                    case "LIST":
                        Thomas.Show();
                        Console.WriteLine();
                        Jens.Show();
                        break;
                    case "FIGHT":
                        string tempfighter1 = string.Empty;
                        string tempfighter2 = string.Empty;
                        Console.WriteLine("enter first fighter");
                        tempfighter1 = Input();
                        Console.WriteLine("enter second fighter");
                        tempfighter2 = Input();
                        Arena.MagicVSMelee(Thomas, Jens);
                        break;
                }
            }
        }
    }
}
