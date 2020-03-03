using System;
using System.Threading;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Traffic Light...");
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Red light - STOP!");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yellow light - PREPARE.");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Green light - GO!");
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.ReadLine();
        }
    }
}
