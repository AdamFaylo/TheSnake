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
			List<Position> Position = new List<Position>();

			Position tempPosition = new Position();
			tempPosition.y = 25;
			tempPosition.x = 50;
			Position.Add(tempPosition);


			for (int i = 0; i <= 5; i++)
			{
				foreach (Position item in Position)
				{


					Console.SetCursorPosition(item.x, item.y);
					Console.Write("*");


				}
			}

		}
	}
}
class Position
{
	public int x;
	public int y;
}