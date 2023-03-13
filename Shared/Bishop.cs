using System;
namespace blazorchess.Shared
{
	public class Bishop : ChessPiece
	{
		string color;

		public Bishop(string setColor) : base(setColor)
        {
            color = setColor;
        }

		public override string getImage()
		{
			string colorchar = "";
			switch (color)
			{
				case "White":
					colorchar = "l";
					break;
				case "Black":
					colorchar = "d";
					break;
			}
			return ("./images/b" + colorchar + ".svg");
        }
	}
}

