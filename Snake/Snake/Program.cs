using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x1 = 5;
            int y1 = 5;
            char sym1 = '*';

            int x2 = 10;
            int y2 = 10;
            char sym2 = '#';

            Draw(x1, y1, sym1);
            Draw(x2, y2, sym2);

            Console.ReadKey();
                        
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }*/

            Point p1 = new Point(5,5,'$');

            Point p2 = new Point(10,10,'%');

            p1.Draw();
            p2.Draw();

            HorizontalLine hLine = new HorizontalLine(5, 10, 8, '+');
            VericalLine vLine = new VericalLine(5, 5, 15, '+');
            hLine.pDraw();
            vLine.pDraw();

            Console.ReadKey();
        }
    }
}
