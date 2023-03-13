using System;
namespace blazorchess.Shared
{
	public abstract class ChessPiece
	{
		string color;
		public ChessPiece(string setColor)
		{
			color = setColor;
		}

		public abstract string getImage();
		
		
	}
}

