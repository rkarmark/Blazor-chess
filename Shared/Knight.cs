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
            return ("./images/" + theme + "/" + colorchar + "N.svg");
        }
    }
}

