using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oppgave_3_på_rad
{
    class BoardModel
    {
        public string FirstLineOne = " ";
        public string FirstLineTwo = " ";
        public string FirstLineThree = " ";

        public string SecondLineOne = " ";
        public string SecondLineTwo = " ";
        public string SecondLineThree = " ";

        public string ThirdLineOne = " ";
        public string ThirdLineTwo = " ";
        public string ThirdLineThree = " ";

        public int Counter = 0;
        public string Letter = "x";

        public void Model(string Entry)
        {
            if(Counter % 2 == 0)
            {
                Letter = "x";
            }
            else
            {
                Letter = "o";
            }
            Counter++;
            switch (Entry.ToUpper())
            {
                case "1A":
                    if (string.IsNullOrWhiteSpace(FirstLineOne))
                    {
                        FirstLineOne = Letter;
                    }
                    else
                    {
                        Counter--;
                    }
                    break;
                case "1B":
                    if (string.IsNullOrWhiteSpace(FirstLineTwo))
                    {
                        FirstLineTwo = Letter;
                    }
                    else
                    {
                        Counter--;
                    }
                    break;
                case "1C":
                    if (string.IsNullOrWhiteSpace(FirstLineThree))
                    {
                        FirstLineThree = Letter;
                    }
                    else
                    {
                        Counter--;
                    }
                    break;

                case "2A":
                    if (string.IsNullOrWhiteSpace(SecondLineOne))
                    {
                        SecondLineOne = Letter;
                    }
                    else
                    {
                        Counter--;
                    }
                    break;
                case "2B":
                    if (string.IsNullOrWhiteSpace(SecondLineTwo))
                    {
                        SecondLineTwo = Letter;
                    }
                    else
                    {
                        Counter--;
                    }
                    break;
                case "2C":
                    if (string.IsNullOrWhiteSpace(SecondLineThree))
                    {
                        SecondLineThree = Letter;
                    }
                    else
                    {
                        Counter--;
                    }
                    break;

                case "3A":
                    if (string.IsNullOrWhiteSpace(ThirdLineOne))
                    {
                        ThirdLineOne = Letter;
                    }
                    else
                    {
                        Counter--;
                    }
                    break;
                case "3B":
                    if (string.IsNullOrWhiteSpace(ThirdLineTwo))
                    {
                        ThirdLineTwo = Letter;
                    }
                    else
                    {
                        Counter--;
                    }
                    break;
                case "3C":
                    if (string.IsNullOrWhiteSpace(ThirdLineThree))
                    {
                        ThirdLineThree = Letter;
                    }
                    else
                    {
                        Counter--;
                    }
                    break;
            }
        }
    }
}
