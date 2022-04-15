using System;

namespace Lab_2_5
{
	class Program
	{
		/*
		   Task:
		   A simple text compression algorithm is based on replacing repetitive letters with one letter and the number of repeating letters. 
		   Compress the input line.
		*/
		static string ConvertStr(string str, int pos, char c, int k, string str2)
		{
			if (pos < str.Length)
			{
				if (pos == 0) 
					return ConvertStr(str, pos + 1, str[pos], 1, str2);
				else
				{
					if (str[pos] == c) 
						return ConvertStr(str, pos + 1, str[pos], k + 1, str2);
					else
					{
						if (k == 1)
							str2 = str2 + c.ToString();
						else
							str2 = str2 + k.ToString() + c.ToString(); // str2 = str2 + "AAA" = str2 + "3A"
						return ConvertStr(str, pos + 1, str[pos], 1, str2);
					}
				}
			}
			else
			{
				if (k == 1)
					str2 = str2 + c.ToString();
				else
					str2 = str2 + k.ToString() + c.ToString();
				return str2; 
			}
		}
		static void Main(string[] args)
		{
			string resStr;
			string str2 = "";
			Console.WriteLine("1) AAABCCCCAADDDD\n2) ACDDVFFSA\n3) +++---;;;zzxkf\n");
			Console.WriteLine("Результати:");
			string str = "AAABCCCCAADDDD";
			resStr = ConvertStr(str, 0, ' ', 0, str2); // resStr = "3AB4C2A4D"
			Console.WriteLine(resStr);
			resStr = ConvertStr("ACDDVFFSA", 0, '+', 0, ""); // resStr = "AC2DV2FSA"
			Console.WriteLine(resStr);
			resStr = ConvertStr("+++---;;;zzxkf", 0, '+', 0, ""); // resStr = "3+3-3;2zxkf"
			Console.WriteLine(resStr);
			Console.ReadKey();
		}
	}
}
