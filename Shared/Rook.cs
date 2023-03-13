using System;
using System.Drawing;

namespace blazorchess.Shared
{
	public class Rook : ChessPiece
	{
        new string color;

		public Rook(string setColor) : base(setColor)
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
            return ("./images/r" + colorchar + ".svg");
        }
    }
}

