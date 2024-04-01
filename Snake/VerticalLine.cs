using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yDowm, int x, char sym)
        {
            pList = new List<Point>();
            for(int y = yUp; y <= yDowm; y++) 
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
