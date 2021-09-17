using System;

namespace Batch34_day5
{
    class ImplementRectangle
    {
        int len, bred, area, peri;

        void getdetails(int x,int y)
        {
            len = x;
            bred = y;
        }
        void calculate()
        {
            area = len * bred;
            peri = 2 * (len + bred);
        }
        void display()
        {
            Console.WriteLine("LENGTH          = " +len);
            Console.WriteLine("BREADTH         = " + bred);
            Console.WriteLine("AREA            = " + area);
            Console.WriteLine("PERIMETER       = " + peri);

        }
        static void Main(string[] args)
        {
            ImplementRectangle ob = new ImplementRectangle();
            ob.getdetails(3, 4);
            ob.calculate();
            ob.display();
        }
    }
}
