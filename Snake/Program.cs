using System;
using System.Collections.Generic;


namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            //Point p1 = new Point(1,3,'*'); 
            //p1.Draw();
            
            //Point p2 = new Point(4, 5, '#');
            //p2.Draw();

            HorizontalLine upline = new HorizontalLine(0,78,0,'+');
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightline = new VerticalLine(0, 24, 78, '+');
            
           
            
            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rightline.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake (p, 4, Direction.RIGHT);
            snake.Drow();
            Console.ReadLine();
        }
     
    }
}
