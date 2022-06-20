
//Build test Coordinate Objects
Coordinate Check1 = new Coordinate(1, 2);
Coordinate Check2 = new Coordinate(2, 3);
Coordinate Check3 = new Coordinate(3,3);
Coordinate Check4 = new Coordinate(9, 8);

Console.WriteLine(Coordinate.AdjacentCheck(Check1, Check2));



public struct Coordinate
{
    public int Row { get; }
    public int Column { get; }

    public Coordinate(int ProvidedRow, int ProvidedColumn)
    {
        Row = ProvidedRow;
        Column = ProvidedColumn;
    }

    public static bool AdjacentCheck(Coordinate First, Coordinate Second)
    {
        int SetRow = First.Row - Second.Row;
        int CheckRow = CheckNegative(SetRow);
        int SetColumn = First.Column - Second.Column;
        int CheckColumn = CheckNegative(SetColumn);
    }

    private static int CheckNegative(int SetCheck);
    {
        if (SetCheck < 0) 
    }
}


