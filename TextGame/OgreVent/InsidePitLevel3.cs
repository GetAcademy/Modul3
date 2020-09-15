using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreVent
{
    public class InsidePitLevel3
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

            if (Program.Location == "Inside Pit Level 3")
            {
                switch (MyAction.ToUpper())
                {
                    case "LOOK FORWARD":
                        Poster.Post("Ahead, you see the staircase continuing down into the darkness");
                        break;
                    case "LOOK LEFT":
                        Poster.Post("To your left is the edge of the staircase towards the center of the pit");
                        break;
                    case "LOOK RIGHT":
                        Poster.Post("To your right," +
                            " you notice that the content in the shelves has changed," +
                            " while still being filled with an extraordinary quantity of papers in various forms," +
                            " the majority of the space is taken up by large wooden boxes that resembles coffins," +
                            " at a closer inspection you confirm that these wooden boxes are indeed coffins," +
                            " why they would be here and not in the cemetary as is customary is beyond your feeble comprehension");
                        break;
                    case "LOOK BEHIND":
                        Poster.Post("You look back up the staircase," +
                            " with a wanting to leave and be done with the horror and fear you have for this place and all of its absurdity," +
                            " but you know what they say about curiosity," +
                            " curiosity is lying in wait for every secret");
                        break;
                    case "DESCEND":
                        Poster.Post("You continue further down into the pit," +
                            " as you progress some singular memories become more disturbed, isolated, broken and distant.");
                        Program.Location = "Inside Pit Level 4";
                        break;
                    case "ASCEND":
                        Poster.Post("You walk back up the staircase");
                        Program.Location = "Inside Pit Level 2";
                        break;
                    case "HELP":
                        Poster.Post("The commands below might also include actions that you havent discovered in the story yet \n or choices your character havent discovered yet \n so use them with caution as using actions you havent discovered in the story might come at the expense of your experience.");
                        Poster.Post("Current Input Opportunities:");
                        Poster.Post("Look Forward");
                        Poster.Post("Look Left", 0, false);
                        Poster.Post("Look Right", 0, false);
                        Poster.Post("Look Behind", 0, false);
                        Poster.Post("Descend", 0, false);
                        Poster.Post("Ascend", 0, false);
                        break;
                    default:
                        Poster.Post("In this pit you may not take such an action, however i can always offer you the option to cower in fear!");
                        Poster.Post("If you are stuck you can use the 'Help' Command to view all possible inputs at the current moment", 0, false);
                        break;
                }
            }
        }
    }
}
