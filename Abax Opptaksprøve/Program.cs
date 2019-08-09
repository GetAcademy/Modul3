using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax_Opptaksprøve
{
    class Program
    {
        #region Tools

        static Kjøretøy[] BROMBROM = new Kjøretøy[] 
        {
            new Bil("NF123456", 147, 200, "grønn", "lett kjøretøy"),
            new Bil("NF445566", 147, 300, "rød", "lett kjøretøy"),
            new Bil("NF445566", 147, 300, "rød", "lett kjøretøy"),
            new Bil("NF223366", 148, 600, "lilla", "tung kjøretøy"),
            new Bil("NF654321", 150, 195, "blå", "lett kjøretøy"),
            new Fly("LN1234",1000,30,2,10,"jetfly"),
            new Båt("ABC123", 100, 30, 500)
        };
        static void Compare(string verdi)
        {
            BROMBROM[0].Show();

            Output("COMPARED TO");

            BROMBROM[1].Show();

            Output("dette er ikke den samme bilen");
        }
        static string Input()
        {
            Console.WriteLine();
            Console.Write("Kommando: ");
            return Console.ReadLine().ToUpper();
        }
        static void Output(string text)
        {
            Console.WriteLine();
            Console.WriteLine(text);
        }

        #endregion Tools

        static void Main()
        {
            // lag en klasse som kan brukes som holder informasjon generelt for alle kjøretøy denne skal arves inn i andre klasser.
            // lag en klasse for bil, båt og fly som kan arve fra kjøretøy klassen.
            // sørg for at bil båt og fly klassen har en show metode for å printe informasjon om seg selv.
            // lag en metode i main som skal kunne gå inn i lister med objekter og sammenligne objekter med værandre for å se om de er like.

            Console.WriteLine(
                "Abax Opptaksprøve\n\n" +
                "Bruk 'Show All' kommandoen for å vise alle kjøretøy\n\n" +
                "Bruk 'Show Specific' kommandoen for å vise et spesifikt kjøretøy, kommandoen vil be om kjennetegn eller registrerings nummer.\n\n" +
                "Bruk 'Exit' kommandoen for å avslutte\n\n" +
                "Bruk 'Sammenlign Kjøretøy' kommandoen for å sammenligne 2 kjøretøy for å se om det er samme kjøretøyet\n\n" +
                "Bruk 'Fly' kommandoen for å få et fly til å flyn\n\n" +
                "Bruk 'Kjør' kommandoen for å få en bil til å kjøre");

            while (true)
            {
                switch (Input())
                {
                    case "SHOW ALL":
                        foreach(var BROM in BROMBROM)
                        {
                            BROM.Show();
                        }
                        continue;
                    case "SHOW SPECIFIC":
                        Output("skriv inn kjøretøyets registrerings nummer eller kjennetegn");
                        string Id = Input();
                        foreach (var BROM in BROMBROM)
                        {
                            if(Id == BROM.RegistreringsNummer || Id == BROM.Kjennetegn)
                            {
                                BROM.Show();
                                break;
                            }
                        }
                        continue;
                    case "SAMMENLIGN KJØRETØY":
                        Console.WriteLine();
                        Compare("147Kw");
                        continue;
                    case "FLY":
                        Fly fly = (Fly)BROMBROM[5];
                        fly.FlyFly();
                        continue;
                    case "DRIVE":
                        Bil bil = (Bil)BROMBROM[0];
                        bil.Drive();
                        continue;
                    case "EXIT":
                        Environment.Exit(0);
                        continue;
                }
                Output("Error Wrong Command");
            }
        }
    }
}
