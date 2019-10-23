using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OgreVent
{
    class Program
    {
        public static Item[] GameItems = new Item[]
            {
                new Item("horseshoes",70,2,1),
                new Item("nails",30,1,1),
                new Item("carpenter tools",150,10,5),
                new Item("dagger",30,2,2,0,2),
                new Item("spear",50,4,0,0,5),
                new Item("shield",100,6),
                new Item("helmet",200,5),
                new Item("ration",3,1,1),
                new Item("vegetables",2,1,1),
                new Item("fruit",2,1,1),
                new Item("meat",5,1,1),
                new Item("waterskin",5,2,2),
                new Item("wooden holy symbol",3,2,2),
                new Item("silver ring",100,2,1),
                new Item("gold ring",500,3,1),
                new Item("silver necklace",200,2,1),
                new Item("gold necklace",700,3,1),
                new Item("signet ring",200,2,1),
                new Item("bottle of endless water",30000,2,2),
                new Item("ring of mighty strength",30000,2,1),
                new Item("talking chair",30000,4,6),
                new Item("talking donkey",30000,0),
                new Item("bag of holding",30000,5,2),
                new Item("ring of invisibility",30000,2,1),
                new Item("chainmail",500,7,0,10),
                new Item("leather armor",200,5,0,5),
                new Item("half plate",1000,17,0,15),
                new Item("full plate",2500,25,0,20),
                new Item("heavy shield",200,10),
                new Item("wanted poster",0,0,1),
                new Item("church key",0,1,1),
                new Item("church lantern",0,2,3),
                new Item("knights gear",0,20,0,15,7),
                new Item("backpack",50,2,1),
            };
        public static string Location = "Markedplace";
        public static List<Item> Inventory = new List<Item>();
        public static int Health = 3;
        public static int CurrentWeight = 0;
        public static int CurrentSpace = 0;
        public static float Money = 0;
        public static int time = 20;

        public static int Time(int TimePassed = 0)
        {
            time -= TimePassed;
            if (time < 1 && EatAndDrink())
            {
                time = 20;
            }
            else
            {
                time = 5;
            }
            return time;
        }

        public static bool EatAndDrink()
        {
            foreach (Item item in Inventory)
            {
                if (item.MyName == "ration" || item.MyName == "vegetables" || item.MyName == "fruit" || item.MyName == "meat" || item.MyName == "waterskin")
                {
                    Console.WriteLine();
                    Console.WriteLine($"You are hungry or thirsty, maybe even both. You stop and take a break and you enjoy your {item.MyName} before you continue your adventure.");
                    Inventory.Remove(item);
                    return true;
                }
                else if(item.MyName == "bottle of endless water")
                {
                    Console.WriteLine();
                    Console.WriteLine($"You are thirsty, you drink your fill from your {item.MyName} before you tuck it away. You are unsure wether you drank from the bottle or the bottle drank from you, it is the strangest most indescribable drinking experience you have had");
                    return true;
                }
                else if(Inventory.Last() == item)
                {
                    Health--;
                    return false;
                }
            }
            return false;
        }

        public static string Input()
        {
            Console.WriteLine();
            Console.Write("Action: ");
            return Console.ReadLine();
        }
        static void Main()
        {
            Console.WriteLine("###################################################################################################################");
            Console.WriteLine("###################################################################################################################");
            Console.WriteLine("###################################################################################################################");
            Console.WriteLine("###################################################################################################################");
            Console.WriteLine("###################################################################################################################");
            Console.WriteLine("#####     ■■■■■■     ■■■■■■■■     ■■■■       ■■■■■■     ■■          ■■     ■■■■■■     ■■■■■■■■    ■■■■■■■■     ####");
            Console.WriteLine("#####     ■■■■■■     ■■■■■■■■     ■■■■       ■■          ■■        ■■      ■■         ■■■■■■■■    ■■■■■■■■     ####");
            Console.WriteLine("#####     ■■  ■■     ■■           ■  ■       ■■           ■■      ■■       ■■         ■■    ■■       ■■        ####");
            Console.WriteLine("#####     ■■  ■■     ■■  ■■■■     ■  ■       ■■■■■■        ■■    ■■        ■■■■■■     ■■    ■■       ■■        ####");
            Console.WriteLine("#####     ■■  ■■     ■■    ■■     ■■■■       ■■             ■■  ■■         ■■         ■■    ■■       ■■        ####");
            Console.WriteLine("#####     ■■■■■■     ■■■■■■■■     ■  ■■      ■■              ■■■■          ■■         ■■    ■■       ■■        ####");
            Console.WriteLine("#####     ■■■■■■     ■■■■■■■■     ■   ■■     ■■■■■■           ■■           ■■■■■■     ■■    ■■       ■■        ####");
            Console.WriteLine("###################################################################################################################");
            Console.WriteLine("###################################################################################################################");
            Console.WriteLine("###################################################################################################################");
            Console.WriteLine("###################################################################################################################");
            Console.WriteLine("###################################################################################################################");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You were the squire of the late sir Yellegor Yellowflag, a monster slayer of great renown!");
            Console.WriteLine("Last night your master was killed in combat against a fierce ogre and you find yourself at the marketplace spending your last coppers on half a bread and some apples.");
            Console.WriteLine("With your tummy temporarily satisfied with nourishment and with no money or valuables to your name, and far from your home, you catch a glimpse of a poster in the corner of your eye");
            Console.WriteLine("You focus your attention on the poster, it is a wanted poster for the great ogre that killed your master, the bounty for the beast has tripled and now offers a gold price from the lord of 300 Gold Pieces");
            Console.WriteLine("And so your Quest to Slay The Ogre Begins!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("To check your inventory use 'inventory' to check how much money you have use 'money' to drop an item use 'drop item' otherwise actions are simple they\ncome in the form of 2 to 3 phrase long commands for example 'look left', have fun");
            Random random = new Random();
            

            string PrintValue(int Value)
            {
                string Bucks = Value.ToString();
                if (Bucks.Length == 1)
                {
                    return $"{Value} Copper";
                }
                if (Bucks.Length == 2)
                {
                    return $"{Bucks[0]} Silver\n{Bucks[1]} Copper";
                }
                if (Bucks.Length == 3)
                {
                    return $"{Bucks[0]} Gold\n{Bucks[1]} Silver\n{Bucks[2]} Copper";
                }
                if (Bucks.Length == 4)
                {
                    return $"{Bucks[0]}{Bucks[1]} Gold\n{Bucks[2]} Silver\n{Bucks[3]} Copper";
                }
                if (Bucks.Length == 5)
                {
                    return $"{Bucks[0]}{Bucks[1]}{Bucks[2]} Gold\n{Bucks[3]} Silver\n{Bucks[4]} Copper";
                }
                if (Bucks.Length == 6)
                {
                    return $"{Bucks[0]}{Bucks[1]}{Bucks[2]}{Bucks[3]} Gold\n{Bucks[4]} Silver\n{Bucks[5]} Copper";
                }
                return string.Empty;
            }

            bool CheckInventory(string ItemName)
            {
                for (int i = 0; i < Inventory.ToArray().Length; i++)
                {
                    if (Inventory[i].MyName == ItemName)
                    {
                        return true;
                    }
                    else if (Inventory.ToArray().Length == 0)
                    {
                        return false;
                    }
                    else if (i == Inventory.ToArray().Length - 1)
                    {
                        return false;
                    }
                }
                return false;
            }

            bool CheckCarryCapacity(int ItemWeight, int ItemSpace)
            {
                int CarryingCapacity = 30;
                int CarrySpace = 10;
                foreach (Item item in Inventory)
                {
                    if (item.MyName == "backpack")
                    {
                        CarryingCapacity += 15;
                        CarrySpace += 20;
                        break;
                    }
                }
                foreach (Item item in Inventory)
                {
                    if (item.MyName == "ring of mighty strength")
                    {
                        CarryingCapacity += 20;
                        break;
                    }
                }
                if (CurrentWeight + ItemWeight <= CarryingCapacity)
                {
                    if (CurrentSpace + ItemSpace <= CarrySpace)
                    {
                        CurrentWeight += ItemWeight;
                        CurrentSpace += ItemSpace;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("you do not have the space for this, did you think you were gonna keister it?");
                        return false;
                    }

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Your feeble peasant body cannot handle the encumbering weight of this item and the weight of your inventory combined");
                    return false;
                }
            }
            bool IsAlive = true;
            string MyAction;
            while (IsAlive)
            {
                if (Health <= 0)
                {
                    IsAlive = false;
                    break;
                }


                MyAction = Input();

                if (MyAction.ToUpper() == "INVENTORY")
                {
                    Console.WriteLine();
                    Console.WriteLine("Inventory:");
                    foreach (Item Item in Inventory.ToArray())
                    {
                        Console.WriteLine(Item.MyName);
                    }
                    Console.WriteLine();
                    Console.WriteLine($"you are currently carrying {CurrentWeight} Kg, and it takes up {CurrentSpace} amount of space in your inventory out of 10 if you dont have a backpack, out of 30 if you do have a backpack.");
                    continue;
                }

                if (MyAction.ToUpper() == "DROP ITEM")
                {
                    Console.WriteLine("what item would you like to drop?");
                    Console.Write("Item: ");
                    string DropItem = Console.ReadLine();
                    for (int i = 0; i < Inventory.ToArray().Length; i++)
                    {
                        if (Inventory[i].MyName == DropItem.ToLower())
                        {
                            Console.WriteLine();
                            Console.WriteLine($"you dropped {Inventory[i].MyName}");
                            CurrentWeight -= Inventory[i].MyWeight;
                            CurrentSpace -= Inventory[i].MySpace;
                            Inventory.Remove(Inventory[i]);
                            break;
                        }
                        if (i == Inventory.ToArray().Length - 1 && Inventory[i].MyName != DropItem)
                        {
                            Console.WriteLine();
                            Console.WriteLine("sorry no item by that name");
                            break;
                        }
                    }
                    continue;
                }

                if (MyAction.ToUpper() == "MONEY")
                {
                    string Bucks = Money.ToString();
                    Console.WriteLine();
                    Console.WriteLine("Belt Pouch:");
                    if (Bucks.Length == 1)
                    {
                        Console.WriteLine($"{Money} Copper");
                    }
                    if (Bucks.Length == 2)
                    {
                        Console.WriteLine($"{Bucks[0]} Silver");
                        Console.WriteLine($"{Bucks[1]} Copper");
                    }
                    if (Bucks.Length == 3)
                    {
                        Console.WriteLine($"{Bucks[0]} Gold");
                        Console.WriteLine($"{Bucks[1]} Silver");
                        Console.WriteLine($"{Bucks[2]} Copper");
                    }
                    if (Bucks.Length == 4)
                    {
                        Console.WriteLine($"{Bucks[0]}{Bucks[1]} Gold");
                        Console.WriteLine($"{Bucks[2]} Silver");
                        Console.WriteLine($"{Bucks[3]} Copper");
                    }
                    if (Bucks.Length == 5)
                    {
                        Console.WriteLine($"{Bucks[0]}{Bucks[1]}{Bucks[2]} Gold");
                        Console.WriteLine($"{Bucks[3]} Silver");
                        Console.WriteLine($"{Bucks[4]} Copper");
                    }
                    if (Bucks.Length == 6)
                    {
                        Console.WriteLine($"{Bucks[0]}{Bucks[1]}{Bucks[2]}{Bucks[3]} Gold");
                        Console.WriteLine($"{Bucks[4]} Silver");
                        Console.WriteLine($"{Bucks[5]} Copper");
                    }
                    continue;
                }

                if (MyAction.ToUpper() == "ADD MONEY")
                {
                    Money += 1000;
                    Console.WriteLine();
                    Console.WriteLine("Added 10 Gold");
                    continue;
                }

                if (Location == "Markedplace")
                {
                    switch (MyAction.ToUpper())
                    {
                        case "LOOK LEFT":
                            Console.WriteLine();
                            Console.WriteLine("To your left you can see a thriving markedplace it is currently early in the morning and most of the merchants have set up their stand and started their day while some tardy merchants are still arriving or in the middle of setting up their stand, in the center of the markedplace there is a rather spacious well with a steady stream of locals regularly retrieving water from it. on the marketplace there is a merchant who sells fresh meat and vegetables from local hunters and farmers, another who sells jewelry and other trinkets, one who seems to sell metalworks mostly tools some weapons, mostly horseshoes and carpentry nails, and one merchant who you cant really say what he is selling, seems like a little bit of this a little bit of that probably just a load of junk, and a merchant who hasnt completely set up his stand just yet who sells armor and good shoes and backpacks fit for the most travel hungry adventurer.");
                            continue;
                        case "LOOK RIGHT":
                            Console.WriteLine();
                            Console.WriteLine("To your right you can see the chapel where youre late master Yellegor Yellowflag was taken for burial preperations as he was a lesser nobleman, not just some mere peasant like yourself. Outside the chapel the flaggelant militia of the holy order of the Phoenix stands guard in rough tattered clothing seemingly non uniform with the exception of the holy symbol representing their god and their order hanging around their necks, the symbols are made of wood. they carry spears and several of them is munching on a loaf of bread in the current moment. the chapels reinforced front entrance is open and the puplic is seemingly free to enter and leave at their own behest.");
                            continue;
                        case "LOOK FORWARD":
                            Console.WriteLine();
                            if (Inventory.ToArray().Length > 0)
                            {
                                for (int i = 0; i < Inventory.ToArray().Length; i++)
                                {
                                    if (Inventory[i] == GameItems[28])
                                    {
                                        Console.WriteLine("You are currently facing the Rusty Shovel, a local tavern renowned for their cheap grog");
                                    }
                                    else if (i == Inventory.ToArray().Length - 1)
                                    {
                                        Console.WriteLine("You are currently facing the wanted poster of the ogre, the poster is hanging on the wall to the left hand side of the entrance to the Rusty Shovel, a local tavern renowned for their cheap grog");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("You are currently facing the wanted poster of the ogre, the poster is hanging on the wall to the left hand side of the entrance to the Rusty Shovel, a local tavern renowned for their cheap grog");
                            }
                            continue;
                        case "LOOK BEHIND":
                            Console.WriteLine();
                            Console.WriteLine("You see the main road in and out of this markedplace, it is rather spacious compared to the standards of the inner city you would think it is about 7 meters wide. Down the road you can see the silhouette of a guard tower basking in the morning sun.");
                            continue;
                        case "JUMP DOWN THE WELL":
                            Console.WriteLine();
                            Console.WriteLine("You throw your body over the side of the well and you fall and bruise youself along the slippery sides until you hit the water with a splash your leg is caught in the bucket and your entire body is flipped upside down as your head hits the hard bottom of the well you gasp for air and take in water, after much struggling you manage to get out of the well with the help of the locals. Some people in the marketplace is giving you weird looks. Why you would ever do this is beyond you");
                            Health--;
                            continue;
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
                            continue;
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
                            continue;
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
                            continue;
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
                            continue;
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
                            continue;
                        case "STEAL":
                            Console.WriteLine();
                            Console.WriteLine("what do you attempt to steal?");
                            Console.WriteLine();
                            string stealA = string.Empty;
                            stealA = Input().ToUpper();
                            foreach (Item Item in GameItems)
                            {
                                if (Item.MyName.ToUpper() == stealA)
                                {
                                    if (random.Next(1, 3) == 2 || CheckInventory("ring of invisibility"))
                                    {
                                        Console.WriteLine();
                                        if (!CheckCarryCapacity(Item.MyWeight, Item.MySpace))
                                        {
                                            break;
                                        }
                                        Inventory.Add(Item);
                                        Console.WriteLine($"You have successfully stolen {stealA}");
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("You have been caught stealing and is beaten by the merchants and a kid");
                                        Health--;
                                    }
                                }
                            }
                            continue;
                        case "BUY":
                            Console.WriteLine();
                            Console.WriteLine("What do you Purchase?");
                            Console.WriteLine();
                            string purchitem = string.Empty;
                            purchitem = Input();
                            foreach (Item Item in GameItems)
                            {
                                if (purchitem.ToUpper() == Item.MyName.ToUpper() && Money >= Item.MyValue)
                                {
                                    if (CheckCarryCapacity(Item.MyWeight, Item.MySpace))
                                    {
                                        Money -= Item.MyValue;
                                        Inventory.Add(Item);
                                        Console.WriteLine();
                                        Console.WriteLine($"You Purchased {Item.MyName}");
                                    }
                                    break;
                                }
                                else if (Item == GameItems[GameItems.Length - 1])
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("This item can not be purchased or you can not afford it, either way you walk away emptyhanded");
                                }
                            }
                            continue;
                        case "SELL":
                            Console.WriteLine();
                            Console.WriteLine("What do you sell?");
                            Console.WriteLine();
                            string sellitem = string.Empty;
                            sellitem = Input();
                            foreach (Item Item in GameItems)
                            {
                                if (sellitem.ToUpper() == Item.MyName.ToUpper())
                                {
                                    Money += (float)Math.Round(Item.MyValue / 2f);
                                    Inventory.Remove(Item);
                                    Console.WriteLine();
                                    Console.WriteLine($"You Sold {Item.MyName} for {PrintValue((int)Math.Round(Item.MyValue / 2f))}");
                                    break;
                                }
                                else if (Item == GameItems[GameItems.Length - 1])
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("This item can not be sold or you do not have it, either way you walk away no richer than before");
                                }
                            }
                            continue;
                        case "TAKE WANTED POSTER":
                            if (Inventory.ToArray().Length > 0)
                            {
                                for (int i = 0; i < Inventory.ToArray().Length; i++)
                                {
                                    if (Inventory[i] == GameItems[28])
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("You already have it");
                                    }
                                    else if (i == Inventory.ToArray().Length - 1)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("You rip the poster off the wall and stuff it into your filthy peasant pockets");
                                        Inventory.Add(GameItems[28]);
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("You rip the poster off the wall and stuff it into your filthy peasant pockets");
                                Inventory.Add(GameItems[28]);
                            }
                            continue;
                        case "GO INTO CHURCH":
                            Console.WriteLine();
                            Console.WriteLine("You walk past the church militia and enter the armory, you are now inside the church");
                            Location = "Church";
                            continue;
                        case "ENTER TAVERN":
                            Console.WriteLine();
                            Console.WriteLine("You open the door and the scent of tobacco hits your face as you enter the dimlit establishment and walk up to the counter");
                            Location = "Tavern";
                            continue;
                        case "GO TO TOWN HALL":
                            Console.WriteLine();
                            Console.WriteLine("You walk to the Town Hall located in the northern part of town,\n as you stand outside the Town Hall you notice that there are more guards here, the people look, walk and talk in a way that would suggest they come from wealth.\n The Town Hall itself has a bell tower with a spire. The Hall is made out of stone for the most part but the stone is painted white, however the spire is made out of wood and is seemingly the only major part of the Hall that is made of wood.");
                            Location = "Town Hall";
                            continue;
                        case "GO TO CHESTLOCK GUILD HALL":
                            Console.WriteLine();
                            Console.WriteLine("You walk to the Chestlock Guild Hall, as you arrive you find that the Guild Hall is actually a Fort with crenellations and everything with a Guild Hall instead of barracks and storage houses instead of stables and other normal structures to be found in a more tradiotional fort.\n And all this inside the city, there is a steady flow of people entering and leaving the Forts gate, and the guards standing by the gate and above on the wall seem ever so vigilant.");
                            Location = "Chestlock Guild Hall";
                            continue;
                        case "GO TO HUNTERS LODGE":
                            Console.WriteLine();
                            Console.WriteLine("You walk to the Hunters Lodge, there you find a man chopping firewood.\n The Lodge itself takes form in a large cabin it looks rather cozy and homely.");
                            Location = "Hunters Lodge";
                            continue;
                        case "GO TO BRINEWOOD FOREST":
                            Console.WriteLine();
                            Console.WriteLine("You walk to Brinewood Forest, you now stand in the forest there are sounds of birds in the trees, there are moss covered rocks and everything seems calm.");
                            Location = "Brinewood Forest";
                            continue;
                        case "GO TO SCHOLARS MARKET":
                            Console.WriteLine();
                            Console.WriteLine("You walk to the Scholars Market, the outside area would make you think of this as a street of townhouses but you notice a sign hanging above one of the doors saying 'The Scholars Market'\n. As you enter you understand that this might have at some point been a street of townhouses but has been later turned into a set of shops located on the same floor under one roof, and not just this street the houses that would have been on the next street aswell making this a rather sizable place.\n The smells in the air are varied and exotic");
                            Location = "Scholars Market";
                            continue;
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
                            continue;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Sorry you cant do that right now, or possibly even ever!");
                    Console.WriteLine("If you are stuck you can use the 'Help' Command to view all possible inputs at the current moment");
                }

                else if (Location == "Church")
                {
                    switch (MyAction.ToUpper())
                    {
                        case "LOOK FORWARD":
                            Console.WriteLine();
                            Console.WriteLine("In front of you there are the doors that lead into the Nave you can see all the way up to the Ambulatory.\n You see a priest by the crossing lighting candles.");
                            continue;
                        case "LOOK LEFT":
                            Console.WriteLine();
                            Console.WriteLine("To your left there is a sleeping guard sitting in a chair, next to the guards chair there is a bill hook and on his belt there is a key");
                            continue;
                        case "LOOK RIGHT":
                            Console.WriteLine();
                            Console.WriteLine("To your right there is a closed door, a lantern hangs on a hook next to the door.");
                            continue;
                        case "LOOK BEHIND":
                            Console.WriteLine();
                            Console.WriteLine("Behind you there is the way back out");
                            continue;
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
                            continue;
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
                            continue;
                        case "WAKE GUARD":
                            Console.WriteLine();
                            Console.WriteLine("The Guard thanks you for waking him but as time passes and the church continues to remain calm and silent he falls asleep again, who could blame him the atmosphere is rather calming.");
                            continue;
                        case "TAKE KEY":
                            Console.WriteLine();
                            for (int i = 0; i < Inventory.ToArray().Length; i++)
                            {
                                if (Inventory[i].MyName == "church key")
                                {
                                    Console.WriteLine("You already have this");
                                    break;
                                }
                                else if (i == Inventory.ToArray().Length - 1)
                                {
                                    if (random.Next(1, 11) != 1)
                                    {
                                        Console.WriteLine("You snatch the key from the guards belt");
                                        Inventory.Add(GameItems[30]);
                                    }
                                    else
                                    {
                                        Console.WriteLine("As you stealthfully grasp the guards key he wakes up and suckerpunches you into the ground, more guards come and pummel you, as you lay on the ground not knowing wether you are concious or not they tell you to leave your wicked ways.\n They tell you to pray at the altar for forgiveness");
                                        Health--;
                                    }
                                    break;
                                }
                            }
                            if (Inventory.ToArray().Length == 0)
                            {
                                if (random.Next(1, 11) != 1)
                                {
                                    Console.WriteLine("You snatch the key from the guards belt");
                                    Inventory.Add(GameItems[30]);
                                }
                                else
                                {
                                    Console.WriteLine("As you stealthfully grasp the guards key he wakes up and suckerpunches you into the ground, more guards come and pummel you, as you lay on the ground not knowing wether you are concious or not they tell you to leave your wicked ways.\n They tell you to pray at the altar for forgiveness");
                                    Health--;
                                }
                            }
                            continue;
                        case "TAKE LANTERN":
                            Console.WriteLine();
                            for (int i = 0; i < Inventory.ToArray().Length; i++)
                            {
                                if (Inventory[i].MyName == "church lantern")
                                {
                                    Console.WriteLine("You already have this");
                                    break;
                                }
                                else if (i == Inventory.ToArray().Length - 1)
                                {
                                    Console.WriteLine("You take the unlit lantern off the wall, lighting it is no problem there are small twigs meant for lighting candles left inside the lantern next to the candle and lit candles around the church.");
                                    Inventory.Add(GameItems[31]);
                                }
                            }
                            if (Inventory.ToArray().Length == 0)
                            {
                                Console.WriteLine("You take the unlit lantern off the wall, lighting it is no problem there are small twigs meant for lighting candles left inside the lantern next to the candle and lit candles around the church.");
                                Inventory.Add(GameItems[31]);
                            }
                            continue;
                        case "OPEN DOOR":
                            Console.WriteLine();
                            for (int i = 0; i < Inventory.ToArray().Length; i++)
                            {
                                if (Inventory[i].MyName == "church key")
                                {
                                    Console.WriteLine("You unlock the door and go down the dark staircase");
                                    for (int j = 0; j < Inventory.ToArray().Length; j++)
                                    {
                                        if (Inventory[j].MyName == "church lantern")
                                        {
                                            Console.WriteLine("You light the lantern on your way down and when you reach the bottom you can see a casket in a room ahead of you laying on a table as you inspect it you find out it is Sir Yellegor Yellowflags casket");
                                            Console.WriteLine("Do you 'Open the Casket' or 'Say Goodbye'");
                                            string TempAction = Input();
                                            if (TempAction.ToUpper() == "OPEN THE CASKET")
                                            {
                                                if (CheckInventory("knights gear"))
                                                {
                                                    Console.WriteLine("You open the casket to reveal his body, you say a prayer then leave");
                                                    break;
                                                }
                                                Console.WriteLine("You open the casket to reveal his body he is clad in his armour his sword lay beside him and his shield lay on his chest");
                                                Console.WriteLine("Do you 'take his gear' or do you 'leave'");
                                                string TempAction2 = Input();
                                                if (TempAction2.ToUpper() == "TAKE HIS GEAR")
                                                {
                                                    for (int g = 0; g < Inventory.ToArray().Length; g++)
                                                    {
                                                        if (Inventory[g].MyName == "knights gear")
                                                        {
                                                            Console.WriteLine("You already have this");
                                                            break;
                                                        }
                                                        else if (g == Inventory.ToArray().Length - 1)
                                                        {
                                                            Console.WriteLine("You take your masters gear and put it on, noone would even recognize a peasant like you in this shining armor. You leave the basement");
                                                            Inventory.Add(GameItems[32]);
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
                                        else if (j == Inventory.ToArray().Length - 1)
                                        {
                                            Console.WriteLine("On your way down into the dark you slip and fall, you are hurt but manage to climb up the stairs and shut the door before you realise that you hurt your head pretty bad down there.");
                                            Health--;
                                        }
                                    }
                                    break;
                                }
                                else if (i == Inventory.ToArray().Length - 1)
                                {
                                    Console.WriteLine("The door is locked.");
                                }
                            }
                            if (Inventory.ToArray().Length == 0)
                            {
                                Console.WriteLine("The door is locked.");
                            }
                            continue;
                        case "LEAVE":
                            Console.WriteLine();
                            Console.WriteLine("You leave the church and enter the Marketplace again");
                            Location = "Markedplace";
                            continue;
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
                            continue;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Sorry you cant do that right now, or possibly even ever!");
                    Console.WriteLine("If you are stuck you can use the 'Help' Command to view all possible inputs at the current moment");
                }

                else if (Location == "Tavern")
                {
                    Console.WriteLine();
                    switch (MyAction.ToUpper())
                    {
                        case "LOOK FORWARD":
                            Console.WriteLine("In front of you theres the counter, behind the counter stands a tall handsome man wearing a nice but simple shirt with rolled up sleeves and dark pants, he has tattoos on his arms.\nThis would be the Barkeep.\nOn top of the counter there are all kinds of miscellaneous items such as glassware, spilt liquids, bugs both of the dead kind and the soon to be kind, the occational blunt dagger forcibly stuck into the counter top and one carving of a heart into the counter top with the text 'i love mom' inside");
                            continue;
                        case "LOOK LEFT":
                            Console.WriteLine("To your left, you can see a staircase leading up to what is most likely bedrooms or private rooms the tavern holds off for richer regulars.\nThere is also a lot of tables many of the with 2 to 5 patrons drinking and talking and playing games of chance.\nNext to the staircase there are 2 barrels forming a narrow walkway that leads underneath the staircase where there is a small table and 3 kegs to sit on, the candle on the middle of the table is unused and rather dusty but there is recently used mugs on the table, the lighting in the tavern is considered dim lit but this corner is even darker than that.");
                            continue;
                        case "LOOK RIGHT":
                            Console.WriteLine("To your right you can see a barmaid wandering through the thick smokelaiden room and patrons smoking and playing a game of cards, in the corner a bard sits on a high chair and plays his lute, the tune is not exactly upbeat.");
                            continue;
                        case "LOOK BEHIND":
                            Console.WriteLine("Behind you, you can see private guards sitting around the exit, looking around for troublemakers, and a man sleeping at the table. His glass was half full until the barmaid came over and poured the remaining grog into a keg you are sure they also use when serving a fresh mug, some things can not be unseen.");
                            continue;
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
                            continue;
                        case "BUY GROG":
                            if (Money > 1)
                            {
                                Console.WriteLine("You buy a mug of grog, you then take your time to drink it, for the price for a mug its not bad, but it is also very far from tasty");
                                Money--;
                            }
                            else
                            {
                                Console.WriteLine("You cannot afford this right now");
                            }
                            continue;
                        case "BUY STEW":
                            if (Money > 0)
                            {
                                Console.WriteLine("You buy stew it smells weird and its content is not even visually identifiable certain chunks come with a texture of overboiled fabric, whatever food is food right yet your stomach has never complained this much in its entire life before");
                                Money--;
                                if (Money > 0)
                                {
                                    Console.WriteLine("you buy a mug of grog to settle your stomach, it works ... kind of.");
                                    Money--;
                                }
                                else
                                {
                                    Console.WriteLine("You may have eaten something you shouldnt");
                                    Health--;
                                }
                            }
                            else
                            {
                                Console.WriteLine("You cannot afford this right now");
                            }
                            continue;
                        case "SIT UNDER STAIRS":
                            Console.WriteLine("You sit down under the staircase and a man... or what you think is a man, sits down with you shortly after. with a rough as gravel voice the creature utters 'do you want to by Fleggersh?'\nwhat do you say?");
                            string TempInput = Input();
                            if (TempInput.ToUpper() == "YES")
                            {
                                if (Money >= 2)
                                {
                                    Console.WriteLine("you recieve a weird mushroom rolled up in a leaf you dont recognize, you eat it. You go on wild adventures and lose track of time though you remain seated.");
                                    Health--;
                                    Money -= 2;
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
                            continue;
                        case "PLAY CARDS":
                            Console.WriteLine("You sit down at the table with the other fellas playing and having a good time\nHow many coppers do you bet?");
                            int BetAmount;
                            Int32.TryParse(Input(), out BetAmount);
                            if (Money < BetAmount)
                            {
                                Console.WriteLine("Sorry you dont have that much money, you are asked to leave the table");
                            }
                            else
                            {
                                if (random.Next(1, 7) == 6)
                                {
                                    Console.WriteLine("You Win this hand");
                                    Money += (float)Math.Round(BetAmount * 1.5);
                                }
                                else
                                {
                                    Console.WriteLine("You lose this hand");
                                    Money -= BetAmount;
                                }
                            }
                            continue;
                        case "LEAVE":
                            Console.WriteLine("You leave the tavern and return to the Markedplace");
                            Location = "Markedplace";
                            continue;
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
                            continue;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Sorry you cant do that right now, or possibly even ever!");
                    Console.WriteLine("If you are stuck you can use the 'Help' Command to view all possible inputs at the current moment");
                }

                else if (Location == "Town Hall")
                {
                    Console.WriteLine();
                    switch (MyAction.ToUpper())
                    {
                        case "GO TO MARKEDPLACE":
                            Console.WriteLine("You go to the markedplace");
                            Location = "Markedplace";
                            continue;
                        case "LOOK LEFT":
                            Console.WriteLine();
                            Console.WriteLine("To your left you can see a crowd gathered around a man speaking atop a box, he is surrounded by a minor crowd that seems to be listening to what the man has to say, the crowd has a varied response on their faces to what the man is saying.");
                            continue;
                        case "LOOK RIGHT":
                            Console.WriteLine();
                            Console.WriteLine("To your right you can see a statue of a man riding a horse wielding a lance and shiny armor.");
                            continue;
                        case "LOOK FORWARD":
                            Console.WriteLine();
                            Console.WriteLine("Ahead of you, you can see the great town hall, guards are stationed around every door and every window it seems like a really secure building and entrance seems limited and privileged to the few.");
                            continue;
                        case "LOOK BACK":
                            Console.WriteLine();
                            Console.WriteLine("Behind you lies the rest of the city, crowded streets and narrow roads between sets of structures of various designs and purposes, atleast the streets are stone and not mud.");
                            continue;
                        case "ENTER TOWN HALL":
                            Console.WriteLine();
                            foreach(Item item in Inventory)
                            {
                                if(item.MyName == "ring of invicibility")
                                {
                                    Console.WriteLine($"You put on your {item.MyName} and sneak past the guards and enter the town hall");
                                    Console.WriteLine("Once on the inside you see people doing paperwork at their desks, while others walk around with piles of paper in their hands and the occasional people talking in the hallways mostly about taxation and other political topics. straight ahead is a set of fine mahogony double doors that has been polished to really bring out its deep red color, the door handles are made out what looks like silver or some similar material and at the center of the handle it is crested with a green gemstone.");
                                    Console.WriteLine("Do you 'Open the Door'? or do you 'Leave'?");
                                    string TempString = Input();
                                    switch (TempString)
                                    {
                                        case "OPEN THE DOOR":
                                            Console.WriteLine("just before you open the doors you can hear voices from the other side of the intimidatingly valuable doors when you open them you are faced with an empty room and a deep swallowing pit, dirty dark and empty an old wooden staircase made out of timber lodged into the side of the pit creating a circling pathway down into the deep darkness");
                                            break;
                                        case "LEAVE":
                                            break;
                                    }
                                }
                            }
                            Console.WriteLine("You bravely attempt to enter the town hall but find yourself stopped by the guards and turned away.");
                            continue;
                        case "LISTEN TO MAN":
                            Console.WriteLine();
                            Console.WriteLine("You walk over to the man standing atop the box, he wears ragged clothes that clearly does not fit in with the finery of this district, he speaks of fanatic beliefs and that all should seek forgiveness before the inevitable end, he does so with a crack in his voice not unlike that of a teenager going through puberty.");
                            continue;
                        case "GO TO STATUE":
                            Console.WriteLine();
                            Console.WriteLine("You walk over to the statue and read the plaque and it says 'In Honour of Sir Pilferd Pernkelbottom must his heroics never be forgotten' it is a marvelous statue of a knight in his shining armor.");
                            continue;
                        case "GO TO CHESTLOCK GUILD HALL":
                            Console.WriteLine();
                            Console.WriteLine("You walk to the Chestlock Guild Hall, as you arrive you find that the Guild Hall is actually a Fort with crenellations and everything with a Guild Hall instead of barracks and storage houses instead of stables and other normal structures to be found in a more tradiotional fort.\n And all this inside the city, there is a steady flow of people entering and leaving the Forts gate, and the guards standing by the gate and above on the wall seem ever so vigilant.");
                            Location = "Chestlock Guild Hall";
                            continue;
                        case "GO TO HUNTERS LODGE":
                            Console.WriteLine();
                            Console.WriteLine("You walk to the Hunters Lodge, there you find a man chopping firewood.\n The Lodge itself takes form in a large cabin it looks rather cozy and homely.");
                            Location = "Hunters Lodge";
                            continue;
                        case "GO TO BRINEWOOD FOREST":
                            Console.WriteLine();
                            Console.WriteLine("You walk to Brinewood Forest, you now stand in the forest there are sounds of birds in the trees, there are moss covered rocks and everything seems calm.");
                            Location = "Brinewood Forest";
                            continue;
                        case "GO TO SCHOLARS MARKET":
                            Console.WriteLine();
                            Console.WriteLine("You walk to the Scholars Market, the outside area would make you think of this as a street of townhouses but you notice a sign hanging above one of the doors saying 'The Scholars Market'\n. As you enter you understand that this might have at some point been a street of townhouses but has been later turned into a set of shops located on the same floor under one roof, and not just this street the houses that would have been on the next street aswell making this a rather sizable place.\n The smells in the air are varied and exotic");
                            Location = "Scholars Market";
                            continue;
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
                            Console.WriteLine("Enter Town Hall");
                            Console.WriteLine("Listen To Man");
                            Console.WriteLine("Go To Statue");
                            Console.WriteLine("Go To Markedplace");
                            Console.WriteLine("Go To Chestlock Guild Hall");
                            Console.WriteLine("Go To Hunters Lodge");
                            Console.WriteLine("Go To Brinewood Forest");
                            Console.WriteLine("Go To Scholars Market");
                            continue;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Sorry you cant do that right now, or possibly even ever!");
                    Console.WriteLine("If you are stuck you can use the 'Help' Command to view all possible inputs at the current moment");
                }

                else if (Location == "Chestlock Guild Hall")
                {
                    switch (MyAction.ToUpper())
                    {
                        case "LOOK LEFT":
                            Console.WriteLine();
                            Console.WriteLine("To your left inside the guild hall you see merchants waiting in line in order to talk to a clerk, it seems many have brought chests or bags of gold");
                            continue;
                        case "LOOK RIGHT":
                            Console.WriteLine();
                            Console.WriteLine("To your right inside the guild hall you see offices, some that seem intended to recieve people who needs to talk to a guild representative and others that seem to be purely for use by those that work here.");
                            continue;
                        case "LOOK FORWARD":
                            Console.WriteLine();
                            Console.WriteLine("Ahead of you inside the guild hall is a grand staircase that lead up to a floor that by the look of the guards stationed by it is off limits.");
                            continue;
                        case "LOOK BACK":
                            Console.WriteLine();
                            Console.WriteLine("Behind you is the way out of the guild hall");
                            continue;
                        case "TALK TO CLERK":
                            Console.WriteLine();
                            Console.WriteLine("waiting in line seems to take forever and you eventually you reach the clerk who informs you that you must live in the city in order to use the banks services, 'regulations' she says in a snarky tone");
                            continue;
                        case "ENTER OFFICE":
                            Console.WriteLine();
                            Console.WriteLine("You enter one of the offices in order to talk to a representative of the guild and as you enter the office, the representative screams 'WAH, peasant! GUARDS!' you are tossed out of the representatives office, you think they can smell the poor person on you, quite a distinct smell");
                            continue;
                        case "GO UP STAIRCASE":
                            Console.WriteLine();
                            Console.WriteLine("You head for the grand staircase, your heart flutters as you imagine what it would be like to walk upon such bejeweled engraved gold lined mirror clear marble stairs perfectly crafted with mathematical precision, though you end up being stopped by the guards who tell you to 'this place is off limits sir, please go and ... count sheep or something somewhere else, guild heads only'");
                            continue;
                        case "GO TO MARKEDPLACE":
                            Console.WriteLine("You go to the markedplace");
                            Location = "Markedplace";
                            continue;
                        case "GO TO TOWN HALL":
                            Console.WriteLine();
                            Console.WriteLine("You walk to the Town Hall located in the northern part of town,\n as you stand outside the Town Hall you notice that there are more guards here, the people look, walk and talk in a way that would suggest they come from wealth.\n The Town Hall itself has a bell tower with a spire. The Hall is made out of stone for the most part but the stone is painted white, however the spire is made out of wood and is seemingly the only major part of the Hall that is made of wood.");
                            Location = "Town Hall";
                            continue;
                        case "GO TO HUNTERS LODGE":
                            Console.WriteLine();
                            Console.WriteLine("You walk to the Hunters Lodge, there you find a man chopping firewood.\n The Lodge itself takes form in a large cabin it looks rather cozy and homely.");
                            Location = "Hunters Lodge";
                            continue;
                        case "GO TO BRINEWOOD FOREST":
                            Console.WriteLine();
                            Console.WriteLine("You walk to Brinewood Forest, you now stand in the forest there are sounds of birds in the trees, there are moss covered rocks and everything seems calm.");
                            Location = "Brinewood Forest";
                            continue;
                        case "GO TO SCHOLARS MARKET":
                            Console.WriteLine();
                            Console.WriteLine("You walk to the Scholars Market, the outside area would make you think of this as a street of townhouses but you notice a sign hanging above one of the doors saying 'The Scholars Market'\n. As you enter you understand that this might have at some point been a street of townhouses but has been later turned into a set of shops located on the same floor under one roof, and not just this street the houses that would have been on the next street aswell making this a rather sizable place.\n The smells in the air are varied and exotic");
                            Location = "Scholars Market";
                            continue;
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
                            continue;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Sorry you cant do that right now, or possibly even ever!");
                    Console.WriteLine("If you are stuck you can use the 'Help' Command to view all possible inputs at the current moment");
                }

                else if (Location == "Hunters Lodge")
                {
                    switch (MyAction.ToUpper())
                    {
                        case "GO TO MARKEDPLACE":
                            Console.WriteLine("You go to the markedplace");
                            Location = "Markedplace";
                            continue;
                        case "GO TO TOWN HALL":
                            Console.WriteLine();
                            Console.WriteLine("You walk to the Town Hall located in the northern part of town,\n as you stand outside the Town Hall you notice that there are more guards here, the people look, walk and talk in a way that would suggest they come from wealth.\n The Town Hall itself has a bell tower with a spire. The Hall is made out of stone for the most part but the stone is painted white, however the spire is made out of wood and is seemingly the only major part of the Hall that is made of wood.");
                            Location = "Town Hall";
                            continue;
                        case "GO TO CHESTLOCK GUILD HALL":
                            Console.WriteLine();
                            Console.WriteLine("You walk to the Chestlock Guild Hall, as you arrive you find that the Guild Hall is actually a Fort with crenellations and everything with a Guild Hall instead of barracks and storage houses instead of stables and other normal structures to be found in a more tradiotional fort.\n And all this inside the city, there is a steady flow of people entering and leaving the Forts gate, and the guards standing by the gate and above on the wall seem ever so vigilant.");
                            Location = "Chestlock Guild Hall";
                            continue;
                        case "GO TO BRINEWOOD FOREST":
                            Console.WriteLine();
                            Console.WriteLine("You walk to Brinewood Forest, you now stand in the forest there are sounds of birds in the trees, there are moss covered rocks and everything seems calm.");
                            Location = "Brinewood Forest";
                            continue;
                        case "GO TO SCHOLARS MARKET":
                            Console.WriteLine();
                            Console.WriteLine("You walk to the Scholars Market, the outside area would make you think of this as a street of townhouses but you notice a sign hanging above one of the doors saying 'The Scholars Market'\n. As you enter you understand that this might have at some point been a street of townhouses but has been later turned into a set of shops located on the same floor under one roof, and not just this street the houses that would have been on the next street aswell making this a rather sizable place.\n The smells in the air are varied and exotic");
                            Location = "Scholars Market";
                            continue;
                        case "LOOK LEFT":
                            Console.WriteLine();
                            Console.WriteLine("You look to your left and gaze upon a man chopping wood");
                            continue;
                        case "LOOK RIGHT":
                            Console.WriteLine();
                            Console.WriteLine("You look to your right and see some men practising with a bow");
                            continue;
                        case "LOOK FORWARD":
                            Console.WriteLine();
                            Console.WriteLine("Ahead you see a cozy looking cabin, its quite large");
                            continue;
                        case "LOOK BACK":
                            Console.WriteLine();
                            Console.WriteLine("Behind you lies Brinewood Forest it reminds you of wet dogs for some reason");
                            continue;
                        case "HELP":
                            Console.WriteLine();
                            Console.WriteLine("The commands below might also include actions that you havent discovered in the story yet \n or choices your character havent discovered yet \n so use them with caution as using actions you havent discovered in the story might come at the expense of your experience.");
                            Console.WriteLine();
                            Console.WriteLine("Current Input Opportunities:");
                            Console.WriteLine();
                            Console.WriteLine("Look Left");
                            Console.WriteLine("Look Right");
                            Console.WriteLine("Look Forward");
                            Console.WriteLine("Look back");
                            Console.WriteLine("Go To Markedplace");
                            Console.WriteLine("Go To Town Hall");
                            Console.WriteLine("Go To Chestlock Guild Hall");
                            Console.WriteLine("Go To Brinewood Forest");
                            Console.WriteLine("Go To Scholars Market");
                            continue;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Sorry you cant do that right now, or possibly even ever!");
                    Console.WriteLine("If you are stuck you can use the 'Help' Command to view all possible inputs at the current moment");
                }

                else if (Location == "Brinewood Forest")
                {
                    switch (MyAction.ToUpper())
                    {
                        case "LOOK LEFT":
                            Console.WriteLine();
                            Console.WriteLine("To your left you see birds in the trees and the occasional blue berries, yummy");
                            continue;
                        case "LOOK RIGHT":
                            Console.WriteLine();
                            Console.WriteLine("To your right you see a beehive in a tree, its surprisingly large.");
                            continue;
                        case "LOOK FORWARD":
                            Console.WriteLine();
                            Console.WriteLine("Ahead of you is a great large OGRE, probably the one and the same that killed your master, it doesnt seem like it has noticed you yet");
                            continue;
                        case "LOOK BACK":
                            Console.WriteLine();
                            Console.WriteLine("Behind you, you can see rough and hard to travel terrain, thorned bushes and the like");
                            continue;
                        case "KILL OGRE":
                            int TotalDamage = 0;
                            int TotalDefence = 0;
                            foreach(Item item in Inventory)
                            {
                                TotalDamage += item.MyDamage;
                                TotalDefence += item.MyArmor;
                            }
                            if(TotalDamage >= 7 && TotalDefence >= 15)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You kill the mighty ogre and return triumphant, you claim your reward and live a merry life as a monster hunter until your last day and pass into legend");
                                Thread.Sleep(10000);
                                Environment.Exit(0);
                            }
                            else
                            {
                                IsAlive = false;
                            }
                            continue;
                        case "GO TO MARKEDPLACE":
                            Console.WriteLine("You go to the markedplace");
                            Location = "Markedplace";
                            continue;
                        case "GO TO TOWN HALL":
                            Console.WriteLine();
                            Console.WriteLine("You walk to the Town Hall located in the northern part of town,\n as you stand outside the Town Hall you notice that there are more guards here, the people look, walk and talk in a way that would suggest they come from wealth.\n The Town Hall itself has a bell tower with a spire. The Hall is made out of stone for the most part but the stone is painted white, however the spire is made out of wood and is seemingly the only major part of the Hall that is made of wood.");
                            Location = "Town Hall";
                            continue;
                        case "GO TO CHESTLOCK GUILD HALL":
                            Console.WriteLine();
                            Console.WriteLine("You walk to the Chestlock Guild Hall, as you arrive you find that the Guild Hall is actually a Fort with crenellations and everything with a Guild Hall instead of barracks and storage houses instead of stables and other normal structures to be found in a more tradiotional fort.\n And all this inside the city, there is a steady flow of people entering and leaving the Forts gate, and the guards standing by the gate and above on the wall seem ever so vigilant.");
                            Location = "Chestlock Guild Hall";
                            continue;
                        case "GO TO HUNTERS LODGE":
                            Console.WriteLine();
                            Console.WriteLine("You walk to the Hunters Lodge, there you find a man chopping firewood.\n The Lodge itself takes form in a large cabin it looks rather cozy and homely.");
                            Location = "Hunters Lodge";
                            continue;
                        case "GO TO SCHOLARS MARKET":
                            Console.WriteLine();
                            Console.WriteLine("You walk to the Scholars Market, the outside area would make you think of this as a street of townhouses but you notice a sign hanging above one of the doors saying 'The Scholars Market'\n. As you enter you understand that this might have at some point been a street of townhouses but has been later turned into a set of shops located on the same floor under one roof, and not just this street the houses that would have been on the next street aswell making this a rather sizable place.\n The smells in the air are varied and exotic");
                            Location = "Scholars Market";
                            continue;
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
                            continue;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Sorry you cant do that right now, or possibly even ever!");
                    Console.WriteLine("If you are stuck you can use the 'Help' Command to view all possible inputs at the current moment");
                }

                else if (Location == "Scholars Market")
                {
                    switch (MyAction.ToUpper())
                    {
                        case "GO TO MARKEDPLACE":
                            Console.WriteLine("You go to the markedplace");
                            Location = "Markedplace";
                            continue;
                        case "HELP":
                            Console.WriteLine();
                            Console.WriteLine("The commands below might also include actions that you havent discovered in the story yet \n or choices your character havent discovered yet \n so use them with caution as using actions you havent discovered in the story might come at the expense of your experience.");
                            Console.WriteLine();
                            Console.WriteLine("Current Input Opportunities:");
                            Console.WriteLine();
                            Console.WriteLine("Go To Markedplace");
                            continue;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Sorry you cant do that right now, or possibly even ever!");
                    Console.WriteLine("If you are stuck you can use the 'Help' Command to view all possible inputs at the current moment");
                }
            }
            Console.WriteLine();
            Console.WriteLine("You are Dead, you will not be remembered, you will not pass into legend. You shall fade into the nothingness of wich you came.");
            Console.WriteLine();
            Thread.Sleep(20000);
        }
    }
}
