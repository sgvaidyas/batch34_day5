using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day5
{
    class Student
    {
        string usn, name;
        int age;
        float percent;

        public void getdata()
        {
            Console.WriteLine("Enter usn");
            usn = Console.ReadLine();
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter percent");
            percent = float.Parse(Console.ReadLine());

        }
        public void display()
        {
            Console.WriteLine("_________________________");
            Console.WriteLine("USN           ="+usn);
            Console.WriteLine("NAME          =" + name);
            Console.WriteLine("AGE           =" + age);
            Console.WriteLine("PERCENT       =" + percent);
        }

    }
    class StudentDetails
    {
        static void Main(string[] args)
        {
            Student ob = new Student();
            ob.getdata();
            ob.display();
        }
    }
}
