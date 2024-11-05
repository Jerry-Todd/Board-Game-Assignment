using System.Configuration.Assemblies;

namespace BoardGame;

public class Checkers : Board
{
    public int Turn;

    public Checkers() : base("Checkers", 2, 2, 30)
    {
        Turn = 1;
    }

    public override void Play()
    {
        while (true)
        {
            Console.WriteLine($"Player {Turn}'s turn");
            Console.ReadLine();
            MovePiece();
            SwitchTurn();
        }
    }

    public void SwitchTurn()
    {
        if (Turn == 1)
        {
            Turn = 2;
            return;
        }
        Turn = 1;
    }
    public void MovePiece()
    {
        Console.WriteLine("Piece Moved");
    }

    public void CreateKing(int y) 
    {
        if (y == 7)
        {
            Console.WriteLine("King Created");
        }
    }
}