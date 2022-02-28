using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class Figure
    {
        protected List<Point> pList; //protected это изменение модификатора доступа что бы переменная была видна у наследников

        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }

}
