using System;

namespace DarkoPetrov.Tasks.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int enteredNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= enteredNumber; i++)
            {
                if (i % 3 == 0 && i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
