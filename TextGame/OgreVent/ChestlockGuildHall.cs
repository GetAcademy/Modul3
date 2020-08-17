using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreVent
{
    public class ChestlockGuildHall
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
            if (Program.Location == "Chestlock Guild Hall")
            {
                switch (MyAction.ToUpper())
                {
                    case "LOOK LEFT":
                        Console.WriteLine();
                        Console.WriteLine("To your left inside the guild hall you see merchants waiting in line in order to talk to a clerk, it seems many have brought chests or bags of gold");
                        break;
                    case "LOOK RIGHT":
                        Console.WriteLine();
                        Console.WriteLine("To your right inside the guild hall you see offices, some that seem intended to recieve people who needs to talk to a guild representative and others that seem to be purely for use by those that work here.");
                        break;
                    case "LOOK FORWARD":
                        Console.WriteLine();
                        Console.WriteLine("Ahead of you inside the guild hall is a grand staircase that lead up to a floor that by the look of the guards stationed by it is off limits.");
                        break;
                    case "LOOK BACK":
                        Console.WriteLine();
                        Console.WriteLine("Behind you is the way out of the guild hall");
                        break;
                    case "TALK TO CLERK":
                        Console.WriteLine();
                        Console.WriteLine("waiting in line seems to take forever and you eventually you reach the clerk who informs you that you must live in the city in order to use the banks services, 'regulations' she says in a snarky tone");
                        break;
                    case "ENTER OFFICE":
                        Console.WriteLine();
                        Console.WriteLine("You enter one of the offices in order to talk to a representative of the guild and as you enter the office, the representative screams 'WAH, peasant! GUARDS!' you are tossed out of the representatives office, you think they can smell the poor person on you, quite a distinct smell");
                        break;
                    case "GO UP STAIRCASE":
                        Console.WriteLine();
                        Console.WriteLine("You head for the grand staircase, your heart flutters as you imagine what it would be like to walk upon such bejeweled engraved gold lined mirror clear marble stairs perfectly crafted with mathematical precision, though you end up being stopped by the guards who tell you to 'this place is off limits sir, please go and ... count sheep or something somewhere else, guild heads only'");
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
                    case "GO TO HUNTERS LODGE":
                        Console.WriteLine();
                        Console.WriteLine("You walk to the Hunters Lodge, there you find a man chopping firewood.\n The Lodge itself takes form in a large cabin it looks rather cozy and homely.");
                        Program.Location = "Hunters Lodge";
                        break;
                    case "GO TO BRINEWOOD FOREST":
                        Console.WriteLine();
                        Console.WriteLine("You walk to Brinewood Forest, you now stand in the forest there are sounds of birds in the trees, there are moss covered rocks and everything seems calm.");
                        Program.Location = "Brinewood Forest";
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
                        Console.WriteLine("Talk To Clerk");
                        Console.WriteLine("Enter Office");
                        Console.WriteLine("Go Up Staircase");
                        Console.WriteLine("Go To Markedplace");
                        Console.WriteLine("Go To Town Hall");
                        Console.WriteLine("Go To Hunters Lodge");
                        Console.WriteLine("Go To Brinewood Forest");
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
