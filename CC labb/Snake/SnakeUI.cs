namespace CC_labb;

public class SnakeUI : UI
{
    public void DrawSnake(List<Position> snake)
    {
        foreach (Position snakePosition in snake)
        {
            Console.SetCursorPosition(snakePosition.x, snakePosition.y);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Write("#");
            Console.ResetColor();
        }
    }
    public void SeeCurrentScore(int score)
    {
        Console.SetCursorPosition(59, 0);
        WriteLine($"Current score: {score}");
    }
    public override string ShowResultForRound(int score)
    {
        return ($"You ate {score} pieces of food. Good job!");
    }
    public void ClearConsole()
    {
        Console.Clear();
    }
    public void Write(string s)
    {
        Console.Write(s);
    }
}
