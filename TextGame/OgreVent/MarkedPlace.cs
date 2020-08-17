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
        public static void Actions(string Action)
        {
            Random random = new Random();
            MyAction = Action;
            if (Program.Location == "Markedplace")
            {
                switch (MyAction.ToUpper())
                {
                    case "LOOK LEFT":
                        Console.WriteLine();
                        Console.WriteLine("To your left you can see a thriving markedplace it is currently early in the morning and most of the merchants have set up their stand and started their day while some tardy merchants are still arriving or in the middle of setting up their stand, in the center of the markedplace there is a rather spacious well with a steady stream of locals regularly retrieving water from it. on the marketplace there is a merchant who sells fresh meat and vegetables from local hunters and farmers, another who sells jewelry and other trinkets, one who seems to sell metalworks mostly tools some weapons, mostly horseshoes and carpentry nails, and one merchant who you cant really say what he is selling, seems like a little bit of this a little bit of that probably just a load of junk, and a merchant who hasnt completely set up his stand just yet who sells armor and good shoes and backpacks fit for the most travel hungry adventurer.");
                        break;
                    case "LOOK RIGHT":
                        Console.WriteLine();
                        Console.WriteLine("To your right you can see the chapel where youre late master Yellegor Yellowflag was taken for burial preperations as he was a lesser nobleman, not just some mere peasant like yourself. Outside the chapel the flaggelant militia of the holy order of the Phoenix stands guard in rough tattered clothing seemingly non uniform with the exception of the holy symbol representing their god and their order hanging around their necks, the symbols are made of wood. they carry spears and several of them is munching on a loaf of bread in the current moment. the chapels reinforced front entrance is open and the puplic is seemingly free to enter and leave at their own behest.");
                        break;
                    case "LOOK FORWARD":
                        Console.WriteLine();
                        if (Program.Inventory.ToArray().Length > 0)
                        {
                            for (int i = 0; i < Program.Inventory.ToArray().Length; i++)
                            {
                                if (Program.Inventory[i] == GameItem.GameItems[28])
                                {
                                    Console.WriteLine("You are currently facing the Rusty Shovel, a local tavern renowned for their cheap grog");
                                }
                                else if (i == Program.Inventory.ToArray().Length - 1)
                                {
                                    Console.WriteLine("You are currently facing the wanted poster of the ogre, the poster is hanging on the wall to the left hand side of the entrance to the Rusty Shovel, a local tavern renowned for their cheap grog");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("You are currently facing the wanted poster of the ogre, the poster is hanging on the wall to the left hand side of the entrance to the Rusty Shovel, a local tavern renowned for their cheap grog");
                        }
                        break;
                    case "LOOK BEHIND":
                        Console.WriteLine();
                        Console.WriteLine("You see the main road in and out of this markedplace, it is rather spacious compared to the standards of the inner city you would think it is about 7 meters wide. Down the road you can see the silhouette of a guard tower basking in the morning sun.");
                        break;
                    case "JUMP DOWN THE WELL":
                        Console.WriteLine();
                        Console.WriteLine("You throw your body over the side of the well and you fall and bruise youself along the slippery sides until you hit the water with a splash your leg is caught in the bucket and your entire body is flipped upside down as your head hits the hard bottom of the well you gasp for air and take in water, after much struggling you manage to get out of the well with the help of the locals. Some people in the marketplace is giving you weird looks. Why you would ever do this is beyond you");
                        Program.Health--;
                        break;
                    case "TALK TO METALWORKS MERCHANT":
                        Console.WriteLine();
                        Console.WriteLine("what do you talk about?");
                        Console.WriteLine();
                        Console.WriteLine("Prices");
                        Console.WriteLine("Local Places");
                        string tempA = string.Empty;
                        tempA = Input().ToUpper();
                        if (tempA == "PRICES")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Horseshoes: 7 Silver");
                            Console.WriteLine("Nails: 3 Silver");
                            Console.WriteLine("Carpenter Tools: 1 Gold 5 Silver");
                            Console.WriteLine("Dagger: 3 Silver");
                            Console.WriteLine("Spear: 5 Silver");
                            Console.WriteLine("Shield: 1 Gold");
                            Console.WriteLine("Helmet: 2 Gold");
                        }
                        else if (tempA == "LOCAL PLACES")
                        {
                            Console.WriteLine();
                            Console.WriteLine("In the city there is The Town Hall, where the ruling class sits and discuss and decide various matters.\n And then there is The ChestLock Guild, which is originally a merchants guild but also own multiple Banks both here and elsewhere. They have a Guild Hall in town that doubles as a Bank.\n There is also a sort of indoor bazaar where you can find this citys most renowned \n alchemist shop,\n magic shop,\n tobacconist\n and\n imported spirits seller");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("The Merchant has nothing to add on this topic");
                        }
                        break;
                    case "TALK TO FOOD MERCHANT":
                        Console.WriteLine();
                        Console.WriteLine("what do you talk about?");
                        Console.WriteLine();
                        Console.WriteLine("Prices");
                        Console.WriteLine("Local Places");
                        string tempB = string.Empty;
                        tempB = Input().ToUpper();
                        if (tempB == "PRICES")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Ration: 3 coppers");
                            Console.WriteLine("Vegetables: 2 coppers");
                            Console.WriteLine("Fruit: 2 coppers");
                            Console.WriteLine("Meat: 5 coppers");
                            Console.WriteLine("Waterskin: 5 coppers");
                        }
                        else if (tempB == "LOCAL PLACES")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Well there is The Town Hall, where the council decides various matters.\n And then there is The ChestLock Guild, which is a great merchants guild. They have a Guild Hall in town.\n There is also a group of shops that share a pretty large building the \n alchemist shop,\n magic shop,\n tobacconist\n and\n imported spirits seller\n i believe it was, if you are into that sort of stuff.\n Last but not least there is the Hunters Lodge located in Brinewood forest its a 2 hour walk there");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("The Merchant has nothing to add on this topic");
                        }
                        break;
                    case "TALK TO JEWELRY MERCHANT":
                        Console.WriteLine();
                        Console.WriteLine("what do you talk about?");
                        Console.WriteLine();
                        Console.WriteLine("Prices");
                        Console.WriteLine("Local Places");
                        string tempC = string.Empty;
                        tempC = Input().ToUpper();
                        if (tempC == "PRICES")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Wooden Holy Symbol: 3 coppers");
                            Console.WriteLine("Silver Ring: 1 Gold");
                            Console.WriteLine("Gold Ring: 5 Gold");
                            Console.WriteLine("Silver Necklace: 2 Gold");
                            Console.WriteLine("Gold Necklace: 7 Gold");
                            Console.WriteLine("Signet Ring: 2 Gold");
                        }
                        else if (tempC == "LOCAL PLACES")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Well there is The Town Hall, where matters are decided.\n And then there is ChestLock Bank, a safe place for your valuables, guaranteed.\n There is also the Scholars Market they have pretty good tobacco, i will tell you where in town you can find them.");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("The Merchant has nothing to add on this topic");
                        }
                        break;
                    case "TALK TO JUNK MERCHANT":
                        Console.WriteLine();
                        Console.WriteLine("what do you talk about?");
                        Console.WriteLine();
                        Console.WriteLine("Prices");
                        Console.WriteLine("What do you sell?");
                        string tempD = string.Empty;
                        tempD = Input().ToUpper();
                        if (tempD == "PRICES")
                        {
                            Console.WriteLine("Bottle of Endless Water: 300 Gold");
                            Console.WriteLine("Ring of Mighty Strength: 300 Gold");
                            Console.WriteLine("Talking Chair: 300 Gold");
                            Console.WriteLine("Talking Donkey: 300 Gold");
                            Console.WriteLine("Bag of Holding: 300 Gold");
                            Console.WriteLine("Ring of Invisibility: 300 Gold");
                        }
                        else if (tempD == "WHAT DO YOU SELL?")
                        {
                            Console.WriteLine();
                            Console.WriteLine("I sell artifacts many of them ancient, they might look simple or mundane but they hold great and unique powers, but one can not make a living of just aquiring and studying them, so i sell them if you have the coin.");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("The Merchant has nothing to add on this topic");
                        }
                        break;
                    case "TALK TO ARMOR MERCHANT":
                        Console.WriteLine();
                        Console.WriteLine("what do you talk about?");
                        Console.WriteLine();
                        Console.WriteLine("Prices");
                        Console.WriteLine("Who Makes It?");
                        string tempE = string.Empty;
                        tempE = Input().ToUpper();
                        if (tempE == "PRICES")
                        {
                            Console.WriteLine("Chainmail: 5 Gold");
                            Console.WriteLine("Leather Armor: 2 Gold");
                            Console.WriteLine("Half Plate: 10 Gold");
                            Console.WriteLine("Full Plate: 25 Gold");
                            Console.WriteLine("Shield: 2 Gold");
                            Console.WriteLine("Backpack: 5 Silver");
                        }
                        else if (tempE == "WHO MAKES IT?")
                        {
                            Console.WriteLine();
                            Console.WriteLine("That good sir is a trade secret but my wares are of supreme craftmanship, that i can assure you");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("The Merchant has nothing to add on this topic");
                        }
                        break;
                    case "STEAL":
                        Console.WriteLine();
                        Console.WriteLine("what do you attempt to steal?");
                        Console.WriteLine();
                        string stealA = string.Empty;
                        stealA = Input().ToUpper();
                        foreach (Item Item in GameItem.GameItems)
                        {
                            if (Item.MyName.ToUpper() == stealA)
                            {
                                if (random.Next(1, 3) == 2 || Program.CheckInventory("ring of invisibility"))
                                {
                                    Console.WriteLine();
                                    if (!Program.CheckCarryCapacity(Item.MyWeight, Item.MySpace))
                                    {
                                        break;
                                    }
                                    Program.Inventory.Add(Item);
                                    Console.WriteLine($"You have successfully stolen {stealA}");
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("You have been caught stealing and is beaten by the merchants and a kid");
                                    Program.Health--;
                                }
                            }
                        }
                        break;
                    case "BUY":
                        Console.WriteLine();
                        Console.WriteLine("What do you Purchase?");
                        Console.WriteLine();
                        string purchitem = string.Empty;
                        purchitem = Input();
                        foreach (Item Item in GameItem.GameItems)
                        {
                            if (purchitem.ToUpper() == Item.MyName.ToUpper() && Program.Money >= Item.MyValue)
                            {
                                if (Program.CheckCarryCapacity(Item.MyWeight, Item.MySpace))
                                {
                                    Program.Money -= Item.MyValue;
                                    Program.Inventory.Add(Item);
                                    Console.WriteLine();
                                    Console.WriteLine($"You Purchased {Item.MyName}");
                                }
                                break;
                            }
                            else if (Item == GameItem.GameItems[GameItem.GameItems.Length - 1])
                            {
                                Console.WriteLine();
                                Console.WriteLine("This item can not be purchased or you can not afford it, either way you walk away emptyhanded");
                            }
                        }
                        break;
                    case "SELL":
                        Console.WriteLine();
                        Console.WriteLine("What do you sell?");
                        Console.WriteLine();
                        string sellitem = string.Empty;
                        sellitem = Input();
                        foreach (Item Item in GameItem.GameItems)
                        {
                            if (sellitem.ToUpper() == Item.MyName.ToUpper())
                            {
                                Program.Money += (float)Math.Round(Item.MyValue / 2f);
                                Program.Inventory.Remove(Item);
                                Console.WriteLine();
                                Console.WriteLine($"You Sold {Item.MyName} for {Program.PrintValue((int)Math.Round(Item.MyValue / 2f))}");
                                break;
                            }
                            else if (Item == GameItem.GameItems[GameItem.GameItems.Length - 1])
                            {
                                Console.WriteLine();
                                Console.WriteLine("This item can not be sold or you do not have it, either way you walk away no richer than before");
                            }
                        }
                        break;
                    case "TAKE WANTED POSTER":
                        if (Program.Inventory.ToArray().Length > 0)
                        {
                            for (int i = 0; i < Program.Inventory.ToArray().Length; i++)
                            {
                                if (Program.Inventory[i] == GameItem.GameItems[28])
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("You already have it");
                                }
                                else if (i == Program.Inventory.ToArray().Length - 1)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("You rip the poster off the wall and stuff it into your filthy peasant pockets");
                                    Program.Inventory.Add(GameItem.GameItems[28]);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("You rip the poster off the wall and stuff it into your filthy peasant pockets");
                            Program.Inventory.Add(GameItem.GameItems[28]);
                        }
                        break;
                    case "GO INTO CHURCH":
                        Console.WriteLine();
                        Console.WriteLine("You walk past the church militia and enter the armory, you are now inside the church");
                        Program.Location = "Church";
                        break;
                    case "ENTER TAVERN":
                        Console.WriteLine();
                        Console.WriteLine("You open the door and the scent of tobacco hits your face as you enter the dimlit establishment and walk up to the counter");
                        Program.Location = "Tavern";
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
                        Console.WriteLine("Look Behind");
                        Console.WriteLine("Jump Down The Well");
                        Console.WriteLine("Talk to Metalworks Merchant");
                        Console.WriteLine("Talk to Food Merchant");
                        Console.WriteLine("Talk to Jewelry merchant");
                        Console.WriteLine("Talk to Junk Merchant");
                        Console.WriteLine("Talk to Armor Merchant");
                        Console.WriteLine("Steal");
                        Console.WriteLine("Buy");
                        Console.WriteLine("Go Into Church");
                        Console.WriteLine("Take Wanted Poster");
                        Console.WriteLine("Sell");
                        Console.WriteLine("Enter Tavern");
                        Console.WriteLine("Go To Town Hall");
                        Console.WriteLine("Go To Chestlock Guild Hall");
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
