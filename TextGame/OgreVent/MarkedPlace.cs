using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreVent
{
    public class MarkedPlace
    {
        public static string Input()
        {
            return Console.ReadLine();
        }
        public static string MyAction;
        public static void Actions(string Location,string Action)
        {
            MyAction = Action;
            if (MyAction.ToUpper() == "LOOK LEFT" && Location == "Markedplace")
            {
                Console.WriteLine();
                Console.WriteLine("To your left you can see a thriving markedplace it is currently early in the morning and most of the merchants have set up their stand and started their day while some tardy merchants are still arriving or in the middle of setting up their stand, in the center of the markedplace there is a rather spacious well with a steady stream of locals regularly retrieving water from it. on the marketplace there is a merchant who sells fresh meat and vegetables from local hunters and farmers, another who sells jewelry and other trinkets, one who seems to sell metalworks mostly tools some weapons, mostly horseshoes and carpentry nails, and one merchant who you cant really say what he is selling, seems like a little bit of this a little bit of that probably just a load of junk, and a merchant who hasnt completely set up his stand just yet who sells armor and good shoes and backpacks fit for the most travel hungry adventurer.");
                MyAction = Input();
            }
            else if (MyAction.ToUpper() == "LOOK RIGHT" && Location == "Markedplace")
            {
                Console.WriteLine();
                Console.WriteLine("To your right you can see the chapel where youre late master Yellegor Yellowflag was taken for burial preperations as he was lesser nobleman not just some mere peasant like yourself. Outside the chapel the flaggelant militia of the holy order of the Phoenix stands guard in rough tattered clothing seemingly non uniform with the exception of the holy symbol representing their god and their order hanging around their necks, the symbols are made of wood. they carry spears and several of them in munching on a loaf of bread in the current moment. the chapels reinforced front entrance is open and the puplic is seemingly free to enter and leave at their own behest.");
                MyAction = Input();
            }
            else if (MyAction.ToUpper() == "HELP" && Location == "Markedplace")
            {
                Console.WriteLine();
                Console.WriteLine("Current Input Opportunities:");
                Console.WriteLine("Look Left");
                Console.WriteLine("Look Right");
                MyAction = Input();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Sorry you cant do that right now, or possibly even ever!");
                Console.WriteLine("If you are stuck you can use the 'Help' Command to view all possible inputs at the current moment");
                MyAction = Input();
            }
        }
    }
}
