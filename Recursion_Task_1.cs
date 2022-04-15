using System;

namespace Lab_2_1
{
	class Program
	{
		static void Row(int number)
		{
			double x = (number - 1) / F(number);
			Console.WriteLine($"n = {number}, x = {x}");
			if (number <= 1) return;
			Row(number - 1);
		}
		static double F(int number)
		{
			if (number <= 1) return 1; //base case
			else return number * F(number - 1); //recursive case
		}
		static void Main(string[] args)
		{
			Row(10);
			Console.ReadKey();
		}
	}
}
