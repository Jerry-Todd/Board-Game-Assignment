using System.Security.Cryptography.X509Certificates;

namespace BoardGame;

public class Program
{
    public static void Main()
    {
        Checkers game1 = new Checkers();
        Scrabble game2 = new Scrabble();
        game1.DisplayInfo();
        game2.DisplayInfo();
        
    }
}
