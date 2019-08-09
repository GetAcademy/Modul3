using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax_Opptaksprøve
{
    abstract class Tools
    {
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
    }
}
