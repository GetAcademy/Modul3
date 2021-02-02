using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreVent
{
    class MayorsOffice
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

            if (Program.Location == "Mayors Office")
            {
                switch (MyAction.ToUpper())
                {
                    case "LOOK LEFT":
                        Poster.Post("To your left," +
                            " you see wonderfull creations of glass put on display on potentially equally wonderfull shelves," +
                            " your visual tourism of the office is however abruptly interrupted by the cold gaze burning a figurative hole through your right temple," +
                            " you confirm what you experience by picking up a slightly aggressive stare in the right corner of your eye," +
                            " you straighten up and face the man.");
                        TalkingToTheMayor();
                        break;
                    case "LOOK RIGHT":
                        Poster.Post("To your right," +
                            " you see bookshelves," +
                            " filled with books with brown leather covers," +
                            " on the third shelf there is a reading lantern with a stack of books resting up against the glass sides of the lantern," +
                            " your visual tourism of the office is however abruptly interrupted by the cold gaze burning a figurative hole through your left temple," +
                            " you confirm what you experience by picking up a slightly aggressive stare in the left corner of your eye," +
                            " you straighten up and face the man.");
                        TalkingToTheMayor();
                        break;
                    case "LOOK FORWARD":
                        Poster.Post("Ahead of you, the man sits comfortably in his chair as he swirls a low," +
                            " wide glass of something brown and transluscent," +
                            " his eyes fixed on you," +
                            " awaiting for you to approach");
                        TalkingToTheMayor();
                        break;
                    case "LOOK BACK":
                        Poster.Post("Behind you," +
                            " is the way out," +
                            " having walked in here you feel as if the way out is but an alluring concept unattainable at the current time," +
                            " in your current predicament," +
                            " your thoughts is however abruptly interrupted by the cold gaze burning a figurative hole in your neck," +
                            " you turn around only to confirm that the man is indeed staring right at you, looking somewhat impatient," +
                            " you straighten up and face the man.");
                        TalkingToTheMayor();
                        break;
                    case "TALK TO MAN":
                        TalkingToTheMayor();
                        break;
                    case "HELP":
                        Poster.Post("The commands below might also include actions that you havent discovered in the story yet \n or choices your character havent discovered yet \n so use them with caution as using actions you havent discovered in the story might come at the expense of your experience.");
                        Poster.Post("Current Input Opportunities:");
                        Poster.Post("Look Left");
                        Poster.Post("Look Right", 0, false);
                        Poster.Post("Look Forward", 0, false);
                        Poster.Post("Look Back", 0, false);
                        Poster.Post("Talk To Man", 0, false);
                        break;
                    default:
                        Poster.Post("Sorry you cant do that right now, or possibly even ever!");
                        Poster.Post("If you are stuck you can use the 'Help' Command to view all possible inputs at the current moment", 0, false);
                        break;
                }
            }
        }
        public static void TalkingToTheMayor()
        {
            // after you have gone to the church and gotton what he wanted you come back here and hand it to him.
        }
    }
}
