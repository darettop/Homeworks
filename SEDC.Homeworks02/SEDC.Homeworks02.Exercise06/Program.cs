using System;

namespace SEDC.Homeworks02.Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter the First Number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2 ) {
                Console.WriteLine("The first number is larger than the second number");
                if (num1 % 2 == 0)
                    Console.WriteLine("The first number is even");
                else
                    Console.WriteLine("The first number is odd");
            }

            if (num2 > num1)
            {
                Console.WriteLine("The second number is larger than the first number");
                if (num2 % 2 == 0)
                    Console.WriteLine("The second number is even");
                else
                    Console.WriteLine("The second number is odd");
            }

            Console.ReadLine();
        }
    }
}
