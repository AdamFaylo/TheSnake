using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
namespace Hello_Word
{
	class Program
	{
	
		static void Main(string[] args)
		{
			int num = 5;
			for (int i = 0; i <= num; i++)
			{
				for (int j = 0; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine("");
			}
	
			Console.ReadKey();	
		}
	}
}