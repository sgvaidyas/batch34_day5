using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day5
{
    class Shape
    {
        float len, bred, rad;
        float rect, sq, circle;
        public Shape()
        {
            len = 2;
            bred = 3;
            rad = 1.5f;
        }
        public void getdata()
        {
            Console.WriteLine("Enter len,bred,rad");
            len = float.Parse(Console.ReadLine());
            bred = float.Parse(Console.ReadLine());
            rad = float.Parse(Console.ReadLine());

        }
        public void cal()
        {
            rect = len * bred;
            sq = len * len;
            circle = 3.142f * rad * rad;
        }
        public void display()
        {
            Console.WriteLine("LENGTH     ="+len);
            Console.WriteLine("BREADTH    =" + bred);
            Console.WriteLine("RADIUS    =" + rad);
            Console.WriteLine("RECT(AREA)    =" + rect);
            Console.WriteLine("SQUARE(AREA)     =" + sq);
            Console.WriteLine("CIRCLE(AREA)     =" + circle);
        }
    }

    class Shape_constructor
    {
        static void Main(string[] args)
        {
            Shape ob = new Shape();
            ob.cal();
            ob.display();
            ob.getdata();
            ob.cal();
            ob.display();
        }
    }
}
