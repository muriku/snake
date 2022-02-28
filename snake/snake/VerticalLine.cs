using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int x, int yUpper, int yBottom, char sym)
        {
            pList = new List<Point>();
            for (int y = yUpper; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);

            }


        }

        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
