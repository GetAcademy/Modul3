using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_Tilfeldige_Firkanter
{
    class VirtualScreenCell
    {
        public bool Up { get; private set; }
        public bool Down { get; private set; }
        public bool Left { get; private set; }
        public bool Right { get; private set; }

        //public char GetCharacter(bool Up, bool Down, bool Left, bool Right)
        public char GetCharacter()
        {
            if(Up && !Down && !Left && !Right) //up
            {
                return '╵';
            }
            else if(!Up && Down && !Left && !Right) //down
            {
                return '╷';
            }
            else if (!Up && !Down && Left && !Right) //left
            {
                return '╴';
            }
            else if (!Up && !Down && !Left && Right) //right
            {
                return '╶';
            }
            else if (Up && Down && !Left && !Right) // up and down
            {
                return '│';
            }
            else if (Up && !Down && Left && !Right) // up and left
            {
                return '┘';
            }
            else if (Up && !Down && !Left && Right) // up and right
            {
                return '└';
            }
            else if (!Up && Down && Left && !Right) // down and left
            {
                return '┐';
            }
            else if (!Up && Down && !Left && Right) // down and right
            {
                return '┌';
            }
            else if (!Up && !Down && Left && Right) // left and right
            {
                return '─';
            }
            else if (Up && Down && Left && !Right) // up and down and left
            {
                return '┤';
            }
            else if (Up && !Down && Left && Right) // up and left and right
            {
                return '┴';
            }
            else if (!Up && Down && Left && Right) // down and left and right
            {
                return '┬';
            }
            else if (Up && Down && !Left && Right) // up and down and right
            {
                return '├';
            }
            else if (Up && Down && Left && Right) // up and down and left and right
            {
                return '┼';
            }
            else
            {
                return ' ';
            }
        }
        public void AddHorizontal()
        {
            Left = true;
            Right = true;
        }
        public void AddVertical()
        {
            Up = true;
            Down = true;
        }
        public void AddLowerLeftCorner()
        {
            Up = true;
            Right = true;
        }
        public void AddUpperLeftCorner()
        {
            Down = true;
            Right = true;
        }
        public void AddUpperRightCorner()
        {
            Down = true;
            Left = true;
        }
        public void AddLowerRightCorner()
        {
            Up = true;
            Left = true;
        }
    }
}
