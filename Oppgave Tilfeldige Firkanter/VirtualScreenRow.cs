using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_Tilfeldige_Firkanter
{
    public class VirtualScreenRow
    {
        VirtualScreenCell[] Cells;

        //string temp = "";

        public VirtualScreenRow(int ScreenWidth)
        {
            Cells = new VirtualScreenCell[ScreenWidth];
            for (int i = 0; i < ScreenWidth; i++)
            {
                Cells[i] = new VirtualScreenCell();
            }
        }

        public void AddBoxTopRow(int topLeftCornerX, int boxWidth)
        {
            Cells[topLeftCornerX].AddUpperLeftCorner();
            var topRightCornerX = topLeftCornerX + boxWidth;
            for (var i = topLeftCornerX + 1; i < topRightCornerX; i++)
            {
                Cells[i].AddHorizontal();
            }
            Cells[topRightCornerX].AddUpperRightCorner();
        }

        public void AddBoxMiddleRow(int LeftX, int Width)
        {
            Cells[LeftX].AddVertical();
            Cells[LeftX + Width].AddVertical();
        }

        public void AddBoxBottomRow(int BottomLeftCornerX, int Width)
        {
            Cells[BottomLeftCornerX].AddLowerLeftCorner();
            var BottomRightCorner = BottomLeftCornerX + Width;
            for(int i = BottomLeftCornerX + 1; i < BottomRightCorner; i++)
            {
                Cells[i].AddHorizontal();
            }
            Cells[BottomRightCorner].AddLowerRightCorner();
        }

        public void Show()
        {
            foreach(var cell in Cells)
            {
                Console.Write(cell.GetCharacter());
            }
            Console.WriteLine();
        }
    }
}
