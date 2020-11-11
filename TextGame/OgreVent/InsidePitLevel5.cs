using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OgreVent
{
    public class InsidePitLevel5
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

            if (Program.Location == "Inside Pit Level 5")
            {
                if (Console.ForegroundColor == ConsoleColor.Red) Console.ForegroundColor = ConsoleColor.DarkRed;
                switch (MyAction.ToUpper())
                {
                    case "LOOK FORWARD":
                        Poster.Post("Ahead you see the silhouette of a man," +
                            " sitting in a chair." +
                            " In the centre of the room you notice small glinting objects surrounding the silhouette.");
                        break;
                    case "LOOK LEFT":
                        Poster.Post("To your left you see the staircase leading back out of this place.");
                        break;
                    case "LOOK RIGHT":
                        Poster.Post("To your right you see the walls as they form a circle," +
                            " the walls down here doesnt have any shelves carved into it," +
                            " they are just plain," +
                            " smoothed rock");
                        break;
                    case "LOOK BEHIND":
                        Poster.Post("Behind you is the wall you are standing up against");
                        break;
                    case "ASCEND":
                        Poster.Post("You sprint back up the staircase until you are out of breath and you stumble and fall," +
                            " you get back up on your feet and catch your breath");
                        Program.Location = "Inside Pit Level 4";
                        break;
                    case "INSPECT MAN":
                        Poster.Post("You walk over to the man sitting in the broken chair in the middle of the room," +
                            " as you get closer you realise the small glinting objects around him are gold coins and pretty gemstones," +
                            " that when you raise your light seems to have fallen out of his pockets and hands at the time he became lifeless," +
                            " as you raise your lamp even further you notice something is off," +
                            " his mouth looks odd almost mechanical," +
                            " his eyes are like made of glass, you realise you are looking at a puppet," +
                            " one that looks freakishly alike a real live human being," +
                            " a sense of immense fear settles in your stomach upon realising this unsettling fact," +
                            " yet the tempation of the gold and gems draw your mind elsewhere for long enough for you to get startled when suddenly the presumed lifeless puppet makes a long winded whispered wheeze," +
                            " its eyes have now focused on you.");
                        Thread.Sleep(500);
                        Poster.Post("The puppet says in an exhausted voice its nutcracker like jaws clacking and clicking as he speaks.", 0, false);
                        Thread.Sleep(500);
                        Poster.Post("'im so sorry," +
                            " i did it for the city," +
                            " i did it for the people," +
                            " the debt after the last war," +
                            " it was too great," +
                            " it would have crippled the people with taxes," +
                            " driven most into hunger and onto the street and many to the fate of death by starvation or disease," +
                            " i had no choice," +
                            " I swear i had no choice," +
                            " at first he asked only for a piece of my soul," +
                            " one fifth and they should not go hungry he said," +
                            " another fifth and you should have enough to free the city of the war debt," +
                            " and another fifth and the city shall happen upon a caravan with medicines to sell," +
                            " a rare offer at the time as medicine was nowhere to be found," +
                            " i could not say no," +
                            " i acted in good faith," +
                            " but the price i paid left me empty and in that emptiness i indulged myself in endless debauchery and greed in order to fill the void," +
                            " in order to attain these luxuries it cost me what remained of myself," +
                            " i traded it all away willingly," +
                            " and for all the women," +
                            " fine meals and money beyond count it could no longer satisfy me," +
                            " im so sorry," +
                            " im so sorry.'");
                        Thread.Sleep(500);
                        Poster.Post("The man puppet thing sheds a tear as it still has not adjusted itself to sit upright as if it can only move its face.");
                        Thread.Sleep(500);
                        Poster.Post("all the while the man has been talking a shadow of a tentacle has materialised," +
                            " seemingly phasing through the solid bedrock in the ground as if it was the water surface instead," +
                            " while the man speaks the tentacle wraps itself around the leg of the man and it climbs up before it dissapears up his back," +
                            " as the man finishes his last sentence," +
                            " a loud heart wrenching crunch sound which source could only be from the tentacle having slid up inside the man," +
                            " and has taken a grip around his spine and crushed it in the process", 0, false);
                        Thread.Sleep(500);
                        Poster.Post("The man goes silent and the puppet like features is suddenly gone," +
                            " the man looks like a man again and a live one at that," +
                            " he gets up out of the chair and dusts off his shoulders", 0, false);
                        Thread.Sleep(500);
                        Poster.Post("'My oh my, it seems we have gotton a visitor!'" +
                            " the man says with a sense of hostility well hidden behind the respectable and happy facade", 0, false);
                        Console.ReadKey();
                        if(Program.CheckInventory("wooden holy symbol"))
                        {

                        }
                        else
                        {

                        }
                        break;
                    case "HELP":
                        Poster.Post("The commands below might also include actions that you havent discovered in the story yet \n or choices your character havent discovered yet \n so use them with caution as using actions you havent discovered in the story might come at the expense of your experience.");
                        Poster.Post("Current Input Opportunities:");
                        Poster.Post("Look Forward");
                        Poster.Post("Look Left", 0, false);
                        Poster.Post("Look Right", 0, false);
                        Poster.Post("Look Behind", 0, false);
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
