using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Test
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter your name");
            MyClass MyProfile = new MyClass();
            MyProfile.Name = Console.ReadLine();
            Console.WriteLine("enter your age");
            Int32.TryParse(Console.ReadLine(), out MyProfile.Age);
            Console.WriteLine("Enter your Height");
            float.TryParse(Console.ReadLine(), out MyProfile.Height);
            Console.WriteLine("enter your weight");
            float.TryParse(Console.ReadLine(), out MyProfile.Weight);

            MyProfile.ShowProfile();
        }
    }
}
