using System;

namespace Batch34_day5
{
    class Employee
    {
        string name, email, bloodgrp;
        int empid;
        float sal;

        public void getdata()
        {
            Console.WriteLine("Enter name =");
            name = Console.ReadLine();
            Console.WriteLine("Enter email =");
            email = Console.ReadLine();
            Console.WriteLine("Enter bloodgrp =");
            bloodgrp = Console.ReadLine();
            Console.WriteLine("Enter empid =");
            empid =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter salary =");
            sal = float.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("____________________________________________");
            Console.WriteLine("EMPID             :"+empid);
            Console.WriteLine("EMPNAME           :" + name);
            Console.WriteLine("EMAIL             :" + email);
            Console.WriteLine("SALARY            :" + sal);
            Console.WriteLine("BLOODGRP          :" + bloodgrp);
        }
    }
}
