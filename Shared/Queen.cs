using System;
namespace blazorchess.Shared
{
	public class Queen : ChessPiece
	{
		string color;

		public Queen(string setColor) : base(setColor)
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
            return ("./images/q" + colorchar + ".svg");
        }
    }
}

