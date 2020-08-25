using System;

namespace Demo.Controller
{
    public static class Lib
    {
        public static void CondoleString(string Str, string Type)
        {
            Console.WriteLine($"\n{Type}：");
            Console.WriteLine(Str);
        }

        public static void CondoleObj(string Str)
        {
            Console.WriteLine("\nObj命名空間：");
            Console.WriteLine(Str);
        }
    }
}
