using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TheSnack
{
	internal class Functions
	{
		public int col = 80, row = 25;
		public char[,] array = new char[26, 81];//the array
		public int xValue;
		public int yValue;
		int loss;
		public int CounterMove { get; set; }
		public Functions(int counterMove)
		{
			CounterMove = counterMove;
		}
		public Functions()
		{
			Random rnd = new Random();
			xValue = rnd.Next(1, 81);
			yValue = rnd.Next(1, 26);
		}
		public void ClearCurrentConsoleLine()
		{
			Console.SetCursorPosition(0, 26);
			Console.Write(new string(' ', Console.WindowWidth));
			Console.SetCursorPosition(0, Console.CursorTop);
		}
		public void PrintBoard()//  הלוח
		{
			for (int i = 0; i < 25; i++)//char=' '
			{
				for (int j = 0; j < 81; j++)
				{
					array[i, j] = ' ';
				
				}
			}
			for (int i = 0; i < 26; i++)//limits
			{
				array[i, 0] = '+';
				array[i, 80] = '+';
				for (int j = 0; j < 81; j++)
				{
					array[0, j] = '+';
					array[25, j] = '+';
					//Console.ForegroundColor = ConsoleColor.Black;
					Console.Write(array[i, j]);
				}
				Console.WriteLine();
			}
		}
		public void MoveUp()
		{
			if (yValue <= 1)
			{
				yValue = 1;
			}
			else
			{
				Console.SetCursorPosition(xValue, yValue);
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("*");
				yValue--;
				CounterMove++;
			}
			Console.SetCursorPosition(xValue, yValue);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("*");
			array[yValue, xValue] = '*';
		}//יכולת לנוע למעלה 
		public void MoveDown()
		{
			if (yValue >= 24)
			{
				yValue = 24;
			}
			else
			{
				Console.SetCursorPosition(xValue, yValue);
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("*");
				yValue++;
				CounterMove++;
			}
			Console.SetCursorPosition(xValue, yValue);
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("*");
			array[yValue, xValue] = '*';
		} //יכולת לנוע למטה
		public void MoveRight()
		{
			if (xValue >= 78)
			{
				xValue = 78;
			}
			else
			{
				Console.SetCursorPosition(xValue, yValue);
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("*");
				xValue++;
				CounterMove++;

			}

			Console.SetCursorPosition(xValue, yValue);
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("*");
			array[yValue, xValue] = '*';
		} //יכולת לנוע ימינה
		public void MoveLeft()
		{
			if (xValue == 2)
			{
				xValue = 2;

			}
			else
			{
				Console.SetCursorPosition(xValue, yValue);
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("*");
				xValue--;
				CounterMove++;

			}
			Console.SetCursorPosition(xValue, yValue);
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("*");
			array[yValue, xValue] = '*';
		} //יכולת לנוע שמאלה
		public void CheckGame(ref bool flag)
		{
			if (loss > 0)
			{
				flag = false;
			}
		}
		public void CheckMoveUp()
		{
			if (array[yValue - 1, xValue] != ' ' && array[yValue - 1, xValue] != '+')
			{
				loss++;
			}
		}
		public void CheckMoveDown()
		{
			if (array[yValue + 1, xValue] != ' ' && array[yValue + 1, xValue] != '+')
			{
				loss++;
			}
		}
		public void CheckMoveRight()
		{
			if (array[yValue, xValue + 1] != ' ' && array[yValue + 1, xValue] != '+')
			{
				loss++;
			}
		}
		public void CheckMoveLeft()
		{
			if (array[yValue, xValue - 1] != ' ' && array[yValue - 1, xValue] != '+')
			{
				loss++;
			}
		}
		

	}
}


