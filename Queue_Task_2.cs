using System;
using System.Collections.Generic;

namespace Lab_4_5
{
	class Car
	{
		public string Name;
		public Car(string name) => (Name) = (name);
	}
	class Program
	{
		static void Main(string[] args)
		{
      /*
        Task:
        Create a queue of objects of class Car. 
        Implement queuing operations: add, sort, delete. 
        Add a Peugeot car to the queue. Display queue items on the console.
      */
			Queue<Car> cars = new Queue<Car>();
			cars.Enqueue(new Car("Volkswagen"));
			cars.Enqueue(new Car("Renault"));
			cars.Enqueue(new Car("KIA"));
			cars.Enqueue(new Car("Hyundai"));
			cars.Enqueue(new Car("Lexus"));
			cars.Enqueue(new Car("Ford"));

			Console.WriteLine("The whole queue:");
			foreach (var c in cars) Console.WriteLine(c.Name);
			Console.WriteLine();

			Console.WriteLine("Enter the name of the car you want to add:");
			string newCar = Console.ReadLine();
			cars.Enqueue(new Car(newCar));
			Console.WriteLine("\nThe queue after adding the car:");
			foreach (var c in cars) Console.WriteLine(c.Name);
			Console.WriteLine();

			cars.Dequeue();
			Console.WriteLine("The queue after removing one car:");
			foreach (var c in cars) Console.WriteLine(c.Name);

			Console.ReadKey();
		}
	}
}
