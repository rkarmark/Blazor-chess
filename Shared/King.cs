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
    }
}

