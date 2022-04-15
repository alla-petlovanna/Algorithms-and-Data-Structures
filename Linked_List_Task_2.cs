using System;
using System.Collections.Generic;

namespace Lab_3_2
{
	class Program
	{
		static void Main(string[] args)
		{
            /*
              Task:
              Create a collection of lists List<string>, which contains a list of computer models. 
              Implement methods of adding, deleting, sorting, searching. Display the results on the console.
            */
            List<string> list = new List<string>();
            list.Add("Apple");
            list.Add("Xiaomi");
            list.Add("Asus");
            list.Add("Lenovo");

            for (int i = 0; i < list.Count; i++) Console.WriteLine($"[{i}] Name = {list[i]}");

            Console.WriteLine();
            list.Sort();
            for (int i = 0; i < list.Count; i++) Console.WriteLine($"[{i}] Name = {list[i]}");

            Console.WriteLine();
            list.Remove("Xiaomi");
            for (int i = 0; i < list.Count; i++) Console.WriteLine($"[{i}] Name = {list[i]}");

            Console.WriteLine();
            Console.WriteLine($"Number of added elements = {list.Count}");
            Console.WriteLine($"Capacity = {list.Capacity}");

            Console.WriteLine();
            string NameToFind = list.Find(item => item == "Apple");
            Console.WriteLine($"Found company = {NameToFind}");

            Console.WriteLine();
            foreach (var it in list.ToArray()) Console.WriteLine($"Name = {it}");
        }
    }
}
