using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day5
{
    class Myclass
    {
        public static int count=0;
        int roll, marks;
        public Myclass()
        {
            roll = 0;
            marks = 0;
            count++;
        }
        public Myclass(int a,int b)
        {
            roll = a;
            marks = b;
            count++;
        }
        public void display()
        {
            Console.WriteLine("ROLL NO  = "  + roll + " MARKS = " + marks+ " count= " +count);
        }
    }
    class Staticex
    {
        static void Main(string[] args)
        {
            Myclass ob1 = new Myclass(3, 49);
            ob1.display();

            Myclass ob2 = new Myclass(2, 65);
            ob2.display();


            Myclass ob3 = new Myclass();
            ob3.display();
            Console.WriteLine();
            ob1.display();
            ob2.display();
            ob3.display();
        }
    }
}
