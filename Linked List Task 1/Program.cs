using System;
using System.Collections.Generic;

namespace Lab_3_1
{
	class Program
	{
		static void Main(string[] args)
		{
            /*
              Task:
              Implement List <T> to store a collection of Animal objects.
              Implement filling the collection with objects using the Add method. Sort collection items by weight.
              Calculate the capacity of the collection and the number of items added.
              Set the capacity to an equal number of items using the TrimExcess method.
              Search the collection of Animal objects to find the cat. Remove this item from the list.
              Convert the list to an array using the ToArray method. 
              Display the results on the console. 
            */
            List<Animal> list = new List<Animal>();
            list.Add(new Animal("panda", 70));
            list.Add(new Animal("hippo", 1500));
            list.Add(new Animal("elephant", 4000));
            list.Add(new Animal("whale", 80000));
            list.Add(new Animal("cat", 4));

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine($"[{i}] The name of the animal = {list[i].Name}, weight = {list[i].Weight}");
            Console.WriteLine();
            list.Sort();
            Console.WriteLine("Sorted list:");
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine($"[{i}] The name of the animal = {list[i].Name}, weight = {list[i].Weight}");

            Console.WriteLine();
            Console.WriteLine($"Number of added elements = {list.Count}");
            Console.WriteLine($"Capacity = {list.Capacity}");

            list.TrimExcess();

            Console.WriteLine($"Number of added elements = {list.Count}");
            Console.WriteLine($"Capacity = {list.Capacity}");
            Console.WriteLine();

            if (list.Contains(new Animal { Name = "cat", Weight = 0 }))

                list.Remove(new Animal { Name = "cat", Weight = 0 });

            else
                list.Add(new Animal("cat", 4));

            Animal found = list.Find(item => item.Name == "whale");
            Console.WriteLine($"Found: {found.Name}, {found.Weight}");

            Console.WriteLine();
            foreach (var it in list.ToArray())
                Console.WriteLine($"The name of the animal = {it.Name}, weight = {it.Weight}");
            Console.ReadKey();
        }
    }
}
