using System;
using System.IO;
using System.Collections.Generic;

namespace Lab_4_1
{
	class Program
	{
		static void Main(string[] args)
		{
            /*
              Task:
              Stack <T>. The text file contains a mathematical expression. You need to check the balance of parentheses in the expression:
              (a+2)-4*(a-3)/(2-7+6)
            */
            char[] charsMass;
            using (StreamReader sr = new StreamReader("../../../text.txt"))
            {
                charsMass = sr.ReadToEnd().ToCharArray();
            }

            Stack<char> chars = new Stack<char>();
            for (int i = 0; i < charsMass.Length; i++) chars.Push(charsMass[i]);

            int a = 0, b = 0, c = chars.Count;
            for (int i = 0; i < c; i++)
            {
                char ch = chars.Pop();
                if (ch == '(') a++;
                if (ch == ')') b++;
            }

            if (a == b) Console.WriteLine("Balanced");
            else Console.WriteLine("Not balanced");

            Console.ReadKey();
        }
    }
}
