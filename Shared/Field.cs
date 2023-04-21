using System;
using blazor_chess;


namespace blazor_chess
{
    //En meget simpel klasse field der har en brik og en bool der siger om feltet er valgt eller ej
    public class Field
    {
        public Boolean isSelected = false;
        public ChessPiece? piece;
    }
}

