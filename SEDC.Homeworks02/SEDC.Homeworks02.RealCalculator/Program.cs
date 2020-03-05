using System;

namespace SEDC.Homeworks02.RealCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the first number...");
			int x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Type the second number...");
			int y = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the operator");
			string z = Console.ReadLine();

			switch (z)
			{
				case "+":
					Console.WriteLine("Answer: " + (x + y));
					break;
				case "-":
					Console.WriteLine("Answer: " + (x - y));
					break;
				case "*":
					Console.WriteLine("Answer: " + (x * y));
					break;
				case "/":
					Console.WriteLine("Answer: " + (x / y));
					break;
				default:
					Console.WriteLine("Enter a valid operator (+,-,*,/)");
					break;

			}
			Console.ReadLine();
		}
	}
}
