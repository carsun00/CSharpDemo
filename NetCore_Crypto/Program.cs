using Crypto.Controller;
using System;

namespace Crypto
{
    class Program
    {
        static void Main(string[] args)
        {
            Des des = new Des();
            des.Display("Test Message.");
            Console.WriteLine("Hello World!");
        }
    }
}
