using System;
public class SumExample
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 1000; i++)
        {
            int sumOfDigits = 0;
            int number = i;
            while (number != 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }
            if (i % sumOfDigits == 0)
            {
                Console.WriteLine(i);
            }
        }
        Console.ReadLine();
    }

}