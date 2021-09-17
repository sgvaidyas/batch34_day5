using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day5
{
    class MyExample
    {
        int x, y;
        public static int data;
        public MyExample()
        {
            x = 99;
            y = 22;
            
        }
        static MyExample()
        {
            data = 77;
        }
        public void display()
        {
            Console.WriteLine("x = " +x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("data = " + data);

        }
    }
    class Staticcons
    {
        static void Main(string[] args)
        {
            MyExample ob = new MyExample();
            ob.display();

        }
    }
}
