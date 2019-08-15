using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SverdOgSandaler
{
    class Swordman : Gladiator
    {
        string MeleeWeapon;
        public Swordman(string meleeweapon, int health, string name, int movespeed) : base(health, name, movespeed)
        {
            MeleeWeapon = meleeweapon;
        }

        public void MeleeAttack()
        {
            Console.WriteLine($"you hit your opponent with your {MeleeWeapon}");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Melee Weapon: {MeleeWeapon}");
        }
    }
}
