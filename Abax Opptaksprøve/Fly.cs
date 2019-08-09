using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax_Opptaksprøve
{
    class Fly : Kjøretøy
    {
        public string Vingespenn;
        public string Lasteevne;
        public string Egenvekt;
        public string Flyklasse;
        public Fly(string kjennetegn, int effekt, int vingespenn, int lasteevne, int egenvekt, string flyklasse) : base(kjennetegn,effekt)
        {
            Vingespenn = $"{vingespenn}M";
            Lasteevne = $"{lasteevne}Tonn";
            Egenvekt = $"{egenvekt}Tonn";
            Flyklasse = flyklasse;
        }

        public override void Show()
        {
            Console.WriteLine();
            base.SelectiveWrite(true, false);
            base.Show();
            Console.WriteLine($"Vingespenn: {Vingespenn,21}");
            Console.WriteLine($"Laste Evne: {Lasteevne,21}");
            Console.WriteLine($"Egen Vekt: {Egenvekt,22}");
            Console.WriteLine($"Flyklasse: {Flyklasse,22}");
        }
        public void FlyFly()
        {
            Console.WriteLine();
            Console.WriteLine($"The plane '{Kjennetegn}' is taking off and heading towards its destination");
        }
    }
}
