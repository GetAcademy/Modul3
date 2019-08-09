using System;

namespace Oppgave2
{
    class Program
    {
        
        static void Main()
        {
            bool IsValid = true;
            string Password = "Placeholder";
            Console.WriteLine("PasswordGenerator");
            Console.WriteLine("");
            Console.WriteLine("use ShowHelpText() for further assistance!");
            Console.WriteLine("");

            #region myUtilities;
            int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }
            int CapitalLetter()
            {
                return RandomNumber(65,90);
            }
            int Digit()
            {
                return RandomNumber(48,57);
            }
            int SmallLetter()
            {
                return RandomNumber(97,122);
            }
            int SpecialCharacter()
            {
                return RandomNumber(33,47);
            }
            void ShowHelpText()
            {
                Console.WriteLine("");
                Console.WriteLine("Options:");
                Console.WriteLine("L = lower case letter");
                Console.WriteLine("C = upper case letter");
                Console.WriteLine("D = digit");
                Console.WriteLine("S = special character (!#¤%&/(){}[]");
                Console.WriteLine("");
            }
            #endregion myUtilities;

            while (!string.IsNullOrWhiteSpace(Password))
            {
                if (!IsValid)
                {
                    ShowHelpText();
                    IsValid = true;
                }
                Console.WriteLine("How Many Characters Should Your Password Be?");
                int PassLength;
                Int32.TryParse(Console.ReadLine(), out PassLength);
                Console.WriteLine("Good! now, should your password have any capital letters, numbers or special characters? if you are unsure use command word 'Help' to show additional information!");
                string PassOptions = Console.ReadLine();
                if(PassOptions == "Help" || PassOptions == "help")
                {
                    ShowHelpText();
                    Console.WriteLine("Good! now, should your password have any capital letters, numbers or special characters?");
                    PassOptions = Console.ReadLine();
                }
                else if (PassOptions.Length > PassLength)
                {
                    IsValid = false;
                }
                string tempstring = "";
                if(PassLength < 8 || PassLength > 20)
                {
                    IsValid = false;
                }
                if (IsValid)
                {
                    for (int i = 0; i < PassLength; i++)
                    {
                        if (!string.IsNullOrWhiteSpace(PassOptions))
                        {
                            foreach (char Character in PassOptions)
                            {
                                switch (Character)
                                {
                                    case (char)76:
                                        tempstring += Convert.ToChar(SmallLetter());
                                        i++;
                                        break;
                                    case (char)67:
                                        tempstring += Convert.ToChar(CapitalLetter());
                                        i++;
                                        break;
                                    case (char)68:
                                        tempstring += Convert.ToChar(Digit());
                                        i++;
                                        break;
                                    case (char)83:
                                        tempstring += Convert.ToChar(SpecialCharacter());
                                        i++;
                                        break;
                                }
                            }
                        }
                        if (i == PassLength)
                        {
                            break;
                        }
                        tempstring += Convert.ToChar(RandomNumber(64, 122));
                    }
                    Password = tempstring;
                    Console.WriteLine("Your New Password is: " + Password);
                }
                else
                {
                    Console.WriteLine("Try Again? Y/N");
                    string Answer = Console.ReadLine();
                    if(Answer.ToUpper() == "Y")
                    {
                        Password = "Y";
                    }
                    else
                    {
                        Password = "";
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("PasswordGenerator");
            Console.WriteLine("");
            Console.WriteLine("Example: PasswordGenerator 14 LCSSDD");
            Console.WriteLine("Adds, 1 lower case");
            Console.WriteLine("Adds, 1 upper case");
            Console.WriteLine("Adds, 2 special characters");
            Console.WriteLine("Adds, 2 digits");
            Console.WriteLine("");
            Console.WriteLine("Have a Good Day, And Enjoy Your New Password!!!");
        }
    }
}
