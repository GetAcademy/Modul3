using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax_Opptaksprøve
{
    class Bil : Kjøretøy
    {
        public string Farge;
        public string Type;
        public Bil(string RegNR, int effekt, int maksfart, string farge, string type) : base(RegNR, effekt, maksfart)
        {
            Farge = farge;
            Type = type;
        }
        public override void Show()
        {
            Console.WriteLine();
            Console.WriteLine($"Registrerings Nummer: {RegistreringsNummer}");
            base.Show();
            Console.WriteLine($"Farge: {Farge,26}");
            Console.WriteLine($"Type: {Type,27}");
        }

        protected override void ShowKjennetegn()
        {
            // fjerne
        }

        public void Drive()
        {
            Console.WriteLine();
            Console.WriteLine($"the car '{RegistreringsNummer}' is leaving the parking lot and heading towards its destination");
        }
    }
}
