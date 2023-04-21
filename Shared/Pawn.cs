using System;
namespace blazor_chess
{
    //Samme boilerplate
    public class Pawn : ChessPiece
    {
        new string color;

        public Pawn(string setColor) : base(setColor)
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
            return ("./images/" + theme + "/" + colorchar + "P.svg");
        }

        public override string getType()
        {
            return "Pawn";
        }

        //Den mest avancerede logik af alle brikker, da den opfører sig forskelligt alt efter om det er første gang den bliver flyttet eller ej, og efter hvilken farve den har.
        //Dette kan skrives meget mere kompakt, men det virker, og er relativt læsbart
        public override bool isMoveLegal(int x0, int y0, int x, int y, Field[,] fields)
        {
            //Logik til første træk
            if (moveCount == 0)
            {
                if (color == "White")
                {
                    //For loop til at flytte sig fremad.
                    for (int i = 1; i < 3; i++)
                    {
                        try
                        {
                            if (fields[x0 - i, y0].piece?.color == null)
                            {
                                if (x0 - i == x && y0 == y)
                                {

                                    return true;
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

                    //For loopet her er for at man har noget at "breake" ud af, hvis at man får en out of array. Der er bedre måder at gøre det på, men det er fuldt funktionelt, og i min experimentering har andet ikke virkert. 
                    for (int i = 1; i < 2; i++)
                    {
                        try
                        {
                            if (fields[x0 - i, y0 + 1].piece?.color == "Black")
                            {
                                if (x0 - i == x && y0 + 1 == y)
                                {

                                    return true;
                                }
                            }
                            if (fields[x0 - i, y0 - 1].piece?.color == "Black")
                            {
                                if (x0 - i == x && y0 - 1 == y)
                                {

                                    return true;
                                }
                            }
                            break;

                        }
                        catch
                        {
                            break;
                        }
                    }
                    return false;
                }

                //Samme logik med retning omvent.
                else if (color == "Black")
                {
                    for (int i = 1; i < 3; i++)
                    {
                        try
                        {
                            if (fields[x0 + i, y0].piece?.color == null)
                            {
                                if (x0 + i == x && y0 == y)
                                {

                                    return true;
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
                    for (int i = 1; i < 2; i++)
                    {
                        try
                        {
                            if (fields[x0 + i, y0 + 1].piece?.color == "White")
                            {
                                if (x0 + i == x && y0 + 1 == y)
                                {

                                    return true;
                                }
                            }
                            if (fields[x0 + i, y0 - 1].piece?.color == "White")
                            {
                                if (x0 + i == x && y0 - 1 == y)
                                {

                                    return true;
                                }
                            }

                            break;

                        }
                        catch
                        {
                            break;
                        }
                    }
                    return false;
                }
                else
                {
                    return false;
                }
            }

            //Igen samme logik, men for alle andre træk end første.
            else if (moveCount > 0)
            {
                if (color == "White")
                {
                    for (int i = 1; i < 2; i++)
                    {
                        try
                        {
                            if (fields[x0 - i, y0].piece?.color == null)
                            {
                                if (x0 - i == x && y0 == y)
                                {

                                    return true;
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
                    for (int i = 1; i < 2; i++)
                    {
                        try
                        {
                            if (fields[x0 - i, y0 + 1].piece?.color == "Black")
                            {
                                if (x0 - i == x && y0 + 1 == y)
                                {

                                    return true;
                                }
                            }
                            if (fields[x0 - i, y0 - 1].piece?.color == "Black")
                            {
                                if (x0 - i == x && y0 - 1 == y)
                                {

                                    return true;
                                }
                            }

                            break;

                        }
                        catch
                        {
                            break;
                        }
                    }
                    return false;
                }
                else if (color == "Black")
                {
                    for (int i = 1; i < 2; i++)
                    {
                        try
                        {
                            if (fields[x0 + i, y0].piece?.color == null)
                            {
                                if (x0 + i == x && y0 == y)
                                {

                                    return true;
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
                    for (int i = 1; i < 2; i++)
                    {
                        try
                        {
                            if (fields[x0 + i, y0 + 1].piece?.color == "White")
                            {
                                if (x0 + i == x && y0 + 1 == y)
                                {

                                    return true;
                                }
                            }
                            if (fields[x0 + i, y0 - 1].piece?.color == "White")
                            {
                                if (x0 + i == x && y0 - 1 == y)
                                {

                                    return true;
                                }
                            }
                            break;
                        }
                        catch
                        {
                            break;
                        }
                    }
                    return false;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

