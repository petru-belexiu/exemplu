using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine("Bye {0}", name);
            Console.ReadKey();
        }
    }
}