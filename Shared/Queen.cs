using System;
namespace blazorchess.Shared
{
	public class Queen : ChessPiece
	{
		new string color;

		public Queen(string setColor) : base(setColor)
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
            return ("./images/" + theme + "/" + colorchar + "Q.svg");
        }
    }
}

