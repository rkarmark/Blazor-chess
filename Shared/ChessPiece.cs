using System;
namespace blazorchess.Shared
{
	public abstract class ChessPiece
	{
		public string color;
		public ChessPiece(string setColor)
		{
			color = setColor;
		}

		public abstract string getImage(string theme);
		
		
	}
}

