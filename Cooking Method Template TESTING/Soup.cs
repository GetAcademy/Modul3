using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooking_Method_Template_TESTING
{
    class Soup : Cooking
    {
        public override void Step1()
        {
            Console.WriteLine("Cut ingredients");
        }
        public override void Step2()
        {
            Console.WriteLine("boil ingredients and add spice after taste");
        }

        public override void Serve()
        {
            base.Serve();
            Console.WriteLine("Soup");
        }
    }
}
