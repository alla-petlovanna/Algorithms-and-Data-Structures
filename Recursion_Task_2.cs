using System;

namespace Lab_2_2
{
	class Program
	{
		/*
		   Task:
		   Implement a recursive algorithm for calculating 10 Fibonacci numbers
		*/
		public static int Fibonachi(int number)
		{
			if (number == 0 || number == 1) return 1;
			return Fibonachi(number - 1) + Fibonachi(number - 2);
		}
		public static void Main(string[] args)
		{
			int n = Fibonachi(10);
			Console.WriteLine($"Fibonachi number = {n}");
			Console.ReadKey();
		}
	}
}
