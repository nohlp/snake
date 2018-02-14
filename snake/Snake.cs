using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nohlp_snake
{
    public class Snake : Figure
    {
        public Snake(Point tail,int lenght,Direction direction)
        {
            List<Point> plist = new List<Point>();
            for (int i=0; i <= lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                plist.Add(p);
                //p.Draw();
            }
        }

        internal void Move()
        {
            throw new NotImplementedException();
        }
    }
}
