using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Test
{
    class MyClass
    {
        public int Age;
        public string Name;
        public float Height;
        public float Weight;


        float CalculateBMI()
        {
            return Weight / (float)Math.Pow(Height,2);
        }
        public void ShowProfile()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age} Years");
            Console.WriteLine($"Height: {Height} Meters");
            Console.WriteLine($"Weight: {Weight}KG");
            Console.WriteLine($"BMI: {Math.Floor(CalculateBMI())}");

            if(Math.Floor(CalculateBMI()) < 30)
            {
                Console.WriteLine("you are underweight");
            }
            else if(Math.Floor(CalculateBMI()) < 40)
            {
                Console.WriteLine("you are normalweight");
            }
            else
            {
                Console.WriteLine("you are overweight");
            }

            
        }
    }
}
