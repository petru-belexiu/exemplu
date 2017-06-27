using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hi {0}", name);
            Console.ReadKey();
        }
    }
}