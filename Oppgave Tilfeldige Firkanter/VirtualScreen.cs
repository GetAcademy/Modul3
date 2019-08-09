using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_Tilfeldige_Firkanter
{
    public class VirtualScreen
    {
        private VirtualScreenRow[] Rows;
        public List<Box> Boxes = new List<Box>();

        public VirtualScreen(int Width, int Height)
        {
            Rows = new VirtualScreenRow[Height];
            Add(new Box(new Random(), Width, Height));
        }
        public void Add(Box box)
        {
            Boxes.Add(box);
        }
        public void Show()
        {
            foreach(Box box in Boxes.ToArray())
            {
                Console.WriteLine();
            }
        }
    }
}
