using System;

namespace DarkoPetrov.Tasks.Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                int productOfDigits = 1;
                int numberKeeper = i;
                while (numberKeeper != 0)
                {
                    productOfDigits *= numberKeeper % 10;
                    numberKeeper /= 10;
                }
                if (i % productOfDigits == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
