﻿using System;
namespace blazor_chess
{
    //Samme boilerplate som alle andre klasser
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

        public override string getType()
        {
            return "Queen";
        }

        public override bool isMoveLegal(int x0, int y0, int x, int y, Field[,] fields)
        {
            //Den har kombineret logik for løber og tårn. Så det er mange linjer, men ikke avanceret og meget det samme. 
            for (int i = 1; i < 8; i++)
            {
                bool hasPassed = false;
                try
                {
                    if (!hasPassed)
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
                            if (fields[x0 + i, y0].piece?.color != color)
                            {
                                if (x0 + i == x && y0 == y)
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
                        if (fields[x0 - i, y0].piece?.color == null)
                        {
                            if (x0 - i == x && y0 == y)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            if (fields[x0 - i, y0].piece?.color != color)
                            {
                                if (x0 - i == x && y0 == y)
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
                        if (fields[x0, y0 + i].piece?.color == null)
                        {
                            if (x0 == x && y0 + i == y)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            if (fields[x0, y0 + i].piece?.color != color)
                            {
                                if (x0 == x && y0 + i == y)
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
                        if (fields[x0, y0 - i].piece?.color == null)
                        {
                            if (x0 == x && y0 - i == y)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            if (fields[x0, y0 - i].piece?.color != color)
                            {
                                if (x0 == x && y0 - i == y)
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
                        if (fields[x0 + i, y0 + i].piece?.color == null)
                        {
                            if (x0 + i == x && y0 + i == y)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            if (fields[x0 + i, y0 + i].piece?.color != color)
                            {
                                if (x0 + i == x && y0 + i == y)
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
                        if (fields[x0 + i, y0 - i].piece?.color == null)
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
                        if (fields[x0 - i, y0 + i].piece?.color == null)
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
                        if (fields[x0 - i, y0 - i].piece?.color == null)
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

