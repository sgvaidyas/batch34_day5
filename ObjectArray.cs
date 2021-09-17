using System;

namespace Batch34_day5
{
    class Person
    {
        string name;
        int identity;
        public static int count;
        public Person()
        {
            Console.WriteLine("Enter name & identity");
            name = Console.ReadLine();
            identity = Convert.ToInt32(Console.ReadLine());
            count++;
        }
        static Person()
        {
            count = 0;
        }
        public void display()
        {
            Console.WriteLine("NAME       = " +name);
            Console.WriteLine("IDENTITY   = " + identity);
            Console.WriteLine("COUNT      = " + count);
        }
    }
    class ObjectArray
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine(Person.count);
            Person ob = new Person();
            Person ob1 = new Person();
            ob.display();
            ob1.display();
            */
            int n;
            Console.WriteLine("Enter the num of objects");
            n = Convert.ToInt32(Console.ReadLine());

            Person[] ob = new Person[n];

            for(int i=0;i<n;i++)
            {
                ob[i] = new Person();
            }
            Console.WriteLine("\n The records are");
            for (int i = 0; i < n; i++)
            {
                ob[i].display();
            }
        }
    }
}
