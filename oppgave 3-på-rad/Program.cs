using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace oppgave_3_på_rad
{
    class Program
    {
        
        static void Main()
        {
            Console.WriteLine("type in coordinates for square with number first!");
            Console.WriteLine();
            while (CheckWinner.Winner == "Undecided")
            {
                BoardView.Show();
                BoardController.PlayerMove();
                CheckWinner.WinCheck();
            }
        }
    }

    class BoardView
    {

        public static BoardModel Board = new BoardModel();
        public static void Show()
        {
            Console.WriteLine("  ABC ");
            Console.WriteLine(" -----");
            Console.WriteLine($"1|{Board.FirstLineOne}{Board.FirstLineTwo}{Board.FirstLineThree}|");
            Console.WriteLine($"2|{Board.SecondLineOne}{Board.SecondLineTwo}{Board.SecondLineThree}|");
            Console.WriteLine($"3|{Board.ThirdLineOne}{Board.ThirdLineTwo}{Board.ThirdLineThree}|");
            Console.WriteLine(" -----");
        }
    }

    class BoardController
    {
        public static void PlayerMove()
        {
            string tempstring = Console.ReadLine();
            if(tempstring == "reset")
            {
                var fileName = Assembly.GetExecutingAssembly().Location;
                Process.Start(fileName);
                Environment.Exit(0);
            }
            else
            {
                BoardView.Board.Model(tempstring);
            }
        }
        public static string Input()
        {
            return Console.ReadLine();
        }
    }

    class CheckWinner
    {
        public static string Winner = "Undecided";
        
        public static void WinCheck()
        {
            var Board = BoardView.Board;

            if(Board.FirstLineOne+Board.FirstLineTwo+Board.FirstLineThree == "xxx" ||
                Board.SecondLineOne + Board.SecondLineTwo + Board.SecondLineThree == "xxx" ||
                Board.ThirdLineOne + Board.ThirdLineTwo + Board.ThirdLineThree == "xxx" ||
                Board.FirstLineOne + Board.SecondLineOne + Board.ThirdLineOne == "xxx" ||
                Board.FirstLineTwo + Board.SecondLineTwo + Board.ThirdLineTwo == "xxx" ||
                Board.FirstLineThree + Board.SecondLineThree + Board.ThirdLineThree == "xxx" ||
                Board.FirstLineOne + Board.SecondLineTwo + Board.ThirdLineThree == "xxx" ||
                Board.FirstLineThree + Board.SecondLineTwo + Board.ThirdLineOne == "xxx")
            {
                Winner = "Player One!";
                Console.WriteLine($"The Match Was Won By {Winner}");
            }
            else if(Board.FirstLineOne + Board.FirstLineTwo + Board.FirstLineThree == "ooo" ||
                Board.SecondLineOne + Board.SecondLineTwo + Board.SecondLineThree == "ooo" ||
                Board.ThirdLineOne + Board.ThirdLineTwo + Board.ThirdLineThree == "ooo" ||
                Board.FirstLineOne + Board.SecondLineOne + Board.ThirdLineOne == "ooo" ||
                Board.FirstLineTwo + Board.SecondLineTwo + Board.ThirdLineTwo == "ooo" ||
                Board.FirstLineThree + Board.SecondLineThree + Board.ThirdLineThree == "ooo" ||
                Board.FirstLineOne + Board.SecondLineTwo + Board.ThirdLineThree == "ooo" ||
                Board.FirstLineThree + Board.SecondLineTwo + Board.ThirdLineOne == "ooo")
            {
                Winner = "Player Two!";
                Console.WriteLine($"The Match Was Won By {Winner}");
            }

        }
    }
}
