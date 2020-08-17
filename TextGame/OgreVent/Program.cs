using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace OgreVent
{
    class Program
    {
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

        static public bool CheckInventory(string ItemName)
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

        static public bool CheckCarryCapacity(int ItemWeight, int ItemSpace)
        {
            if (CurrentWeight + ItemWeight <= CarryingCapacity())
            {
                if (CurrentSpace + ItemSpace <= CarrySpace())
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

        static public int CarryingCapacity()
        {
            int carryingCapacity = 30;
            foreach (Item item in Inventory)
            {
                if (item.MyName == "backpack")
                {
                    carryingCapacity += 15;
                    break;
                }
            }
            foreach (Item item in Inventory)
            {
                if (item.MyName == "ring of mighty strength")
                {
                    carryingCapacity += 20;
                    break;
                }
            }
            return carryingCapacity;
        }
        static public int CarrySpace()
        {
            int carrySpace = 10;
            foreach (Item item in Inventory)
            {
                if (item.MyName == "backpack")
                {
                    carrySpace += 20;
                    break;
                }
            }
            return carrySpace;
        }

        public static string PrintValue(int Value)
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

        public static bool IsAlive = true;

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
                    Console.WriteLine($"you are currently carrying {CurrentWeight} Kg, and it takes up {CurrentSpace} amount of space in your inventory out of {CarrySpace()}. You can also carry a total weight of {CarryingCapacity()} Kg.");
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
                    MarkedPlace.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Church")
                {
                    Church.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Town Hall")
                {
                    TownHall.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Chestlock Guild Hall")
                {
                    ChestlockGuildHall.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Hunters Lodge")
                {
                    HuntersLodge.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Brinewood Forest")
                {
                    BrinewoodForest.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Scholars Market")
                {
                    ScholarsMarket.Actions(MyAction.ToUpper());
                    continue;
                }
            }
            Console.WriteLine();
            Console.WriteLine("You are Dead, you will not be remembered, you will not pass into legend. You shall fade into the nothingness of wich you came.");
            Console.WriteLine();
            Thread.Sleep(20000);
        }
    }
}
