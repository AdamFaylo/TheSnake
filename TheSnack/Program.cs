using snack_2;
using System;
using System.Diagnostics.Metrics;
using TheSnack;
using System.Globalization;

namespace MyApp
{
	internal class Program
	{

		static void Main(string[] args)
		{
			int newGame = 1;
			int x = 1;
		
			while (newGame < 10)
			{
				Functions myFuncs = new Functions();
				Shapes shapes = new Shapes();
				Console.Clear();
				Random rnd = new();
				bool flag = true;
				myFuncs.PrintBoard();
				 myFuncs.CounterMove=x;
				Console.SetWindowSize(81, 28);
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine($"Your Level :{newGame} Counter {myFuncs.CounterMove}");

				for (int i = 0; i < newGame + 4; i++)//כמות 
				{
					switch (rnd.Next(0, 4))//רנדומליט  אובייקטים
					{
						case 0:
							shapes.Printtriangular1(myFuncs.array);
							break;
						case 1:
							shapes.PrintLine(myFuncs.array);
							break;
						case 2:
							shapes.PrintSqr(myFuncs.array);
							break;
						case 3:
							shapes.PrintRectangle(myFuncs.array);
							break;
					}
				}
				while (flag == true)
				{
					var key = Console.ReadKey();
					switch (key.Key)
					{
						case ConsoleKey.UpArrow:
							myFuncs.CheckMoveUp();
							myFuncs.MoveUp();
							break;
						case ConsoleKey.DownArrow:
							myFuncs.CheckMoveDown();
							myFuncs.MoveDown();
							break;
						case ConsoleKey.RightArrow:
							myFuncs.CheckMoveRight();
							myFuncs.MoveRight();
							break;
						case ConsoleKey.LeftArrow:
							myFuncs.CheckMoveLeft();
							myFuncs.MoveLeft();
							break;
						case ConsoleKey.F1:
							Console.Clear();
							Console.SetCursorPosition(40,10);
							Console.WriteLine("End Game");
							break;
					}
					myFuncs.CheckGame(ref flag);
					myFuncs.ClearCurrentConsoleLine();
					Console.WriteLine($"Your Level :{newGame} Counter {myFuncs.CounterMove}");
				}
				x = myFuncs.CounterMove;
				newGame++;
				
			}
				Console.Clear();

		}
	}
}
