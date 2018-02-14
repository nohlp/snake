using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nohlp_snake
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            /*
            Console.SetWindowSize(80,80);
            Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(4, 6, '#');
            p2.Draw();
            */
            //Console.ReadLine();



            HorizontalLine upline = new HorizontalLine(0,78,0,'+');
            HorizontalLine downline = new HorizontalLine(0, 78, 20, '+');
            VerticalLine leftline = new VerticalLine(0, 20, 0, '+');
            VerticalLine rightline = new VerticalLine(0, 20, 78, '+');

            upline.Draw();
            downline.Draw();
            leftline.Draw();
            rightline.Draw();

        }


    }
}
