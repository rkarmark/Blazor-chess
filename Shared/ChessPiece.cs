using System;
namespace blazor_chess
{
	public abstract class ChessPiece
	{
		public string color;
		public bool firstMove = true;
		public ChessPiece(string setColor)
		{
			color = setColor;
		}

		public abstract string getImage(string theme);
		public abstract Boolean isMoveLegal(int x0, int y0, int x, int y,string?[,] colors);
	}
}

