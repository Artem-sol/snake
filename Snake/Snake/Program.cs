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

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(2);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            Console.ReadKey();
        }
    }
}
