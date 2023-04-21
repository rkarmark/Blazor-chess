using System;
namespace blazor_chess
{
    //En abstract class som alle brikker arver fra, selve klassen bliver der ikke lavet objekter af
    public abstract class ChessPiece
    {
        public string color;
        public int moveCount = 0;
        public ChessPiece(string setColor)
        {
            color = setColor;
        }
        //En metode til at få et billede af brikken, som skal overrides af de enkelte brikker
        public abstract string getImage(string theme);

        //Det samme gælder for getType, som returnerer typen af brikken
        public abstract string getType();
        //Og isMoveLegal, som returnerer om et træk er lovligt, her skal der være logik til det. Derfor har den forskellige parametere. bla. får den et array af fields, som er brættet. Dette er primært for at fremtidssikre at man kan tjekke for ting som en passant hvis man vil lave logik til det.
        public abstract Boolean isMoveLegal(int x0, int y0, int x, int y, Field[,] fields);
    }
}

