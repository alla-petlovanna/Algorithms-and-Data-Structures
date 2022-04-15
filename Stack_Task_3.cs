using System;
using System.Collections.Generic;

namespace Lab_4_3
{
	class Program
	{
		static void Main(string[] args)
		{
      /*
        Task:
        Write a program that fills a stack of an array of 10 integers and outputs them in reverse order.
      */
			int[] arr = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
			Stack<int> numbers = new Stack<int>();

			foreach (var n in arr) numbers.Push(n);
			foreach (var n in numbers) Console.Write(n + " ");

			Console.ReadKey();
		}
	}
}
