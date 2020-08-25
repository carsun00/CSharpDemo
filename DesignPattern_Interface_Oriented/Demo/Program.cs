using Demo.Controller;
using System;

namespace Demo
{
    class Program
    {
     
        static void Main(string[] args)
        {
            InterfaceDemo Demo = new InterfaceDemo();
            Demo.Display();
            Console.WriteLine("Hello World!");
            Console.ReadKey();

        }
    }
}
