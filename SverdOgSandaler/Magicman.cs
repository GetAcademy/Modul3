using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SverdOgSandaler
{
    class Magicman : Gladiator
    {
        public string Spell;
        public Magicman(string spell, int health, string name, int movespeed) : base(health, name, movespeed)
        {
            Spell = spell;
        }

        public void MagicAttack()
        {
            Console.WriteLine($"You cast {Spell} at your foe!");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Spell: {Spell}");
        }
    }
}
