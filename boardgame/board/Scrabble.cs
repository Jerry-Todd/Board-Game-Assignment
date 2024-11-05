using System.Configuration.Assemblies;

namespace BoardGame;

public class Scrabble : Board
{
    public int Turn;
    public Scrabble() : base("Scrabble", 2, 4, 90)
    {
        Turn = 1;
    }

    public override void Play()
    {
        while (true)
        {
            Console.WriteLine($"Player {Turn}'s turn");
            Console.ReadLine();
            PlaceTile();
            SwitchTurn();
        }
    }

    public void SwitchTurn()
    {
        Turn++;
        if (MaxPlayers < Turn)
        {
            Turn = 1;
        }
    }
    public void PlaceTile()
    {
        Console.WriteLine("Letter placed");
        if (IsTileSpecial())
        {
            Console.WriteLine("Extra points!");
        }
    }

    public bool IsTileSpecial()
    {
        return false;
    }

}