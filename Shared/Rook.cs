using System;
using System.Drawing;

namespace blazor_chess
{
    //samme boilerplate som ved de andre klasser
    public class Rook : ChessPiece
    {
        new string color;

        public Rook(string setColor) : base(setColor)
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
            return ("./images/" + theme + "/" + colorchar + "R.svg");
        }

        public override string getType()
        {
            return "Rook";
        }

        public override bool isMoveLegal(int x0, int y0, int x, int y, Field[,] fields)
        {
            //Samme logik som ved bishop, bare ikke på skråt men ligeud i 4 retninger.

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

            return false;
        }
    }
}

