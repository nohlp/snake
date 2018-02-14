using System;
using System.Collections.Generic;

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

            List<int> numlist = new List<int>();
            numlist.Add(0);
            numlist.Add(1);
            numlist.Add(2);

            int x = numlist[0];
            int y = numlist[1];
            int z = numlist[2];
        }


    }
}
