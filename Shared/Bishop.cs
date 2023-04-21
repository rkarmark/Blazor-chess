using System;
namespace blazor_chess
{
    //Klasse til løberen, som er en child class af ChessPiece
    public class Bishop : ChessPiece
    {
        new string color;
        //Konstruktør arvet af chesspiece
        public Bishop(string setColor) : base(setColor)
        {
            color = setColor;
        }

        //Override af getImage, som returnerer stien til billedet af brikken
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
            return ("./images/" + theme + "/" + colorchar + "B.svg");
        }

        //Override af getType, som returnerer typen af brikken
        public override string getType()
        {
            return "Bishop";
        }

        //Override af isMoveLegal, som returnerer om et træk er lovligt
        public override bool isMoveLegal(int x0, int y0, int x, int y, Field[,] fields)
        {
            //For op til 7 gange i en retning så tjekker den om det er muligt at flytte til.
            for (int i = 1; i < 8; i++)
            {
                //Haspassed er en bool som bliver sat til true, hvis der er en brik i vejen for løberen. Det gør at man kan angribe en brik, men ikke kan forbigå den.
                bool hasPassed = false;
                //Der bruges try/catch, til når den prøver at tjekke et felt udenfor brættet. Hvis den prøver det, så går den ud af loopet, da der ikke er mere at lede efter.
                try
                {
                    //Hvis den har passeret et felt, så er der ikke noget det burde returnere true
                    if (!hasPassed)
                    {
                        //Tjekker om det er tomt
                        if (fields[x0 + i, y0 + i].piece == null)
                        {
                            //Tjekker om det er det felt vi vil flytte til
                            if (x0 + i == x && y0 + i == y)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            //Tjekker om det er samme farve
                            if (fields[x0 + i, y0 + i].piece?.color != color)
                            {
                                //Tjekker om det er det felt vi vil flytte til
                                if (x0 + i == x && y0 + i == y)
                                {
                                    return true;
                                }
                                //Ellers sætter den haspassed til true, så den ikke kan forbigå brikken
                                hasPassed = true;
                            }
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    break;
                }
            }

            //Gentagelse af samme kode i alle 4 retninger.
            for (int i = 1; i < 8; i++)
            {
                bool hasPassed = false;
                try
                {
                    if (!hasPassed)
                    {
                        if (fields[x0 + i, y0 - i].piece == null)
                        {
                            if (x0 + i == x && y0 - i == y)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            if (fields[x0 + i, y0 - i].piece?.color != color)
                            {
                                if (x0 + i == x && y0 - i == y)
                                {
                                    return true;
                                }
                                hasPassed = true;
                            }
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    break;
                }
            }

            for (int i = 1; i < 8; i++)
            {
                bool hasPassed = false;
                try
                {
                    if (!hasPassed)
                    {
                        if (fields[x0 - i, y0 + i].piece == null)
                        {
                            if (x0 - i == x && y0 + i == y)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            if (fields[x0 - i, y0 + i].piece?.color != color)
                            {
                                if (x0 - i == x && y0 + i == y)
                                {
                                    return true;
                                }
                                hasPassed = true;
                            }
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    break;
                }
            }

            for (int i = 1; i < 8; i++)
            {
                bool hasPassed = false;
                try
                {
                    if (!hasPassed)
                    {
                        if (fields[x0 - i, y0 - i].piece == null)
                        {
                            if (x0 - i == x && y0 - i == y)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            if (fields[x0 - i, y0 - i].piece?.color != color)
                            {
                                if (x0 - i == x && y0 - i == y)
                                {
                                    return true;
                                }
                                hasPassed = true;
                            }
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    break;
                }
            }

            return false;
        }
    }
}

