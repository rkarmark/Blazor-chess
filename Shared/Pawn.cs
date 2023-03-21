using System;
namespace blazor_chess
{
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

        public override bool isMoveLegal(int x0, int y0, int x, int y, Field[,] fields)
        {
            if (firstMove)
            {
                if (color == "White")
                {
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
                            else if (fields[x0 - i, y0 - 1].piece?.color == "Black")
                            {
                                if (x0 - i == x && y0 - 1 == y)
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
                    return false;
                }
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
                            else if (fields[x0 + i, y0 - 1].piece?.color == "White")
                            {
                                if (x0 + i == x && y0 - 1 == y)
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
                            else if (fields[x0 - i, y0 - 1].piece?.color == "Black")
                            {
                                if (x0 - i == x && y0 - 1 == y)
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
                            else if (fields[x0 + i, y0 - 1].piece?.color == "White")
                            {
                                if (x0 + i == x && y0 - 1 == y)
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

