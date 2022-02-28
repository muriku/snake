using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class VerticalLine : Figure
    {
        public VerticalLine(int yUpper, int yBottom, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUpper; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);

            }


        }
    }
}
