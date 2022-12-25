using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace snack_2
{
	internal class Shapes
	{
		bool canPlace = true;
		Random rnd = new Random();
		public int pos1, pos2, sqr, triangular, h, w;
		int line;

		public Shapes()
		{
			pos1 = rnd.Next(2, 26);
			pos2 = rnd.Next(2, 80);
			line = rnd.Next(2, 11);
			sqr = rnd.Next(3, 11);
			h = rnd.Next(3, 11);
			w = rnd.Next(3, 11);
			triangular = rnd.Next(2, 10);
		}
		public void Printtriangular1(char[,] arr)
		{
			int colorIndex = rnd.Next(0, 16);
			ConsoleColor randomColor = (ConsoleColor)colorIndex;
			Console.ForegroundColor = randomColor;

			bool canPlace = true;
			do
			{
				canPlace = true;

				do
				{
					pos2 = rnd.Next(2, 80);
				}
				while ((pos2 + triangular > 80));
				do
				{
					pos1 = rnd.Next(2, 26);
				}
				while (pos1 + triangular > 25);


				for (int i = 0; i < triangular; i++)
				{
					for (int j = 0; j <= i; j++)
					{
						if (arr[pos1 + j, pos2 + i] != ' ')
						{
							canPlace = false;
							break;
						}
					}
					if (!canPlace) { break; }
				}

			} while (!canPlace);


			for (int i = 0; i < triangular; i++)
			{
				for (int j = 0; j <= i; j++)
				{


					arr[pos1 + j, pos2 + i] = '#';
					Console.SetCursorPosition(pos2 + i, pos1 + j);
					Console.Write(arr[pos1 + j, pos2 + i]);
				}
			}
		}
		public void PrintLine(char[,] arr)
		{
			int colorIndex = rnd.Next(0, 16);
			ConsoleColor randomColor = (ConsoleColor)colorIndex;
			Console.ForegroundColor = randomColor;

			

			do
			{
				canPlace = true;
				pos2 = rnd.Next(2, 80 - line);
				pos1 = rnd.Next(2, 25);
			

				for (int i = 0; i < line; i++)
				{
					if (arr[pos1, pos2 + i] != ' ')
					{
						canPlace = false;
						break;
					}
				}
				if (!canPlace) { break; }


			} while (!canPlace);

			for (int i = 0; i < line; i++)
			{
				arr[pos1, pos2 + i] = '=';
				Console.SetCursorPosition(pos2 + i, pos1);
				Console.Write(arr[pos1, pos2 + i]);
			}
		}
		public void PrintSqr(char[,] arr)
		{
			int colorIndex = rnd.Next(0, 16);
			ConsoleColor randomColor = (ConsoleColor)colorIndex;
			Console.ForegroundColor = randomColor;


			bool canPlace = true;
			do
			{
				canPlace = true;

				do
				{
					pos2 = rnd.Next(2, 80);
				}
				while ((pos2 + triangular > 80));
				do
				{
					pos1 = rnd.Next(2, 26);
				}
				while (pos1 + triangular > 25);


				for (int i = 0; i < sqr; i++)
				{
					for (int j = 0; j <= i; j++)
					{
						if (arr[pos1 + j, pos2 + i] != ' ')
						{
							canPlace = false;
							break;
						}
					}
					if (!canPlace) { break; }
				}

			} while (!canPlace);

			for (int i = 0; i < sqr; i++)
			{
				for (int j = 0; j < sqr; j++)
				{
					arr[pos1 + j, pos2 + i] = 'ם';
					Console.SetCursorPosition(pos2 + i, pos1 + j);
					Console.Write(arr[pos1 + j, pos2 + i]);
				}

			}
		}
		public void PrintRectangle(char[,] arr)
		{
			int colorIndex = rnd.Next(0, 16);
			ConsoleColor randomColor = (ConsoleColor)colorIndex;
			Console.ForegroundColor = randomColor;

			bool canPlace = true;
			do
			{
				canPlace = true;

				do
				{
					pos2 = rnd.Next(2, 78);
				}
				while ((pos2 + triangular > 80));
				do
				{
					pos1 = rnd.Next(2, 26);
				}
				while (pos1 + triangular > 25);


				for (int i = 0; i < h; i++)
				{
					for (int j = 0; j < w; j++)
					{
						if (arr[pos1 + j, pos2 + i] != ' ')
						{
							canPlace = false;
							break;
						}
					}
					if (!canPlace) { break; }
				}

			} while (!canPlace);

			for (int i = 0; i < h; i++)
			{
				for (int j = 0; j < w; j++)
				{
					arr[pos1 + j, pos2 + i] = 'x';
					Console.SetCursorPosition(pos2 + i, pos1 + j);
					Console.Write(arr[pos1 + j, pos2 + i]);
				}

			}
		}
	}
}

