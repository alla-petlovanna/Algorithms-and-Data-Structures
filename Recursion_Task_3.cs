using System;

namespace Lab_2_3
{
	class Program
	{
		/*
		   Task:
		   Implement a recursive algorithm for calculating the product of numbers from 1 to 50.
		*/
		static double Pr(double n)
		{
			if (n <= 1) return 1; //base case
			else return n * Pr(n - 1); //recursive case
		}
		static void Main(string[] args)
		{
			double pr = Pr(50);
			Console.WriteLine($"Pr = {pr}");
			Console.ReadKey();
		}
	}
}
