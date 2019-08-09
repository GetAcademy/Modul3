using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax_Opptaksprøve
{
    abstract class Kjøretøy
    {
        public string Effekt;
        public string MaksFart;
        public string RegistreringsNummer;
        public string Kjennetegn;

        public Kjøretøy(string id, int effekt, int maksfartKm = 0, int maksfartKnop = 0)
        {
            Effekt = $"{effekt}Kw";
            if(maksfartKm > 0)
            {
                MaksFart = $"{maksfartKm}Km/t";
            }
            else if(maksfartKnop > 0)
            {
                MaksFart = $"{maksfartKnop}Knop";
            }
            RegistreringsNummer = $"nr {id}";
            Kjennetegn = $"{id}";
        }
        public virtual void Show()
        {
            Console.WriteLine($"Effekt: {Effekt,25}");
        }
        public virtual void SelectiveWrite(bool kjennetegn,bool maksfart)
        {
            if (kjennetegn)
            {
                Console.WriteLine($"Kjennetegn: {Kjennetegn,21}");
            }
            if (maksfart)
            {
                Console.WriteLine($"Maks Fart: {MaksFart,22}");
            }
        }
    }
}
