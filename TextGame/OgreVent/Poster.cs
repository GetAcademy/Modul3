using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreVent
{
    class Poster
    {
        public Poster(string post, int delay = 0)
        {
            Console.WriteLine();
            Console.WriteLine(post);
            Program.Time(delay);
        }
    }
}
