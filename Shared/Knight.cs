using System;
namespace blazor_chess
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
        public override bool isMoveLegal(int x0, int y0, int x, int y, string?[,] colors)
        {
            if (Math.Abs(x - x0) == 2 && Math.Abs(y - y0) == 1 || Math.Abs(x - x0) == 1 && Math.Abs(y - y0) == 2)
            {
                return true;
            }
            return false;
        }
    }
}

