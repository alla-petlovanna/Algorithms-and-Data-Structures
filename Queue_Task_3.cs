using System;
using System.Collections.Generic;

namespace Lab_4_6
{
	class Program
	{
		static void Main(string[] args)
		{
      /*
        Task:
        Write a program that selects from an array and displays all positive numbers first, then all negative ones.
      */
			int[] array = { 8, -3, 2, -6, -11, 3, -12, -50 };
			Queue<int> queue = new Queue<int>();

			Console.WriteLine("All positive numbers:");
			foreach (var i in array) if (i > 0) queue.Enqueue(i);
			while (queue.Count > 0) Console.WriteLine(queue.Dequeue());
			
			Console.WriteLine("\nAll negative numbers:");
			foreach (var i in array) if (i < 0) queue.Enqueue(i);
			while (queue.Count > 0) Console.WriteLine(queue.Dequeue());

			Console.ReadKey();
		}
	}
}
