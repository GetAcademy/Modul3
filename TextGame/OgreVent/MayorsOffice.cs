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
            Poster.Post("The man leans forward and rests his elbows on his desk, before he says 'so, do you have it? do you have my ring?'");
            if(GlobalBools.TookTheMayorsRing && Program.CheckInventory("mayors ring"))
            {
                Poster.Post("The magic in the ring creates a presence that fills the room," +
                    " making it a sort of magical elephant in the room" +
                    " you think the very question he poses is but a formality," +
                    " the presence of the ring is a secret to noone." +
                    " There is no question about it," +
                    " you will be handing the ring over to him," +
                    " the consequenses of doing otherwise would be unimaginably terrifying and is therefore a non option," +
                    " however the fear of not knowing what he intends to do with either you or the ring once he has it creeps into your mind as the moment grows closer.");
                Poster.Post("saying nothing you quickly step forward towards the edge of his desk," +
                    " dropping the ring on top of some lightly stained notes next to an inkwell before you quickly take a step back again." +
                    " fear fills you as he looks at the still spinning piece of metal with great excitement");
                Poster.Post("As he latches his hands around the ring,'" +
                    " you are in a sudden moment brought to another place," +
                    " one of fire," +
                    " one of brimstone," +
                    " the smell of sulphur is so real," +
                    " the crapmp nature of the place seems so commonplace," +
                    " it is like you have already spent an eterntiy here," +
                    " the amount of people gathered around your near viscinity is enough to restrict all movement of your upper body," +
                    " however with your neck and head you are able to observe 2 large gates made of the thickest iron you have ever seen jagged and spiked," +
                    " parts of it on fire arts of the spikes covered in what you think to be human heads," +
                    " the crowd you are ever stuck in is slowly but surely moving towards the gates," +
                    " the inevitability of passing trough to the other sides of this magmatic inferno." +
                    " A pain and misery you have never felt before in your life seems to be ever more present as you move closer to these gates," +
                    " a sense of futility overtakes you as you realise these gates are the very end of everything regardless of the sight smell" +
                    " and otherwise experience of the place on the other side. a physically unrecognizable shape yet recognizable in other ways, is the mayor on top of his throne way past the gates with a string instrument strapped around his upper body ");
                GlobalBools.DoneWithTheDevil = true;
            }
        }
    }
}
