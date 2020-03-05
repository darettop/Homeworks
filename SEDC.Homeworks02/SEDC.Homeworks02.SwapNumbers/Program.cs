using System;

namespace SEDC.Homeworks02.SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region WithTemporaryVariable
            int number1, number2, temporary;
            Console.Write("Input the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Input the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            temporary = number1;
            number1 = number2;
            number2 = temporary;
            Console.Write("First Number: " + number1);
            Console.Write(" Second Number: " + number2);
            #endregion

            #region WithoutTemporaryVariable
            Console.WriteLine("\n\nNow the same just without a temporary variable!");
            int nNumber1, nNumber2;
            Console.Write("Input the First Number : ");
            nNumber1 = int.Parse(Console.ReadLine());
            Console.Write("Input the Second Number : ");
            nNumber2 = int.Parse(Console.ReadLine());
            nNumber1 = nNumber1 * nNumber2;
            nNumber2 = nNumber1 / nNumber2;
            nNumber1 = nNumber1 / nNumber2;   
            Console.Write("Frist Number: " + nNumber1 + " Sedond Number: " + nNumber2);
            #endregion
            Console.ReadLine();

        }
    }
}
