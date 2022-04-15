using System;
using System.Collections.Generic;

namespace Lab_3_3
{
	class Program
	{
		static void Main(string[] args)
		{
            /*
              Task:
              Create a class hierarchy and populate two List<> with derived class objects. Display list items on the console.
            */
            List<A> list1 = new List<A>();
            List<A> list2 = new List<A>();
            Random rand = new Random();

            for (int i = 0; i < 10; i++) list1.Add(new A());
            for (int i = 0; i < 10; i++)
            {
                switch (rand.Next(1, 4))
                {
                    case 1: list2.Add(new B()); break;
                    case 2: list2.Add(new C()); break;
                    case 3: list2.Add(new D()); break;
                }
            }
            Console.WriteLine($"List 1 | List 2");
            for (int i = 0; i < 10; i++)
            {
                if (list1[i] is D) Console.Write("   " + $"D" + "   |");
                else if (list1[i] is B) Console.Write("   " + $"B" + "   |");
                else if (list1[i] is C) Console.Write("   " + $"C" + "   |");
                else Console.Write("   " + $"A" + "   |");

                if (list2[i] is D) Console.WriteLine("   " + $"D");
                else if (list2[i] is B) Console.WriteLine("   " + $"B");
                else if (list2[i] is C) Console.WriteLine("   " + $"C");
                else Console.WriteLine("   " + $"A");
            }
            Console.ReadKey();
        }
    }

    class A { }
    class B : A { }
    class C : A { }
    class D : C { }
}
