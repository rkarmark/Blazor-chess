using System;
namespace blazor_chess
{
	public class Bishop : ChessPiece
	{
		new string color;

		public Bishop(string setColor) : base(setColor)
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
			return ("./images/" + theme + "/" + colorchar + "B.svg");
        }

        public override string getType()
        {
            return "Bishop";
        }

        public override bool isMoveLegal(int x0, int y0, int x, int y, string?[,] colors)
        {

            for (int i = 1; i < 8; i++)
            {
                bool hasPassed = false;
                try
                {
                    if (!hasPassed)
                    {
                        if (colors[x0 + i, y0 + i] == null)
                        {
                            if (x0 + i == x && y0 + i == y)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            if (colors[x0 + i, y0 + i] != color)
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
                        if (colors[x0 + i, y0 - i] == null)
                        {
                            if (x0 + i == x && y0 - i == y)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            if (colors[x0 + i, y0 - i] != color)
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
                        if (colors[x0 - i, y0 + i] == null)
                        {
                            if (x0 - i == x && y0 + i == y)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            if (colors[x0 - i, y0 + i] != color)
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
                        if (colors[x0 - i, y0 - i] == null)
                        {
                            if (x0 - i == x && y0 - i == y)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            if (colors[x0 - i, y0 - i] != color)
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

