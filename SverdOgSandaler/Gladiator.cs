using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SverdOgSandaler
{
    class Gladiator
    {
        public int Health;
        public string Name;
        public int MovementSpeed;

        public Gladiator(int health, string name, int movespeed)
        {
            Health = health;
            Name = name;
            MovementSpeed = movespeed;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Movement Speed: {MovementSpeed}");
        }
    }
}
