using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreVent
{
    public class Church
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

            if (Program.Location == "Church")
            {
                switch (MyAction.ToUpper())
                {
                    case "LOOK FORWARD":
                        Console.WriteLine();
                        Console.WriteLine("In front of you there are the doors that lead into the Nave you can see all the way up to the Ambulatory.\n You see a priest by the crossing lighting candles.");
                        break;
                    case "LOOK LEFT":
                        Console.WriteLine();
                        Console.WriteLine("To your left there is a sleeping guard sitting in a chair, next to the guards chair there is a bill hook and on his belt there is a key");
                        break;
                    case "LOOK RIGHT":
                        Console.WriteLine();
                        Console.WriteLine("To your right there is a closed door, a lantern hangs on a hook next to the door.");
                        break;
                    case "LOOK BEHIND":
                        Console.WriteLine();
                        Console.WriteLine("Behind you there is the way back out");
                        break;
                    case "TALK TO PRIEST":
                        Console.WriteLine();
                        Console.WriteLine("what do you talk to him about?");
                        Console.WriteLine();
                        Console.WriteLine("Ask about funeral");
                        Console.WriteLine("Ask about Yellegors Belongings");
                        Console.WriteLine("Ask to see Yellegors body");
                        string LocalInput = Input();
                        Console.WriteLine();
                        if (LocalInput.ToUpper() == "ASK ABOUT FUNERAL")
                        {
                            Console.WriteLine("The priest says that Sir Yellowflags funeral will be held tomorrow on the evening, he says it is such a tragedy what happened to sir Yellowflag");
                        }
                        else if (LocalInput.ToUpper() == "ASK ABOUT YELLEGORS BELONGINGS")
                        {
                            Console.WriteLine("The priest says that most of Yellegors belongings will be passed onto his wife, but his armor, shield and sword will be buried with the knight.");
                        }
                        else if (LocalInput.ToUpper() == "ASK TO SEE YELLEGORS BODY")
                        {
                            Console.WriteLine("The priest says that it is uncommon to allow other people than family members to see the body, so im going to have to ask you to say your farewells during the funeral.");
                        }
                        else
                        {
                            Console.WriteLine("The priest knows nothing of this topic or has nothing to add to this topic, either way the conversation grinds to a halt.");
                        }
                        break;
                    case "PRAY":
                        Console.WriteLine();
                        if (random.Next(1, 5) == 4)
                        {
                            Console.WriteLine("As you pray you feel a holy warmth envelop you");
                        }
                        else
                        {
                            Console.WriteLine("You pray at the altar, god knows what your prayers are about.");
                        }
                        break;
                    case "WAKE GUARD":
                        Console.WriteLine();
                        Console.WriteLine("The Guard thanks you for waking him but as time passes and the church breaks to remain calm and silent he falls asleep again, who could blame him the atmosphere is rather calming.");
                        break;
                    case "TAKE KEY":
                        Console.WriteLine();
                        for (int i = 0; i < Program.Inventory.ToArray().Length; i++)
                        {
                            if (Program.Inventory[i].MyName == "church key")
                            {
                                Console.WriteLine("You already have this");
                                break;
                            }
                            else if (i == Program.Inventory.ToArray().Length - 1)
                            {
                                if (random.Next(1, 11) != 1)
                                {
                                    Console.WriteLine("You snatch the key from the guards belt");
                                    Program.Inventory.Add(GameItem.GameItems[30]);
                                }
                                else
                                {
                                    Console.WriteLine("As you stealthfully grasp the guards key he wakes up and suckerpunches you into the ground, more guards come and pummel you, as you lay on the ground not knowing wether you are concious or not they tell you to leave your wicked ways.\n They tell you to pray at the altar for forgiveness");
                                    Program.Health--;
                                }
                                break;
                            }
                        }
                        if (Program.Inventory.ToArray().Length == 0)
                        {
                            if (random.Next(1, 11) != 1)
                            {
                                Console.WriteLine("You snatch the key from the guards belt");
                                Program.Inventory.Add(GameItem.GameItems[30]);
                            }
                            else
                            {
                                Console.WriteLine("As you stealthfully grasp the guards key he wakes up and suckerpunches you into the ground, more guards come and pummel you, as you lay on the ground not knowing wether you are concious or not they tell you to leave your wicked ways.\n They tell you to pray at the altar for forgiveness");
                                Program.Health--;
                            }
                        }
                        break;
                    case "TAKE LANTERN":
                        Console.WriteLine();
                        for (int i = 0; i < Program.Inventory.ToArray().Length; i++)
                        {
                            if (Program.Inventory[i].MyName == "church lantern")
                            {
                                Console.WriteLine("You already have this");
                                break;
                            }
                            else if (i == Program.Inventory.ToArray().Length - 1)
                            {
                                Console.WriteLine("You take the unlit lantern off the wall, lighting it is no problem there are small twigs meant for lighting candles left inside the lantern next to the candle and lit candles around the church.");
                                Program.Inventory.Add(GameItem.GameItems[31]);
                            }
                        }
                        if (Program.Inventory.ToArray().Length == 0)
                        {
                            Console.WriteLine("You take the unlit lantern off the wall, lighting it is no problem there are small twigs meant for lighting candles left inside the lantern next to the candle and lit candles around the church.");
                            Program.Inventory.Add(GameItem.GameItems[31]);
                        }
                        break;
                    case "OPEN DOOR":
                        Console.WriteLine();
                        for (int i = 0; i < Program.Inventory.ToArray().Length; i++)
                        {
                            if (Program.Inventory[i].MyName == "church key")
                            {
                                Console.WriteLine("You unlock the door and go down the dark staircase");
                                for (int j = 0; j < Program.Inventory.ToArray().Length; j++)
                                {
                                    if (Program.Inventory[j].MyName == "church lantern")
                                    {
                                        Console.WriteLine("You light the lantern on your way down and when you reach the bottom you can see a casket in a room ahead of you laying on a table as you inspect it you find out it is Sir Yellegor Yellowflags casket");
                                        Console.WriteLine("Do you 'Open the Casket' or 'Say Goodbye'");
                                        string TempAction = Input();
                                        if (TempAction.ToUpper() == "OPEN THE CASKET")
                                        {
                                            if (Program.CheckInventory("knights gear"))
                                            {
                                                Console.WriteLine("You open the casket to reveal his body, you say a prayer then leave");
                                                break;
                                            }
                                            Console.WriteLine("You open the casket to reveal his body he is clad in his armour his sword lay beside him and his shield lay on his chest");
                                            Console.WriteLine("Do you 'take his gear' or do you 'leave'");
                                            string TempAction2 = Input();
                                            if (TempAction2.ToUpper() == "TAKE HIS GEAR")
                                            {
                                                for (int g = 0; g < Program.Inventory.ToArray().Length; g++)
                                                {
                                                    if (Program.Inventory[g].MyName == "knights gear")
                                                    {
                                                        Console.WriteLine("You already have this");
                                                        break;
                                                    }
                                                    else if (g == Program.Inventory.ToArray().Length - 1)
                                                    {
                                                        Console.WriteLine("You take your masters gear and put it on, noone would even recognize a peasant like you in this shining armor. You leave the basement");
                                                        Program.Inventory.Add(GameItem.GameItems[32]);
                                                        break;
                                                    }
                                                }
                                                break;
                                            }
                                            else if (TempAction2.ToUpper() == "LEAVE")
                                            {
                                                Console.WriteLine("You close the casket and return to the church");
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Say what? Anyways you leave");
                                            }
                                        }
                                        else if (TempAction.ToUpper() == "SAY GOODBYE")
                                        {
                                            Console.WriteLine("After you say your last goodbyes and have a good cry... alone... in the dark undercroft of the church, like the absolute loser that you are, you pull yourself together and return to the first floor of the church");
                                        }
                                        else
                                        {
                                            Console.WriteLine("I have no idea what you just wrote but im sure it was gross, good for you. You return to the first floor of the church");
                                        }
                                    }
                                    else if (j == Program.Inventory.ToArray().Length - 1)
                                    {
                                        Console.WriteLine("On your way down into the dark you slip and fall, you are hurt but manage to climb up the stairs and shut the door before you realise that you hurt your head pretty bad down there.");
                                        Program.Health--;
                                    }
                                }
                                break;
                            }
                            else if (i == Program.Inventory.ToArray().Length - 1)
                            {
                                Console.WriteLine("The door is locked.");
                            }
                        }
                        if (Program.Inventory.ToArray().Length == 0)
                        {
                            Console.WriteLine("The door is locked.");
                        }
                        break;
                    case "LEAVE":
                        Console.WriteLine();
                        Console.WriteLine("You leave the church and enter the Marketplace again");
                        Program.Location = "Markedplace";
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
                        Console.WriteLine("Look Behind");
                        Console.WriteLine("Talk To Priest");
                        Console.WriteLine("Pray");
                        Console.WriteLine("Wake Guard");
                        Console.WriteLine("Take Key");
                        Console.WriteLine("Take Lantern");
                        Console.WriteLine("Open Door");
                        Console.WriteLine("Leave");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Sorry you cant do that right now, or possibly even ever!");
                Console.WriteLine("If you are stuck you can use the 'Help' Command to view all possible inputs at the current moment");
            }

            else if (Program.Location == "Tavern")
            {
                Console.WriteLine();
                switch (MyAction.ToUpper())
                {
                    case "LOOK FORWARD":
                        Console.WriteLine("In front of you theres the counter, behind the counter stands a tall handsome man wearing a nice but simple shirt with rolled up sleeves and dark pants, he has tattoos on his arms.\nThis would be the Barkeep.\nOn top of the counter there are all kinds of miscellaneous items such as glassware, spilt liquids, bugs both of the dead kind and the soon to be kind, the occational blunt dagger forcibly stuck into the counter top and one carving of a heart into the counter top with the text 'i love mom' inside");
                        break;
                    case "LOOK LEFT":
                        Console.WriteLine("To your left, you can see a staircase leading up to what is most likely bedrooms or private rooms the tavern holds off for richer regulars.\nThere is also a lot of tables many of the with 2 to 5 patrons drinking and talking and playing games of chance.\nNext to the staircase there are 2 barrels forming a narrow walkway that leads underneath the staircase where there is a small table and 3 kegs to sit on, the candle on the middle of the table is unused and rather dusty but there is recently used mugs on the table, the lighting in the tavern is considered dim lit but this corner is even darker than that.");
                        break;
                    case "LOOK RIGHT":
                        Console.WriteLine("To your right you can see a barmaid wandering through the thick smokelaiden room and patrons smoking and playing a game of cards, in the corner a bard sits on a high chair and plays his lute, the tune is not exactly upbeat.");
                        break;
                    case "LOOK BEHIND":
                        Console.WriteLine("Behind you, you can see private guards sitting around the exit, looking around for troublemakers, and a man sleeping at the table. His glass was half full until the barmaid came over and poured the remaining grog into a keg you are sure they also use when serving a fresh mug, some things can not be unseen.");
                        break;
                    case "TALK TO BARKEEP":
                        Console.WriteLine("What do you talk about?");
                        Console.WriteLine("Local News");
                        Console.WriteLine("Price for grog");
                        Console.WriteLine("Price for stew");
                        string LocalInput = Input();
                        Console.WriteLine();
                        if (LocalInput.ToUpper() == "LOCAL NEWS")
                        {
                            Console.WriteLine("Have you heard the farmers living along the edge of Brinewood demands that the lord raise a militia to deal with goblin raids on their farms, tshh they should see the rats in the slums here, theyre about the same size and about twice as ferocious as any goblin i ever served, erh i mean encountered. That reminds me, have you tried the stew? Its pretty descent.");
                        }
                        else if (LocalInput.ToUpper() == "PRICE FOR GROG")
                        {
                            Console.WriteLine("The grog costs 1 copper per mug, did i mention we also have stew?");
                        }
                        else if (LocalInput.ToUpper() == "PRICE FOR STEW")
                        {
                            Console.WriteLine("The stew costs 1 copper, eat your fill");
                        }
                        else
                        {
                            Console.WriteLine("The Barkeep has nothing to add on this subject");
                        }
                        break;
                    case "BUY GROG":
                        if (Program.Money > 1)
                        {
                            Console.WriteLine("You buy a mug of grog, you then take your time to drink it, for the price for a mug its not bad, but it is also very far from tasty");
                            Program.Money--;
                        }
                        else
                        {
                            Console.WriteLine("You cannot afford this right now");
                        }
                        break;
                    case "BUY STEW":
                        if (Program.Money > 0)
                        {
                            Console.WriteLine("You buy stew it smells weird and its content is not even visually identifiable certain chunks come with a texture of overboiled fabric, whatever food is food right yet your stomach has never complained this much in its entire life before");
                            Program.Money--;
                            if (Program.Money > 0)
                            {
                                Console.WriteLine("you buy a mug of grog to settle your stomach, it works ... kind of.");
                                Program.Money--;
                            }
                            else
                            {
                                Console.WriteLine("You may have eaten something you shouldnt");
                                Program.Health--;
                            }
                        }
                        else
                        {
                            Console.WriteLine("You cannot afford this right now");
                        }
                        break;
                    case "SIT UNDER STAIRS":
                        Console.WriteLine("You sit down under the staircase and a man... or what you think is a man, sits down with you shortly after. with a rough as gravel voice the creature utters 'do you want to by Fleggersh?'\nwhat do you say?");
                        string TempInput = Input();
                        if (TempInput.ToUpper() == "YES")
                        {
                            if (Program.Money >= 2)
                            {
                                Console.WriteLine("you recieve a weird mushroom rolled up in a leaf you dont recognize, you eat it. You go on wild adventures and lose track of time though you remain seated.");
                                Program.Health--;
                                Program.Money -= 2;
                            }
                        }
                        else if (TempInput.ToUpper() == "NO")
                        {
                            Console.WriteLine("The man gets up and leaves, for all you know he has blended in with the room or gone to wherever he came from for he is not to be seen anywhere once he leaves your sight");
                        }
                        else
                        {
                            Console.WriteLine("What? he gets up and leaves");
                        }
                        break;
                    case "PLAY CARDS":
                        Console.WriteLine("You sit down at the table with the other fellas playing and having a good time\nHow many coppers do you bet?");
                        int BetAmount;
                        Int32.TryParse(Input(), out BetAmount);
                        if (Program.Money < BetAmount)
                        {
                            Console.WriteLine("Sorry you dont have that much Program.Money, you are asked to leave the table");
                        }
                        else
                        {
                            if (random.Next(1, 7) == 6)
                            {
                                Console.WriteLine("You Win this hand");
                                Program.Money += (float)Math.Round(BetAmount * 1.5);
                            }
                            else
                            {
                                Console.WriteLine("You lose this hand");
                                Program.Money -= BetAmount;
                            }
                        }
                        break;
                    case "LEAVE":
                        Console.WriteLine("You leave the tavern and return to the Markedplace");
                        Program.Location = "Markedplace";
                        break;
                    case "HELP":
                        Console.WriteLine();
                        Console.WriteLine("The commands below might also include actions that you havent discovered in the story yet \n or choices your character havent discovered yet \n so use them with caution as using actions you havent discovered in the story might come at the expense of your experience.");
                        Console.WriteLine();
                        Console.WriteLine("Current Input Opportunities:");
                        Console.WriteLine();
                        Console.WriteLine("Look Forward");
                        Console.WriteLine("Look Left");
                        Console.WriteLine("Look Right");
                        Console.WriteLine("Look Behind");
                        Console.WriteLine("Talk to Barkeep");
                        Console.WriteLine("Buy Grog");
                        Console.WriteLine("Buy Stew");
                        Console.WriteLine("Sit Under Stairs");
                        Console.WriteLine("Play Cards");
                        Console.WriteLine("Leave");
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
