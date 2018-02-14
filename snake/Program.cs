using System;

namespace nohlp_snake
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');

            Point p2 = new Point(4, 6, '#');

            p1.Draw();

            p2.Draw();
            //Console.ReadLine();
        }


    }
}
