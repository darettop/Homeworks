using System;

namespace SEDC.Homeworks03.Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = new int[5];
            Console.WriteLine("Enter a number: ");
            integerArray[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            integerArray[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            integerArray[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            integerArray[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            integerArray[4] = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < integerArray.Length; i++)
            {
                sum += integerArray[i];
            }
            Console.WriteLine("The sum of all the numbers in the array is: " + sum);

            Console.ReadLine();
        }
    }
}
