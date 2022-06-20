// This is challenge work for the "C# Players Guide"
// This is for the Level 28 "Room Coordinates" Challenge
// This was a Structs challenge

//Build test Coordinate Objects
Coordinate Check1 = new Coordinate("Check 1", 4, 4);
Coordinate Check2 = new Coordinate("Check 2", 3, 4);
Coordinate Check3 = new Coordinate("Check 3", 4, 5);
Coordinate Check4 = new Coordinate("Check 4", 9, 8);

//Output for the program
Console.WriteLine($"Checking Adjacency for: {Check1.Name} and {Check2.Name}");
Console.WriteLine($"{Check1.Name} is set to ({Check1.Column},{Check1.Row})");
Console.WriteLine($"{Check2.Name} is set to ({Check2.Column},{Check2.Row})");
Console.WriteLine($"They are Adjacent: {Coordinate.AdjacentCheck(Check1, Check2)} \n");


Console.WriteLine($"Checking Adjacency for: {Check1.Name} and {Check3.Name}");
Console.WriteLine($"{Check1.Name} is set to ({Check1.Column},{Check1.Row})");
Console.WriteLine($"{Check3.Name} is set to ({Check3.Column},{Check3.Row})");
Console.WriteLine($"They are Adjacent: {Coordinate.AdjacentCheck(Check1, Check3)} \n");

Console.WriteLine($"Checking Adjacency for: {Check2.Name} and {Check3.Name}");
Console.WriteLine($"{Check2.Name} is set to ({Check2.Column},{Check2.Row})");
Console.WriteLine($"{Check3.Name} is set to ({Check3.Column},{Check3.Row})");
Console.WriteLine($"They are Adjacent: {Coordinate.AdjacentCheck(Check2, Check3)} \n");

Console.WriteLine($"Checking Adjacency for: {Check1.Name} and {Check4.Name}");
Console.WriteLine($"{Check1.Name} is set to ({Check1.Column},{Check1.Row})");
Console.WriteLine($"{Check4.Name} is set to ({Check4.Column},{Check4.Row})");
Console.WriteLine($"They are Adjacent: {Coordinate.AdjacentCheck(Check1, Check4)} \n");

Console.WriteLine("Press any key to end the test");
Console.ReadKey();

public struct Coordinate
{
    public string Name { get;  }
    public int Row { get; }
    public int Column { get; }

    public Coordinate(string TestName, int ProvidedRow, int ProvidedColumn)
    {
        Name = TestName;
        Row = ProvidedRow;
        Column = ProvidedColumn;
        
    }

    public static bool AdjacentCheck(Coordinate First, Coordinate Second)
    {
        int SetRow = First.Row - Second.Row;
        int CheckRow = CheckNegative(SetRow); //Added to check and convert negative number from line above
        
        int SetColumn = First.Column - Second.Column;
        int CheckColumn = CheckNegative(SetColumn); //Added to check and convert negative number from line above

        if (CheckRow == 0 && CheckColumn <= 1) return true;
        else if (CheckRow <= 1 && CheckColumn == 0) return true;
        else return false;
    }

    private static int CheckNegative(int SetCheck)  //I should have just used C#'s Absolute Value method.
    {
        if (SetCheck < 0)
        {
            SetCheck *= -1;
            return SetCheck;
        }
        else return SetCheck;
    }
}


