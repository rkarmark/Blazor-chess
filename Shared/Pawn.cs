using System;
namespace blazor_chess
{
    public class Pawn : ChessPiece
    {
        new string color;
        public bool firstMove;

        public Pawn(string setColor) : base(setColor)
        {
            color = setColor;
            firstMove = true;
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
        public override bool isMoveLegal(int x0, int y0, int x, int y, string?[,] colors)
        {
            if (firstMove)
            {
                if (color == "White")
                {
                    for (int i = 1; i < 3; i++)
                    {
                        try
                        {
                            if (colors[x0 - i, y0] == null)
                            {
                                if (x0 - i == x && y0 == y)
                                {
                                    firstMove = false;
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
                            if (colors[x0 - i, y0 + 1] == "Black")
                            {
                                if (x0 - i == x && y0 + 1 == y)
                                {
                                    firstMove = false;
                                    return true;
                                }
                            }
                            else if (colors[x0 - i, y0 - 1] == "Black")
                            {
                                if (x0 - i == x && y0 - 1 == y)
                                {
                                    firstMove = false;
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
                    return false;
                }
                else if (color == "Black")
                {
                    for (int i = 1; i < 3; i++)
                    {
                        try
                        {
                            if (colors[x0 + i, y0] == null)
                            {
                                if (x0 + i == x && y0 == y)
                                {
                                    firstMove = false;
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
                            if (colors[x0 + i, y0 + 1] == "White")
                            {
                                if (x0 + i == x && y0 + 1 == y)
                                {
                                    firstMove = false;
                                    return true;
                                }
                            }
                            else if (colors[x0 + i, y0 - 1] == "White")
                            {
                                if (x0 + i == x && y0 - 1 == y)
                                {
                                    firstMove = false;
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
                    return false;
                }
                else
                {
                    return false;
                }
            }
            else if (!firstMove)
            {
                if (color == "White")
                {
                    for (int i = 1; i < 2; i++)
                    {
                        try
                        {
                            if (colors[x0 - i, y0] == null)
                            {
                                if (x0 - i == x && y0 == y)
                                {
                                    firstMove = false;
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
                            if (colors[x0 - i, y0 + 1] == "Black")
                            {
                                if (x0 - i == x && y0 + 1 == y)
                                {
                                    firstMove = false;
                                    return true;
                                }
                            }
                            else if (colors[x0 - i, y0 - 1] == "Black")
                            {
                                if (x0 - i == x && y0 - 1 == y)
                                {
                                    firstMove = false;
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
                    return false;
                }
                else if (color == "Black")
                {
                    for (int i = 1; i < 2; i++)
                    {
                        try
                        {
                            if (colors[x0 + i, y0] == null)
                            {
                                if (x0 + i == x && y0 == y)
                                {
                                    firstMove = false;
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
                            if (colors[x0 + i, y0 + 1] == "White")
                            {
                                if (x0 + i == x && y0 + 1 == y)
                                {
                                    firstMove = false;
                                    return true;
                                }
                            }
                            else if (colors[x0 + i, y0 - 1] == "White")
                            {
                                if (x0 + i == x && y0 - 1 == y)
                                {
                                    firstMove = false;
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

