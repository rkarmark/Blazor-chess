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

        public override string getImage(string theme)
        {
            string colorchar = "";
            switch (color)
            {
                case "White":
                    colorchar = "w";
                    break;
                case "Black":
                    colorchar = "b";
                    break;
            }
            return ("./images/" + theme + "/" + colorchar + "R.svg");
        }
    }
}

