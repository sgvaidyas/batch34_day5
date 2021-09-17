using System;

namespace Batch34_day5
{
    static class MyStatic
    {
        public static int x = 100;
        public static float pi = 3.142f;

    }
    class StaticClassEx
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyStatic.x);
            MyStatic.x = 999;
            Console.WriteLine(MyStatic.x);
            Console.WriteLine(MyStatic.pi);
        }
    }
}
