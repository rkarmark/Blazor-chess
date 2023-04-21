using System;
namespace blazor_chess
{
    //Samme boilderplate, læs bishop.cs for at få info om dette
    public class Knight : ChessPiece
    {
        new string color;

        public Knight(string setColor) : base(setColor)
        {
            color = setColor;
        }

        public override string getType()
        {
            return "Knight";
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

        //Springeren har sjov logik. Men der er to muligheder. Enten skal den flytte sig 2 felter på x og 1 felt på y, eller 1 på x og 2 på y.
        public override bool isMoveLegal(int x0, int y0, int x, int y, Field[,] fields)
        {
            if (Math.Abs(x - x0) == 2 && Math.Abs(y - y0) == 1 || Math.Abs(x - x0) == 1 && Math.Abs(y - y0) == 2)
            {
                return true;
            }
            return false;
        }
    }
}

