using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SverdOgSandaler
{
    class Arena
    {
        static public void MagicVSMagic(Magicman Glad1, Magicman Glad2)
        {
            while(Glad1.Health > 0 && Glad2.Health > 0)
            {
                Glad1.MagicAttack();
                Glad2.Health--;
                if (Glad2.Health == 0)
                {
                    Console.WriteLine($"{Glad1.Name} won the fight against {Glad2.Name}");
                    break;
                }
                Glad2.MagicAttack();
                Glad1.Health--;
                if(Glad1.Health == 0)
                {
                    Console.WriteLine($"{Glad2.Name} won the fight against {Glad1.Name}");
                }
            }
            Console.WriteLine("The fight is over");
        }
        static public void MagicVSRanged(Magicman Glad1, Bowman Glad2)
        {
            while (Glad1.Health > 0 && Glad2.Health > 0)
            {
                Glad1.MagicAttack();
                Glad2.Health--;
                if (Glad2.Health == 0)
                {
                    Console.WriteLine($"{Glad1.Name} won the fight against {Glad2.Name}");
                    break;
                }
                Glad2.RangedAttack();
                Glad1.Health--;
                if (Glad1.Health == 0)
                {
                    Console.WriteLine($"{Glad2.Name} won the fight against {Glad1.Name}");
                }
            }
            Console.WriteLine("The fight is over");
        }
        static public void MagicVSMelee(Magicman Glad1, Swordman Glad2)
        {
            while (Glad1.Health > 0 && Glad2.Health > 0)
            {
                Glad1.MagicAttack();
                Glad2.Health--;
                if (Glad2.Health <= 0)
                {
                    Console.WriteLine($"{Glad1.Name} won the fight against {Glad2.Name}");
                    break;
                }
                Glad2.MeleeAttack();
                Glad1.Health--;
                if (Glad1.Health <= 0)
                {
                    Console.WriteLine($"{Glad2.Name} won the fight against {Glad1.Name}");
                }
            }
            Console.WriteLine("The fight is over");
        }
        static public void MeleeVSRanged(Swordman Glad1, Bowman Glad2)
        {
            while (Glad1.Health > 0 && Glad2.Health > 0)
            {
                Glad1.MeleeAttack();
                Glad2.Health--;
                if (Glad2.Health == 0)
                {
                    Console.WriteLine($"{Glad1.Name} won the fight against {Glad2.Name}");
                    break;
                }
                Glad2.RangedAttack();
                Glad1.Health--;
                if (Glad1.Health == 0)
                {
                    Console.WriteLine($"{Glad2.Name} won the fight against {Glad1.Name}");
                }
            }
            Console.WriteLine("The fight is over");
        }
        static public void RangedVSRanged(Bowman Glad1, Bowman Glad2)
        {
            while (Glad1.Health > 0 && Glad2.Health > 0)
            {
                Glad1.RangedAttack();
                Glad2.Health--;
                if (Glad2.Health == 0)
                {
                    Console.WriteLine($"{Glad1.Name} won the fight against {Glad2.Name}");
                    break;
                }
                Glad2.RangedAttack();
                Glad1.Health--;
                if (Glad1.Health == 0)
                {
                    Console.WriteLine($"{Glad2.Name} won the fight against {Glad1.Name}");
                }
            }
            Console.WriteLine("The fight is over");
        }
        static public void MeleeVSMelee(Swordman Glad1, Swordman Glad2)
        {
            while (Glad1.Health > 0 && Glad2.Health > 0)
            {
                Glad1.MeleeAttack();
                Glad2.Health--;
                if (Glad2.Health == 0)
                {
                    Console.WriteLine($"{Glad1.Name} won the fight against {Glad2.Name}");
                    break;
                }
                Glad2.MeleeAttack();
                Glad1.Health--;
                if (Glad1.Health == 0)
                {
                    Console.WriteLine($"{Glad2.Name} won the fight against {Glad1.Name}");
                }
            }
            Console.WriteLine("The fight is over");
        }
    }
}
