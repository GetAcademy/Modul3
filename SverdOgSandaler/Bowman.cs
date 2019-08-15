using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SverdOgSandaler
{
    class Bowman : Gladiator
    {
        public string RangedWeapon;
        public Bowman(string rangedweapon, int health, string name, int movespeed) : base(health, name, movespeed)
        {
            RangedWeapon = rangedweapon;
        }

        public void RangedAttack()
        {
            Console.WriteLine($"you fire your {RangedWeapon} at the enemy");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Ranged Weapon: {RangedWeapon}");
        }
    }
}
