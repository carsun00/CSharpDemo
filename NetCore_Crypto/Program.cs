using Crypto.Controller;
using System;

namespace Crypto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string Msg = "Test Message.";
            Console.WriteLine("Des");
            Des des = new Des();
            des.Display(Msg);

            Console.WriteLine("\nTripleDes");
            TripleDes tripleDes = new TripleDes();
            tripleDes.Display(Msg);

            Console.WriteLine("Des");
            Aes aes = new Aes();
            aes.Display(Msg);
            Console.WriteLine("Hello World!");
        }
    }
}
