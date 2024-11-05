namespace BoardGame;

public abstract class Board(string Name, int MinPlayers, int MaxPlayers, int PlayTime)
{
    public string Name = Name;
    public int MinPlayers = MinPlayers;
    public int MaxPlayers = MaxPlayers;
    public int PlayTime = PlayTime;

    public virtual void Play()
    {
        Console.WriteLine("Playing the board game.");
    }

    public void DisplayInfo()
    {
        Console.WriteLine(Name);
        Console.WriteLine($" - {MinPlayers}-{MaxPlayers} players");
        Console.WriteLine($" - Average playtime is {PlayTime} minutes");
    }
}