using System;
using System.Threading;

namespace rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello wanderer");
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("Welcome " + playerName);

            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A Demon is approaching! Defend yourself!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("= Starting Battle =");
            Console.WriteLine(playerName);
            Console.WriteLine();
            Console.WriteLine("vs.");
            Console.WriteLine();
        
        }
    }
}
