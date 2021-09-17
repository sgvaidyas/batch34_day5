using System;

namespace Batch34_day5
{
    class Point
    {
        int x, y;

        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public void display()
        {
            Console.WriteLine("X = " + x + "\nY = " + y);
        }
        ~Point()
        {
            Console.WriteLine("destructing....");
            display();
        }

    }
    class PointImplement
    {
        static void Main(string[] args)
        {
            Point ob = new Point(7,9);
            //ob.display();

            Point ob1 = new Point(5, 4);

            Point ob2 = new Point(44, 34);


            //ob1.display();
            Console.WriteLine("hi");
            Console.WriteLine("hello");

        }
    }
}
