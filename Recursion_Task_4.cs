using System;

namespace Lab_2_4
{
	class Program
	{
		static void ReverseString(char[] str, int number)
		{
			Console.Write(str[number]);
			if (number > 0) ReverseString(str, number - 1);
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a line:");
			string str = Console.ReadLine();
			char[] mass = str.ToCharArray();
			ReverseString(mass, str.Length - 1);
			Console.ReadKey();
		}
	}
}
