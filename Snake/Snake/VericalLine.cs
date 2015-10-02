using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VericalLine
    {
        List<Point> pList;

        public VericalLine(int x, int yUp, int yDown, char sym)
        {
            pList = new List<Point>();

            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);

            }

        }

        public void pDraw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
