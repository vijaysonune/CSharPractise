using System;
using System.Collections;
using System.Collections.Generic;

namespace ReplaceStringApp
{
    class Program
    {

		public static void Main()
		{
			//int readonly val=56;

			Console.WriteLine("Enter string 1");
			string str1 = "How are you?"; //Console.ReadLine();
			Console.WriteLine("Enter string 2");
			string str2 = "are";//Console.ReadLine();
			Console.WriteLine("Enter string 3");
			string str3 = "abc1234";//Console.ReadLine();
			Console.WriteLine(Replace(str1, str2, str3));
			Console.ReadLine();

		}

		static string Replace(string str1, string str2, string str3)
		{
			string[] stringList = str1.Split(' ');
			

			for(int i=0;i< stringList.Length;i++)
			{
				if (stringList[i] == str2)
				{
					stringList[i] = str3;
				}
			}

			string combindedString = string.Join(" ", stringList);

			return combindedString;
		}

	}
}
