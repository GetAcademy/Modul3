using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_Tilfeldige_Firkanter
{
    class Program
    {
        static void Main()
        {
            var boxes = new[]
            {
                new Box(5,5, 10, 10),
                new Box(RandomNumber(1,49),RandomNumber(1,49), RandomNumber(10,50), RandomNumber(10,50)),
                new Box(RandomNumber(1,49),RandomNumber(1,49), RandomNumber(10,50), RandomNumber(10,50)),
                new Box(RandomNumber(1,49),RandomNumber(1,49), RandomNumber(10,50), RandomNumber(10,50)),
                new Box(RandomNumber(1,49),RandomNumber(1,49), RandomNumber(10,50), RandomNumber(10,50)),
                new Box(RandomNumber(1,49),RandomNumber(1,49), RandomNumber(10,50), RandomNumber(10,50)),
                new Box(RandomNumber(1,49),RandomNumber(1,49), RandomNumber(10,50), RandomNumber(10,50)),
                new Box(RandomNumber(1,49),RandomNumber(1,49), RandomNumber(10,50), RandomNumber(10,50)),
                new Box(RandomNumber(1,49),RandomNumber(1,49), RandomNumber(10,50), RandomNumber(10,50)),
                new Box(RandomNumber(1,49),RandomNumber(1,49), RandomNumber(10,50), RandomNumber(10,50)),
            };
            VirtualScreenRow[] rows = new VirtualScreenRow[100]; //new VirtualScreenRow(true, false, false, 10);
            for (var i = 0; i < rows.Length; i++)
            {
                rows[i] = new VirtualScreenRow(100);
            }
            foreach (var box in boxes)
            {
                var firstRow = rows[box.Y];
                firstRow.AddBoxTopRow(box.X, box.Width);
                for (var y = box.Y + 1; y < box.EndY; y++)
                {
                    var MiddleRow = rows[y];
                    MiddleRow.AddBoxMiddleRow(box.X, box.Width);
                }
                var LastRow = rows[box.EndY];
                LastRow.AddBoxBottomRow(box.X, box.Width);
            }

            Console.Clear();
            foreach (var row in rows)
            {
                row.Show();
            }
        }

        static Random random = new Random();
        static int RandomNumber(int Min, int Max)
        {
            return random.Next(Min, Max);
        }
    }
}
