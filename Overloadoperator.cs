using System;

namespace Batch34_day5
{
    class Candidate
    {
        string name;
        float per;

        public void getdata()
        {
            Console.WriteLine("Enter name & percent");
            name = Console.ReadLine();
            per = float.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("\nNAME     ="+name);
            Console.WriteLine("PERCENT  =" + per);
        }
        public static Candidate operator +(Candidate ob1,Candidate ob2)
        {
            Candidate res= new Candidate();
            res.per = ob1.per + ob2.per;
            res.name = "result";
            return res;
        }
        public static Candidate operator -(Candidate ob)
        {
            Candidate res = new Candidate();
            res.per = -ob.per;
            res.name = "Negative";
            return res;
        }
    }

    class Overloadoperator
    {
        static void Main(string[] args)
        {
            Candidate ob1 = new Candidate();
            Candidate ob2 = new Candidate();
            Candidate ob3;
            ob1.getdata();
            ob2.getdata();
            //operator+(ob1,ob2)
            ob3 = ob1 + ob2; 
            ob3.display();
            Candidate ob4 = -ob2;
            ob4.display();

        }
    }
}
