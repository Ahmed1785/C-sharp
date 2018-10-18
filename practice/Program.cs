using System;
using ConsoleApplication;

namespace practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human myHuman = new Human("Ahmed", 10);
            Console.WriteLine(myHuman.damage);
        }
    }
}
