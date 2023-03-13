using System;
namespace blazorchess.Shared
{
	public class Pawn : ChessPiece
	{
		string color;

		public Pawn(string setColor):base(setColor)
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
            return ("./images/p" + colorchar + ".svg");
        }
    }
}

