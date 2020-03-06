using System;

namespace SEDC.Homeworks02.Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a number between one and three: ");
            number = int.Parse(Console.ReadLine());
            switch(number)
            {
                case 1:
                   Console.WriteLine("You got a new car!");
                   break;
                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
               }
            Console.ReadLine();
        }
    }
}
