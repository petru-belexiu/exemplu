using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = System.IO.File.ReadAllText("name.txt");
            Console.WriteLine("Bye {0}", name);
            Console.ReadKey();
        }
    }
}