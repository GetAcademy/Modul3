using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreVent
{
    public class DemonPit
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

            if (Program.Location == "Demon Pit")
            {
                if (!AmbiencePlayer.SoundOn) AmbiencePlayer.PlaySong("TownCave");
                else if(AmbiencePlayer.CurrentlyPlaying != "TownCave")
                {
                    AmbiencePlayer.SoundOn = false;
                    AmbiencePlayer.PlaySong("TownCave");
                }
                if (Console.ForegroundColor == ConsoleColor.White) Console.ForegroundColor = ConsoleColor.Gray;
                switch (MyAction.ToUpper())
                {
                    case "LOOK FORWARD":
                        Poster.Post("");
                        break;
                    case "LOOK LEFT":
                        Poster.Post("");
                        break;
                    case "LOOK RIGHT":
                        Poster.Post("");
                        break;
                    case "LOOK BEHIND":
                        Poster.Post("");
                        break;
                    case "LEAVE":
                        Poster.Post("You manage to claw your way out passing the mahagony doors and leave the building and return to the outside of the town hall.");
                        Program.Location = "Town Hall";
                        break;
                    case "HELP":
                        Poster.Post("The commands below might also include actions that you havent discovered in the story yet \n or choices your character havent discovered yet \n so use them with caution as using actions you havent discovered in the story might come at the expense of your experience.");
                        Poster.Post("Current Input Opportunities:");
                        Poster.Post("Look Forward");
                        Poster.Post("Look Left", 0, false);
                        Poster.Post("Look Right", 0, false);
                        Poster.Post("Look Behind", 0, false);
                        Poster.Post("Leave", 0, false);
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
