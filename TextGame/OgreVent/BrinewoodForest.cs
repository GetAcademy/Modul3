using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OgreVent
{
    public class BrinewoodForest
    {
        public static string Input()
        {
            return Console.ReadLine();
        }
        public static string MyAction;
        public static void Actions(string Action)
        {
            Random random = new Random();
            MyAction = Action;
            if (Program.Location == "Brinewood Forest")
            {
                switch (MyAction.ToUpper())
                {
                    case "LOOK LEFT":
                        Console.WriteLine();
                        Console.WriteLine("To your left you see birds in the trees and the occasional blue berries, yummy");
                        break;
                    case "LOOK RIGHT":
                        Console.WriteLine();
                        Console.WriteLine("To your right you see a beehive in a tree, its surprisingly large.");
                        break;
                    case "LOOK FORWARD":
                        Console.WriteLine();
                        Console.WriteLine("Ahead of you is a great large OGRE, probably the one and the same that killed your master, it doesnt seem like it has noticed you yet");
                        break;
                    case "LOOK BACK":
                        Console.WriteLine();
                        Console.WriteLine("Behind you, you can see rough and hard to travel terrain, thorned bushes and the like");
                        break;
                    case "KILL OGRE":
                        int TotalDamage = 0;
                        int TotalDefence = 0;
                        foreach (Item item in Program.Inventory)
                        {
                            TotalDamage += item.MyDamage;
                            TotalDefence += item.MyArmor;
                        }
                        if (TotalDamage >= 7 && TotalDefence >= 15)
                        {
                            Console.WriteLine();
                            Console.WriteLine("You kill the mighty ogre and return triumphant, you claim your reward and live a merry life as a monster hunter until your last day and pass into legend");
                            Thread.Sleep(10000);
                            Environment.Exit(0);
                        }
                        else
                        {
                            Program.IsAlive = false;
                        }
                        break;
                    case "GO TO MARKEDPLACE":
                        Console.WriteLine("You go to the markedplace");
                        Program.Location = "Markedplace";
                        break;
                    case "GO TO TOWN HALL":
                        Console.WriteLine();
                        Console.WriteLine("You walk to the Town Hall located in the northern part of town,\n as you stand outside the Town Hall you notice that there are more guards here, the people look, walk and talk in a way that would suggest they come from wealth.\n The Town Hall itself has a bell tower with a spire. The Hall is made out of stone for the most part but the stone is painted white, however the spire is made out of wood and is seemingly the only major part of the Hall that is made of wood.");
                        Program.Location = "Town Hall";
                        break;
                    case "GO TO CHESTLOCK GUILD HALL":
                        Console.WriteLine();
                        Console.WriteLine("You walk to the Chestlock Guild Hall, as you arrive you find that the Guild Hall is actually a Fort with crenellations and everything with a Guild Hall instead of barracks and storage houses instead of stables and other normal structures to be found in a more tradiotional fort.\n And all this inside the city, there is a steady flow of people entering and leaving the Forts gate, and the guards standing by the gate and above on the wall seem ever so vigilant.");
                        Program.Location = "Chestlock Guild Hall";
                        break;
                    case "GO TO HUNTERS LODGE":
                        Console.WriteLine();
                        Console.WriteLine("You walk to the Hunters Lodge, there you find a man chopping firewood.\n The Lodge itself takes form in a large cabin it looks rather cozy and homely.");
                        Program.Location = "Hunters Lodge";
                        break;
                    case "GO TO SCHOLARS MARKET":
                        Console.WriteLine();
                        Console.WriteLine("You walk to the Scholars Market, the outside area would make you think of this as a street of townhouses but you notice a sign hanging above one of the doors saying 'The Scholars Market'\n. As you enter you understand that this might have at some point been a street of townhouses but has been later turned into a set of shops located on the same floor under one roof, and not just this street the houses that would have been on the next street aswell making this a rather sizable place.\n The smells in the air are varied and exotic");
                        Program.Location = "Scholars Market";
                        break;
                    case "HELP":
                        Console.WriteLine();
                        Console.WriteLine("The commands below might also include actions that you havent discovered in the story yet \n or choices your character havent discovered yet \n so use them with caution as using actions you havent discovered in the story might come at the expense of your experience.");
                        Console.WriteLine();
                        Console.WriteLine("Current Input Opportunities:");
                        Console.WriteLine();
                        Console.WriteLine("Look Left");
                        Console.WriteLine("Look Right");
                        Console.WriteLine("Look Forward");
                        Console.WriteLine("Look Back");
                        Console.WriteLine("Go To Markedplace");
                        Console.WriteLine("Go To Town Hall");
                        Console.WriteLine("Go To Chestlock Guild Hall");
                        Console.WriteLine("Go To Hunters Lodge");
                        Console.WriteLine("Go To Scholars Market");
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Sorry you cant do that right now, or possibly even ever!");
                        Console.WriteLine("If you are stuck you can use the 'Help' Command to view all possible inputs at the current moment");
                        break;
                }
            }
        }
    }
}
