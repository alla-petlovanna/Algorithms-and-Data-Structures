using System;
using System.Collections.Generic;

namespace Lab_4_4
{
	class Program
	{
		static void Main(string[] args)
		{
            /*
              Task:
              Create a queue of text messages (10 messages). 
              Implement queuing operations: add, sort, delete. Display queue elements on the console.
            */
            Queue<string> fruits = new Queue<string>();
            fruits.Enqueue("coconut");
            fruits.Enqueue("banana");
            fruits.Enqueue("orange");
            fruits.Enqueue("pineapple");
            fruits.Enqueue("tangerine");
            fruits.Enqueue("pear");
            fruits.Enqueue("peach");
            fruits.Enqueue("plum");
            fruits.Enqueue("apricot");
            fruits.Enqueue("kiwi");

            Console.WriteLine("The whole queue:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("\nEnter the name of the fruit you want to add:");
            string newFruit = Console.ReadLine();
            fruits.Enqueue(newFruit);
            Console.WriteLine("\nThe queue after adding the fruit:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("\nThe queue after removing one fruit:");
            fruits.Dequeue();
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.ReadKey();
        }
    }
}
