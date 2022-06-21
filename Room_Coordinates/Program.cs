// This is challenge work for the "C# Players Guide"
// This is for the Level 28 "Room Coordinates" Challenge
// This was a Structs challenge

//Build test Coordinate Objects
Coordinate Check1 = new Coordinate("Check 1", 4, 4);
Coordinate Check2 = new Coordinate("Check 2", 3, 4);
Coordinate Check3 = new Coordinate("Check 3", 4, 5);
Coordinate Check4 = new Coordinate("Check 4", 9, 8);

//Output for the program

//Test 1
Console.WriteLine($"Checking Adjacency for: {Check1.Name} and {Check2.Name}");
Console.WriteLine($"{Check1.Name} is set to ({Check1.Column},{Check1.Row})");
Console.WriteLine($"{Check2.Name} is set to ({Check2.Column},{Check2.Row})");
Console.WriteLine($"They are Adjacent: {Coordinate.AdjacentCheck(Check1, Check2)} \n");

//Test 2
Console.WriteLine($"Checking Adjacency for: {Check1.Name} and {Check3.Name}");
Console.WriteLine($"{Check1.Name} is set to ({Check1.Column},{Check1.Row})");
Console.WriteLine($"{Check3.Name} is set to ({Check3.Column},{Check3.Row})");
Console.WriteLine($"They are Adjacent: {Coordinate.AdjacentCheck(Check1, Check3)} \n");

//Test 3
Console.WriteLine($"Checking Adjacency for: {Check2.Name} and {Check3.Name}");
Console.WriteLine($"{Check2.Name} is set to ({Check2.Column},{Check2.Row})");
Console.WriteLine($"{Check3.Name} is set to ({Check3.Column},{Check3.Row})");
Console.WriteLine($"They are Adjacent: {Coordinate.AdjacentCheck(Check2, Check3)} \n");

//Test 4
Console.WriteLine($"Checking Adjacency for: {Check1.Name} and {Check4.Name}");
Console.WriteLine($"{Check1.Name} is set to ({Check1.Column},{Check1.Row})");
Console.WriteLine($"{Check4.Name} is set to ({Check4.Column},{Check4.Row})");
Console.WriteLine($"They are Adjacent: {Coordinate.AdjacentCheck(Check1, Check4)} \n");

//Close
Console.WriteLine("Press any key to end the test");
Console.ReadKey();

//Struct
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
    
    //Pass output to check/convert possible negative number produced by the expression
    public static bool AdjacentCheck(Coordinate First, Coordinate Second)
    {
      
        int SetRow = CheckNegative(First.Row - Second.Row);         
        int SetColumn = CheckNegative(First.Column - Second.Column);
        
        //Check adjacent logic
        if (SetRow == 0 && SetColumn <= 1) return true;
        else if (SetRow <= 1 && SetColumn == 0) return true;
        else return false;
    }
    
    //If SetCheck is a negative number return positive of the number
    private static int CheckNegative(int SetCheck)  
    {   
        if (SetCheck < 0)
        {
            SetCheck *= -1;
            return SetCheck;
        }
        else return SetCheck;
    }
}


