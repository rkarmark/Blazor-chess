using System;
namespace blazor_chess
{
    //Samme bolierplate som ved de andre klasser
    public class King : ChessPiece
    {
        new string color;

        public King(string setColor) : base(setColor)
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

        //Logikken her er meget simpel. Den tjekker om det er indenfor en radius af 1 felt, og om feltet er tomt eller ej.
        public override bool isMoveLegal(int x0, int y0, int x, int y, Field[,] fields)
        {
            if (Math.Abs(x - x0) <= 1 && Math.Abs(y - y0) <= 1 && fields[x, y].piece?.color != color)
            {
                return true;
            }
            return false;
        }
    }
}

