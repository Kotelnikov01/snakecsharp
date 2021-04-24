using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Draw();
            
            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(6, 8, '^');
            p3.Draw();

            Point p4 = new Point(1, 6, '%');
            p4.Draw();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            numList.RemoveAt(0);

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            List<Point> plist = new List<Point>();

            plist.Add(p1);
            plist.Add(p2);
            plist.Add(p3);
            plist.Add(p4);


            Console.ReadLine();
        }
     
    }
}
