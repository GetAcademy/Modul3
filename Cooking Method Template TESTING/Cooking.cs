using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooking_Method_Template_TESTING
{
    abstract class Cooking
    {
        public abstract void Step1();
        public abstract void Step2();

        public virtual void Serve()
        {
            Console.WriteLine("You serve: ");
        }

        public void Execute()
        {
            Step1();
            Step2();
            Serve();
        }
    }
}
