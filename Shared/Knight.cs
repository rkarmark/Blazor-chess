using System;
namespace blazorchess.Shared
{
	public class Knight : ChessPiece
	{
		new string color;

		public Knight(string setColor) : base(setColor)
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
            return ("./images/n" + colorchar + ".svg");
        }
    }
}

