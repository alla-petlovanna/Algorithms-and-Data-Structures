using System;
using System.Collections.Generic;

namespace Lab_4_2
{
	class Program
	{
		static void Main(string[] args)
		{
            /*
              Task:
              Create a stack of 10 lines with fruit names. Implement operations with this stack: add, sort, delete items. 
              Add to the stack fruits named Cherry and Apple. Check if the Apple is on the stack without removing it. 
              Convert the stack to an array and sort its elements.
            */
            Stack<string> fruits = new Stack<string>();
            fruits.Push("coconut");
            fruits.Push("banana");
            fruits.Push("orange");
            fruits.Push("pineapple");
            fruits.Push("tangerine");
            fruits.Push("pear");
            fruits.Push("peach");
            fruits.Push("plum");
            fruits.Push("apricot");
            fruits.Push("kiwi");

            Console.WriteLine("Stack:");
            foreach (string fruit in fruits) Console.Write(fruit + " ");
            Console.WriteLine("\n");

            Console.WriteLine("Deleting an element:");
            fruits.Pop();
            foreach (string fruit in fruits) Console.Write(fruit + " ");
            Console.WriteLine("\n");

            fruits.Push("cherry");
            fruits.Push("apple");
            Console.WriteLine("Added:");
            Console.WriteLine(fruits.Peek());
            Console.WriteLine();
            
            var arr = fruits.ToArray();
            Array.Sort(arr);
            foreach (string fruit in arr) Console.Write(fruit + " ");

            Console.ReadKey();
        }
	}
}
