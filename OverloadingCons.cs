using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day5
{
    class OverloadingCons
    {
        int x, y;
        OverloadingCons()
        {
            x = 9;
            y = 8;
        }
        OverloadingCons(int val)
        {
            x = val;
            y = val;
        }
        OverloadingCons(int a,int b)
        {
            x = a;
            y = b;
        }
        void display()
        {
            Console.WriteLine("X = "+x+"\nY = "+y);
        }
        static void Main(string[] args)
        {
            OverloadingCons ob = new OverloadingCons();
            ob.display();
            OverloadingCons ob1 = new OverloadingCons(77,88);
            ob1.display();

            OverloadingCons ob2 = new OverloadingCons(99);
            ob2.display();
        }
    }
}
