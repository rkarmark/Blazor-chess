using System;
namespace blazor_chess
{
	public class King : ChessPiece
	{
        new string color;

		public King(string setColor):base(setColor)
		{
			color = setColor;
		}

        public override string getType()
        {
            return "King";
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
            return ("./images/" + theme + "/" + colorchar + "K.svg");
        }
        public override bool isMoveLegal(int x0, int y0, int x, int y, string?[,] colors)
        {
            if (Math.Abs(x-x0) <= 1 && Math.Abs(y-y0)<=1 && colors[x,y] != color) {
                return true;
            }
            return false;
        }
    }
}

