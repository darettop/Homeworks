using System;

namespace DarkoPetrov.Tasks.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int enteredNumber = int.Parse(Console.ReadLine());
            for(int i = 1; i <= enteredNumber; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
