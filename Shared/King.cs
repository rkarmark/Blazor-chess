using System;
namespace blazorchess.Shared
{
	public class King : ChessPiece
	{
        new string color;

		public King(string setColor):base(setColor)
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
            return ("./images/k" + colorchar + ".svg");
        }
    }
}

