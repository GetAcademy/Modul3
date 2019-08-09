using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax_Opptaksprøve
{
    class Båt : Kjøretøy
    {
        public string Bruttotonnasje;
        public Båt(string kjennetegn, int effekt, int maksfart, int bruttotonnasje) : base(kjennetegn,effekt,0,maksfart)
        {
            Bruttotonnasje = $"{bruttotonnasje}Kg";
        }

        public override void Show()
        {
            Console.WriteLine();
            base.SelectiveWrite(true, true);
            base.Show();
            Console.WriteLine($"Bruttotonasje: {Bruttotonnasje,18}");
        }

        public override void SelectiveWrite(bool kjennetegn, bool maksfart)
        {
            if (kjennetegn)
            {
                Console.WriteLine($"Kjennetegn: {Kjennetegn,21}");
            }
            base.Show();
            if (maksfart)
            {
                Console.WriteLine($"Maks Fart: {MaksFart,22}");
            }
        }
    }
}
