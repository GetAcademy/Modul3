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
                        Poster.Post("In front of you there are the doors that lead into the Nave you can see all the way up to the Ambulatory.\n You see a priest by the crossing lighting candles.");
                        break;
                    case "LOOK LEFT":
                        Poster.Post("To your left there is a sleeping guard sitting in a chair, next to the guards chair there is a bill hook and on his belt there is a key");
                        break;
                    case "LOOK RIGHT":
                        Poster.Post("To your right there is a closed door, a lantern hangs on a hook next to the door.");
                        break;
                    case "LOOK BEHIND":
                        Poster.Post("Behind you there is the way back out");
                        break;
                    case "TALK TO PRIEST":
                        Poster.Post("what do you talk to him about?", 1);
                        Poster.Post();
                        Poster.Post("Ask about funeral");
                        Poster.Post("Ask about Yellegors Belongings");
                        Poster.Post("Ask to see Yellegors body");
                        string LocalInput = Input();
                        Poster.Post();
                        if (LocalInput.ToUpper() == "ASK ABOUT FUNERAL")
                        {
                            Poster.Post("The priest says that Sir Yellowflags funeral will be held tomorrow on the evening, he says it is such a tragedy what happened to sir Yellowflag");
                        }
                        else if (LocalInput.ToUpper() == "ASK ABOUT YELLEGORS BELONGINGS")
                        {
                            Poster.Post("The priest says that most of Yellegors belongings will be passed onto his wife, but his armor, shield and sword will be buried with the knight.");
                        }
                        else if (LocalInput.ToUpper() == "ASK TO SEE YELLEGORS BODY")
                        {
                            Poster.Post("The priest says that it is uncommon to allow other people than family members to see the body, so im going to have to ask you to say your farewells during the funeral.");
                        }
                        else
                        {
                            Poster.Post("The priest knows nothing of this topic or has nothing to add to this topic, either way the conversation grinds to a halt.");
                        }
                        break;
                    case "PRAY":
                        if (random.Next(1, 5) == 4)
                        {
                            Poster.Post("As you pray you feel a holy warmth envelop you");
                        }
                        else
                        {
                            Poster.Post("You pray at the altar, god knows what your prayers are about.");
                        }
                        break;
                    case "WAKE GUARD":
                        Poster.Post("The Guard thanks you for waking him but as time passes and the church breaks to remain calm and silent he falls asleep again, who could blame him the atmosphere is rather calming.", 1);
                        break;
                    case "TAKE KEY":
                        if(Program.CheckInventory("church key"))
                        {
                            Poster.Post("You already have this");
                        }
                        else if (GlobalBools.TookChurchKey)
                        {
                            Poster.Post("At some point you took this key and then you got rid of it, the guard has not aquired another key, in fact it seems he has been busy sleeping");
                        }
                        else
                        {
                            if (Program.CheckInventory("ring of invisibility"))
                            {
                                Poster.Post("You put on the ring of invisibility, rendering you unseen to the naked eye.");
                                Poster.Post("You then snatch the key from the guards belt.");
                                if (random.Next(1, 11) == 1)
                                {
                                    Poster.Post("The guard wakes, but does not notice you or that his keys are missing");
                                    Poster.Post("he goes back to sleep soon after and you take the ring off again");
                                }
                                else
                                {
                                    Poster.Post("The guard does not wake up.");
                                }
                                if(GameItem.AddItemToInventory("church key"))
                                {
                                    Poster.Post("You put the key away in your pocket");
                                    GlobalBools.TookChurchKey = true;
                                }
                                else
                                {
                                    Poster.Post("However you seem to be unable to find a place to put it, all your pockets are filled to the brim!, you decide to gently put the key back where you found it");
                                }
                            }
                            else if (random.Next(1, 11) != 1)
                            {
                                Poster.Post("You snatch the key from the guards belt");
                                if (GameItem.AddItemToInventory("church key"))
                                {
                                    Poster.Post("You put the key away in your pocket");
                                    GlobalBools.TookChurchKey = true;
                                }
                                else
                                {
                                    Poster.Post("However you seem to be unable to find a place to put it, all your pockets are filled to the brim!, you decide to gently put the key back where you found it");
                                }
                            }
                            else
                            {
                                Poster.Post("As you stealthfully grasp the guards key he wakes up and suckerpunches you into the ground, more guards come and pummel you, as you lay on the ground not knowing wether you are concious or not they tell you to leave your wicked ways.\n They tell you to pray at the altar for forgiveness");
                                Program.Health--;
                            }
                        }
                        break;
                    case "TAKE LANTERN":
                        if(Program.CheckInventory("church lantern"))
                        {
                            Poster.Post("You already have this");
                        }
                        else if (GlobalBools.TookChurchLantern)
                        {
                            Poster.Post("You already took this at some point, and then you got rid of it remember? maybe you should have held onto it when you had it?");
                        }
                        else
                        {
                            if (GameItem.AddItemToInventory("church lantern")) Poster.Post("You take the unlit lantern off the wall, lighting it is no problem there are small twigs meant for lighting candles left inside the lantern next to the candle and lit candles around the church.");
                            else Poster.Post("You would take the lantern if you only had somewhere to put the damn thing");
                        }
                        break;
                    case "OPEN DOOR":
                        if(Program.CheckInventory("church key"))
                        {
                            Poster.Post("You unlock the door and go down the dark staircase");
                            if(Program.CheckInventory("church lantern"))
                            {
                                Poster.Post("You light the lantern on your way down and when you reach the bottom you can see a casket in a room ahead of you laying on a table as you inspect it you find out it is Sir Yellegor Yellowflags casket");
                                Poster.Post("Do you 'Open the Casket' or 'Say Goodbye'");
                                string TempAction = Input();
                                if (TempAction.ToUpper() == "OPEN THE CASKET")
                                {
                                    if (Program.CheckInventory("knights gear"))
                                    {
                                        Poster.Post("You open the casket to reveal his body, you say a prayer then leave");
                                        break;
                                    }
                                    else if (GlobalBools.TookKnightsGear)
                                    {
                                        Poster.Post("You open the casket to reveal his body, you say a prayer then leave");
                                        break;
                                    }
                                    Poster.Post("You open the casket to reveal his body he is clad in his armour his sword lay beside him and his shield lay on his chest");
                                    Poster.Post("Do you 'take his gear' or do you 'leave'");
                                    string TempAction2 = Input();
                                    if (TempAction2.ToUpper() == "TAKE HIS GEAR")
                                    {
                                        if(Program.CheckInventory("knights gear"))
                                        {
                                            Poster.Post("You already have this");
                                        }
                                        else
                                        {
                                            if (GameItem.AddItemToInventory("knights gear"))
                                            {
                                                Poster.Post("You take your masters gear and put it on, noone would even recognize a peasant like you in this shining armor. You leave the basement");
                                                GlobalBools.TookKnightsGear = true;
                                            }
                                            else
                                            {
                                                Poster.Post("If you could carry your masters gear you would, but it is heavy and large, and you have clearly prioritized carrying other things");
                                            }
                                        }
                                        break;
                                    }
                                    else if (TempAction2.ToUpper() == "LEAVE")
                                    {
                                        Poster.Post("You close the casket and return to the church");
                                        break;
                                    }
                                    else
                                    {
                                        Poster.Post("Say what? Anyways you leave");
                                    }
                                }
                                else if (TempAction.ToUpper() == "SAY GOODBYE")
                                {
                                    Poster.Post("After you say your last goodbyes and have a good cry... alone... in the dark undercroft of the church, like the absolute loser that you are, you pull yourself together and return to the first floor of the church");
                                }
                                else
                                {
                                    Poster.Post("I have no idea what you just wrote but im sure it was gross, good for you. You return to the first floor of the church");
                                }
                            }
                            else
                            {
                                Poster.Post("On your way down into the dark you slip and fall, you are hurt but manage to climb up the stairs and shut the door before you realise that you hurt your head pretty bad down there.");
                                Program.Health--;
                            }
                        }
                        else
                        {
                            Poster.Post("The door is locked.");
                        }
                        break;
                    case "LEAVE":
                        Poster.Post("You leave the church and enter the Marketplace again");
                        Program.Location = "Markedplace";
                        break;
                    case "HELP":
                        Poster.Post("The commands below might also include actions that you havent discovered in the story yet \n or choices your character havent discovered yet \n so use them with caution as using actions you havent discovered in the story might come at the expense of your experience.");
                        Poster.Post("Current Input Opportunities:");
                        Poster.Post("Look Left");
                        Poster.Post("Look Right", 0, false);
                        Poster.Post("Look Forward", 0, false);
                        Poster.Post("Look Behind", 0, false);
                        Poster.Post("Talk To Priest", 0, false);
                        Poster.Post("Pray", 0, false);
                        Poster.Post("Wake Guard", 0, false);
                        Poster.Post("Take Key", 0, false);
                        Poster.Post("Take Lantern", 0, false);
                        Poster.Post("Open Door", 0, false);
                        Poster.Post("Leave", 0, false);
                        break;
                    default:
                        Poster.Post("Sorry you cant do that right now, or possibly even ever!");
                        Poster.Post("If you are stuck you can use the 'Help' Command to view all possible inputs at the current moment", 0, false);
                        break;
                }
            }


        }
    }
}
